#pragma checksum "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a5834b150b54a59715ce1ca89d1e77fdd3922f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\_ViewImports.cshtml"
using ZShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\_ViewImports.cshtml"
using ZShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5834b150b54a59715ce1ca89d1e77fdd3922f4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dddf48b01e87c2b8187c25bf68804d6cfc85afcb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hidden-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        
.col-item
{
    border: 1px solid #E1E1E1;
    border-radius: 10px;
    background: #FFF;
}
.col-item:hover
{
  box-shadow: 0px 2px 5px -1px #000;
  -moz-box-shadow: 0px 2px 5px -1px #000;
  -webkit-box-shadow: 0px 2px 5px -1px #000;
  -webkit-border-radius: 0px;
  -moz-border-radius: 0px;
  border-radius: 10px;
  -webkit-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  -ms-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
  border-bottom:2px solid #52A1D5;
}
.col-item .photo img
{
    margin: 0 auto;
    width: 100%;
    padding: 1px;
    border-radius: 10px 10px 0 0 ;
}

.col-item .info
{
    padding: 10px;
    border-radius: 0 0 5px 5px;
    margin-top: 1px;
}

.col-item .price
{
    /*width: 50%;*/
    float: left;
    margin-top: 5px;
}

.col-item .price h5
{
    line-height: 20px;
    margin: 0;
    
}

.price-text-color
{
    color: #219FD1;
");
            WriteLiteral(@"}

.col-item .info .rating
{
    color: #777;
}

.col-item .rating
{
    /*width: 50%;*/
    float: left;
    font-size: 17px;
    text-align: right;
    line-height: 52px;
    margin-bottom: 10px;
    height: 52px;
}

.col-item .separator
{
    border-top: 1px solid #E1E1E1;
}

.clear-left
{
    clear: left;
}

.col-item .separator p
{
    line-height: 20px;
    margin-bottom: 0;
    margin-top: 10px;
    text-align: center;
}

.col-item .separator p i
{
    margin-right: 5px;
}
.col-item .btn-add
{
    width: 50%;
    float: left;
}

.col-item .btn-add
{
    border-right: 1px solid #E1E1E1;

}

.col-item .btn-details
{
    width: 50%;
    float: left;
    padding-left: 10px;
}
.controls
{
    margin-top: 20px;
}
[data-slide=""prev""]
{
    margin-right: 10px;
}

/*
Hover the image
*/
.post-img-content
{
    height: 196px;
    position: relative;
}
.post-img-content img
{
    position: absolute;
    padding: 1px;
    border-radius: ");
            WriteLiteral(@"10px 10px 0 0 ;
}
.post-title{
    display: table-cell;
    vertical-align: bottom;
    z-index: 2;
    position: relative;
}
.post-title b{
    background-color: rgba(51, 51, 51, 0.58);
    display: inline-block;
    margin-bottom: 5px;
    margin-left: 2px;
    color: #FFF;
    padding: 10px 15px;
    margin-top: 10px;
    font-size: 12px;
}
.post-title b:first-child{
    font-size: 14px;
}
.round-tag{
    width: 60px;
    height: 60px;
    border-radius: 50% 50% 50% 0;
    border: 4px solid #FFF;
    background: #37A12B;
    position: absolute;
    bottom: 0px;
    padding: 15px 6px;
    font-size: 17px;
    color: #FFF;
    font-weight: bold;
}
    </style>
<tbody>
    <div class=""container"" style=""margin-top:50px;"">
        <div class=""row"">
");
#nullable restore
#line 178 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {





#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xs-12 col-sm-6 col-md-3\">\r\n                    <div class=\"col-item\">\r\n                        <div class=\"post-img-content\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3180, "\"", 3238, 1);
#nullable restore
#line 187 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml"
WriteAttributeValue("", 3186, Html.DisplayFor(modelItem => item.ImageUrlShowCase), 3186, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\" />\r\n");
            WriteLiteral("                        </div>\r\n                        <div class=\"info\">\r\n                            <div class=\"row\">\r\n                                <div class=\"price col-md-6\">\r\n                                    <h5>  ");
#nullable restore
#line 196 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <h5 class=\"price-text-color\">");
#nullable restore
#line 197 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                </div>
                            </div>
                            <div class=""separator clear-left"">
                                <p class=""btn-add"">
                                    <i class=""fa fa-shopping-cart""></i><a href=""#"" class=""hidden-sm"">Купить</a>
                                </p>
                                <p class=""btn-details"">
                                    <i class=""fa fa-list""></i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a5834b150b54a59715ce1ca89d1e77fdd3922f49061", async() => {
                WriteLiteral("Осмотреть");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml"
                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                            <div class=\"clearfix\">\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 213 "C:\Users\Zhdan\Source\Repos\ZShop\ZShop\Views\Home\Index.cshtml"





             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</tbody>

<link href=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
