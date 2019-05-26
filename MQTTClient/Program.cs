using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MQTTnet;
using MQTTnet.Core;
using MQTTnet.Core.Client;
using MQTTnet.Core.Packets;
using MQTTnet.Core.Protocol;

namespace MQTTClient
{
    public class Program
    {
        public static MqttClient mqttClient = null;
        public static void Main()
        {
            Task.Run(async () => { await ConnectMqttServerAsync(); });
        }
        public static async Task ConnectMqttServerAsync()
        {
            if (mqttClient == null)
            {
                mqttClient = new MqttClientFactory().CreateMqttClient() as MqttClient;
                //mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;
                mqttClient.Connected += MqttClient_Connected;
                mqttClient.Disconnected += MqttClient_Disconnected;
            }

            try
            {
                var options = new MqttClientTcpOptions
                {
                    //Server = "114.55.171.95",
                    Server = "127.0.0.1",
                    ClientId = Guid.NewGuid().ToString().Substring(0, 5),
                    UserName = "11@qq.com",
                    Password = "123423",
                    CleanSession = true
                };

                await mqttClient.ConnectAsync(options);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"连接到MQTT服务器失败！" + Environment.NewLine + ex.Message + Environment.NewLine);
            }
            //Publish("99616@qq.com:App", "空调,false,off");
        }
        public static void Publish(string topic,string inputString)
        {
            if (string.IsNullOrEmpty(topic))
            {
                Console.WriteLine("发布主题不能为空！\n");
                return;
            }

            var appMsg = new MqttApplicationMessage(topic, Encoding.UTF8.GetBytes(inputString), MqttQualityOfServiceLevel.AtMostOnce, false);
            mqttClient.PublishAsync(appMsg);
        }
        public static void MqttClient_Connected(object sender, EventArgs e)
        {
            Console.WriteLine("已连接到MQTT服务器！\n");
        }

        public static void MqttClient_Disconnected(object sender, EventArgs e)
        {
            Console.WriteLine("已断开MQTT连接！\n");
        }
    }
}
