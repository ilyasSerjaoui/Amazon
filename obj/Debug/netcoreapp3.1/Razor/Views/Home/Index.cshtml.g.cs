#pragma checksum "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b52709a4c6181e5fb3a86892ea300db479a8709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(amazon.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace amazon.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 11 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b52709a4c6181e5fb3a86892ea300db479a8709", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee2708500c3762c9949b1f06142712605b951eb", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<amazon.Models.Home>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imgproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("320px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
  
    Regex aNum = new Regex(@"\s+");

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
  
    Layout = "_Layout.cshtml";
    ViewData["fng"] = ViewData["f-n"];
    ViewData["getcountelements"]=ViewData["countelements"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\" />\n");
            WriteLiteral("<div class=\"women_fashion\">\n    <div class=\"title\"><i class=\"fa fa-female\" style=\"font-size:36px\"></i> women fashion</div>\n    <div style=\"position:absolute; top:60px;\">\n");
#nullable restore
#line 15 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
         foreach (var item in Model)
        {
            if (item.image != null)
            {
                if (item.type == "women_fashion")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b52709a4c6181e5fb3a86892ea300db479a87096101", async() => {
                WriteLiteral("\n                        <div class=\"productspalte\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b52709a4c6181e5fb3a86892ea300db479a87096435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 994, "~/images/", 994, 9, true);
#nullable restore
#line 23 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 1003, item.image, 1003, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            <div id=\"nameproduct\">\n");
#nullable restore
#line 25 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                 if (item.name.Length <= 50)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                               Write(item.name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                              
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                     for (var i = 0; i <= 50; i++)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                   Write(item.name[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                     
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("...\n                            </div>\n                            <div id=\"mushproduct\">");
#nullable restore
#line 37 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                             Write(item.howmush);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ratings</div>\n                            <div id=\"priceproduct\">");
#nullable restore
#line 38 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                              Write(item.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                      WriteLiteral(aNum.Replace(@item.name, "_"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                                                                    WriteLiteral(ViewData["f-n"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Em"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Em", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Em"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                                                                                                       WriteLiteral(ViewData["email"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 41 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n<div class=\"men_fashion\">\n    ");
#nullable restore
#line 48 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
Write(ViewData["em"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"title\"><i class=\"fa fa-male\" style=\"font-size:36px\"></i> male fashion</div>\n    <div style=\"position:absolute; top:60px;\">\n");
#nullable restore
#line 51 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
         foreach (var item in Model)
        {
            if (item.image != null)
            {
                if (item.type == "men_fashion")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"productspalte\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b52709a4c6181e5fb3a86892ea300db479a870915275", async() => {
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b52709a4c6181e5fb3a86892ea300db479a870915555", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2517, "~/images/", 2517, 9, true);
#nullable restore
#line 59 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 2526, item.image, 2526, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            <div id=\"nameproduct\">\n");
#nullable restore
#line 61 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                 if (item.name.Length <= 50)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                               Write(item.name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                              
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                     for (var i = 0; i <= 50; i++)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                   Write(item.name[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                     
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("...\n                            </div>\n                            <div id=\"mushproduct\">");
#nullable restore
#line 73 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                             Write(item.howmush);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ratings</div>\n                            <div id=\"priceproduct\">");
#nullable restore
#line 74 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                              Write(item.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                          WriteLiteral(aNum.Replace(@item.name, "_"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                                                                        WriteLiteral(ViewData["f-n"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Em"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Em", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Em"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                                                                                                           WriteLiteral(ViewData["email"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 77 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n<div class=\"electronics\">\n    <div class=\"title\"><i class=\"fa fa-desktop\" style=\"font-size:36px\"></i> electronics</div>\n    <div style=\"position:absolute; top:60px;\">\n\n");
#nullable restore
#line 86 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
         foreach (var item in Model)
        {
            if (item.image != null)
            {
                if (item.type == "electronics")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"productspalte\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b52709a4c6181e5fb3a86892ea300db479a870924220", async() => {
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b52709a4c6181e5fb3a86892ea300db479a870924500", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4022, "~/images/", 4022, 9, true);
#nullable restore
#line 94 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
AddHtmlAttributeValue("", 4031, item.image, 4031, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                            <div id=\"nameproduct\">\n");
#nullable restore
#line 97 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                 if (item.name.Length <= 50)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                               Write(item.name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                              
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                     for (var i = 0; i <= 50; i++)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                   Write(item.name[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                     
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("...\n                            </div>\n\n                            <div id=\"mushproduct\">");
#nullable restore
#line 110 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                             Write(item.howmush);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ratings</div>\n                            <div id=\"priceproduct\">");
#nullable restore
#line 111 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                              Write(item.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                          WriteLiteral(aNum.Replace(@item.name, "_"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                                                                        WriteLiteral(ViewData["f-n"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Em"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Em", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Em"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                                                                                                                                                           WriteLiteral(ViewData["email"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 114 "/Users/mac/Projects/amazon/amazon/Views/Home/Index.cshtml"
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<style>
    body {
        background: url(""https://m.media-amazon.com/images/I/61CX1noQ8nL._SX3000_.jpg"");
        background-size: cover;
    }

    .title {
        margin: 20px;
        padding-left: 100px;
        font-size: 20px;
        font-weight: bold;
    }

    #mushproduct {
        font-size: 14px;
        font-weight: bold;
        color: #007185;
        padding: 5px;
    }

    #priceproduct {
        font-weight: bold;
        font-size: 15px;
        padding: 5px;
        color: black;
    }

    .productspalte {
        width: 150px;
        height: 300px;
        padding: 15px;
        margin: 10px;
        display: inline-block;
        cursor: pointer;
    }

        .productspalte:hover #nameproduct {
            color: orange;
        }

    .men_fashion {
        position: absolute;
        top: 300px;
        left: 513px;
        background: white;
        width: 450px;
        height: 5000px;
    }

    .electronics {
        position: absolute;
        top: 300");
            WriteLiteral(@"px;
        left: 980px;
        border-top-right-radius: 20px;
        background: white;
        width: 450px;
        height: 5000px;
    }

    .women_fashion {
        position: absolute;
        top: 300px;
        left: 40px;
        border-top-left-radius: 20px;
        background: white;
        width: 450px;
        height: 5000px;
    }

    #nameproduct {
        font-weight: normal;
        font-size: 15px;
        color: black;
    }
</style>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<amazon.Models.Home>> Html { get; private set; }
    }
}
#pragma warning restore 1591
