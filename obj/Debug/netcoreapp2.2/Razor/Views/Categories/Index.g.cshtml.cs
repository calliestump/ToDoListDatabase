#pragma checksum "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010022eee96e568173cb5d0115d719560dab6326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
#line 1 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"010022eee96e568173cb5d0115d719560dab6326", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(51, 49, true);
            WriteLiteral("<div class = \"container\">\n  <h1>Categories</h1>\n\n");
            EndContext();
#line 8 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
   if (@Model.Count == 0)
  {

#line default
#line hidden
            BeginContext(130, 48, true);
            WriteLiteral("    <h3>No categories have been added yet!</h3>\n");
            EndContext();
#line 11 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
  } 

#line default
#line hidden
            BeginContext(183, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 13 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
   foreach (Category category in Model)
  {

#line default
#line hidden
            BeginContext(228, 10, true);
            WriteLiteral("    <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 238, "\'", 269, 2);
            WriteAttributeValue("", 245, "/categories/", 245, 12, true);
#line 15 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
WriteAttributeValue("", 257, category.Id, 257, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(270, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(272, 13, false);
#line 15 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
                                      Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(285, 10, true);
            WriteLiteral("</a></h3>\n");
            EndContext();
#line 16 "/Users/callie/Desktop/Week10/CSharpToDoList.Solution/ToDoList/Views/Categories/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(299, 43, true);
            WriteLiteral("\n  <p><a href=\'/\'>Back home</a></p>\n</div>\n");
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
