﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    using NewLife;
    using NewLife.CMX;
    using NewLife.CMX.Web;
    
    #line 1 "..\..\Views\Shared\_Footer.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Footer.cshtml")]
    public partial class _Views_Shared__Footer_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Footer_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Footer.cshtml"
  
    var footer = Nav.Root.FindByPath("尾部") ?? Nav.Root;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Views\Shared\_Footer.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Shared\_Footer.cshtml"
     foreach (var nav in footer.Childs)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"span3\"");

WriteLiteral(">\r\n            <h3>");

            
            #line 9 "..\..\Views\Shared\_Footer.cshtml"
           Write(nav.Name);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 10 "..\..\Views\Shared\_Footer.cshtml"
            
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Shared\_Footer.cshtml"
             foreach (var item in nav.Childs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 302), Tuple.Create("\"", 318)
            
            #line 12 "..\..\Views\Shared\_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 309), Tuple.Create<System.Object, System.Int32>(item.Url
            
            #line default
            #line hidden
, 309), false)
);

WriteAttribute("target", Tuple.Create(" target=\"", 319), Tuple.Create("\"", 380)
            
            #line 12 "..\..\Views\Shared\_Footer.cshtml"
, Tuple.Create(Tuple.Create("", 328), Tuple.Create<System.Object, System.Int32>(item.Url.StartsWithIgnoreCase("http")?"_blank":""
            
            #line default
            #line hidden
, 328), false)
);

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\_Footer.cshtml"
                                                                                             Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>");

WriteLiteral("<br>\r\n");

            
            #line 13 "..\..\Views\Shared\_Footer.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 15 "..\..\Views\Shared\_Footer.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n<div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <p>");

            
            #line 19 "..\..\Views\Shared\_Footer.cshtml"
      Write(SysConfig.Current.Company);

            
            #line default
            #line hidden
WriteLiteral(" &copy; ");

            
            #line 19 "..\..\Views\Shared\_Footer.cshtml"
                                        Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral(" 设计制作：<a");

WriteLiteral(" href=\"http://www.newlifex.com\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">新生命开发团队</a></p>\r\n    </div>\r\n</div>\r\n");

            
            #line 22 "..\..\Views\Shared\_Footer.cshtml"
 if (DbRunTimeModule.Enable)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 25 "..\..\Views\Shared\_Footer.cshtml"
   Write(Html.Raw(DbRunTimeModule.GetInfo()));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 27 "..\..\Views\Shared\_Footer.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
