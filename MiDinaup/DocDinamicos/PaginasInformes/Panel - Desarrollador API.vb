Partial Public Class DocumentosDinamicosD
  Partial Class PaginasInformesD
      Public Class PanelDesarrolladorAPIC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new()
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("e86e733f-213f-4437-9f71-30d9d0450f1c"))
              me.ID = new GUID("e86e733f-213f-4437-9f71-30d9d0450f1c")
              me.Titulo  = "Panel - Desarrollador API"
          End sub
      End Class
  End Class
End Class
