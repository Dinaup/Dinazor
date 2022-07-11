using static DinaNETCore.APID;

namespace Dinazor.Services
{
    public class DinaupConfiguracionC
    {

 



        public DinaNETCore.APID.ServidorDinaup_ConectorC Conexion;
        public IConfiguration Configuration;
        public string Config_Host = "";
        public string Config_Port = "";
        public string Config_Apikey = "";
        public string Config_UbicacionID = "";
        public string Config_EmpresaID = "";




        public string Config_Archivos = "";
        public string Config_ArchivosPublicos = "";



        public DinaupConfiguracionC()
        {
            var configurationBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, false);
            this.Configuration = configurationBuilder.Build();
            this.Config_Host = Configuration.GetValue<string>("Dinaup:Host");
            this.Config_Port = Configuration.GetValue<string>("Dinaup:Port");
            this.Config_Apikey = Configuration.GetValue<string>("Dinaup:Apikey");
            this.Config_UbicacionID = Configuration.GetValue<string>("Dinaup:UbicacionID");
            this.Config_EmpresaID = Configuration.GetValue<string>("Dinaup:EmpresaID");

            this.Config_Archivos = Configuration.GetValue<string>("APP:Archivos");
            this.Config_ArchivosPublicos = Configuration.GetValue<string>("APP:ArchivosPublicos");



            DinaNETCore.ASP_NETD.PaginaD.Iniciar(Config_Apikey, Config_Host, Config_Port);
            this.Conexion = DinaNETCore.ASP_NETD.PaginaD.DinaupServer;
           
        }






        //public async static Task<DinaNETCore.ASP_NETD.SesionServicio> DetectarSesionDeUsuario(Microsoft.AspNetCore.Http.HttpContext Contexto)
        //{


        //    CargarConfiguracion();

        //    var IP = Contexto.Connection.RemoteIpAddress.ToString();
        //    var Request_UserAgent = Contexto.Request.Headers["User-Agent"];

        //    var R = new DinaNETCore.ASP_NETD.SesionServicio(IP, Request_UserAgent);
        //    await R.Iniciar();
        //    return R;

        //}






    }
}
