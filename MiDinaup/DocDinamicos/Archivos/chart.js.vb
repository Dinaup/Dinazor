Partial Public Class DocumentosDinamicosD
  Partial Class ArchivosD
      Public Class chartjsC
          Inherits DinaNETCore.APID.Base_DocumentoDinamicoC
          Sub new()
              Parametros = New DinaNETCore.APID.Funcion_DocumentoDinamico_Consultar_ParametrosC(new GUID("90012274-cc61-4049-839a-3829bd332ca9"))
              me.ID = new GUID("90012274-cc61-4049-839a-3829bd332ca9")
              me.Titulo  = "chart.js"
          End sub
      End Class
  End Class
End Class
