Partial Public Class DocumentosDinamicosD
  Partial Class ArchivosD
      Public Class VuejsC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new()
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("61cf8f36-f715-4d20-95a6-a6ea5825f0e3"))
              me.ID = new GUID("61cf8f36-f715-4d20-95a6-a6ea5825f0e3")
              me.Titulo  = "Vue.js"
          End sub
      End Class
  End Class
End Class
