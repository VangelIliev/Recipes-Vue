#pragma checksum "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778ad400529e86ccf9965cbdf61bd022515bc5c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_All), @"mvc.1.0.view", @"/Views/Recipes/All.cshtml")]
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
#line 1 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\_ViewImports.cshtml"
using Web.Models.AdminModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\_ViewImports.cshtml"
using Web.Models.EmailModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\_ViewImports.cshtml"
using Web.Models.RecipeModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778ad400529e86ccf9965cbdf61bd022515bc5c0", @"/Views/Recipes/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eef39c2a2fef9d65eaf4676bfc50279fa1d8338a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Recipes_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RecipeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRecipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\n");
#nullable restore
#line 3 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
     if (this.TempData.ContainsKey("Message"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success alert-dismissable\">\n            ");
#nullable restore
#line 6 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
       Write(this.TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\n        </div>\n");
#nullable restore
#line 9 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n");
#nullable restore
#line 11 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
         foreach (var recipe in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-md-4 mt-3 \" style=\"width: 18rem;text-align:left\">\n                <div");
            BeginWriteAttribute("id", " id=\"", 486, "\"", 527, 2);
            WriteAttributeValue("", 491, "carouselExampleIndicators-", 491, 26, true);
#nullable restore
#line 14 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 517, recipe.Id, 517, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\">\n\n                    <ol class=\"carousel-indicators\">\n");
#nullable restore
#line 17 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                         for (int i = 0; i < recipe.ImagesFilePaths.Count; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-target=\"#carouselExampleIndicators-");
#nullable restore
#line 21 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                       Write(recipe.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 21 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\n");
#nullable restore
#line 22 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-target=\"#carouselExampleIndicators-");
#nullable restore
#line 25 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                       Write(recipe.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-slide-to=\"");
#nullable restore
#line 25 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\n");
#nullable restore
#line 26 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ol>\n                    <div class=\"carousel-inner\">\n");
#nullable restore
#line 31 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                         for (int i = 0; i < recipe.ImagesFilePaths.Count; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item active\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "778ad400529e86ccf9965cbdf61bd022515bc5c012403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1580, "~/Images/", 1580, 9, true);
#nullable restore
#line 36 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
AddHtmlAttributeValue("", 1589, recipe.ImagesFilePaths[i], 1589, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
AddHtmlAttributeValue("", 1622, i, 1622, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1624, "slide", 1625, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 38 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "778ad400529e86ccf9965cbdf61bd022515bc5c014950", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1892, "~/Images/", 1892, 9, true);
#nullable restore
#line 42 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
AddHtmlAttributeValue("", 1901, recipe.ImagesFilePaths[i], 1901, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
AddHtmlAttributeValue("", 1934, i, 1934, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1936, "slide", 1937, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 44 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <a class=\"carousel-control-prev\"");
            BeginWriteAttribute("href", " href=\"", 2120, "\"", 2164, 2);
            WriteAttributeValue("", 2127, "#carouselExampleIndicators-", 2127, 27, true);
#nullable restore
#line 48 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 2154, recipe.Id, 2154, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next""");
            BeginWriteAttribute("href", " href=\"", 2430, "\"", 2474, 2);
            WriteAttributeValue("", 2437, "#carouselExampleIndicators-", 2437, 27, true);
#nullable restore
#line 52 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 2464, recipe.Id, 2464, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>
                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 58 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                      Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2848, "\"", 2866, 1);
#nullable restore
#line 59 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 2856, recipe.Id, 2856, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                    <p>\n                        Likes  :  <span");
            BeginWriteAttribute("id", " id=\"", 2934, "\"", 2963, 2);
            WriteAttributeValue("", 2939, "numberOfLikes-", 2939, 14, true);
#nullable restore
#line 61 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 2953, recipe.Id, 2953, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                 Write(recipe.NumberOfLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n");
#nullable restore
#line 62 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                         if (this.User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"like likeBtn\"");
            BeginWriteAttribute("id", " id=\"", 3142, "\"", 3157, 1);
#nullable restore
#line 64 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 3147, recipe.Id, 3147, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <i class=\"fa fa-thumbs-o-up\"");
            BeginWriteAttribute("id", " id=\"", 3220, "\"", 3235, 1);
#nullable restore
#line 65 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 3225, recipe.Id, 3225, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\"></i>\n                            </button>\n                            <button class=\"dislike dislikeBtn\"");
            BeginWriteAttribute("id", " id=\"", 3361, "\"", 3376, 1);
#nullable restore
#line 67 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 3366, recipe.Id, 3366, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <i class=\"fa fa-thumbs-o-down\"");
            BeginWriteAttribute("id", " id=\"", 3441, "\"", 3456, 1);
#nullable restore
#line 68 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 3446, recipe.Id, 3446, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\"></i>\n                            </button>\n");
#nullable restore
#line 70 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\n                    <p>\n                        Comments - <span");
            BeginWriteAttribute("id", " id=\"", 3635, "\"", 3667, 2);
            WriteAttributeValue("", 3640, "numberOfComments-", 3640, 17, true);
#nullable restore
#line 73 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
WriteAttributeValue("", 3657, recipe.Id, 3657, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                     Write(recipe.NumberOfComments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n");
#nullable restore
#line 74 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                         if (this.User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "778ad400529e86ccf9965cbdf61bd022515bc5c024019", async() => {
                WriteLiteral("Add comment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                                                                WriteLiteral(recipe.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 77 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <p>Owner - ");
#nullable restore
#line 79 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                          Write(recipe.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 80 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                     if (this.User.Identity.IsAuthenticated)
                    {
                        if (this.User.IsInRole("Administrator"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "778ad400529e86ccf9965cbdf61bd022515bc5c027467", async() => {
                WriteLiteral("Delete Recipe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                                                                         WriteLiteral(recipe.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "778ad400529e86ccf9965cbdf61bd022515bc5c030315", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                                                       WriteLiteral(recipe.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 86 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "778ad400529e86ccf9965cbdf61bd022515bc5c033224", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                                                                                                       WriteLiteral(recipe.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 90 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 96 "C:\Users\veno1\source\repos\Recipies-Vue-Softuni\SoftUniProject\Views\Recipes\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        var btnLike = document.getElementsByClassName('likeBtn');
        for (var i = 0; i < btnLike.length; i++) {
            btnLike[i].addEventListener('click', function (e) {
                $.ajax({
                    url: `/Likes/LikeRecipe/${e.target.id}`,
                    type: ""POST"",
                    dataType: ""json"",
                    data: { ""id"": e.target.id },
                    success: function (data) {
                        if (data.success) {
                            var numberOfLikesSpan = document.getElementById(`numberOfLikes-${data.id}`);
                            var numberOfLikes = numberOfLikesSpan.innerText;
                            var numberOfLikesAsNumber = Number.parseInt(numberOfLikes);
                            numberOfLikesAsNumber++;
                            numberOfLikesSpan.innerText = numberOfLikesAsNumber;
                            alert(""Successfully liked recipe"");
                        } else {
                            w");
                WriteLiteral(@"indow.alert(data.message);
                        };
                    },
                    error: function (error) {
                        window.alert(""Unable to like recipe"");
                    }
                });
            })
        }        
        var btnDislike = document.getElementsByClassName('dislikeBtn');
        for (var i = 0; i < btnDislike.length; i++) {
            btnDislike[i].addEventListener('click', function (e) {
                $.ajax({
                    url: `/Likes/DisLikeRecipe/${e.target.id}`,
                    type: ""POST"",
                    dataType: ""json"",
                    data: { ""id"": e.target.id },
                    success: function (data) {
                        if (data.success) {
                            var numberOfLikesSpan = document.getElementById(`numberOfLikes-${e.target.id}`);
                            var numberOfLikes = numberOfLikesSpan.innerText;
                            var numberOfLikesAsNumber = Number.parseInt(numberOfLik");
                WriteLiteral(@"es);
                            numberOfLikesAsNumber--;
                            numberOfLikesSpan.innerText = numberOfLikesAsNumber;
                            alert(""Successfully disliked recipe"");
                        } else {
                            window.alert(data.message);
                        };
                    },
                    error: function (error) {
                        window.alert(""Unable to dislike recipe"");
                    }
                });
            })
        }
        
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RecipeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591