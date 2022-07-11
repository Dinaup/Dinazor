using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using static DinaNETCore.APID;


namespace Dinazor.Services
{


    public class ControladorDeArchivosC
    {



        public DinaupConfiguracionC DinaupConfiguracion;
        public DatosCacheC DatosCache;


        public ControladorDeArchivosC(DinaupConfiguracionC _DinaupConfiguracion, DatosCacheC _DatosCache)
        {
            this.DinaupConfiguracion = _DinaupConfiguracion;
            this.DatosCache = _DatosCache;
        }









        public Byte[] HashKey = DinaNETCore.ExtensionesM.CrearArrayDeBytesAleatorio(64);
        public string FirmarURL_Archivo(MiDinaup.InformesD.FuncionalidadD.APIArchivosC.APIArchivos_FilaC  Archivo)
        {

            var Conexion = DinaNETCore.ASP_NETD.PaginaD.DinaupServer;
            var Ruta_Archivo_Publico = BuscarArchivo_Publico(Archivo.ID.ToString());
            var Ruta_Archivo_Privado = BuscarArchivo_Privado(Archivo.ID.ToString());
            string Firma_NombreDeArchivo = Archivo.ID.ToString();
            string Mime = DinaNETCore.ExtensionesM.GetMimeType(Archivo.Filename);



            if (System.IO.File.Exists(Ruta_Archivo_Publico))
            {
                return string.Concat("/dinaup/archivos/", Firma_NombreDeArchivo, "?mime=", Mime, "&file=", Archivo.Filename);
            }


            if (System.IO.File.Exists(Ruta_Archivo_Privado))
            {
                string Firma_FechaDeExpiracion = DateTime.UtcNow.AddMinutes(20).Ticks.ToString();
                var TokenFirma = Firma_NombreDeArchivo + "[/]" + Firma_FechaDeExpiracion + "[/]" + Archivo.Filename + "[/]" + Mime;
                string Firma_HMAC = DinaNETCore.ExtensionesM.CalcularHMAC(HashKey, TokenFirma);
                return string.Concat("/dinaup/archivos/", Firma_NombreDeArchivo, "?expire=", Firma_FechaDeExpiracion, "&mime=", Mime, "&file=", Archivo.Filename, "&signature=", Firma_HMAC);
            }

            return "";


        }

        public string FirmarURL_Archivo(DinaupAPI_ArchivoC Archivo)
        {



            var Conexion = DinaNETCore.ASP_NETD.PaginaD.DinaupServer;
            var Ruta_Archivo_Publico =  BuscarArchivo_Publico(Archivo);
            var Ruta_Archivo_Privado =  BuscarArchivo_Privado(Archivo);
            string Firma_NombreDeArchivo = Archivo.ArchivoID.ToString();


            if (System.IO.File.Exists(Ruta_Archivo_Publico))
            {
                return string.Concat("/dinaup/archivos/", Firma_NombreDeArchivo, "?mime=", Archivo.Mime, "&file=", Archivo.Nombre);
            }


            if (System.IO.File.Exists(Ruta_Archivo_Privado))
            {
                string Firma_FechaDeExpiracion = DateTime.UtcNow.AddMinutes(20).Ticks.ToString();
                var TokenFirma = Firma_NombreDeArchivo + "[/]" + Firma_FechaDeExpiracion + "[/]" + Archivo.Nombre + "[/]" + Archivo.Mime;
                string Firma_HMAC = DinaNETCore.ExtensionesM.CalcularHMAC(HashKey, TokenFirma);
                return string.Concat("/dinaup/archivos/", Firma_NombreDeArchivo, "?expire=", Firma_FechaDeExpiracion, "&mime=", Archivo.Mime, "&file=", Archivo.Nombre, "&signature=", Firma_HMAC);
            }

            return "";



        }

        //public string FirmarURL_Archivo(string IDDeArchivo)
        //{

        //    var Conexion = DinaNETCore.ASP_NETD.PaginaD.DinaupServer;
        //    var Ruta_Archivo_Publico =  BuscarArchivo_Publico(IDDeArchivo);
        //    var Ruta_Archivo_Privado =  BuscarArchivo_Privado(IDDeArchivo);
        //    string Firma_NombreDeArchivo = IDDeArchivo;


        //    if (System.IO.File.Exists(Ruta_Archivo_Publico))
        //    {
        //        return string.Concat("/dinaup/archivos/", Firma_NombreDeArchivo, "?mime=", Archivo.Mime, "&file=", Archivo.Nombre);
        //    }


