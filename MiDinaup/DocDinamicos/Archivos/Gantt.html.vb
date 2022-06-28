Partial Public Class DocumentosDinamicosD
  Partial Class ArchivosD
      Public Class GantthtmlC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new(JSON As String, id As String, Escala As Integer)
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("bcc0e6e8-2b80-47bd-97c7-544d8b24e27d"))
              me.ID = new GUID("bcc0e6e8-2b80-47bd-97c7-544d8b24e27d")
              me.Titulo  = "Gantt.html"
              Agregar_Respuesta("JSON",JSON)
              Agregar_Respuesta("id",id)
              Agregar_Respuesta("Escala",Escala)
          End sub
      End Class
  End Class
End Class
