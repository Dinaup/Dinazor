Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class DocumentosDinamicosTodosLosDocumentosDinamicosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("acd19d19-a4cc-4e0b-8235-3dd5cc0689d1"))
              me.ID = new GUID("acd19d19-a4cc-4e0b-8235-3dd5cc0689d1")
              me.Titulo  = "Documentos Dinámicos > Todos los Documentos Dinámicos"
          End sub
          Public Class DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC
              Public FechaAltaSistema As Date?
              Public TextoPrincipal As String
              Public Subcategoria As String
              Public ID As Guid
              Public FechaUltimaModificacion As Date?
              Public Categoria As String
              Public Eliminado As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Subcategoria = o("Subcategoria").STR
              Me.ID = o("ID").ToGuid
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Categoria = o("Categoria").STR
              Me.Eliminado = o("Eliminado").BOOL
              End Sub
          End Class
      End Class
  End Class
End Class