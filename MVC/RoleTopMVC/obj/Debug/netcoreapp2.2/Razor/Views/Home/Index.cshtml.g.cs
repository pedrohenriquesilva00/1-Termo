#pragma checksum "C:\Users\pedro\Documents\1 Termo DEV\RoleTopMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8bb1292e49f3265b1959c508b10a726f95c9f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\pedro\Documents\1 Termo DEV\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\pedro\Documents\1 Termo DEV\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8bb1292e49f3265b1959c508b10a726f95c9f3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(38, 5684, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc8bb1292e49f3265b1959c508b10a726f95c9f33198", async() => {
                BeginContext(44, 5671, true);
                WriteLiteral(@"
<main>
        <!-------------------------------------------------------
            EFEITO PARALLAX   
            -------------------------------------------------------->
            <div class=""conteudotuto"">
                <div id=""banner-area"">
                </div>
                <div class=""parallax""></div>
                <!------------------------------------------------------
                    PROGRAMAÇÃO DE SHOWS
                    -------------------------------------------------------->
        <section id=""shows"">
            <h1>Eventos da semana</h1>
            <div>
                <img src=""img/jorge e mateus.jpg"" title=""Jorge & Mateus"">
            </div>
        </section>
        
        <!---------------------------------------------------------
        FORMATAÇÃO DO CORPO DE TEXTO DO SITE
        ---------------------------------------------------------->
        <section id=""texto"">
            <h1>Rolê Top - Um pouco sobre nós</h1>
            <p>Fund");
                WriteLiteral(@"ada em [ano de fundação, por exemplo, 1998], pelos senhores
                Alexandre Fukaya e César Sportore, a Rolê Top tem como principal
                missão oferecer [coloque aqui o que sua empresa vende ou oferece].
            </p>
            <br>
            <div class=""container"">
                <img src=""img/administrador icon.jfif"" />
                <img src=""img/administrador icon 2.jpg"" />
            </div>
            <p>Serviço de qualidade é com a Rolê Top!</p>
            <br>
            <p>Aqui na Rolê Top, encontrará um local de extrema qualidade. Quer ver
                dias e horários disponíveis? Dê uma olhada no calendário e agende já! </p>
                <br>
            <p>Durante o processo de criação do site, que envolve a definição
                do layout e a cirção do conteúdo, é comum que uma parte dele seja
                negligenciada: são as páginas de sobre [ou, em inglês, about pages],
                que têm o objetivo de dar uma ideia geral sob");
                WriteLiteral(@"re o seu negócio, sua
                missão e valores. E é por isso que mesmo que acreditamos que as páginas
                de about estão entre as mais importantes do site.
            </p>
        </section>
        
        <!-------------------------------------------------------------------------------
            FORMATAÇÃO DO SERVIÇOS ADICIONAIS
            -------------------------------------------------------------------------------->
            <section id=""servicos"">
                <h1>Serviços adicionais</h1>
                <p>Além do espaço, nós disponibilizamos também alguns serviços adicionais,
                    para melhorar ainda mais sua experiência com a Rolê Top! Esses incluem
                    sistema de iluminação e de som profissionais. Se quiser incluí-los no
                    pacote, na seção de agendamento terá a opção de incluí-los com um valor
                    adicional ao do seu evento. </p>
                    <br>
                    <p>Não perca ");
                WriteLiteral(@"tempo, agende já</p>
                    <br/>
                    <div id=""som"">
                        <img src=""img/sistema de som.jpg"" />
                    </div>
                    
                    <div class=""container2"">
                        <div id=""iluminacao"">
                            <img src=""img/sistema de iluminação profissional.jpg"" />
                        </div>
                        <div id=""ssom"">
                            <img src=""img/o-coordenador-sadio-trabalha-com-sistema-de-som-profissional.jpg"" />
                        </div>
                    </div>
                </section>
                
                <!----------------------------------------------------------------------------------
                    FORMATAÇÃO DA SEÇÃO REDES SOCIAIS
                    ------------------------------------------------------------------------------------>
                    <section id=""social"">
                        <h1>Nossas redes sociais</");
                WriteLiteral(@"h1>
                        <figure class=""foto-legenda2"">
                            <div id=""face"">
                                <img src=""img/facebook.jpg"" />
                                <figcaption><a href=""https://www.facebook.com"" target=""blank"">Facebook</a></figcaption>
                                <img src=""img/instagram.jpg"" />
                                <figcaption><a href=""https://www.instagram.com"" target=""blank"">Instagram</a></figcaption>
                            </div>
                        </figure>
                    </section>
                    
                    <!-----------------------------------------------------------------------------------
                        FORMATAÇÃO DO MAPA DE LOCALIZAÇÃO
------------------------------------------------------------------------------------>
<section id=""localizacao"">
    <h1>Onde estamos</h1>
    <h3>Veja no Google Maps como chegar no nosso espaço.</h3>
    <br>
    <h3>Contamos com uma localização pr");
                WriteLiteral(@"ivilegiada!</h3>
    <br/>
</section>

<div id=""local"">
    <iframe
    src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.890423799602!2d-46.64607037245504!3d-23.53644322236868!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda%20Bar%C3%A3o%20de%20Limeira%2C%20539%20-%20Campos%20El%C3%ADseos%2C%20S%C3%A3o%20Paulo%20-%20SP%2C%2001202-001!5e0!3m2!1spt-BR!2sbr!4v1567712605007!5m2!1spt-BR!2sbr""
    frameborder=""0"" style=""border:0;"" allowfullscreen="""">
</iframe>
</div>
</main>
");
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
            BeginContext(5722, 9, true);
            WriteLiteral("\r\n</html>");
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
