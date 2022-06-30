using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using static DinaNETCore.ExtensionesM;
using static DinaNETCore.ModelosD;
using static DinaNETCore.APID;
using Radzen;

namespace Dinazor.Pages
{
    public partial class Sesion
    {


        public List<string>? AvisosOk;
        public List<string>? AvisosError;


        public IniciarSesion_ModeloC Form_IniciarSesion = new();
        public CambiarContrasena_ModelC Form_CambiarContrasena = new();
        public RecuperarContrasena_ModeloC Form_RecuperarContrasena = new();
        public CrearCuenta_ModelC Form_CrearCuenta = new();
        public CrearCuenta_Activar_ModelC? Form_CrearCuenta_Activar = null;

        public static DinaNETCore.RateLimitsD.RateLimitsC FormLimites_IniciarSesion = new(10, 100, 60 * 5);
        public static DinaNETCore.RateLimitsD.RateLimitsC FormLimites_CambiarContrasena = new(10, 100, 60 * 5);
        public static DinaNETCore.RateLimitsD.RateLimitsC FormLimites_RecuperarContrasena = new(10, 100, 60 * 5);
        public static DinaNETCore.RateLimitsD.RateLimitsC FormLimites_CrearCuenta = new(10, 100, 60 * 5);
        public static DinaNETCore.RateLimitsD.RateLimitsC FormLimites_CrearCuenta_Activar = new(10, 100, 60 * 5);



        public bool Form_IniciarSesion_Procesando = false;
        public bool Form_CambiarContrasena_Procesando = false;
        public bool Form_RecuperarContrasena_Procesando = false;
        public bool Form_CrearCuenta_Procesando = false;
        public bool Form_CrearCuenta_Activar_Procesando = false;




        //@@    Iniciar Sesión    
        public async void ProcesarFormulario_IniciarSesion()
        {

            if (string.IsNullOrEmpty(Form_IniciarSesion.EmpresaID))
            {
                Form_IniciarSesion.EmpresaID = (Dinaup_Servidor.Config_EmpresaID);
            }

            if (string.IsNullOrEmpty(Form_IniciarSesion.UbicacionID))
            {
                Form_IniciarSesion.UbicacionID = (Dinaup_Servidor.Config_UbicacionID);
            }

            //!++ Formato 
            if (Form_IniciarSesion == null)
                return;

            var MotivoNo = Form_IniciarSesion.Motivo_RellenadoIncorrecto();
            if (!string.IsNullOrEmpty(MotivoNo))
            {
                AvisosError = new List<string> { MotivoNo };
                AvisosOk = null;
                return;
            }



            //!++ Límites  
            var LoPermitenLosLimites = FormLimites_IniciarSesion.Autorizar(Dinaup_Sesion.Request_UserIP);
            if (!string.IsNullOrEmpty(LoPermitenLosLimites))
            {
                NotificationService.Notify(NotificationSeverity.Error, "Ups",
                    "Estamos recibiendo demasiado tráfico." +
                    "<br>La opción de <b>iniciar sesión</b> estará desactivada durante unos minutos. " +
                    "<br>Inténtelo de nuevo más tarde. ", 10000);
                return;
            }



            try
            {

                Form_IniciarSesion_Procesando = true;


                await Dinaup_Sesion.IniciarSesion(Form_IniciarSesion, this.Coockie);

                AvisosError = Form_IniciarSesion.Respuesta_AvisoError;
                AvisosOk = Form_IniciarSesion.Respuesta_AvisosOk;


                if (Form_IniciarSesion.Respuesta_DetallesDeSesion != null && Form_IniciarSesion.Respuesta_DetallesDeSesion.CambiarPass)
                {
                    NavigationManager.NavigateTo("/Sesion");
                }
                else if (Form_IniciarSesion.Respuesta_DetallesDeSesion != null)
                {
                    NavigationManager.NavigateTo("/");
                }


            }
            catch
            {
            }
            finally
            {
                Form_IniciarSesion_Procesando = false;
                this.StateHasChanged();
            }

        }

        //@@    Cambiar Contraseña    

