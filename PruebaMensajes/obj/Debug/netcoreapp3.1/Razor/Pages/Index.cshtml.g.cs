#pragma checksum "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "587222a23f485ceddaab1331de20c31de662b1b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PruebaMensajes.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PruebaMensajes.Pages
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
#line 1 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\_ViewImports.cshtml"
using PruebaMensajes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"587222a23f485ceddaab1331de20c31de662b1b7", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b285146cac07ca639ab1c9ad45d72af4bb2e78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container row"">
    <div class=""col-6"">
        <h2 class=""text-info"">Reservas Pistas</h2>
    </div>
    <br />
</div>
<br />
<div class=""4"">
    <input type=""date"" id=""fecha"" />
</div>
<br />
<div class=""row"">
    <div class=""alert alert-info text-center invisible"" style=""width: 33%"" id=""aceptarReserva"">
        <p>¿Quiere reservar una pista de padel a esta hora?</p>
        <a class=""btn btn-success"" id=""btnAceptar"">Aceptar</a>
        <a class=""btn btn-danger"" id=""btnCancelar"" onclick=""cancelar(document.getElementById('aceptarReserva'))"">Cancelar</a>
    </div>
    <div class=""alert alert-info text-center invisible"" style=""width: 33%"" id=""salirSinReservar"">
        <p>¿Quiere reservar una pista de padel a esta hora?</p>
        <a class=""btn btn-success"">Aceptar</a>
        <a class=""btn btn-danger"">Cancelar</a>
    </div>
    <div class=""alert alert-info text-center invisible"" style=""width: 33%"" id=""cancelarReserva"">
        <p>¿Quiere reservar una pista de padel a es");
            WriteLiteral("ta hora?</p>\r\n        <a class=\"btn btn-success\">Aceptar</a>\r\n        <a class=\"btn btn-danger\">Cancelar</a>\r\n    </div>\r\n</div>\r\n<div style=\"padding: 4px;\r\n            width: 100%;\r\n            height: 550px;\r\n            overflow: auto;\">\r\n\r\n");
            WriteLiteral("    <table class=\"table table-striped border\">\r\n        <tr class=\"table-secondary\">\r\n            <th>Hora</th>\r\n            <th>Estado</th>\r\n            <th>Reservas</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml"
         for (var i = 9; i <= 21; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(":00</td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 1716, "\"", 1725, 2);
#nullable restore
#line 52 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml"
WriteAttributeValue("", 1721, i, 1721, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1723, "-h", 1723, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Libre</td>\r\n                <td>\r\n                    <a class=\"btn btn-success btn-sm\" style=\"color:white\"");
            BeginWriteAttribute("id", " id=\"", 1834, "\"", 1845, 2);
#nullable restore
#line 54 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml"
WriteAttributeValue("", 1839, i, 1839, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1841, "-btn", 1841, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1846, "\"", 1877, 4);
            WriteAttributeValue("", 1856, "reserva(this,", 1856, 13, true);
            WriteAttributeValue(" ", 1869, "\'", 1870, 2, true);
#nullable restore
#line 54 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml"
WriteAttributeValue("", 1871, i, 1871, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1873, "-h\')", 1873, 4, true);
            EndWriteAttribute();
            WriteLiteral(">Reservar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\erick\Source\Repos\thedragonflu\prueba\PruebaMensajes\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

</div>


<script>
    // Formato de la fecha actual
    var fecha = document.querySelector('input[type=""date""]');

    function formatoFecha() {
        let date = new Date();
        let year = date.getFullYear().toString();
        let day = date.getDate().toString();
        let month = date.getMonth() + 1;
        if (month < 9) {
            return year + ""-0"" + month.toString() + ""-"" + day;
        } else {
            return year + ""-"" + month + ""-"" + day;
        }

    }
    fecha.value = formatoFecha();

    // Hacer visible la alerta de aceptar reserva
    function confirmar() {
        let element = document.getElementById(""aceptarReserva"");
        element.className = ""alert alert-info text-center visible"";
    }

    // Hacer invisible la alerta de aceptar
    function cancelar(elmnt) {
        elmnt.className = ""alert alert-info text-center invisible"";
    }

    // Cambio de estilo de Libre a Reservado
    function reserva(elmnt, id) {
        ");
            WriteLiteral(@"confirmar();
        $(document).ready(function () {
            $(""#btnAceptar"").click(function (i) {
                let element = document.getElementById(id);
                element.style.background = ""purple"";
                element.style.color = ""white"";
                element.innerHTML = ""Reservado"";
                element.style.borderRadius = ""0px 50px 50px 0px"";

                element.previousElementSibling.style.background = ""purple"";
                element.previousElementSibling.style.color = ""white"";
                element.previousElementSibling.style.borderRadius = ""50px 0px 0px 50px"";

                elmnt.className = ""btn btn-danger btn-sm"";
                elmnt.innerHTML = ""Cancelar"";
                cancelar(document.getElementById('aceptarReserva'));
            });
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
