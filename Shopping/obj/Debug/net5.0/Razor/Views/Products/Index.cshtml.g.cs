#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb21fc22f87d03d0e9739118385501d62c77340f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb21fc22f87d03d0e9739118385501d62c77340f", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4487f0c86abf7612e0a877d6bdae29213eff1b91", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
   
    var Products = (List<ProductModel>)ViewData["Product"];
    var id = (int)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ol>\r\n");
#nullable restore
#line 8 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
     foreach (var Product in Products)
    {
        if (id == Product.id)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>Product ID : ");
#nullable restore
#line 12 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
                        Write(Product.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , Product Name :  ");
#nullable restore
#line 12 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
                                                      Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , Product Price :  ");
#nullable restore
#line 12 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
                                                                                       Write(Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
        }
        else if (id == -1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>Product ID : ");
#nullable restore
#line 16 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
                        Write(Product.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , Product Name :  ");
#nullable restore
#line 16 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
                                                      Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , Product Price :  ");
#nullable restore
#line 16 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
                                                                                       Write(Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Shopping\Shopping\Views\Products\Index.cshtml"
        }


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ol>");
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