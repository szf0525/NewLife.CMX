﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.CMX;
    using NewLife.CMX.Web;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/Index.cshtml")]
    public partial class _Views_Home_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Home\Index.cshtml"
  
    ViewBag.Title = "首页";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"jumbotron\"");

WriteLiteral(">\r\n    <p>\r\n        <h1>学无先后达者为师</h1>\r\n    </p>\r\n</div>\r\n<div");

WriteLiteral(" class=\"benefits container\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Home\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Home\Index.cshtml"
      
        var cats = Category.Root.Childs.ToList().Where(e => e.Model == null || e.Model.Enable).ToList();
        var cell = 3;
        var width = 12 / cell;
        var left = 12 - width * cell;
        var right = left / 2;
        left -= right;
        for (int i = 0; i < cats.Count; )
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\Home\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Home\Index.cshtml"
                 if (left > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 570), Tuple.Create("\"", 590)
, Tuple.Create(Tuple.Create("", 578), Tuple.Create("col-md-", 578), true)
            
            #line 22 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 585), Tuple.Create<System.Object, System.Int32>(left
            
            #line default
            #line hidden
, 585), false)
);

WriteLiteral("></div>\r\n");

            
            #line 23 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 24 "..\..\Views\Home\Index.cshtml"
                 for (int j = 0; j < cell && i < cats.Count; j++, i++)
                {
                    var cat = cats[i];

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 774), Tuple.Create("\"", 795)
, Tuple.Create(Tuple.Create("", 782), Tuple.Create("col-md-", 782), true)
            
            #line 27 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 789), Tuple.Create<System.Object, System.Int32>(width
            
            #line default
            #line hidden
, 789), false)
);

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n                            <h2>");

            
            #line 29 "..\..\Views\Home\Index.cshtml"
                           Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(" style=\"vertical-align:text-bottom\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1040), Tuple.Create("\"", 1072)
            
            #line 32 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1047), Tuple.Create<System.Object, System.Int32>(this.GetCategoryUrl(cat)
            
            #line default
            #line hidden
, 1047), false)
);

WriteLiteral(">更多</a>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-md-12 widget_list lz_con fixed tab_list show\"");

WriteLiteral(">\r\n                            <ul>\r\n");

            
            #line 36 "..\..\Views\Home\Index.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Home\Index.cshtml"
                                 foreach (var item in cat.GetInfos(1, 5))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <li>\r\n                                       " +
" [<a");

WriteAttribute("href", Tuple.Create(" href=\"", 1431), Tuple.Create("\"", 1473)
            
            #line 39 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(this.GetCategoryUrl(item.Category)
            
            #line default
            #line hidden
, 1438), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                                            <i></i>");

            
            #line 40 "..\..\Views\Home\Index.cshtml"
                                              Write(item.Category);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </a>]\r\n                                " +
"        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1649), Tuple.Create("\"", 1674)
            
            #line 42 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create<System.Object, System.Int32>(this.GetUrl(item)
            
            #line default
            #line hidden
, 1656), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                                            <i></i>");

            
            #line 43 "..\..\Views\Home\Index.cshtml"
                                              Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </a>\r\n                                 " +
"   </li>\r\n");

            
            #line 46 "..\..\Views\Home\Index.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </ul>\r\n                        </div>\r\n              " +
"      </div>\r\n");

            
            #line 50 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 51 "..\..\Views\Home\Index.cshtml"
                 if (right > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2072), Tuple.Create("\"", 2093)
, Tuple.Create(Tuple.Create("", 2080), Tuple.Create("col-md-", 2080), true)
            
            #line 53 "..\..\Views\Home\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2087), Tuple.Create<System.Object, System.Int32>(right
            
            #line default
            #line hidden
, 2087), false)
);

WriteLiteral("></div>\r\n");

            
            #line 54 "..\..\Views\Home\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 56 "..\..\Views\Home\Index.cshtml"
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591