#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Comments
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
    
    #line 3 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Comments/CommentsCount.Default.cshtml")]
    public partial class CommentsCount_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsCountViewModel>
    {
        public CommentsCount_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" data-sf-role=\"comments-count-wrapper\"");

WriteLiteral(" data-sf-thread-key=\"");

            
            #line 8 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
                                                          Write(Model.ThreadKey);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"sf-Comment-count\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" data-sf-role=\"comments-count-anchor\"");

WriteAttribute("href", Tuple.Create(" href=\"", 372), Tuple.Create("\"", 397)
            
            #line 9 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 379), Tuple.Create<System.Object, System.Int32>(Model.NavigateUrl
            
            #line default
            #line hidden
, 379), false)
);

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"sf-icon-comment\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" data-sf-role=\"comments-count-anchor-text\"");

WriteLiteral("></span>\r\n    </a>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"service-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 576), Tuple.Create("\"", 603)
            
            #line 14 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 584), Tuple.Create<System.Object, System.Int32>(ViewBag.ServiceUrl
            
            #line default
            #line hidden
, 584), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-count-resources\"");

WriteAttribute("value", Tuple.Create(" value=\'", 673), Tuple.Create("\'", 824)
, Tuple.Create(Tuple.Create("", 681), Tuple.Create("{\"commentsPlural\":", 681), true)
, Tuple.Create(Tuple.Create(" ", 699), Tuple.Create("\"", 700), true)
            
            #line 15 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
             , Tuple.Create(Tuple.Create("", 701), Tuple.Create<System.Object, System.Int32>(Html.Resource("CommentsPlural")
            
            #line default
            #line hidden
, 701), false)
, Tuple.Create(Tuple.Create("", 733), Tuple.Create("\",", 733), true)
, Tuple.Create(Tuple.Create(" ", 735), Tuple.Create("\"leaveComment\":\"", 736), true)
            
            #line 15 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 752), Tuple.Create<System.Object, System.Int32>(Html.Resource("LeaveComment")
            
            #line default
            #line hidden
, 752), false)
, Tuple.Create(Tuple.Create("", 782), Tuple.Create("\",", 782), true)
, Tuple.Create(Tuple.Create(" ", 784), Tuple.Create("\"comment\":\"", 785), true)
            
            #line 15 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
                                                                                                            , Tuple.Create(Tuple.Create("", 796), Tuple.Create<System.Object, System.Int32>(Html.Resource("Comment")
            
            #line default
            #line hidden
, 796), false)
, Tuple.Create(Tuple.Create("", 821), Tuple.Create("\"", 821), true)
, Tuple.Create(Tuple.Create(" ", 822), Tuple.Create("}", 823), true)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

            
            #line 18 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-count.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
