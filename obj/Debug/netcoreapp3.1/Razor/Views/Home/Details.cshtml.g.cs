#pragma checksum "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b4770cf4d07a0c328d63294898bd504fe073371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(amazon.Views.Home.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b4770cf4d07a0c328d63294898bd504fe073371", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee2708500c3762c9949b1f06142712605b951eb", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<amazon.Models.Home>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("550px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btnsprs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cartitem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.9.0/jquery.min.js\"></script>\n    <script src=\"http://www.parsecdn.com/js/parse-1.2.2.min.js\"></script>\n");
#nullable restore
#line 4 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
      
        Layout = "_Layout.cshtml";
        ViewData["fng"] = ViewData["f-n"];
        ViewData["getcountelements"] = ViewData["countelements"];
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
     foreach (var itemDetails in Model)
    {
        if (itemDetails.image != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b4770cf4d07a0c328d63294898bd504fe0733715705", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 523, "~/images/", 523, 9, true);
#nullable restore
#line 13 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
AddHtmlAttributeValue("", 532, itemDetails.image, 532, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div class=\"details\">\n                <div class=\"name\">");
#nullable restore
#line 15 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                             Write(itemDetails.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                <div class=\"rating\">");
#nullable restore
#line 16 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                               Write(itemDetails.howmush);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ratings</div>\n                <hr />\n                <div id=\"prices\">\n                    Price: <div class=\"p1\" id=\"price\"> ");
#nullable restore
#line 19 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                  Write(itemDetails.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\n");
#nullable restore
#line 20 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                      
                        if (itemDetails.price.Contains("-"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"p2\" id=\"price\"></div>\n");
#nullable restore
#line 24 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>you save:</p><div class=\"p2\" id=\"price\">\n");
#nullable restore
#line 28 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                  
                                    string price = itemDetails.price.Replace("$", "");
                                    float pricetosave;
                                    float.TryParse(price, out pricetosave);
                                    pricetosave = pricetosave * 4 / 100;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                $");
#nullable restore
#line 34 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                            Write(pricetosave);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ( 4% )\n                            </div>\n");
#nullable restore
#line 36 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"

                        }
                        double delivery = 66.80;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"deliver\">\n                        $ ");
#nullable restore
#line 41 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                     Write(delivery);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Shipping & Import Fees Deposit to...\n                    </div>\n                </div>\n                <div class=\"purchse\">\n");
#nullable restore
#line 45 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                      
                        bool ifnotlogin(string Em)
                        {
                            return Em == "login";
                        }
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                     if (ifnotlogin(ViewData["f-n"].ToString()) != true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b4770cf4d07a0c328d63294898bd504fe07337111105", async() => {
                WriteLiteral("\n                            <button style=\"background: yellow; border-radius:40px; border:none; width: 200px; padding: 10px; \" id=\"btncard\">add to cart</button>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                                                              WriteLiteral(itemDetails.name.Replace(" ", "_"));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                                                                                                                    WriteLiteral(itemDetails.price.Replace("$", ""));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["price"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-price", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["price"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                                                                                                                                                                          WriteLiteral(itemDetails.image);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["image"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-image", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["image"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                                                                                                                                                                                                            WriteLiteral(ViewData["f-n"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Em"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Em", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["Em"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                                                                                                                                                                                                                                                WriteLiteral(itemDetails.howmush);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["rating"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-rating", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["rating"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                                                                                                                                                                                                                                                                                      WriteLiteral(itemDetails.type);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                                                                                                                                                                                                                                                                                                                          WriteLiteral(ViewData["em"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 56 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"btnsprs\">\n                            <button style=\"background: yellow; border-radius:40px; border:none; width: 200px; padding: 10px; \" id=\"btncardfake\">add to cart</button>\n                        </div>\n");
#nullable restore
#line 62 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <button style=""background: orange; border-radius: 40px; border:none; width: 200px; padding: 10px; "" class=""btnsprs"" id=""btnbuy"">buy now</button>
                    <div class=""btnsprs"" style=""padding-left: 10px; color: green; font-weight: bold;  font-size: 15px;"">In Stock</div><br />

                    <div id=""detailpur"" style=""color:#007185;"" class=""del"">
                        Deliver to..
                    </div>
                    <div id=""detailpur"" class=""where"">
                        $");
#nullable restore
#line 71 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                    Write(delivery);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Shipping & Import Fees Deposit to\n                    </div>\n                    <div id=\"detailpur\" style=\"color:black; \" class=\"deliverTime\">\n");
#nullable restore
#line 74 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                          
                            DateTime dateTime = DateTime.Now;
                            var getdate = dateTime.AddDays(15);
                            switch (getdate.Month)
                            {
                                case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery january - ");
#nullable restore
#line 80 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                       Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 81 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery january - ");
#nullable restore
#line 83 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                       Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 84 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery march - ");
#nullable restore
#line 86 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                     Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 87 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery April - ");
#nullable restore
#line 89 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                     Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 90 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 5:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery may - ");
#nullable restore
#line 92 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                   Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 93 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 6:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery june - ");
#nullable restore
#line 95 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                    Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 96 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 7:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery july - ");
#nullable restore
#line 98 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                    Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 99 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 8:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery august - ");
#nullable restore
#line 101 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                      Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 102 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 9:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery september - ");
#nullable restore
#line 104 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                         Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 105 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 10:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery october - ");
#nullable restore
#line 107 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                       Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 108 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 11:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery november - ");
#nullable restore
#line 110 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                        Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 111 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                                case 12:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>Delivery december - ");
#nullable restore
#line 113 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                                        Write(getdate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 114 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
                                    break;
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 120 "/Users/mac/Projects/amazon/amazon/Views/Home/Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
        document.getElementById(""btncardfake"").addEventListener(""click"", () => {
            document.getElementById(""loginbtn"").click()
        })
    </script>
    <style>
        #detailpur {
            display: inline-flex;
            width: 150px;
            padding-left: 10px;
            padding-top: 10px;
            font-size: 13px;
            font-weight: bold;
            color: gray;
        }

        .btnsprs {
            display: inline-block;
            padding-left: 5px;
            padding-right: 5px;
        }

        .purchse {
            position: absolute;
            top: 300px;
            width: 500px;
            padding: 15px;
            border: solid 1px gray;
            border-radius: 8px;
        }

        .deliver {
            font-size: 15px;
            color: gray;
            margin: 10px;
            font-style: initial;
        }

        .image {
            position: absolute;
            top: 100px;
            left: 30px;
            border: so");
            WriteLiteral(@"lid 1px;
        }

        .details {
            position: absolute;
            top: 100px;
            left: 550px;
        }

        .name {
            letter-spacing: 1px;
            font-weight: bold;
            width: 600px;
            font-size: 22px;
        }

        .rating {
            color: #007185;
            padding-bottom: 5px;
            padding-top: 5px;
        }

        #prices {
            padding-top: 15px;
        }

        #price {
            color: red;
            font-size: 18px;
        }

        .p1, .p2 {
            display: inline-block;
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