        public async void ProcesarFormulario_CambiarContrasena()
        {


                //!++ Formato 
                if (Form_CambiarContrasena == null)
                    return;


                var MotivoNo = Form_CambiarContrasena.Motivo_RellenadoIncorrecto();
                if (!string.IsNullOrEmpty(MotivoNo))
                {
                    AvisosError = new List<string> { MotivoNo };
                    AvisosOk = null;
                    return;
                }


                //!++ Límites  
                var LoPermitenLosLimites = FormLimites_CambiarContrasena.Autorizar(Dinaup_Sesion.Request_UserIP);

                if (!string.IsNullOrEmpty(LoPermitenLosLimites))
                {

                    NotificationService.Notify(NotificationSeverity.Error, "Ups",
                        "Estamos recibiendo demasiado tráfico." +
                        "<br>Esta opción estará desactivada durante unos minutos. " +
                        "<br>Inténtelo de nuevo más tarde. ", 10000);

                    return;
                }




                try
                {
                    Form_CambiarContrasena_Procesando = true;
                    var x = await Dinaup_Servidor.Conexion.Funcion_Sesion_CambiarContrasena(
                    Dinaup_Sesion.DinaupSesionIDCoockie.ToGuid(),
                    Form_CambiarContrasena.Usuario_Contrasena, Form_CambiarContrasena.Usuario_RepetirContrasena,
                    Dinaup_Sesion.Request_UserIP, Dinaup_Sesion.Request_UserAgent);

                    AvisosError = x.avisoserror;
                    AvisosOk = x.avisosok;


                    if (x.DetallesSesion != null && x.DetallesSesion.CambiarPass)
                    {
                    }
                    else if (x.DetallesSesion != null)
                    {

                        Dinaup_Sesion.Detectarsesion();
                        NavigationManager.NavigateTo("/");
                    }
                }
                catch
                {
                }
                finally
                {
                    Form_CambiarContrasena_Procesando = false;
                    this.StateHasChanged();
                }


            }




            //@@    CREAR CUENTA    
            public async void ProcesarFormulario_CrearCuenta()
            {


                //!++ Formato 
                if (Form_CrearCuenta == null)
                    return;


                var MotivoNo = Form_CrearCuenta.Motivo_RellenadoIncorrecto();
                if (!string.IsNullOrEmpty(MotivoNo))
                {
                    AvisosError = new List<string> { MotivoNo };
                    AvisosOk = null;
                    return;
                }


                //!++ Límites  

                var LoPermitenLosLimites = FormLimites_CrearCuenta.Autorizar(Dinaup_Sesion.Request_UserIP);
                if (!string.IsNullOrEmpty(LoPermitenLosLimites))
                {

                    NotificationService.Notify(NotificationSeverity.Error, "Ups",
                        "Estamos recibiendo demasiado tráfico." +
                        "<br>Esta opción estará desactivada durante unos minutos. " +
                        "<br>Inténtelo de nuevo más tarde. ", 10000);

                    return;
                }




                //!++ ¡Se procesa!  

                try
                {
                    Form_CrearCuenta_Procesando = true;
                    Form_CrearCuenta.Contexto_EmpresaID = (Dinaup_Servidor.Config_EmpresaID).ToGuid();
                    Form_CrearCuenta.Contexto_UbicacionID = (Dinaup_Servidor.Config_UbicacionID).ToGuid();

                    var respuesta = await Dinaup_Servidor.Conexion.Funcion_Sesion_CrearCuenta(Form_CrearCuenta, Dinaup_Sesion.Request_UserAgent, Dinaup_Sesion.Request_UserIP);

                    this.AvisosError = respuesta.avisoserror;
                    this.AvisosOk = respuesta.avisosok;


                    if (Form_CrearCuenta.Retornar_RegistroID_CuentaTemporal != Guid.Empty)
                    {
                        if (Form_CrearCuenta.Retornar_CodigoDeValidacion_Requerido)
                        {

                            /* Al asignar esta referencia el formulario se hará visible */
                            Form_CrearCuenta_Activar = new CrearCuenta_Activar_ModelC();
                            Form_CrearCuenta_Activar.CuentaTemporalID = Form_CrearCuenta.Retornar_RegistroID_CuentaTemporal;
                        }
                    }


                }
                catch
                {
                }
                finally
                {
                    Form_CrearCuenta_Procesando = false;
                    this.StateHasChanged();
                }


            }




