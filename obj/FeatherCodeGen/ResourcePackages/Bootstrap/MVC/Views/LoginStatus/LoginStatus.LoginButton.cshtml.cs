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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.LoginStatus
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
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginButton.cshtml")]
    public partial class LoginStatus_LoginButton : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginButton()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 228), Tuple.Create("\"", 251)
            
            #line 8 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 236), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 236), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(" class=\"media\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\r\n            <img");

WriteLiteral(" data-sf-role=\"sf-logged-in-avatar\"");

WriteLiteral(" width=\"80\"");

WriteLiteral(" height=\"80\"");

WriteLiteral(" class=\"media-object\"");

WriteLiteral("  />\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\r\n\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 538), Tuple.Create("\"", 575)
            
            #line 16 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 545), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 545), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral("></a>\r\n            <p");

WriteLiteral(" data-sf-role=\"sf-logged-in-email\"");

WriteLiteral("></p>\r\n            <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-sf-role=\"sf-logged-in-log-out-btn\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                                               Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n\r\n        <button");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" data-sf-role=\"login-status-button\"");

WriteLiteral(">");

            
            #line 25 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                                      Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1010), Tuple.Create("\"", 1052)
            
            #line 26 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1017), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 1017), false)
);

WriteLiteral(">");

            
            #line 26 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\r\n    </div>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1176), Tuple.Create("\"", 1207)
            
            #line 31 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1184), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1184), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1270), Tuple.Create("\"", 1298)
            
            #line 32 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1278), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1278), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-login-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1360), Tuple.Create("\"", 1387)
            
            #line 33 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1368), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 1368), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1452), Tuple.Create("\"", 1492)
            
            #line 34 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1460), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1460), false)
);

WriteLiteral(" />\r\n\r\n");

            
            #line 36 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
