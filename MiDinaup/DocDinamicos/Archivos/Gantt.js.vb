Partial Public Class DocumentosDinamicosD
  Partial Class ArchivosD
      Public Class GanttjsC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new()
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("c1899956-f94b-4d43-8d9d-acb6acaf2bde"))
              me.ID = new GUID("c1899956-f94b-4d43-8d9d-acb6acaf2bde")
              me.Titulo  = "Gantt.js"
          End sub
      End Class
  End Class
End Class
