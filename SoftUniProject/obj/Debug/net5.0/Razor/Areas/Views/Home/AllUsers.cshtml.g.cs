#pragma checksum "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de291849cf1c3c8c1603dfc6c5ffc98f5dd4e2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Views_Home_AllUsers), @"mvc.1.0.view", @"/Areas/Views/Home/AllUsers.cshtml")]
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
#nullable restore
#line 1 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\_ViewImports.cshtml"
using Web.Models.EmailModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\_ViewImports.cshtml"
using Web.Models.RecipeModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
using Web.Models.AdminModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de291849cf1c3c8c1603dfc6c5ffc98f5dd4e2f8", @"/Areas/Views/Home/AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60b2cc3b46e0d6b5799f0cc66a619c4751dccb9", @"/Areas/Views/Home/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Views_Home_AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<UserDetailsViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""header mt-md-5"">
    <div class=""header-body"">
        <div class=""row align-items-center"">
            <div class=""col"">
                <h6 class=""header-pretitle"">
                    Users
                </h6>
                <h1 class=""header-title"">
                    List of users
                </h1>
            </div>
        </div>
    </div>
</div>
<div class=""card"">
    <div class=""card-body"">
        <table class=""table table-sm"">
            <thead>
                <tr>
                    <th>Email</th>
                    <th>Role</th>
                    <th>Update</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"table-light\">\n                        <td>");
#nullable restore
#line 32 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 33 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                         if (user.Role != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 35 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                           Write(user.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 36 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <div class=\"text-danger\">Missing role</div>\n                            </td>\n");
#nullable restore
#line 42 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de291849cf1c3c8c1603dfc6c5ffc98f5dd4e2f88914", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                                     WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de291849cf1c3c8c1603dfc6c5ffc98f5dd4e2f811609", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                                     WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 54 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                             if (user.Role != "Administrator")
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                           Write(Html.ActionLink("Delete", "DeleteUser", new { id = user.Id }, new
                                {
                                    @class = "btn btn-danger",
                                    onclick = "return confirm('Are you sure you want to delete this user ? );"
                                }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                                  
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                    </tr>\n");
#nullable restore
#line 64 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de291849cf1c3c8c1603dfc6c5ffc98f5dd4e2f815713", async() => {
                WriteLiteral("Add new User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
#nullable restore
#line 69 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
         if (TempData["success-message"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">\n                ");
#nullable restore
#line 72 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
           Write(TempData["success-message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 74 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Areas\Views\Home\AllUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<UserDetailsViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591