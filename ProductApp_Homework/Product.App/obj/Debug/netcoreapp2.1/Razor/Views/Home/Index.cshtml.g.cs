#pragma checksum "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68c3edb69fca448eea497babaed36c19583dec28"
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
#line 1 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\_ViewImports.cshtml"
using Products.App;

#line default
#line hidden
#line 2 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\_ViewImports.cshtml"
using Products.App.Models;

#line default
#line hidden
#line 3 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\_ViewImports.cshtml"
using Products.App.Models.Enums;

#line default
#line hidden
#line 4 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\_ViewImports.cshtml"
using Products.App.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68c3edb69fca448eea497babaed36c19583dec28", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"853c57fec0a9ae8df0f94f5890a48c7e16ec3a81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(68, 26, true);
            WriteLiteral("\r\n<h1>Products:</h1>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
            BeginContext(128, 47, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
            EndContext();
            BeginContext(176, 15, false);
#line 13 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(191, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(208, 64, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <ol>\r\n");
            EndContext();
#line 20 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
             foreach (ProductVM product in Model.Products)
            {

#line default
#line hidden
            BeginContext(347, 24, true);
            WriteLiteral("                <li><h4>");
            EndContext();
            BeginContext(372, 12, false);
#line 22 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
                   Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(384, 28, true);
            WriteLiteral("</h4></li>\r\n                ");
            EndContext();
            BeginContext(412, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5accfe413da94491af00ba37ffd21537", async() => {
                BeginContext(501, 15, true);
                WriteLiteral("More details...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            WriteLiteral("ProductDetails/");
#line 23 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
                                                           WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(520, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(537, 53, true);
            WriteLiteral("        </ol>\r\n\r\n        <h3>The number of products: ");
            EndContext();
            BeginContext(591, 22, false);
#line 27 "C:\Users\code\Desktop\MVC_Homework\ProductApp_Homework\Product.App\Views\Home\Index.cshtml"
                               Write(Model.NumberOfProducts);

#line default
#line hidden
            EndContext();
            BeginContext(613, 25, true);
            WriteLiteral("</h3>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
