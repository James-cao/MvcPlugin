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
    
    #line 1 "..\..\Views\Shared\_PluginsMenu.cshtml"
    using MvcPluginMasterApp.IoCConfig;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_PluginsMenu.cshtml"
    using MvcPluginMasterApp.PluginsBase;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_PluginsMenu.cshtml")]
    public partial class _Views_Shared__PluginsMenu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__PluginsMenu_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_PluginsMenu.cshtml"
  
    var plugins = SmObjectFactory.Container.GetAllInstances<IPlugin>().ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 7 "..\..\Views\Shared\_PluginsMenu.cshtml"
 foreach (var plugin in plugins)
{
    var menuItem = plugin.GetMenuItem(this.Request.RequestContext);

            
            #line default
            #line hidden
WriteLiteral("    <li>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 293), Tuple.Create("\"", 313)
            
            #line 11 "..\..\Views\Shared\_PluginsMenu.cshtml"
, Tuple.Create(Tuple.Create("", 300), Tuple.Create<System.Object, System.Int32>(menuItem.Url
            
            #line default
            #line hidden
, 300), false)
);

WriteLiteral(">");

            
            #line 11 "..\..\Views\Shared\_PluginsMenu.cshtml"
                           Write(menuItem.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </li>\r\n");

            
            #line 13 "..\..\Views\Shared\_PluginsMenu.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
