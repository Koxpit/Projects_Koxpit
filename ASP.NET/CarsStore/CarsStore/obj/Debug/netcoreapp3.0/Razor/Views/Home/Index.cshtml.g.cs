#pragma checksum "C:\GitHub_Koxpit\Projects_Koxpit\ASP.NET\CarsStore\CarsStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a4f796804c1eec193f346eb37a6a55b602b7f7"
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
#line 1 "C:\GitHub_Koxpit\Projects_Koxpit\ASP.NET\CarsStore\CarsStore\Views\_ViewImports.cshtml"
using CarsStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\GitHub_Koxpit\Projects_Koxpit\ASP.NET\CarsStore\CarsStore\Views\_ViewImports.cshtml"
using CarsStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\GitHub_Koxpit\Projects_Koxpit\ASP.NET\CarsStore\CarsStore\Views\_ViewImports.cshtml"
using CarsStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a4f796804c1eec193f346eb37a6a55b602b7f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1632d5eacaae6014cd8c09ec9f1159aedb9339ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Лучшие автомобили</h2>\r\n<div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 5 "C:\GitHub_Koxpit\Projects_Koxpit\ASP.NET\CarsStore\CarsStore\Views\Home\Index.cshtml"
      
        foreach (Car car in Model.FavCars)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub_Koxpit\Projects_Koxpit\ASP.NET\CarsStore\CarsStore\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("AllCars", car));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\GitHub_Koxpit\Projects_Koxpit\ASP.NET\CarsStore\CarsStore\Views\Home\Index.cshtml"
                                                    
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
