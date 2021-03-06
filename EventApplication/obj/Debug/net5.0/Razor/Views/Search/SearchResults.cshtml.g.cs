#pragma checksum "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7bbb11b92d3350173c707e6e6d0833d6390b14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchResults), @"mvc.1.0.view", @"/Views/Search/SearchResults.cshtml")]
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
#line 1 "D:\WebApp\WebApp\EventApplication\Views\_ViewImports.cshtml"
using EventApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WebApp\WebApp\EventApplication\Views\_ViewImports.cshtml"
using EventApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
using EventApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a7bbb11b92d3350173c707e6e6d0833d6390b14", @"/Views/Search/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39fdd6a16401e4b7639cdffea0d09ddd669f80ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
  
    ViewData["Title"] = "SearchResults";
    Layout = "~/Views/Shared/_Layout.cshtml";

        string[] TableHeaders = new string[]
            {
              "Name",
              "Location",
              "Time",
              "Date",
              "Status",
              "Category"
            };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class = \"table row justify-content-center align-align-items-center \">\r\n    <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n            <tr>\r\n");
#nullable restore
#line 24 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                  
                        foreach(var head in TableHeaders)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 28 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                           Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 30 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                        }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n    \r\n        <tbody>\r\n");
#nullable restore
#line 36 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
              
                if (Model != null)
                {
                    foreach (var Data in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>    \r\n                            <td>");
#nullable restore
#line 42 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                           Write(Data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                           Write(Data.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                           Write(Data.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                           Write(Data.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                           Write(Data.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                           Write(Data.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 50 "D:\WebApp\WebApp\EventApplication\Views\Search\SearchResults.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        \r\n\r\n    </table>\r\n</div>");
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
