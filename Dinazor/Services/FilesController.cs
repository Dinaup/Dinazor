using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;

namespace Dinazor.Services
{


    public class DinaupServidorDeArchivos
    {



        public static Byte[] HashKey = DinaNETCore.ExtensionesM.CrearArrayDeBytesAleatorio(64);





        public static string FirmarURL_Archivo(string IDDeArchivo)
        {
            string Firma_NombreDeArchivo = IDDeArchivo;
            string Firma_FechaDeExpiracion = DateTime.UtcNow.AddMinutes(20).Ticks.ToString();
            var TokenFirma = Firma_NombreDeArchivo + "[/]" + Firma_FechaDeExpiracion;
            string Firma_HMAC = DinaNETCore.ExtensionesM.CalcularHMAC(HashKey, TokenFirma);
            return string.Concat("/dinaup/archivos/", Firma_NombreDeArchivo, "?expire=", Firma_FechaDeExpiracion, "&signature=", Firma_HMAC);
        }


        public static async Task ProcesarArchivo(HttpContext context, RequestDelegate next)
        {

            if (context.Request.Path.StartsWithSegments(new PathString("/dinaup/archivos")))
            {


                try
                {

					var NombreDeArchivo = System.IO.Path.GetFileName(context.Request.Path);
					//var Archivo = "c:\\Dinaup\\archivos_publicos\\" + NombreDeArchivo;
					//if (System.IO.File.Exists(Archivo))
					//{
					//    context.Response.Headers.Add("Cache-Control", "max-age=31536000");
					//    await context.Response.SendFileAsync(Archivo);
					//    return;
					//}


					if (NombreDeArchivo.Length > 10 && context.Request.Query.ContainsKey("expire") && context.Request.Query.ContainsKey("signature"))
                    {


                        var request_Expire = context.Request.Query["expire"][0];
                        var request_Signature = context.Request.Query["signature"][0];
                        var Firma_HMAC = DinaNETCore.ExtensionesM.CalcularHMAC(HashKey, NombreDeArchivo + "[/]" + request_Expire);

                        if (request_Signature == Firma_HMAC)
                        {


                            var Archivo_Privado = "c:\\Dinaup\\SQL64\\data\\dup_archivo\\" + NombreDeArchivo[0] + "\\" + NombreDeArchivo[1] + "\\" + NombreDeArchivo[3] + "\\" + NombreDeArchivo[4] + "\\" + NombreDeArchivo + ".dat";
                            if (System.IO.File.Exists(Archivo_Privado))
                            {
                                context.Response.Headers.Add("Cache-Control", "max-age=31536000");
                                await context.Response.SendFileAsync(Archivo_Privado);
                                return;

                            }
                            else
                            {


                                foreach (string dataproyecto in System.IO.Directory.EnumerateDirectories("c:\\Dinaup\\SQL64\\"))
                                {


                                    if (dataproyecto.Contains("\\dup_"))
                                    {

                                        var Archivo_Proyecto = dataproyecto  + "\\dup_archivo\\" +
                                                               NombreDeArchivo[0] + "\\" + NombreDeArchivo[1] + "\\" + NombreDeArchivo[2] + "\\" + NombreDeArchivo[3] + "\\" +
                                                               NombreDeArchivo + ".dat";


                                        if (System.IO.File.Exists(Archivo_Proyecto))
                                        {
                                            context.Response.Headers.Add("Cache-Control", "max-age=31536000");
                                            await context.Response.SendFileAsync(Archivo_Proyecto);
                                            return;

                                        }



                                    }

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


            await next(context);

        }

         

    }


}
