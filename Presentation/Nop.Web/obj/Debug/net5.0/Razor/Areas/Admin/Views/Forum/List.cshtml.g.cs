#pragma checksum "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a348a9ec87b89cdb6938b62dbff7bf681f646e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Forum_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Forum/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.MultiFactorAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a348a9ec87b89cdb6938b62dbff7bf681f646e", @"/Areas/Admin/Views/Forum/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Forum_List : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ForumGroupSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateForumGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateForum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml"
  
    //page title
    ViewBag.PageTitle = T("Admin.ContentManagement.Forums").Text;
    //active menu item (system name)
    Html.SetActiveMenuItemSystemName("Manage forums");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-header clearfix\">\r\n    <h1 class=\"float-left\">\r\n        ");
#nullable restore
#line 13 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml"
   Write(T("Admin.ContentManagement.Forums"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <div class=\"float-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5a348a9ec87b89cdb6938b62dbff7bf681f646e15357", async() => {
#nullable restore
#line 16 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml"
                                                            Write(T("Admin.ContentManagement.Forums.ForumGroup.CreateForumGroup"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5a348a9ec87b89cdb6938b62dbff7bf681f646e16853", async() => {
#nullable restore
#line 17 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml"
                                                       Write(T("Admin.ContentManagement.Forums.Forum.CreateForum"));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml"
   Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ForumListButtons }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<section class=""content"">
    <div class=""container-fluid"">
        <div class=""form-horizontal"">
            <div class=""cards-group"">
                <div class=""card card-default"">
                    <div class=""card-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-doc-reference", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5a348a9ec87b89cdb6938b62dbff7bf681f646e18928", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopDocReferenceTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml"
                                                    WriteLiteral(T("Admin.Documentation.Reference.Forums", Docs.Forums + Utm.OnAdmin));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-string-resource", __Nop_Web_Framework_TagHelpers_Admin_NopDocReferenceTagHelper.StringResource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 30 "C:\Kod\nopcommerce\Presentation\Nop.Web\Areas\Admin\Views\Forum\List.cshtml"
                   Write(await Html.PartialAsync("Table", new DataTablesModel
                        {
                            Name = "forumgroup-grid",
                            UrlRead = new DataUrl("ForumGroupList", "Forum", null),
                            PrimaryKeyColumn = nameof(ForumGroupModel.Id),
                            Length = Model.PageSize,
                            LengthMenu = Model.AvailablePageSizes,
                            ColumnCollection = new List<ColumnProperty>
                            {
                                new ColumnProperty(null)
                                {
                                    Render = new RenderChildCaret(),
                                    Width = "5",
                                    Searchable = false,
                                    ClassName =  NopColumnClassDefaults.ChildControl
                                },
                                new ColumnProperty(nameof(ForumGroupModel.Name))
                                {
                                    Title = T("Admin.ContentManagement.Forums.ForumGroup.Fields.Name").Text,
                                    Width = "300"
                                },
                                new ColumnProperty(nameof(ForumGroupModel.DisplayOrder))
                                {
                                    Title = T("Admin.ContentManagement.Forums.ForumGroup.Fields.DisplayOrder").Text,
                                    Width = "100",
                                    ClassName =  NopColumnClassDefaults.CenterAll
                                },
                                new ColumnProperty(nameof(ForumGroupModel.CreatedOn))
                                {
                                    Title = T("Admin.ContentManagement.Forums.ForumGroup.Fields.CreatedOn").Text,
                                    Width = "200",
                                    Render = new RenderDate()
                                },
                                new ColumnProperty(nameof(ForumGroupModel.Id))
                                {
                                    Title = T("Admin.Common.Edit").Text,
                                    Width = "50",
                                    ClassName = NopColumnClassDefaults.Button,
                                    Render = new RenderButtonEdit(new DataUrl("EditForumGroup"))
                                }
                            },
                            ChildTable = new DataTablesModel
                            {
                                Name = "forumdetails-grid",
                                UrlRead = new DataUrl("ForumList", "Forum", null),
                                IsChildTable = true,
                                Length = Model.PageSize,
                                LengthMenu = Model.AvailablePageSizes,
                                Filters = new List<FilterParameter>
                                {
                                    new FilterParameter(nameof(ForumModel.ForumGroupId), nameof(ForumGroupModel.Id), true)
                                },
                                ColumnCollection = new List<ColumnProperty>
                                {
                                    new ColumnProperty(nameof(ForumModel.Name))
                                    {
                                        Title = T("Admin.ContentManagement.Forums.Forum.Fields.Name").Text,
                                        Width = "300"
                                    },
                                    new ColumnProperty(nameof(ForumModel.DisplayOrder))
                                    {
                                        Title = T("Admin.ContentManagement.Forums.Forum.Fields.DisplayOrder").Text,
                                        Width = "150",
                                        ClassName =  NopColumnClassDefaults.CenterAll
                                    },
                                    new ColumnProperty(nameof(ForumModel.CreatedOn))
                                    {
                                        Title = T("Admin.ContentManagement.Forums.Forum.Fields.CreatedOn").Text,
                                        Width = "150",
                                        Render = new RenderDate()
                                    },
                                    new ColumnProperty(nameof(ForumModel.Id))
                                    {
                                        Title = T("Admin.Common.Edit").Text,
                                        Width = "50",
                                        ClassName = NopColumnClassDefaults.Button,
                                        Render = new RenderButtonEdit(new DataUrl("EditForum"))
                                    }
                                }
                            }
                        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumGroupSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
