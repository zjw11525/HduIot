#pragma checksum "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287db0c4129f5ea0ccb837de32f256ffdfc616b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HduIot.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml", typeof(HduIot.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), null)]
namespace HduIot.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\_ViewImports.cshtml"
using HduIot.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using HduIot.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using HduIot.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287db0c4129f5ea0ccb837de32f256ffdfc616b2", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9abb4c2fbe344ec1d49b2bca27b6b2139e99464", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ae4f317274944184dd50abf66411da9ce1b0b7", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2bbe215e86372ed739f0f145185d7cca0c4b770", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("remove-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("link-login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
  
    ViewData["Title"] = "管理其他账户登录";

#line default
#line hidden
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 51, false);
#line 7 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
            EndContext();
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(176, 66, true);
            WriteLiteral("    <h4>用其他账号登录</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
            EndContext();
#line 13 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
             foreach (var login in Model.CurrentLogins)
            {

#line default
#line hidden
            BeginContext(314, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(361, 19, false);
#line 16 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                   Write(login.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(380, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 18 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                         if (Model.ShowRemoveButton)
                        {

#line default
#line hidden
            BeginContext(494, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(518, 515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4eaad3fdc0a43d2870661ee3d6f3eb7", async() => {
                BeginContext(587, 69, true);
                WriteLiteral("\r\n                            <div>\r\n                                ");
                EndContext();
                BeginContext(656, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b42c93436aa34a8ebc7827ddbc5c1262", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(731, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(765, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5496ffdd33d4bd59555acb7804ab58a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 23 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(836, 79, true);
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 915, "\"", 951, 3);
                WriteAttributeValue("", 923, "移除登录账户", 923, 6, true);
#line 24 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 929, login.LoginProvider, 930, 20, false);

#line default
#line hidden
                WriteAttributeValue(" ", 950, "", 951, 1, true);
                EndWriteAttribute();
                BeginContext(952, 74, true);
                WriteLiteral(">移除</button>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1033, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1119, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1145, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 31 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                        }

#line default
#line hidden
            BeginContext(1181, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1246, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 37 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#line 38 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
            BeginContext(1320, 39, true);
            WriteLiteral("    <h4>使用其他账号登录</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(1359, 492, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f71bfbd7b6394e8281b0e96a139aefbf", async() => {
                BeginContext(1453, 55, true);
                WriteLiteral("\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
                EndContext();
#line 45 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
                BeginContext(1589, 104, true);
                WriteLiteral("                    <button id=\"link-login-button\" type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1693, "\"", 1715, 1);
#line 47 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1701, provider.Name, 1701, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1716, "\"", 1753, 3);
                WriteAttributeValue("", 1724, "使用账户", 1724, 4, true);
#line 47 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1728, provider.DisplayName, 1729, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1750, "登录", 1751, 3, true);
                EndWriteAttribute();
                BeginContext(1754, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1756, 20, false);
#line 47 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                                                                                                 Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(1776, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 48 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                }

#line default
#line hidden
                BeginContext(1806, 38, true);
                WriteLiteral("            </p>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1851, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 52 "C:\Users\Administrator\Desktop\ASP.NET core\HduIot\HduIot\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel>)PageContext?.ViewData;
        public ExternalLoginsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
