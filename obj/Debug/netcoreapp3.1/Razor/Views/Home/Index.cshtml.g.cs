#pragma checksum "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "559198085f306d6c4acbbdb5693ca8abbf4b1a2a"
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
#line 1 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\_ViewImports.cshtml"
using ENTREVISTA_EMPREGARE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\_ViewImports.cshtml"
using ENTREVISTA_EMPREGARE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559198085f306d6c4acbbdb5693ca8abbf4b1a2a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb23223b6b226729111cfb26504c99bdb385b3e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vaga>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/destaque.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Destaque"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""h-100"">
    <section class=""w-100 d-flex justify-content-between"">
        <div style=""color: #5B5CSE"" class=""d-flex flex-column align-items-start justify-content-center px-lg-5"">
            <p>SOLUÇÕES PARA</p>
            <h1 class=""font-weight-bold"">CANDIDATOS</h1>
            <p>
                Amplie suas possibilidades! Cadastre seu currículo e aproveite os <br/> recusos
                exclusivos que disponibilizamos para você gratuitamente
            </p>
            <button type=""button"" class=""btn-primary mt-4"">CADASTRE-SE</button>
         </div>
          <div> 
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "559198085f306d6c4acbbdb5693ca8abbf4b1a2a4774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>        \r\n    </section>\r\n    <section class=\"d-flex align-items-center flex-column bg-primary text-light p-4\">\r\n        <h2 class=\"mb-2\">Confira nossas vagas disponíveis</h2>\r\n\r\n        <div class=\"d-flex flex-wrap\">\r\n");
#nullable restore
#line 25 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\Home\Index.cshtml"
             foreach (var vaga in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"w-25 mt-4\">\r\n                            <h4 class=\"m-0\">");
#nullable restore
#line 28 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\Home\Index.cshtml"
                                       Write(vaga.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            <spam class=""d-flex"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""map-marker-alt"" class=""svg-inline--fa fa-map-marker-alt fa-w-12"" role=""img"" viewBox=""0 0 384 512""><path fill=""white"" d=""M172.268 501.67C26.97 291.031 0 269.413 0 192 0 85.961 85.961 0 192 0s192 85.961 192 192c0 77.413-26.97 99.031-172.268 309.67-9.535 13.774-29.93 13.773-39.464 0zM192 272c44.183 0 80-35.817 80-80s-35.817-80-80-80-80 35.817-80 80 35.817 80 80 80z"" /></svg>
                                <p class=""m-0"">");
#nullable restore
#line 31 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\Home\Index.cshtml"
                                          Write(vaga.Localizacao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </spam>
                            <spam>
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""20"" height=""20"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""money-bill-wave"" class=""svg-inline--fa fa-money-bill-wave fa-w-20"" role=""img"" viewBox=""0 0 640 512""><path fill=""white"" d=""M621.16 54.46C582.37 38.19 543.55 32 504.75 32c-123.17-.01-246.33 62.34-369.5 62.34-30.89 0-61.76-3.92-92.65-13.72-3.47-1.1-6.95-1.62-10.35-1.62C15.04 79 0 92.32 0 110.81v317.26c0 12.63 7.23 24.6 18.84 29.46C57.63 473.81 96.45 480 135.25 480c123.17 0 246.34-62.35 369.51-62.35 30.89 0 61.76 3.92 92.65 13.72 3.47 1.1 6.95 1.62 10.35 1.62 17.21 0 32.25-13.32 32.25-31.81V83.93c-.01-12.64-7.24-24.6-18.85-29.47zM48 132.22c20.12 5.04 41.12 7.57 62.72 8.93C104.84 170.54 79 192.69 48 192.69v-60.47zm0 285v-47.78c34.37 0 62.18 27.27 63.71 61.4-22.53-1.81-43.59-6.31-63.71-13.62zM320 352c-44.19 0-80-42.99-80-96 0-53.02 35.82-96 80-96s80 42.98 80 96c0 53.03-35.83 96-8");
            WriteLiteral(@"0 96zm272 27.78c-17.52-4.39-35.71-6.85-54.32-8.44 5.87-26.08 27.5-45.88 54.32-49.28v57.72zm0-236.11c-30.89-3.91-54.86-29.7-55.81-61.55 19.54 2.17 38.09 6.23 55.81 12.66v48.89z"" /></svg>
                            <spam class=""d-flex"">
                            <p class=""m-0"">");
#nullable restore
#line 36 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\Home\Index.cshtml"
                                      Write(vaga.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Ricardo\Desktop\FTI - Aulas\TESTE ENTREVISTA EMPREGARE\ENTREVISTA EMPREGARE\Views\Home\Index.cshtml"
            }            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </section>
    <section class=""d-flex align-items-center flex-column"">
        <h2 style=""color: #5B5CSE"" class=""mt-5 mb-4"">Faça parte você também</h2>
        <button type=""button"" class=""btn-primary btn-lg mt-4"">CADASTRE-SE</button>
    </section>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vaga>> Html { get; private set; }
    }
}
#pragma warning restore 1591