            //@@    CREAR CUENTA > Activar
            public async void ProcesarFormulario_CrearCuenta_Activar()
            {

                //!++ Formato 
                if (Form_CrearCuenta_Activar == null)
                    return;


                var MotivoNo = Form_CrearCuenta_Activar.Motivo_RellenadoIncorrecto();
                if (!string.IsNullOrEmpty(MotivoNo))
                {
                    AvisosError = new List<string> { MotivoNo };
                    AvisosOk = null;
                    return;
                }


                //!++ Límites  
                var LoPermitenLosLimites = FormLimites_CrearCuenta_Activar.Autorizar(Dinaup_Sesion.Request_UserIP);
                if (!string.IsNullOrEmpty(LoPermitenLosLimites))
                {

                    NotificationService.Notify(NotificationSeverity.Error, "Ups",
                        "Estamos recibiendo demasiado tráfico." +
                        "<br>Esta opción estará desactivada durante unos minutos. " +
                        "<br>Inténtelo de nuevo más tarde. ", 10000);

                    return;
                }



                //!++ ¡Se procesa!  
                try
                {
                    Form_CrearCuenta_Activar_Procesando = true;
                    var respuesta = await Dinaup_Servidor.Conexion.Funcion_Sesion_CrearCuenta_Activar(Form_CrearCuenta_Activar, Form_CrearCuenta.Usuario_Identificador, Dinaup_Sesion.Request_UserIP);
                    this.AvisosError = respuesta.avisoserror;
                    this.AvisosOk = respuesta.avisosok;

                    if (Form_CrearCuenta_Activar.Retornar_Identificador != "")
                    {
                        Form_IniciarSesion.UbicacionID = Form_CrearCuenta.Contexto_UbicacionID.STR();
                        Form_IniciarSesion.EmpresaID = Form_CrearCuenta.Contexto_EmpresaID.STR();


                        if (Form_CrearCuenta != null)
                        {
                            Form_IniciarSesion.Identificador = Form_CrearCuenta.Usuario_Identificador;
                            Form_IniciarSesion.Pass = Form_CrearCuenta.Usuario_Contrasena;
                        }
                        Form_CrearCuenta_Activar = null;
                        NavigationManager.NavigateTo("/Sesion");

                    }



                }
                catch
                {
                }
                finally
                {
                    Form_CrearCuenta_Activar_Procesando = false;
                    this.StateHasChanged();
                }

            }




            //@@    Recuperar Contraseña 
            public async void ProcesarFormulario_RecuperarContrasena()
            {
                //!++ Formato 
                if (Form_RecuperarContrasena == null)
                    return;

                var MotivoNo = Form_RecuperarContrasena.Motivo_RellenadoIncorrecto();
                if (!string.IsNullOrEmpty(MotivoNo))
                {
                    AvisosError = new List<string> { MotivoNo };
                    AvisosOk = null;
                    return;
                }





                //!++ Límites  

                var LoPermitenLosLimites = FormLimites_RecuperarContrasena.Autorizar(Dinaup_Sesion.Request_UserIP);
                if (!string.IsNullOrEmpty(LoPermitenLosLimites))
                {

                    NotificationService.Notify(NotificationSeverity.Error, "Ups",
                        "Estamos recibiendo demasiado tráfico." +
                        "<br>Esta opción estará desactivada durante unos minutos. " +
                        "<br>Inténtelo de nuevo más tarde. ", 10000);

                    return;
                }






                //!++ ¡Se procesa!  


                try
                {
                    Form_CrearCuenta_Procesando = true;
                    Form_RecuperarContrasena.Contexto_EmpresaID = (Dinaup_Servidor.Config_EmpresaID).ToGuid();
                    Form_RecuperarContrasena.Contexto_UbicacionID = (Dinaup_Servidor.Config_UbicacionID).ToGuid();

                    var respuesta = await Dinaup_Servidor.Conexion.Funcion_Sesion_RecuperarContrasena(Form_RecuperarContrasena, Dinaup_Sesion.Request_UserAgent, Dinaup_Sesion.Request_UserIP);

                    this.AvisosError = respuesta.avisoserror;
                    this.AvisosOk = respuesta.avisosok;


                    if (Form_CrearCuenta.Retornar_RegistroID_CuentaTemporal != Guid.Empty)
                    {
                        if (Form_CrearCuenta.Retornar_CodigoDeValidacion_Requerido)
                        {

                            /* Al asignar esta referencia el formulario se hará visible */
                            Form_CrearCuenta_Activar = new CrearCuenta_Activar_ModelC();
                            Form_CrearCuenta_Activar.CuentaTemporalID = Form_CrearCuenta.Retornar_RegistroID_CuentaTemporal;
                        }
                    }


                }
                catch
                {
                }
                finally
                {
                    Form_CrearCuenta_Procesando = false;
                    this.StateHasChanged();
                }



            }









        }
    }