        //    if (System.IO.File.Exists(Ruta_Archivo_Privado))
        //    {
        //        string Firma_FechaDeExpiracion = DateTime.UtcNow.AddMinutes(20).Ticks.ToString();
        //        var TokenFirma = Firma_NombreDeArchivo + "[/]" + Firma_FechaDeExpiracion;
        //        string Firma_HMAC = DinaNETCore.ExtensionesM.CalcularHMAC(HashKey, TokenFirma);
        //        return string.Concat("/dinaup/archivos/", Firma_NombreDeArchivo, "?expire=", Firma_FechaDeExpiracion, "&mime=", Archivo.Mime, "&file=", Archivo.Nombre, "&signature=", Firma_HMAC);
        //    }

        //    return "";

        //}


        public async Task ProcesarArchivo(HttpContext context, RequestDelegate next)
        {



            if (context.Request.Path.StartsWithSegments(new PathString("/dinaup/archivos")))
            {

                try
                {

                    var Conexion = DinaNETCore.ASP_NETD.PaginaD.DinaupServer;


                    var NombreDeArchivo = System.IO.Path.GetFileName(context.Request.Path);



                    var Archivo_Publico = BuscarArchivo_Publico(NombreDeArchivo);
                    var Ruta_Archivo_Privado = BuscarArchivo_Privado(NombreDeArchivo);


                    if (System.IO.File.Exists(Archivo_Publico))
                    {
                        context.Response.Headers.Add("Cache-Control", "max-age=31536000");
                        await context.Response.SendFileAsync(Archivo_Publico);
                        return;
                    }



                    if (NombreDeArchivo.Length > 10 && context.Request.Query.ContainsKey("expire") && context.Request.Query.ContainsKey("signature"))
                    {

                        if (System.IO.File.Exists(Ruta_Archivo_Privado))
                        {


                            var request_Expire = context.Request.Query["expire"][0];
                            var request_Signature = context.Request.Query["signature"][0];
                            var request_file = context.Request.Query["file"][0];
                            var request_mime = context.Request.Query["mime"][0];
                            var Firma_HMAC = DinaNETCore.ExtensionesM.CalcularHMAC(HashKey, NombreDeArchivo + "[/]" + request_Expire + "[/]" + request_file + "[/]" + request_mime);

                            if (request_Signature == Firma_HMAC)
                            {
                                var Archivo_Privado = Ruta_Archivo_Privado;
                                if (System.IO.File.Exists(Archivo_Privado))
                                {
                                    context.Response.Headers.Add("Content-Type", request_mime);
                                    context.Response.Headers.Add("Content-Disposition", "attachment; filename=\"" + request_file + "\"");
                                    context.Response.Headers.Add("Cache-Control", "max-age=31536000");
                                    await context.Response.SendFileAsync(Archivo_Privado);
                                    return;

                                }

                            }
                        }

                    }



                }
                catch
                {
                }



                context.Response.StatusCode = 403;
                return;


            }

            try
            {
                await next(context);
            }
            catch { }


        }







        public string BuscarArchivo_Privado(DinaupAPI_ArchivoC Archivo)
        {

            var ID = Archivo.ArchivoID.ToString();
            if (DinaupConfiguracion.Config_Archivos != "")
                return System.IO.Path.Combine(DinaupConfiguracion.Config_Archivos, ID[0].ToString(), ID[1].ToString(), ID[2].ToString(), ID[3].ToString(), ID + ".dat");
            else
                return "";
        }


        public string BuscarArchivo_Publico(DinaupAPI_ArchivoC Archivo)
        {
            var ID = Archivo.ArchivoID.ToString();
            if (DinaupConfiguracion.Config_ArchivosPublicos != "")
                return System.IO.Path.Combine(DinaupConfiguracion.Config_ArchivosPublicos, ID[0].ToString(), ID[1].ToString() + ID[2].ToString(), ID + ".dat");
            else
                return "";
        }



        public string BuscarArchivo_Privado(string ID)
        {
            if (DinaupConfiguracion.Config_Archivos != "")
                return System.IO.Path.Combine(DinaupConfiguracion.Config_Archivos, ID[0].ToString(), ID[1].ToString(), ID[2].ToString(), ID[3].ToString(), ID + ".dat");
            else
                return "";
        }




        public string BuscarArchivo_Publico(string ID)
        {
            if (DinaupConfiguracion.Config_ArchivosPublicos != "")
                return System.IO.Path.Combine(DinaupConfiguracion.Config_ArchivosPublicos, ID[0].ToString(), ID[1].ToString() + ID[2].ToString(), ID + ".dat");
            else
                return "";
        }



    }


}
