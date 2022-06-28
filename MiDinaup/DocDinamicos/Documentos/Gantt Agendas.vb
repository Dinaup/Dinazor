Partial Public Class DocumentosDinamicosD
  Partial Class DocumentosD
      Public Class GanttAgendasC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new()
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("79ff1384-83d0-4a97-88c3-491f71ebdbbd"))
              me.ID = new GUID("79ff1384-83d0-4a97-88c3-491f71ebdbbd")
              me.Titulo  = "Gantt Agendas"
          End sub
      End Class
  End Class
End Class
