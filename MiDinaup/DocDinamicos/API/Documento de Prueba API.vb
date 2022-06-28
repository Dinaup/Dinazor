Partial Public Class DocumentosDinamicosD
  Partial Class APID
      Public Class DocumentodePruebaAPIC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new(Texto As String)
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("9ea36ade-05f4-4abb-abb4-3bf76065494c"))
              me.ID = new GUID("9ea36ade-05f4-4abb-abb4-3bf76065494c")
              me.Titulo  = "Documento de Prueba API"
              Agregar_Respuesta("Texto",Texto)
          End sub
      End Class
  End Class
End Class
