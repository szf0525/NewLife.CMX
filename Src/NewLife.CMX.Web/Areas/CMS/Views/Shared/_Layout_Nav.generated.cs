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
    
    #line 1 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Shared/_Layout_Nav.cshtml")]
    public partial class _Areas_CMS_Views_Shared__Layout_Nav_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_CMS_Views_Shared__Layout_Nav_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
  
    var chn = ViewBag.Channel as Channel;
    var cat = ViewBag.Category as ICategory;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
 if (chn != null && cat != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <i");

WriteLiteral(" class=\"ace-icon fa fa-home home-icon\"");

WriteLiteral("></i>\r\n");

WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 217), Tuple.Create("\"", 289)
            
            #line 9 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 224), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", new { channel = chn.ID, category = cat.ID })
            
            #line default
            #line hidden
, 224), false)
);

WriteLiteral(" class=\"h4\"");

WriteLiteral("><strong>");

            
            #line 9 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
                                                                                              Write(chn.Name);

            
            #line default
            #line hidden
WriteLiteral("</strong></a>\r\n");

            
            #line 10 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
    if (cat != null)
    {
        foreach (ICategory item in cat.AllParents)
        {
            if (item.ID != 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                ");

WriteLiteral("&nbsp;/&nbsp;");

WriteLiteral("\r\n");

WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 540), Tuple.Create("\"", 613)
            
            #line 17 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 547), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", new { channel = chn.ID, category = item.ID })
            
            #line default
            #line hidden
, 547), false)
);

WriteLiteral(" class=\"h4\"");

WriteLiteral(">");

            
            #line 17 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
                                                                                                   Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 18 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("&nbsp;/&nbsp;");

WriteLiteral("\r\n");

WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 713), Tuple.Create("\"", 785)
            
            #line 22 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 720), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", new { channel = chn.ID, category = cat.ID })
            
            #line default
            #line hidden
, 720), false)
);

WriteLiteral(" class=\"h4\"");

WriteLiteral("><strong>");

            
            #line 22 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
                                                                                              Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("</strong></a>\r\n");

            
            #line 23 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
}
else
{
    var menu = ManageProvider.Menu.Current;

            
            #line default
            #line hidden
WriteLiteral("    <i");

WriteLiteral(" class=\"ace-icon fa fa-home home-icon\"");

WriteLiteral("></i>\r\n");

            
            #line 28 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
    if (menu != null)
    {
        foreach (IMenu item in menu.AllParents)
        {
            if (item.ID != 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1092), Tuple.Create("\"", 1143)
            
            #line 34 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 1099), Tuple.Create<System.Object, System.Int32>(item.Url!=null? Url.Content(item.Url):"#"
            
            #line default
            #line hidden
, 1099), false)
);

WriteLiteral(" class=\"h4\"");

WriteLiteral(">");

            
            #line 34 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
                                                                             Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("                ");

WriteLiteral("&nbsp;/&nbsp;");

WriteLiteral("\r\n");

            
            #line 36 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1262), Tuple.Create("\"", 1289)
            
            #line 39 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 1269), Tuple.Create<System.Object, System.Int32>(Url.Action("Index")
            
            #line default
            #line hidden
, 1269), false)
);

WriteLiteral(" class=\"h4\"");

WriteLiteral("><strong>");

            
            #line 39 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
                                                  Write(menu != null ? menu.DisplayName : ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong></a>");

            
            #line 39 "..\..\Areas\CMS\Views\Shared\_Layout_Nav.cshtml"
                                                                                                                     }
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
