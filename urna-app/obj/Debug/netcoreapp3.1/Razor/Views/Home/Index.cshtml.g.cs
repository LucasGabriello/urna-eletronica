#pragma checksum "C:\Users\Mari\Desktop\Hubcount\urna-eletronica\urna-app\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ff6f7c57f768701ae644ba583fe42caa37f8c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Mari\Desktop\Hubcount\urna-eletronica\urna-app\Views\_ViewImports.cshtml"
using urna_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mari\Desktop\Hubcount\urna-eletronica\urna-app\Views\_ViewImports.cshtml"
using urna_app.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ff6f7c57f768701ae644ba583fe42caa37f8c8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c49d90fb782098297cbc831df13b4177005759", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mari\Desktop\Hubcount\urna-eletronica\urna-app\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">URNA ELETRÔNICA</h1>\r\n    \r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ff6f7c57f768701ae644ba583fe42caa37f8c83652", async() => {
                WriteLiteral(@"
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
  <style>
    
    .num{background-color:black; 
    color: white}
    .num:hover{color: #f1f1f1}
    .table {margin:0 auto;
    border : none}

    .n1{
    height: 30px;
    background-color:#fff;
    border:1px;
    }

</style>
 
");
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
            WriteLiteral("\r\n\r\n      <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n          \r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n          \t<div class=\"col-sm-7 well\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4ff6f7c57f768701ae644ba583fe42caa37f8c85168", async() => {
                WriteLiteral("\r\n              <div class=\"form-group\">\r\n                <input class=\"form-control input-lg \" id=\"n1\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 796, "\"", 804, 0);
                EndWriteAttribute();
                BeginWriteAttribute("maxlength", " maxlength =", 805, "", 817, 0);
                EndWriteAttribute();
                WriteLiteral(" 2>\r\n                <h2>Nome - SIGLA</h2>\r\n                <h3>Vice</h3>\r\n              </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            
            <div class=""col-sm-5"">
                <table class=""table"">
                  <tr>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='1' }"">1</button></th>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='2' }"">2</button></th>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='3' }"">3</button></th>
                  </tr>
   	              <tr>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='4' }"">4</button></th>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1')");
            WriteLiteral(@".value.length<2){ document.getElementById('n1').value +='5' }"">5</button></th>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='6' }"">6</button></th>
                  </tr>
                  <tr>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='7' }"">7</button></th>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='8' }"">8</button></th>
                    <th><button type=""button"" class=""btn num"" onclick=""if (document.getElementById('n1').value.length<2){ document.getElementById('n1').value +='9' }"">9</button></th>
                  </tr>
                  <tr>
                    <th></th>
                    <th><button type=""button"" class=""btn num"" onclick=""if (docu");
            WriteLiteral(@"ment.getElementById('n1').value.length<2){ document.getElementById('n1').value +='0' }"">0</button></th>
                    <th></th>
                  </tr>
                  <tr>
                    <th><button type=""button"" class=""btn btn-default"">Branco</button></th>
                    <th><button type=""button"" class=""btn btn-danger"" onclick=""document.getElementById('n1').value='' "">Corrige</button></th>
                    <th><button type=""button"" class=""btn btn-success"" id=""teste"">Confirma</button></th>
                  </tr>
                </table> 
            </div>
        </div>
        <div class=""col-sm-3"">
        </div>
      </div>");
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
