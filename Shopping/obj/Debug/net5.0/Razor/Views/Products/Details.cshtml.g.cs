#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a869f567bb2bb73620d820d6b934789e9b62194"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a869f567bb2bb73620d820d6b934789e9b62194", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml"
  
    var Products = (List<ProductModel>)ViewData["Product"];
    var id = (int)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <table class=""table"" style=""width:100%;text-align:center;"">
    <thead>
        <tr>
            <th scope=""col"">Product ID</th>
            <th scope=""col"">Product Name</th>
            <th scope=""col"">Product Price</th>
            <th scope=""col"">Product Image </th>
            
        </tr>
    </thead>
");
#nullable restore
#line 18 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml"
     foreach (var Product in Products)
    {
        if (id == Product.id)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml"
                           Write(Product.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml"
               Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml"
               Write(Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=", 695, "", 714, 1);
#nullable restore
#line 26 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml"
WriteAttributeValue("", 700, Product.image, 700, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\" height=\"200px\" /></td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Details.cshtml"
        }
           


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
