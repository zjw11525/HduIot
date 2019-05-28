
using MQTTnet;
using MQTTnet.Core.Adapter;
using MQTTnet.Core.Diagnostics;
using MQTTnet.Core.Protocol;
using MQTTnet.Core.Server;
using System;
using System.Text;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;

namespace MqttServerTest
{
    public class DeviceModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Name { get; set; }
        public bool Switch { get; set; }
        public string Message { get; set; }
        public string DeviceKey { get; set; }
    }
    public class DeviceContext : DbContext
    {
        public DbSet<DeviceModel> Devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=iZ3rzhvtee8j5iZ;Database=DeviceDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            //options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HduIot-DeviceDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }

    public class Program
    {
        public static MqttServer mqttServer = null;
        public static void Main()
        {
            MqttNetTrace.TraceMessagePublished += MqttNetTrace_TraceMessagePublished;
            new Thread(StartMqttServer).Start();
            //Console.ReadKey();
            //while (true)
            //{
            //    var inputString = Console.ReadLine().ToLower().Trim();

            //    if (inputString == "exit")
            //    {
            //        mqttServer?.StopAsync();
            //        Console.WriteLine("MQTT服务已停止！");
            //        break;
            //    }
            //    else if (inputString == "clients")
            //    {
            //        foreach (var item in mqttServer.GetConnectedClients())
            //        {
            //            Console.WriteLine($"客户端标识：{item.ClientId}，协议版本：{item.ProtocolVersion}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"命令[{inputString}]无效！");
            //    }
            //}
        }

        public static void StartMqttServer()
        {
            DeviceContext devices = new DeviceContext();

            if (mqttServer == null)
            {
                try
                {
                    var options = new MqttServerOptions
                    {
                        ConnectionValidator = p =>
                        {
                            DeviceModel device = devices.Devices.SingleOrDefault(x => x.DeviceKey == p.Password);
                            if ((device.Name == p.Username) || (device.User == p.Username))
                                return MqttConnectReturnCode.ConnectionAccepted;

                            return MqttConnectReturnCode.ConnectionRefusedBadUsernameOrPassword;
                        }
                    };

                    mqttServer = new MqttServerFactory().CreateMqttServer(options) as MqttServer;
                    mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;
                    mqttServer.ClientConnected += MqttServer_ClientConnected;
                    mqttServer.ClientDisconnected += MqttServer_ClientDisconnected;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            mqttServer.StartAsync();
            Console.WriteLine("MQTT服务启动成功！");
        }

        public static void MqttServer_ClientConnected(object sender, MqttClientConnectedEventArgs e)
        {
            Console.WriteLine($"客户端[{e.Client.ClientId}]已连接，协议版本：{e.Client.ProtocolVersion}");           
        }

        public static void MqttServer_ClientDisconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            Console.WriteLine($"客户端[{e.Client.ClientId}]已断开连接！");
        }

        public static void MqttServer_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            DeviceContext devices = new DeviceContext();
            string topic = e.ApplicationMessage.Topic;
            string message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
            Console.WriteLine($"客户端[{e.ClientId}]>> 主题：{e.ApplicationMessage.Topic} 负荷：{Encoding.UTF8.GetString(e.ApplicationMessage.Payload)} Qos：{e.ApplicationMessage.QualityOfServiceLevel} 保留：{e.ApplicationMessage.Retain}");

            string[] _topic = topic.Split(':');
            string[] _message = message.Split(',');

            if (_topic.Length < 2) return;
            if (_message[0] != null)
            {
                var dbSet = devices.Devices.Where(t => t.User == _topic[0]);
                int count = dbSet.Count();
                DeviceModel device = new DeviceModel();
                foreach (DeviceModel _device in dbSet)
                {
                    if (_device.Name == _message[0])
                    {
                        device = _device;
                    }
                }
                //var device = devices.Devices.SingleOrDefault(x => x.Name == _message[0]);//这个设备存在
                if (device == null) return;
                if (device.User == _topic[0])//这个设备属于当前访问用户
                {
                    if (_message[1] != null)
                    {
                        if ((_message[1] == "true") || (_message[1] == "false"))
                        device.Switch = Convert.ToBoolean(_message[1]);
                        devices.SaveChanges();
                    }
                    if (_message.Length < 3) return;
                    if ((_message[2] != null)&&(_topic[1] == device.Name))//只有设备端发布的消息才进入数据库
                    {
                        device.Message = _message[2];
                        devices.SaveChanges();
                    }
                    if ((_message.Length > 3) && (_topic[1] == device.Name))
                    {
                        if (!Directory.Exists($"wwwroot\\images\\{ device.User}\\{device.Name}"))
                            Directory.CreateDirectory($"wwwroot\\images\\{ device.User}\\{device.Name}");
                        FileStream image = File.OpenWrite($"wwwroot\\images\\{device.User}\\{device.Name}\\1.jpg");
                        for (int i = 3; i < _message.Length; i++)
                        {
                            byte[] b = new byte[1];
                            b[0] = Convert.ToByte(_message[i]);
                            image.Seek(i-3, SeekOrigin.Begin);
                            image.Write(b, 0, 1);
                        }
                        image.Close();
                    }//图片
                }
            }
        }

        public static void MqttNetTrace_TraceMessagePublished(object sender, MqttNetTraceMessagePublishedEventArgs e)
        {
            /*Console.WriteLine($">> 线程ID：{e.ThreadId} 来源：{e.Source} 跟踪级别：{e.Level} 消息: {e.Message}");
            if (e.Exception != null)
            {
                Console.WriteLine(e.Exception);
            }*/
        }
    }
}