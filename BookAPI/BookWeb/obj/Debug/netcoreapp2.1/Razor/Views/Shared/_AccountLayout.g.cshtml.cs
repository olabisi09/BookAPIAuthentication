#pragma checksum "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Shared\_AccountLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1de051cf02ea084d92c99af80d07915033c6dff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AccountLayout), @"mvc.1.0.view", @"/Views/Shared/_AccountLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AccountLayout.cshtml", typeof(AspNetCore.Views_Shared__AccountLayout))]
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
#line 1 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\_ViewImports.cshtml"
using BookWeb;

#line default
#line hidden
#line 2 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\_ViewImports.cshtml"
using BookWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1de051cf02ea084d92c99af80d07915033c6dff", @"/Views/Shared/_AccountLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba6b1b965d54a65f696aeef7f37afda1d7ae018", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AccountLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-search position-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CookieConsentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 17, true);
            WriteLiteral("<!DOCTYPE html>\r\n");
            EndContext();
            BeginContext(17, 1147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fcf58d706d54a8c956fdaa9ddbcf10c", async() => {
                BeginContext(23, 1105, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content="""">
    <meta name=""Book Store"" content="""">
    <!-- Favicon icon -->
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""../../assets/images/favicon.png"">
    <title>BooksThor - Probably the best bookstore out there.</title>
    <!-- Custom CSS -->
    <link href=""../../assets/libs/chartist/dist/chartist.min.css"" rel=""stylesheet"">
    <!-- Custom CSS -->
    <link href=""../../dist/css/style.min.css"" rel=""stylesheet"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
        <script src=""https://oss.maxcdn.co");
                WriteLiteral("m/libs/respond.js/1.4.2/respond.min.js\"></script>\r\n    <![endif]-->\r\n    <title> ");
                EndContext();
                BeginContext(1129, 17, false);
#line 22 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Shared\_AccountLayout.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(1146, 11, true);
                WriteLiteral(" </title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1164, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1166, 7336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24391714f020431b877b90f055c701d7", async() => {
                BeginContext(1172, 1731, true);
                WriteLiteral(@"
    <!-- ============================================================== -->
    <!-- Preloader - style you can find in spinners.css -->
    <!-- ============================================================== -->
    <div class=""preloader"">
        <div class=""lds-ripple"">
            <div class=""lds-pos""></div>
            <div class=""lds-pos""></div>
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- Main wrapper - style you can find in pages.scss -->
    <!-- ============================================================== -->
    <div id=""main-wrapper"" data-layout=""vertical"" data-navbarbg=""skin5"" data-sidebartype=""full"" data-sidebar-position=""absolute"" data-header-position=""absolute"" data-boxed-layout=""full"">
        <!-- ============================================================== -->
        <!-- Topbar header - style you can find in pages.scss -->
        <!-- ============================================================== -->
");
                WriteLiteral(@"
        <header class=""topbar"" data-navbarbg=""skin5"">
            <nav class=""navbar top-navbar navbar-expand-md navbar-dark"">
                <div class=""navbar-header"" data-logobg=""skin5"">
                    <!-- ============================================================== -->
                    <!-- Logo -->
                    <!-- ============================================================== -->
                    <a class=""navbar-brand"">
                        <!-- Logo icon -->
                        <b class=""logo-icon"">
                            <!--You can put here icon as well // <i class=""wi wi-sunset""></i> //-->
                            <!-- Dark Logo icon -->
");
                EndContext();
                BeginContext(3017, 54, true);
                WriteLiteral("                            <!-- Light Logo icon -->\r\n");
                EndContext();
                BeginContext(3192, 224, true);
                WriteLiteral("                        </b>\r\n                        <!--End Logo icon -->\r\n                        <!-- Logo text -->\r\n                        <span class=\"logo-text\">\r\n                            <!-- dark Logo text -->\r\n");
                EndContext();
                BeginContext(3530, 54, true);
                WriteLiteral("                            <!-- Light Logo text -->\r\n");
                EndContext();
                BeginContext(3705, 1660, true);
                WriteLiteral(@"                            BooksThor
                        </span>
                    </a>
                    <!-- ============================================================== -->
                    <!-- End Logo -->
                    <!-- ============================================================== -->
                    <!-- This is for the sidebar toggle which is visible on mobile only -->
                    <a class=""nav-toggler waves-effect waves-light d-block d-md-none"" href=""javascript:void(0)""><i class=""ti-menu ti-close""></i></a>
                </div>
                <!-- ============================================================== -->
                <!-- End Logo -->
                <!-- ============================================================== -->
                <div class=""navbar-collapse collapse"" id=""navbarSupportedContent"" data-navbarbg=""skin5"">
                    <!-- ============================================================== -->
                    <!");
                WriteLiteral(@"-- toggle and nav items -->
                    <!-- ============================================================== -->
                    <ul class=""navbar-nav float-left mr-auto"">
                        <!-- ============================================================== -->
                        <!-- Search -->
                        <!-- ============================================================== -->
                        <li class=""nav-item search-box"">
                            <a class=""nav-link waves-effect waves-dark"" href=""javascript:void(0)""><i class=""ti-search""></i></a>
                            ");
                EndContext();
                BeginContext(5365, 235, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaf6dd5952f7449881e1e65dfac66e07", async() => {
                    BeginContext(5408, 185, true);
                    WriteLiteral("\r\n                                <input type=\"text\" class=\"form-control\" placeholder=\"Search &amp; enter\"> <a class=\"srh-btn\"><i class=\"ti-close\"></i></a>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5600, 1870, true);
                WriteLiteral(@"
                        </li>
                    </ul>
                    <!-- ============================================================== -->
                    <!-- Right side toggle and nav items -->
                    <!-- ============================================================== -->
                    <ul class=""navbar-nav float-right"">
                        <!-- ============================================================== -->
                        <!-- User profile and search -->
                        <!-- ============================================================== -->
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle text-muted waves-effect waves-dark pro-pic"" href="""" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><img src=""../../assets/images/users/1.jpg"" alt=""user"" class=""rounded-circle"" width=""31""></a>
                            <div class=""dropdown-menu dropdown-menu-right us");
                WriteLiteral(@"er-dd animated"">
                                <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ti-user m-r-5 m-l-5""></i> My Profile</a>
                                <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ti-wallet m-r-5 m-l-5""></i> My Balance</a>
                                <a class=""dropdown-item"" href=""javascript:void(0)""><i class=""ti-email m-r-5 m-l-5""></i> Inbox</a>
                            </div>
                        </li>
                        <!-- ============================================================== -->
                        <!-- User profile and search -->
                        <!-- ============================================================== -->
                    </ul>
                </div>
            </nav>
        </header>
    </div>
    ");
                EndContext();
                BeginContext(7470, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "433bdc1c5c4e4ffabe172053f02f9db0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7510, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7517, 12, false);
#line 115 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Shared\_AccountLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(7529, 922, true);
                WriteLiteral(@"

    <script src=""../../assets/libs/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src=""../../assets/libs/popper.js/dist/umd/popper.min.js""></script>
    <script src=""../../assets/libs/bootstrap/dist/js/bootstrap.min.js""></script>
    <script src=""../../dist/js/app-style-switcher.js""></script>
    <!--Wave Effects -->
    <script src=""../../dist/js/waves.js""></script>
    <!--Menu sidebar -->
    <script src=""../../dist/js/sidebarmenu.js""></script>
    <!--Custom JavaScript -->
    <script src=""../../dist/js/custom.js""></script>
    <!--This page JavaScript -->
    <!--chartis chart-->
    <script src=""../../assets/libs/chartist/dist/chartist.min.js""></script>
    <script src=""../../assets/libs/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.min.js""></script>
    <script src=""../../dist/js/pages/dashboards/dashboard1.js""></script>

    ");
                EndContext();
                BeginContext(8452, 41, false);
#line 134 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Shared\_AccountLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(8493, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
