#pragma checksum "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1418f97d4c01debee4792928c96702ac21cdca39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Manager), @"mvc.1.0.view", @"/Views/Home/Manager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Manager.cshtml", typeof(AspNetCore.Views_Home_Manager))]
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
#line 1 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\_ViewImports.cshtml"
using beds.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\_ViewImports.cshtml"
using beds.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1418f97d4c01debee4792928c96702ac21cdca39", @"/Views/Home/Manager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ecbb638ff6e70c3d47de681f5ccefe3f292c579", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Manager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<beds.Models.bedPatientModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/dragAndDropFnc.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Manager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(283, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(323, 728, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3baa821ba5cb407fb263be1d0942948c", async() => {
                BeginContext(329, 27, true);
                WriteLiteral("\r\n    <title></title>\r\n    ");
                EndContext();
                BeginContext(356, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f03a57f3ba42cbba98736bd514cd84", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(402, 642, true);
                WriteLiteral(@"
    <style type=""text/css"">
        #bed {
            float: right;
            width: 175px;
            height: 125px;
            border: 5px dashed lightyellow;
            background: grey;
            text-align: center;
            margin: 20px 10px;
            color: orange;
            font-size: 15px;
        }

        #container {
            width: 300px;
            height: 400px;
            border: 5px dashed gray;
            background: lightyellow;
            text-align: center;
            margin: 20px 10px;
            color: orange;
            font-size: 15px;
        }
    </style>
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
            BeginContext(1051, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1053, 2710, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95b02b5f0474740a008d5360fe7695c", async() => {
                BeginContext(1059, 136, true);
                WriteLiteral("\r\n    <h4>Patients</h4>\r\n    <div class=\"card-deck\">\r\n        <div id=\"container\" ondragover=\"dragOver(event);\" ondrop=\"drop(event);\">\r\n");
                EndContext();
#line 40 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
             foreach (var patient in Model._patient)
            {
                if (patient.Location == "")
                {

#line default
#line hidden
                BeginContext(1328, 24, true);
                WriteLiteral("                    <div");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1352, "\"", 1368, 1);
#line 44 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
WriteAttributeValue("", 1357, patient.ID, 1357, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1369, 163, true);
                WriteLiteral(" class=\"card\" draggable=\"true\" ondragstart=\"dragStart(event);\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
                EndContext();
                BeginContext(1533, 11, false);
#line 46 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                                            Write(patient.Sex);

#line default
#line hidden
                EndContext();
                BeginContext(1544, 2, true);
                WriteLiteral(" ,");
                EndContext();
                BeginContext(1547, 11, false);
#line 46 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                                                          Write(patient.Age);

#line default
#line hidden
                EndContext();
                BeginContext(1558, 66, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 49 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(1658, 129, true);
                WriteLiteral("        </div>\r\n\r\n        <div>\r\n            <h4>Beds</h4>\r\n            <h7>Drag and drop patients to assign them to a bed</h7>\r\n");
                EndContext();
#line 56 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
              int count = 0;

#line default
#line hidden
                BeginContext(1818, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 57 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
             foreach (var bed in Model._beds)
            {
                if (count % 2 == 0)
                {

#line default
#line hidden
                BeginContext(1936, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1958, 25, true);
                WriteLiteral("<div class=\"card-deck\">\r\n");
                EndContext();
#line 62 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                    }

#line default
#line hidden
                BeginContext(2006, 81, true);
                WriteLiteral("                    <div id=\"bed\">\r\n                        <p class=\"card-text\">");
                EndContext();
                BeginContext(2088, 8, false);
#line 64 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                                        Write(bed.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2096, 52, true);
                WriteLiteral("</p>\r\n                        <div class=\"card-body\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2148, "\"", 2160, 1);
#line 65 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
WriteAttributeValue("", 2153, bed.ID, 2153, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2161, 55, true);
                WriteLiteral(" ondragover=\"dragOver(event);\" ondrop=\"drop(event);\">\r\n");
                EndContext();
#line 66 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                             foreach (var patient in Model._patient)
                            {
                                if (patient.Location == bed.ID)
                                {

#line default
#line hidden
                BeginContext(2417, 40, true);
                WriteLiteral("                                    <div");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2457, "\"", 2473, 1);
#line 70 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
WriteAttributeValue("", 2462, patient.ID, 2462, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2474, 195, true);
                WriteLiteral(" class=\"card\" draggable=\"true\" ondragstart=\"dragStart(event);\">\r\n                                        <div class=\"card-body\">\r\n                                            <p class=\"card-text\">");
                EndContext();
                BeginContext(2670, 11, false);
#line 72 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                                                            Write(patient.Sex);

#line default
#line hidden
                EndContext();
                BeginContext(2681, 2, true);
                WriteLiteral(" ,");
                EndContext();
                BeginContext(2684, 11, false);
#line 72 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                                                                          Write(patient.Age);

#line default
#line hidden
                EndContext();
                BeginContext(2695, 98, true);
                WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n");
                EndContext();
#line 75 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                                }
                            }

#line default
#line hidden
                BeginContext(2859, 60, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 79 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"

                    if (count % 2 == 1)
                    {

#line default
#line hidden
                BeginContext(2985, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(3007, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 83 "C:\Users\Dfrench5173\source\repos\beds\beds\Views\Home\Manager.cshtml"
                }
                count++;
            }

#line default
#line hidden
                BeginContext(3075, 40, true);
                WriteLiteral("\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(3115, 639, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99bcfcb0fe744ff99e27f1fd22e9cc9", async() => {
                    BeginContext(3178, 569, true);
                    WriteLiteral(@"
        <h4>Please click save after each movement of a patient</h4>
        <div class=""form-group row"">
            <div class=""col-sm-10"">
                <input type=""text"" id=""beingDragged"" name=""beingDragged"" required readonly />
            </div>
        </div>

        <div class=""form-group row"">
            <div class=""col-sm-10"">
                <input type=""text"" id=""droppedIn"" name=""droppedIn"" required readonly />
            </div>
        </div>

        <div>
            <button type=""submit"">Save Bed</button>
        </div>
    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3754, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<beds.Models.bedPatientModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
