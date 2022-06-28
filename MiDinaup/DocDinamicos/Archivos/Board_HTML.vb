Partial Public Class DocumentosDinamicosD
  Partial Class ArchivosD
      Public Class BoardHTMLC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new(JSON As String)
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("4d2280af-c0e7-42f4-b357-3c26a23ad141"))
              me.ID = new GUID("4d2280af-c0e7-42f4-b357-3c26a23ad141")
              me.Titulo  = "Board_HTML"
              Agregar_Respuesta("JSON",JSON)
          End sub
      End Class
  End Class
End Class
