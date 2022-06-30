using Microsoft.AspNetCore.Components;
using static DinaNETCore.APID;
using Microsoft.JSInterop;
using Radzen;

namespace Dinazor
{


    public class DinaupPage : OwningComponentBase 
    {


        [Inject]
        protected DinaNETCore.ASP_NETD.SesionServicio Dinaup_Sesion { get; set; }


        [Inject]
        protected Dinazor.Services.DinaupService Dinaup_Servidor { get; set; }


        //[Inject]
        //protected IJSRuntime Js { get; set; }

        //[Inject]
        //protected DinaNETCore.ICookie CoockieX { get; set; }

        [Inject]
        protected HttpContextAccessor HttpContext { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }



       


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

         
    }
}