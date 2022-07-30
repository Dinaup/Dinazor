using Microsoft.AspNetCore.Components;
using static DinaNetCore.APID;
using Microsoft.JSInterop;
using Radzen;
using Dinazor.Services;

namespace Dinazor
{


    public class DinaupPage : OwningComponentBase
    {


        [Inject]
        public DinaNetCore.ASP_NETD.SesionServicio Dinaup_Sesion { get; set; }

        [Inject]
        public Dinazor.Services.DinaupConfiguracionC Dinaup_Servidor { get; set; }

        [Inject]
        public HttpContextAccessor HttpContext { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public NotificationService NotificationService { get; set; }

        [Inject]
        public DialogService DialogService { get; set; }

        [Inject]
        public DatosCacheC DatosCacheados { get; set; }

  

        //TODO Pendiente sacar la zona horaria del usuario
        public DateTime Convertir_A_FechaLocal(DateTime Fecha)
        {
            return Fecha.ToLocalTime();
        }


        //TODO Pendiente sacar la zona horaria del usuario
        public DateTime? Convertir_A_FechaLocal(DateTime? Fecha)
        {
            if (Fecha == null)
                return null;

            return Fecha.Value.ToLocalTime();
        }



        //TODO Pendiente sacar la zona horaria del usuario
        public DateTime Convertir_A_UTC(DateTime Fecha)
        {
            return Fecha.ToUniversalTime();
        }


        //TODO Pendiente sacar la zona horaria del usuario
        public DateTime? Convertir_A_UTC(DateTime? Fecha)
        {
            if (Fecha == null)
                return null;

            return Fecha.Value.ToUniversalTime();
        }


        protected override void OnInitialized()
        {


        
            if (!Dinaup_Sesion.Iniciado)
            {

                var IP = HttpContext.HttpContext.Connection.RemoteIpAddress.ToString();
                var Request_UserAgent = HttpContext.HttpContext.Request.Headers["User-Agent"];
                string? SesionID;
                if (HttpContext.HttpContext.Request.Cookies.TryGetValue("sesionid", out SesionID) == false)
                {
                    SesionID = "";
                }

                Dinaup_Sesion.Iniciar(IP, Request_UserAgent, SesionID);
            }

            base.OnInitialized();
        }







        public async Task BusyDialog(string message)
        {
            await DialogService.OpenAsync("", ds =>
            {
                RenderFragment content = b =>
                {
                    b.OpenElement(0, "div");
                    b.AddAttribute(1, "class", "row");

                    b.OpenElement(2, "div");
                    b.AddAttribute(3, "class", "col-md-12");

                    b.AddContent(4, message);

                    b.CloseElement();
                    b.CloseElement();
                };
                return content;
            }, new DialogOptions() { ShowTitle = false, Style = "min-height:auto;min-width:auto;width:auto", CloseDialogOnEsc = false });
        }









    }
}