#pragma checksum "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d51c325b00c6d3c85edb6bda3a8dbf23c55663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d51c325b00c6d3c85edb6bda3a8dbf23c55663", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba6b1b965d54a65f696aeef7f37afda1d7ae018", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookWeb.Entities.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn float-right hidden-sm-down btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
   
    ViewData["Title"] = "Books";

#line default
#line hidden
            BeginContext(85, 47, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html dir=\"ltr\" lang=\"en\">\r\n");
            EndContext();
            BeginContext(132, 991, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41dcbc51ba9f40c1bb5399d7475dd78b", async() => {
                BeginContext(138, 978, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content="""">
    <meta name=""book"" content="""">
    <!-- Favicon icon -->
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""../../assets/images/favicon.png"">
    <title>Booktastic - Probably the best book store out there</title>
    <!-- Custom CSS -->
    <link href=""../../dist/css/style.min.css"" rel=""stylesheet"">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
        <script src=""https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js""></script>
    <![endif]-->
");
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
            BeginContext(1123, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1125, 8190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87fdc5594526483786feb35a4b1cf1fb", async() => {
                BeginContext(1131, 1807, true);
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
        <div class=""page-wrapper"">
            <!-- ============================================================== -->
            <!-- Bread crumb and right sidebar toggle -->
            <!-- =================================");
                WriteLiteral(@"============================= -->
            <div class=""page-breadcrumb"">
                <div class=""row align-items-center"">
                    <div class=""col-5"">
                        <h4 class=""page-title"">Books</h4>
                        <div class=""d-flex align-items-center"">
                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb"">
                                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Books</li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                    <div class=""col-7"">
");
                EndContext();
                BeginContext(3197, 1278, true);
                WriteLiteral(@"                    </div>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class=""container-fluid"">
                <!-- ============================================================== -->
                <!-- Start Page Content -->
                <!-- ============================================================== -->
                <div class=""row"">

                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <h4 class=""card-title"">Book Details<");
                WriteLiteral("/h4>\r\n                                <h6 class=\"card-subtitle\">The ultimate all-you-can-read buffet.</h6>\r\n                            </div>\r\n                            <div class=\"col-md-12 col-12 align-self-center\">\r\n                                ");
                EndContext();
                BeginContext(4475, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de0453c21434e7bb30a30284e6a07a6", async() => {
                    BeginContext(4571, 43, true);
                    WriteLiteral("<i class=\"mdi mdi-plus-circle\"></i>New Book");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4618, 1259, true);
                WriteLiteral(@"
                            </div>
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th scope=""col"">Id</th>
                                            <th scope=""col"">Title</th>
                                            <th scope=""col"">Author ID</th>
                                            <th scope=""col"">Genre ID</th>
                                            <th scope=""col"">ISBN</th>
                                            <th scope=""col"">Year Published</th>
                                            <th scope=""col"">Rating</th>
                                            <th scope=""col"">Summary</th>
                                            <th scope=""col"">Created By</th>
                                            <th scope=""col"">Date Created</th>
             ");
                WriteLiteral("                               <th></th>\r\n                                            <th></th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
                EndContext();
#line 105 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                         foreach (var book in Model)
                                        {

#line default
#line hidden
                BeginContext(5990, 94, true);
                WriteLiteral("                                        <tr>\r\n                                            <td>");
                EndContext();
                BeginContext(6085, 7, false);
#line 108 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Id);

#line default
#line hidden
                EndContext();
                BeginContext(6092, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6148, 10, false);
#line 109 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Title);

#line default
#line hidden
                EndContext();
                BeginContext(6158, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6214, 13, false);
#line 110 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.AuthorId);

#line default
#line hidden
                EndContext();
                BeginContext(6227, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6283, 12, false);
#line 111 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.GenreID);

#line default
#line hidden
                EndContext();
                BeginContext(6295, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6351, 9, false);
#line 112 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.ISBN);

#line default
#line hidden
                EndContext();
                BeginContext(6360, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6416, 16, false);
#line 113 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.YearPublish);

#line default
#line hidden
                EndContext();
                BeginContext(6432, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6488, 11, false);
#line 114 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Rating);

#line default
#line hidden
                EndContext();
                BeginContext(6499, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6555, 12, false);
#line 115 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(6567, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6623, 14, false);
#line 116 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.CreatedBy);

#line default
#line hidden
                EndContext();
                BeginContext(6637, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6693, 16, false);
#line 117 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                           Write(book.DateCreated);

#line default
#line hidden
                EndContext();
                BeginContext(6709, 55, true);
                WriteLiteral("</td>\r\n                                            <td>");
                EndContext();
                BeginContext(6764, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "987d2a6a21984cc7ab5ca9660cfc73dc", async() => {
                    BeginContext(6809, 44, true);
                    WriteLiteral("<i class=\"ti-pencil\" aria-hidden=\"true\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 118 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                                                       WriteLiteral(book.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6857, 56, true);
                WriteLiteral(" </td>\r\n                                            <td>");
                EndContext();
                BeginContext(6913, 189, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e453ae1670447fd831b50a561dd0c80", async() => {
                    BeginContext(6973, 38, true);
                    WriteLiteral("<i class=\"ti-trash\" aria-hidden=\"true\"");
                    EndContext();
                    BeginWriteAttribute("onclick", " onclick=\"", 7011, "\"", 7092, 12);
                    WriteAttributeValue("", 7021, "return", 7021, 6, true);
                    WriteAttributeValue(" ", 7027, "confirm(\'Are", 7028, 13, true);
                    WriteAttributeValue(" ", 7040, "you", 7041, 4, true);
                    WriteAttributeValue(" ", 7044, "sure", 7045, 5, true);
                    WriteAttributeValue(" ", 7049, "you", 7050, 4, true);
                    WriteAttributeValue(" ", 7053, "want", 7054, 5, true);
                    WriteAttributeValue(" ", 7058, "to", 7059, 3, true);
                    WriteAttributeValue(" ", 7061, "delete", 7062, 7, true);
                    WriteAttributeValue(" ", 7068, "the", 7069, 4, true);
                    WriteAttributeValue(" ", 7072, "book", 7073, 5, true);
#line 119 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
WriteAttributeValue(" ", 7077, book.Title, 7078, 11, false);

#line default
#line hidden
                    WriteAttributeValue("", 7089, "?\')", 7089, 3, true);
                    EndWriteAttribute();
                    BeginContext(7093, 5, true);
                    WriteLiteral("></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 119 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                                                         WriteLiteral(book.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7102, 55, true);
                WriteLiteral(" </td>\r\n                                        </tr>\r\n");
                EndContext();
#line 121 "C:\Users\DELL\source\repos\BookAPI\BookWeb\Views\Book\Index.cshtml"
                                        }

#line default
#line hidden
                BeginContext(7200, 2108, true);
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- End PAge Content -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Right sidebar -->
                <!-- ============================================================== -->
                <!-- .right-sidebar -->
                <!-- ============================================================== -->
                <!-- End Right sidebar -->
                <!-- ============================================================== -->
            </div>
        </div>
        <!-- ============================================================== --");
                WriteLiteral(@">
        <!-- End Page wrapper  -->
        <!-- ============================================================== -->
    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- All Jquery -->
    <!-- ============================================================== -->
    <script src=""../../assets/libs/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src=""../../assets/libs/popper.js/dist/umd/popper.min.js""></script>
    <script src=""../../assets/libs/bootstrap/dist/js/bootstrap.min.js""></script>
    <script src=""../../dist/js/app-style-switcher.js""></script>
    <!--Wave Effects -->
    <script src=""../../dist/js/waves.js""></script>
    <!--Menu sidebar -->
    <script src=""../../dist/js/sidebarmenu.js""></script>
    <!--Custom JavaScrip");
                WriteLiteral("t -->\r\n    <script src=\"../../dist/js/custom.js\"></script>\r\n");
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
            BeginContext(9315, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookWeb.Entities.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
