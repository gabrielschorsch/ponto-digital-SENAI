#pragma checksum "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\Home\Avaliacoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac20f8f8e8c6a7b0f2914295cf4657e5a07edc18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Avaliacoes), @"mvc.1.0.view", @"/Views/Home/Avaliacoes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Avaliacoes.cshtml", typeof(AspNetCore.Views_Home_Avaliacoes))]
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
#line 1 "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\_ViewImports.cshtml"
using ponto_digital_final;

#line default
#line hidden
#line 2 "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\_ViewImports.cshtml"
using ponto_digital_final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac20f8f8e8c6a7b0f2914295cf4657e5a07edc18", @"/Views/Home/Avaliacoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c88f4ec5ce12793661cd7598b37bc2f4f50333e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Avaliacoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("RetornarAvaliacao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\Home\Avaliacoes.cshtml"
  
ViewData["TituloPag"] = "Avaliacoes";
var user = (Usuario) ViewData["usuario"];

#line default
#line hidden
            BeginContext(89, 45, true);
            WriteLiteral("\r\n<h2>Deixe sua avaliação do produto</h2>\r\n\r\n");
            EndContext();
            BeginContext(134, 1037, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b37f5f5727a40768785d8186d12a867", async() => {
                BeginContext(181, 522, true);
                WriteLiteral(@"
    <div class=""rating"">
        <input type=""radio"" id=""star5"" name=""rating"" value=""5"" /><label for=""star5""></label>
        <input type=""radio"" id=""star4"" name=""rating"" value=""4"" /><label for=""star4""></label>
        <input type=""radio"" id=""star3"" name=""rating"" value=""3"" /><label for=""star3""></label>
        <input type=""radio"" id=""star2"" name=""rating"" value=""2"" /><label for=""star2""></label>
        <input type=""radio"" id=""star1"" name=""rating"" value=""1"" /><label for=""star1""></label>
    </div>

    <br>
");
                EndContext();
#line 18 "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\Home\Avaliacoes.cshtml"
         if(user == null){

#line default
#line hidden
                BeginContext(731, 80, true);
                WriteLiteral("        <input type=\"text\" name=\"nome\" id=\"nome_avaliacao\" placeholder=\"Nome\">\r\n");
                EndContext();
#line 20 "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\Home\Avaliacoes.cshtml"
        } else{

#line default
#line hidden
                BeginContext(828, 58, true);
                WriteLiteral("        <input type=\"text\" name=\"nome\" id=\"nome_avaliacao\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 886, "\"", 904, 1);
#line 21 "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\Home\Avaliacoes.cshtml"
WriteAttributeValue("", 894, user.Nome, 894, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(905, 5, true);
                WriteLiteral(" > \r\n");
                EndContext();
#line 22 "C:\Users\49549303837\Documents\Senai\projetos\HTML_CSS\ponto-digital-SENAI\Views\Home\Avaliacoes.cshtml"
        }

#line default
#line hidden
                BeginContext(921, 243, true);
                WriteLiteral("        <br />\r\n        <textarea name=\"comentario\" id=\"textarea1\" cols=\"40\" rows=\"20\" placeholder=\"Deixe seu comentário\"></textarea>\r\n        <br />\r\n        <input id=\"enviar\" type=\"submit\" value=\"►\" onclick=\'alert(\"Depoimento enviado!\")\'>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1171, 1, true);
            WriteLiteral(" ");
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
