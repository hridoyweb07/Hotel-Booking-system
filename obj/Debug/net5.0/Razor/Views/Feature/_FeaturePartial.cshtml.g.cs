#pragma checksum "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a302514e49c027a0d30b9c04d6df3b66e9d77bfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feature__FeaturePartial), @"mvc.1.0.view", @"/Views/Feature/_FeaturePartial.cshtml")]
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
#line 1 "F:\GitHub\Hotel Management Application\Views\_ViewImports.cshtml"
using HotelApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GitHub\Hotel Management Application\Views\_ViewImports.cshtml"
using HotelApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a302514e49c027a0d30b9c04d6df3b66e9d77bfc", @"/Views/Feature/_FeaturePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a233b9cca9704942898401d0bf47e554f69be65", @"/Views/_ViewImports.cshtml")]
    public class Views_Feature__FeaturePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelApp.Database.Feature>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 8 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
           Write(Html.DisplayNameFor(model => model.FeatureID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
           Write(Html.DisplayNameFor(model => model.FeatureName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
           Write(Html.DisplayNameFor(model => model.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 437, "\"", 542, 5);
            WriteAttributeValue("", 447, "showInPopup(\'", 447, 13, true);
#nullable restore
#line 17 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
WriteAttributeValue("", 460, Url.Action("AddOrEdit", "Feature", null, Context.Request.Scheme), 460, 65, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 525, "\',", 525, 2, true);
            WriteAttributeValue(" ", 527, "\'New", 528, 5, true);
            WriteAttributeValue(" ", 532, "Feature\')", 533, 10, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                   class=\"btn btn-success text-white\"> Create New\r\n                </a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.FeatureID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
               Write(Html.DisplayFor(modelItem => item.FeatureName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1034, "\"", 1050, 1);
#nullable restore
#line 34 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
WriteAttributeValue("", 1040, item.Icon, 1040, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Photo\" class=\"img-thumbnail\" width=\"80\" height=\"100\" />\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1181, "\"", 1312, 5);
            WriteAttributeValue("", 1191, "showInPopup(\'", 1191, 13, true);
#nullable restore
#line 37 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
WriteAttributeValue("", 1204, Url.Action("AddOrEdit", "Feature", new { id = item.FeatureID }, Context.Request.Scheme), 1204, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1292, "\',", 1292, 2, true);
            WriteAttributeValue(" ", 1294, "\'Update", 1295, 8, true);
            WriteAttributeValue(" ", 1302, "Feature\')", 1303, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">\r\n                        Edit\r\n                    </a>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a302514e49c027a0d30b9c04d6df3b66e9d77bfc8531", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"DELETE\" class=\"btn btn-danger\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
                                                WriteLiteral(item.FeatureID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "F:\GitHub\Hotel Management Application\Views\Feature\_FeaturePartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelApp.Database.Feature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
