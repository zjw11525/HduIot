#pragma checksum "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dbd63eff897df53f75547cfbd682176898eb5bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Views\_ViewImports.cshtml"
using HduIot;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Views\_ViewImports.cshtml"
using HduIot.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dbd63eff897df53f75547cfbd682176898eb5bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"969f373f35a9108747a771308a24cf282fdce609", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/im1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("ASP.NET"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Visual Studio"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Microsoft Azure"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "HDU物联网创客";

#line default
#line hidden
            BeginContext(44, 439, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">
            ");
            EndContext();
            BeginContext(483, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c605947b82140a28ff8c0533df65978", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(550, 357, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525028&clcid=0x409"">
                        快速接入您的物联网设备
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            ");
            EndContext();
            BeginContext(907, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04b327ad30f94ddc8741e14942e8e783", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(980, 369, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>                   
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525030&clcid=0x409"">
                        加入我们
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            ");
            EndContext();
            BeginContext(1349, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "918eb4d355bc453591102b332478b177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1424, 2462, true);
            WriteLiteral(@"
            <div class=""carousel-caption"" role=""option"">
                <p>         
                    <a class=""btn btn-default"" href=""https://go.microsoft.com/fwlink/?LinkID=525027&clcid=0x409"">
                        平台简介
                    </a>
                </p>
            </div>
        </div>
    </div>
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>应用场景</h2>
        <ul>
            <li>嵌入式设备接入</li>
            <li>示例:<a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">树莓派接入</a></li>
        </ul>
    ");
            WriteLiteral(@"</div>
    <div class=""col-md-3"">
        <h2>如何开始</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">添加设备</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">用户手册</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">协议测试工具</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">API接口</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>概要</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">应用范例</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">添加设备</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">用户手册</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">协议测试工具</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">API接口</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkI");
            WriteLiteral(@"d=699319"">适用场景</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>关于</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">关于我们</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517853"">联系方式</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398609"">技术支持</a></li>
        </ul>
    </div>
</div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
