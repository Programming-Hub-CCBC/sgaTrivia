#pragma checksum "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9faa7fde6c815577a9865c59d2d195a98cf5c3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Index), @"mvc.1.0.view", @"/Views/Questions/Index.cshtml")]
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
#line 1 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\_ViewImports.cshtml"
using bc_awareness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\_ViewImports.cshtml"
using bc_awareness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9faa7fde6c815577a9865c59d2d195a98cf5c3de", @"/Views/Questions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926af9b8749e9ba29546a92066c12a0c63ea894f", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bc_awareness.Models.QuestionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- <p>");
#nullable restore
#line 6 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
   Write(ViewData["Content"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>-->\n\n<div class=\"  text-center\">\n    <h2> ");
#nullable restore
#line 9 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
    Write(Model.Question.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <a");
            BeginWriteAttribute("href", " href=\"", 194, "\"", 234, 2);
            WriteAttributeValue("", 201, "/questions/index/", 201, 17, true);
#nullable restore
#line 10 "D:\osele\Documents\code\bc_awareness_website\bc_awareness\Views\Questions\Index.cshtml"
WriteAttributeValue("", 218, Model.nextIndex, 218, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> next</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bc_awareness.Models.QuestionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
