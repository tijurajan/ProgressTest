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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Reviews
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
    
    #line 3 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Reviews/ReviewsCount.Default.cshtml")]
    public partial class ReviewsCount_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsCountViewModel>
    {
        public ReviewsCount_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" data-sf-role=\"comments-count-wrapper\"");

WriteLiteral(" data-sf-thread-key=\"");

            
            #line 8 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                          Write(Model.ThreadKey);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"sf-Review-count\"");

WriteLiteral(">\r\n\r\n    <span");

WriteLiteral(" data-sf-role=\"list-rating-wrapper\"");

WriteLiteral(" class=\"sf-Ratings\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" data-sf-role=\"list-rating-container\"");

WriteLiteral(" class=\"sf-Ratings-stars sf-Ratings-stars--ronly\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"text-muted sf-Ratings-average\"");

WriteLiteral(">\r\n            (<span");

WriteLiteral(" data-sf-role=\"list-rating-value\"");

WriteLiteral("></span>)\r\n        </span>\r\n    </span>\r\n     <a");

WriteLiteral(" data-sf-role=\"comments-count-anchor\"");

WriteAttribute("href", Tuple.Create(" href=\"", 695), Tuple.Create("\"", 720)
            
            #line 16 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 702), Tuple.Create<System.Object, System.Int32>(Model.NavigateUrl
            
            #line default
            #line hidden
, 702), false)
);

WriteLiteral(" class=\"sf-Ratings-count\"");

WriteLiteral(">\t\t\r\n          <span");

WriteLiteral(" data-sf-role=\"comments-count-anchor-text\"");

WriteLiteral("></span>\t\t\r\n     </a>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"service-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 882), Tuple.Create("\"", 909)
            
            #line 19 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 890), Tuple.Create<System.Object, System.Int32>(ViewBag.ServiceUrl
            
            #line default
            #line hidden
, 890), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-count-resources\"");

WriteAttribute("value", Tuple.Create(" value=\'", 979), Tuple.Create("\'", 1178)
, Tuple.Create(Tuple.Create("", 987), Tuple.Create("{\"commentsPlural\":", 987), true)
, Tuple.Create(Tuple.Create(" ", 1005), Tuple.Create("\"", 1006), true)
            
            #line 20 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
            , Tuple.Create(Tuple.Create("", 1007), Tuple.Create<System.Object, System.Int32>(Html.Resource("ReviewsPlural")
            
            #line default
            #line hidden
, 1007), false)
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create("\",", 1038), true)
, Tuple.Create(Tuple.Create(" ", 1040), Tuple.Create("\"leaveComment\":\"", 1041), true)
            
            #line 20 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                              , Tuple.Create(Tuple.Create("", 1057), Tuple.Create<System.Object, System.Int32>(Html.Resource("WriteReview")
            
            #line default
            #line hidden
, 1057), false)
, Tuple.Create(Tuple.Create("", 1086), Tuple.Create("\",", 1086), true)
, Tuple.Create(Tuple.Create(" ", 1088), Tuple.Create("\"comment\":\"", 1089), true)
            
            #line 20 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                         , Tuple.Create(Tuple.Create("", 1100), Tuple.Create<System.Object, System.Int32>(Html.Resource("Review")
            
            #line default
            #line hidden
, 1100), false)
, Tuple.Create(Tuple.Create("", 1124), Tuple.Create("\",", 1124), true)
, Tuple.Create(Tuple.Create(" ", 1126), Tuple.Create("\"averageRating\":\"", 1127), true)
            
            #line 20 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1144), Tuple.Create<System.Object, System.Int32>(Html.Resource("AverageRating")
            
            #line default
            #line hidden
, 1144), false)
, Tuple.Create(Tuple.Create("", 1175), Tuple.Create("\"", 1175), true)
, Tuple.Create(Tuple.Create(" ", 1176), Tuple.Create("}", 1177), true)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"rating-template\"");

WriteLiteral("  style=\"display:none;\"");

WriteLiteral("><span>&#9733;</span></div>\r\n\r\n");

            
            #line 26 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Reviews/rating.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 27 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-count.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
