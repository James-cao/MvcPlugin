﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
    using MvcPluginMasterApp.Plugin2.DomainClasses;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/ArticlesArea/Views/Home/Index.cshtml")]
    public partial class _Areas_ArticlesArea_Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<IList<Article>>
    {
        public _Areas_ArticlesArea_Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
  
    ViewBag.Title = "From Plugin 2";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
Write(Styles.Render("~/Plugin2/Content"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>");

            
            #line 8 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
Write(ViewBag.Message);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    Embedded image:\r\n    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 233), Tuple.Create("\"", 286)
            
            #line 12 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Url.Content("~/ArticlesArea/Images/clock.png")
            
            #line default
            #line hidden
, 239), false)
);

WriteLiteral(" alt=\"clock\"");

WriteLiteral(" />\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <ul>\r\n");

            
            #line 17 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li>");

            
            #line 19 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
           Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 20 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 26 "..\..\Areas\ArticlesArea\Views\Home\Index.cshtml"
Write(Scripts.Render("~/Plugin2/Scripts"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
