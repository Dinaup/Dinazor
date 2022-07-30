using static DinaNetCore.APID;

namespace Dinazor.Services
{
    public class DinaupConfiguracionC
    {




        public DinaNetCore.NET_Servicio_FirmaURLC  FirmadorURLArchivos;

        public DinaNetCore.APID.ServidorDinaup_ConectorC Conexion;
        public IConfiguration Configuration;
        public string Config_Host = "";
        public string Config_Port = "";
        public string Config_Apikey = "";
        public string Config_UbicacionID = "";
        public string Config_EmpresaID = "";


        public string Config_Archivos = "";
        public string Config_ArchivosPublicos = "";
        public string Config_CarpetaTemporalDeArchivosSubidos = "";



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
            this.Config_CarpetaTemporalDeArchivosSubidos = Configuration.GetValue<string>("APP:ArchivosSubida");
            DinaNetCore.ASP_NETD.PaginaD.Iniciar(Config_Apikey, Config_Host, Config_Port);
            this.Conexion = DinaNetCore.ASP_NETD.PaginaD.DinaupServer;
            var HashKey = DinaNetCore.ExtensionesM.CrearArrayDeBytesAleatorio(64);
            FirmadorURLArchivos = new DinaNetCore.NET_Servicio_FirmaURLC(this.Config_ArchivosPublicos, this.Config_Archivos, this.Config_CarpetaTemporalDeArchivosSubidos, HashKey);

        }


    }
}
