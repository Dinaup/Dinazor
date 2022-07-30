using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Primitives;
using static DinaNETCore.APID;
using static DinaNETCore.ExtensionesM;
using Dinazor.Services;


namespace Dinazor
{

    public class ControladorDeArchivos : Microsoft.AspNetCore.Mvc.Controller
    {


        public ServicioFirmasURLC FirmaDeArchivos { get; set; }
        public DinaupConfiguracionC DinaupConfiguracion { get; set; }
        public DatosCacheC DatosCache { get; set; }



        public ControladorDeArchivos(ServicioFirmasURLC _FirmaDeArchivos, DinaupConfiguracionC _DinaupConfiguracion, DatosCacheC _DatosCache)
        {
            this.FirmaDeArchivos = _FirmaDeArchivos;
            this.DatosCache = _DatosCache;
            this.DinaupConfiguracion = _DinaupConfiguracion;
        }






        [HttpPost("dinaup/subirarchivos/subir")]
        public IActionResult Single(IFormFile[] files, string firma)
        {
            try
            {

                StringValues Param_Ext;
                StringValues Param_Max;
                StringValues Param_Firma;
                StringValues Param_Num;
                Request.Query.TryGetValue("ext", out Param_Ext);
                Request.Query.TryGetValue("max", out Param_Max);
                Request.Query.TryGetValue("signature", out Param_Firma);
                Request.Query.TryGetValue("signature", out Param_Firma);
                Request.Query.TryGetValue("num", out Param_Num);

                if (Param_Ext.Count != 1)
                    return StatusCode(500, "Parámetro ext inválido");
                if (Param_Max.Count != 1)
                    return StatusCode(500, "Parámetro max inválido");
                if (Param_Firma.Count != 1)
                    return StatusCode(500, "Parámetro signature inválido");
                if (Param_Num.Count != 1)
                    return StatusCode(500, "Parámetro números inválido" );
                if (files.Length == 0)
                    return StatusCode(500, "No se ha detectado ningún archivo.");


                string Valor_Ext = Param_Ext[0];
                decimal Valor_Max = Param_Max[0].DEC(0);
                string Valor_Firma = Param_Firma[0];
                int Valor_NumeroMaximoDeArchivos = Param_Num[0].INT(0);

                if (FirmaDeArchivos.FirmarURL_SubirArchivo_EsValida(Valor_Max, Valor_Ext, Valor_NumeroMaximoDeArchivos, Valor_Firma) == false)
                    return StatusCode(500, "No está autorizado.");


                if (Valor_NumeroMaximoDeArchivos < files.Length)
                    return StatusCode(500, "No puede enviar tantos archivos.");







                var ListaDeArchivos = new List<FirmaURLArchivoSubidoC>();


                foreach (var file in files)
                {

                    var Actual_ArchivoID = Guid.NewGuid().ToString();
                    var Actual_RutaEnDisco = DinaupConfiguracion.BuscarArchivo_Subido(Actual_ArchivoID);


                    if (Directory.Exists(Path.GetDirectoryName(Actual_RutaEnDisco)) == false)
                        Directory.CreateDirectory(Path.GetDirectoryName(Actual_RutaEnDisco));


                    using (Stream fileStream = new FileStream(Actual_RutaEnDisco, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    var URLArchivo = FirmaDeArchivos.FirmarURL_LeerArchivoSubido_Firmar(Actual_ArchivoID);
                    var AchivoDetalles = new FirmaURLArchivoSubidoC(Actual_ArchivoID.ToGuid(), URLArchivo, file.Name);
                    ListaDeArchivos.Add(AchivoDetalles);


                }
                



                var RetornarArchivos = new JSONBuildC();
                RetornarArchivos.Add("{");
                RetornarArchivos.Add("archivos", ListaDeArchivos);
                RetornarArchivos.Add("}");

                return StatusCode(200, RetornarArchivos.ToJson());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        [HttpGet("dinaup/archivos/{id}")]
        public IActionResult Get(string ID)
        {



            try
            {


                var request_tama = (Request.Query["tama"].Count == 1) ? Request.Query["tama"][0] : "";
                var Conexion = DinaNETCore.ASP_NETD.PaginaD.DinaupServer;

                var NombreDeArchivo = System.IO.Path.GetFileName(Request.Path);
                var Archivo_Publico = DinaupConfiguracion.BuscarArchivo_Publico(NombreDeArchivo);
                var Archivo_Publico_Tamano = DinaupConfiguracion.BuscarArchivo_Publico(Archivo_Publico, request_tama);

                var Ruta_Archivo_Privado = DinaupConfiguracion.BuscarArchivo_Privado(NombreDeArchivo);
                var Ruta_Archivo_Privado_Tamano = DinaupConfiguracion.BuscarArchivo_Privado(Ruta_Archivo_Privado, request_tama);



                if (Archivo_Publico_Tamano != Archivo_Publico && System.IO.File.Exists(Archivo_Publico_Tamano))
                {
                    Response.Headers.Add("Cache-Control", "max-age=31536000");
                    return new PhysicalFileResult(Archivo_Publico_Tamano, DinaNETCore.ExtensionesM.GetMimeType(Archivo_Publico_Tamano)) { FileDownloadName = System.IO.Path.GetFileName(Archivo_Publico_Tamano) };

                }
                else if (System.IO.File.Exists(Archivo_Publico))
                {

                    Response.Headers.Add("Cache-Control", "max-age=31536000");
                    return new PhysicalFileResult(Archivo_Publico, DinaNETCore.ExtensionesM.GetMimeType(Archivo_Publico)) { FileDownloadName = System.IO.Path.GetFileName(Archivo_Publico) };

                }



                if (NombreDeArchivo.Length > 10 && Request.Query.ContainsKey("expire") && Request.Query.ContainsKey("signature"))
                {

                    if (System.IO.File.Exists(Ruta_Archivo_Privado))
                    {


                        var request_Expire = Request.Query["expire"][0];
                        var request_Signature = Request.Query["signature"][0];
                        var request_file = Request.Query["file"][0];
                        var request_mime = Request.Query["mime"][0];
                        var Firma_HMAC = DinaNETCore.ExtensionesM.CalcularHMAC(FirmaDeArchivos.HashKey, NombreDeArchivo + "[/]" + request_Expire + "[/]" + request_file + "[/]" + request_mime);

                        if (request_Signature == Firma_HMAC)
                        {

                            if (Ruta_Archivo_Privado_Tamano != Ruta_Archivo_Privado && System.IO.File.Exists(Ruta_Archivo_Privado_Tamano))
                            {
                                Response.Headers.Add("Content-Type", request_mime);
                                Response.Headers.Add("Content-Disposition", "attachment; filename=\"" + request_file + "\"");
                                Response.Headers.Add("Cache-Control", "max-age=31536000");
                                return new PhysicalFileResult(Ruta_Archivo_Privado_Tamano, request_mime) { FileDownloadName = request_file };

                            }

                            if (System.IO.File.Exists(Ruta_Archivo_Privado))
                            {
                                Response.Headers.Add("Content-Type", request_mime);
                                Response.Headers.Add("Content-Disposition", "attachment; filename=\"" + request_file + "\"");
                                Response.Headers.Add("Cache-Control", "max-age=31536000");

                                return new PhysicalFileResult(Ruta_Archivo_Privado, request_mime) { FileDownloadName = request_file };

                            }





                        }
                    }

                }



            }
            catch { }


            return StatusCode(403, "Archivo no encontrado.");


        }








        [HttpGet("dinaup/archivossubidos/{id}")]
        public IActionResult RecibirArchivoSubido(string ID)
        {






            try
            {



                if (ID.Length > 10 && Request.Query.ContainsKey("expire") && Request.Query.ContainsKey("signature"))
                {


                    var Conexion = DinaNETCore.ASP_NETD.PaginaD.DinaupServer;
                    var ArchivoSubido = DinaupConfiguracion.BuscarArchivo_Subido(ID);
                    if (System.IO.File.Exists(ArchivoSubido))
                    {
                        var request_Expire = Request.Query["expire"][0];
                        var request_Signature = Request.Query["signature"][0];

                        if (FirmaDeArchivos.FirmarURL_LeerArchivoSubido_EsValida(ID, request_Expire, request_Signature))
                        {
                            return new PhysicalFileResult(ArchivoSubido, "application/octet-stream");
                        }

                    }

                }



            }
            catch { }


            return StatusCode(403, "Archivo no encontrado.");


        }










    }

}
