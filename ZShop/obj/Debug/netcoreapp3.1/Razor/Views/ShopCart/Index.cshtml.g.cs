#pragma checksum "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faec49111a6c9265049c6bc80ce3286c80059753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
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
#line 1 "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\_ViewImports.cshtml"
using ZShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\_ViewImports.cshtml"
using ZShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faec49111a6c9265049c6bc80ce3286c80059753", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dddf48b01e87c2b8187c25bf68804d6cfc85afcb", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\ShopCart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""container mb-4"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th scope=""col""> </th>
                            <th scope=""col"">Product</th>
                            <th scope=""col"">Available</th>
                            <th scope=""col"" class=""text-center"">Quantity</th>
                            <th scope=""col"" class=""text-right"">Price</th>
                            <th> </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\ShopCart\Index.cshtml"
                         foreach (var item in Model.shopCart.ShopItemsList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><img src=\"https://dummyimage.com/50x50/55595c/fff\" /> </td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\ShopCart\Index.cshtml"
                               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>In stock</td>\r\n                                <td><input class=\"form-control\" type=\"text\" value=\"1\" /></td>\r\n                                <td class=\"text-right\">");
#nullable restore
#line 33 "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\ShopCart\Index.cshtml"
                                                  Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" грн</td>\r\n                                <td class=\"text-right\"><button class=\"btn btn-sm btn-danger\"><i class=\"fa fa-trash\"></i> </button> </td>\r\n                            </tr>\r\n");
            WriteLiteral(@"                            <tr>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td></td>
                                <td><strong>Total</strong></td>
                                <td class=""text-right""><strong>346,90 €</strong></td>
                            </tr>
");
#nullable restore
#line 46 "C:\Users\Zhdan\source\repos\ZShop\ZShop\Views\ShopCart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                </table>
            </div>
        </div>
        <div class=""col mb-2"">
            <div class=""row"">
                <div class=""col-sm-12  col-md-6"">
                    <button class=""btn btn-block btn-light"">Continue Shopping</button>
                </div>
                <div class=""col-sm-12 col-md-6 text-right"">
                    <button class=""btn btn-lg btn-block btn-success text-uppercase"">Checkout</button>
                </div>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
