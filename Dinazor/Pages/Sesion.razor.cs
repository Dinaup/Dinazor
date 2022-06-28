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



        public bool Form_IniciarSesion_Procesando = false;
        public bool Form_CambiarContrasena_Procesando = false;
        public bool Form_RecuperarContrasena_Procesando = false;
        public bool Form_CrearCuenta_Procesando = false;
        public bool Form_CrearCuenta_Activar_Procesando = false;




        public async void ProcesarFormulario_IniciarSesion()
        {


            try
            {

                Form_IniciarSesion_Procesando = true;

                if (string.IsNullOrEmpty(Form_IniciarSesion.EmpresaID))
                {
                    Form_IniciarSesion.EmpresaID = (Dinaup_Servidor.Config_EmpresaID);
                }

                if (string.IsNullOrEmpty(Form_IniciarSesion.UbicacionID))
                {
                    Form_IniciarSesion.UbicacionID = (Dinaup_Servidor.Config_UbicacionID);
                }


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


        public async void ProcesarFormulario_CambiarContrasena()
        {



            if (Form_CambiarContrasena.Pass1 == "")
            {
                AvisosError = new List<string> { "Debe rellenar contraseña 1" };
                AvisosOk = null;
            }
            else if (Form_CambiarContrasena.Pass2 == "")
            {

                AvisosError = new List<string> { "Debe rellenar contraseña 2" };
                AvisosOk = null;
            }
            else if (Form_CambiarContrasena.Pass1 != Form_CambiarContrasena.Pass2)
            {

                AvisosError = new List<string> { "Las contraseñas indicadas deben ser iguales" };
                AvisosOk = null;
            }
            else if (Form_CambiarContrasena.Pass1.Length < 4)
            {
                AvisosError = new List<string> { "Las contraseñas es demasiado corta." };
                AvisosOk = null;
            }
            else
            {



                try
                {
                    Form_CambiarContrasena_Procesando = true;
                    var x = await Dinaup_Servidor.Conexion.Funcion_Sesion_CambiarContrasena(
                    Dinaup_Sesion.DinaupSesionIDCoockie.ToGuid(),
                    Form_CambiarContrasena.Pass1, Form_CambiarContrasena.Pass2,
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



        }


        public async void ProcesarFormulario_CrearCuenta_Activar()
        {





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




        public async void ProcesarFormulario_CrearCuenta()
        {



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


        public async void ProcesarFormulario_RecuperarContrasena()
        {
            Form_RecuperarContrasena.Return_EsperandoCodigo = !Form_RecuperarContrasena.Return_EsperandoCodigo;


        }









    }
}
