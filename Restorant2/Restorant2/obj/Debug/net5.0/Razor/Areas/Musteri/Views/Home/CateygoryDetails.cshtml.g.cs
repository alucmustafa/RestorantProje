#pragma checksum "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68fdee3fd07ec1f9f0c7a7016ce3b31b20431c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Musteri_Views_Home_CateygoryDetails), @"mvc.1.0.view", @"/Areas/Musteri/Views/Home/CateygoryDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\_ViewImports.cshtml"
using Restorant2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\_ViewImports.cshtml"
using Restorant2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fdee3fd07ec1f9f0c7a7016ce3b31b20431c02", @"/Areas/Musteri/Views/Home/CateygoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628f6d1ae6c651f3235e1e9e989dad6029ea831a", @"/Areas/Musteri/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Musteri_Views_Home_CateygoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Restorant2.Models.Menu>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Musteri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn1 flex-c-m size1 txt3 trans-0-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
  
    ViewData["Title"] = "CateygoryDetails";
    Layout = "~/Views/Shared/MasterPage_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Slide-->
<section class=""section-slide"">
    <div class=""wrap-slick1"">
        <div class=""slick1"">
            <div class=""item-slick1 item1-slick1"" style=""background-image: url(/Website/images/slide1-01.jpg);"">
                <div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
                    <span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""fadeInDown"">
                        Hoş geldiniz
                    </span>

                    <h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""fadeInUp"">
                        Kardeşler
                    </h2>

                    <div class=""wrap-btn-slide1 animated visible-false"" data-appear=""zoomIn"">
                        <!-- Button1 -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68fdee3fd07ec1f9f0c7a7016ce3b31b20431c025693", async() => {
                WriteLiteral("\r\n                            Menüler\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""item-slick1 item2-slick1"" style=""background-image: url(/Website/images/master-slides-02.jpg);"">
                <div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
                    <span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rollIn"">
                        Hoş geldiniz
                    </span>

                    <h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""lightSpeedIn"">
                        Restorant2
                    </h2>

                    <div class=""wrap-btn-slide1 animated visible-false"" data-appear=""slideInUp"">
                        <!-- Button1 -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68fdee3fd07ec1f9f0c7a7016ce3b31b20431c028249", async() => {
                WriteLiteral("\r\n                            Menüler\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""item-slick1 item3-slick1"" style=""background-image: url(/Website/images/master-slides-01.jpg);"">
                <div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
                    <span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rotateInDownLeft"">
                        Hoş Geldiniz
                    </span>

                    <h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""rotateInUpRight"">
                        Restorant2
                    </h2>

                    <div class=""wrap-btn-slide1 animated visible-false"" data-appear=""rotateIn"">
                        <!-- Button1 -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68fdee3fd07ec1f9f0c7a7016ce3b31b20431c0210817", async() => {
                WriteLiteral("\r\n                            Menüler\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"wrap-slick1-dots\"></div>\r\n    </div>\r\n</section>\r\n\r\n<div class=\"section-gallery p-t-20 \">\r\n    ");
#nullable restore
#line 75 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n<section class=\"section-lunch bgwhite\">\r\n\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row p-t-10\">\r\n");
#nullable restore
#line 88 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
             if (Model.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-8 col-lg-6 m-l-r-auto"">
                        <!-- Block3 -->
                        <div class=""blo3 flex-w flex-col-l-sm m-b-30"">
                            <div class=""pic-blo3 size20 bo-rad-10 hov-img-zoom m-r-28"">
                                <a href=""#""><img");
            BeginWriteAttribute("src", " src=\"", 4026, "\"", 4043, 1);
#nullable restore
#line 96 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
WriteAttributeValue("", 4032, item.Image, 4032, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-MENU\"></a>\r\n                            </div>\r\n\r\n                            <div class=\"text-blo3 size21 flex-col-l-m\">\r\n                                <a href=\"#\" class=\"txt21 m-b-3\">\r\n                                    ");
#nullable restore
#line 101 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n\r\n                                <span class=\"txt23\">\r\n                                    ");
#nullable restore
#line 105 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n\r\n                                <span class=\"txt22 m-t-20\">\r\n                                    ");
#nullable restore
#line 109 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n");
#nullable restore
#line 116 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"alert alert-warning text-center\">\r\n                  Üzgünüm...Seçtiğiniz kategoriye ait bir menü bulunmamaktadır.\r\n\r\n              </div>\r\n");
#nullable restore
#line 124 "C:\Users\Admin\Desktop\Restorant2\Restorant2\Areas\Musteri\Views\Home\CateygoryDetails.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Restorant2.Models.Menu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
