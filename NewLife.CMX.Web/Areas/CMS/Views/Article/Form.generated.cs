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
    
    #line 2 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using NewLife.CMX.Web;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 3 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\CMS\Views\Article\Form.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/CMS/Views/Article/Form.cshtml")]
    public partial class _Areas_CMS_Views_Article_Form_cshtml : System.Web.Mvc.WebViewPage<NewLife.CMX.IInfo>
    {
        public _Areas_CMS_Views_Article_Form_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..\Areas\CMS\Views\Article\Form.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var entity = Model as IEntity;
    var isNew = entity.IsNullKey;
    var inf = Model as IInfo;
    var article = inf.Ext as IArticle ?? new Article();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Areas\CMS\Views\Article\Form.cshtml"
   Write(Html.Partial("_Form_Header", entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\Areas\CMS\Views\Article\Form.cshtml"
        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\CMS\Views\Article\Form.cshtml"
         using (Html.BeginForm((isNew ? "Add" : "Edit"), null, new { id = Model[fact.Unique.Name] }))
        {
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                    
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                     
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.Partial("_Form_Title", entity));

            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-sm-2\"");

WriteLiteral(">来源</label>\r\n                <div");

WriteLiteral(" class=\"col-sm-1\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.ForDropDownList(Article._.SourceID, Source.FindAllVisible().Cast<IEntity>().ToList(), null, false));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-3\"");

WriteLiteral(">名称</label>\r\n                    <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"SourceName\"");

WriteLiteral(" name=\"SourceName\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1260), Tuple.Create("\"", 1287)
            
            #line 30 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                         , Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(article.SourceName
            
            #line default
            #line hidden
, 1268), false)
);

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"col-sm-5\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">地址</label>\r\n                    <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-home\"");

WriteLiteral("></i></span>\r\n                            <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" id=\"SourceUrl\"");

WriteLiteral(" name=\"SourceUrl\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1759), Tuple.Create("\"", 1785)
            
            #line 38 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                           , Tuple.Create(Tuple.Create("", 1767), Tuple.Create<System.Object, System.Int32>(article.SourceUrl
            
            #line default
            #line hidden
, 1767), false)
);

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"</div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-sm-2 col-md-2\"");

WriteLiteral(">内容</label>\r\n                <div");

WriteLiteral(" class=\"col-sm-10 col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 46 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.Partial("_Form_Content", entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">摘要</label>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <textarea");

WriteLiteral(" cols=\"100\"");

WriteLiteral(" name=\"Summary\"");

WriteLiteral(" rows=\"5\"");

WriteLiteral(">");

            
            #line 52 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                            Write(inf.Summary);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">置顶</label>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 58 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.CheckBox("Top", @article.Top, new { @class = "chkSwitch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <label");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">推荐</label>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 62 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.CheckBox("Recommend", @article.Recommend, new { @class = "chkSwitch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">热门</label>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 68 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.CheckBox("Hot", @article.Hot, new { @class = "chkSwitch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <label");

WriteLiteral(" class=\"control-label col-md-1\"");

WriteLiteral(">幻灯片</label>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 72 "..\..\Areas\CMS\Views\Article\Form.cshtml"
               Write(Html.CheckBox("Slide", @article.Slide, new { @class = "chkSwitch" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">封面</label>\r\n                <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" name=\"Cover\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3657), Tuple.Create("\"", 3679)
            
            #line 78 "..\..\Areas\CMS\Views\Article\Form.cshtml"
, Tuple.Create(Tuple.Create("", 3665), Tuple.Create<System.Object, System.Int32>(article.Cover
            
            #line default
            #line hidden
, 3665), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">发布时间</label>\r\n                <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-calendar\"");

WriteLiteral("></i></span>\r\n                        <input");

WriteLiteral(" class=\"form-control date form_datetime\"");

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" name=\"PublishTime\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4134), Tuple.Create("\"", 4175)
            
            #line 86 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                             , Tuple.Create(Tuple.Create("", 4142), Tuple.Create<System.Object, System.Int32>(inf.PublishTime.ToFullString("")
            
            #line default
            #line hidden
, 4142), false)
);

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 90 "..\..\Areas\CMS\Views\Article\Form.cshtml"
            
            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.Partial("_Form_Footer", entity));

            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                 
            
            
            #line default
            #line hidden
            
            #line 91 "..\..\Areas\CMS\Views\Article\Form.cshtml"
       Write(Html.Partial("_Form_Action", entity));

            
            #line default
            #line hidden
            
            #line 91 "..\..\Areas\CMS\Views\Article\Form.cshtml"
                                                 
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $(""#SourceID"").change(
        function () {
            var v = $(""#SourceID"").val();
            $.ajax({
                type: ""Post"",//使用get方法访问后台
                dataType: ""json"",//返回json格式的数据
                url: '/CMS/Source/Get/' + v,//要访问的后台地址
                success: function (msg) {//msg为返回的数据，在这里做数据绑定
                    $(""#SourceName"").attr(""value"", msg.Name);
                    $(""#SourceUrl"").attr(""value"", msg.Url);
                }
            });
        });
</script>");

        }
    }
}
#pragma warning restore 1591
