Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class DiseñosDeComplementosTodosLosDiseñosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of DiseñosDeComplementosTodosLosDiseños_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of DiseñosDeComplementosTodosLosDiseños_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New DiseñosDeComplementosTodosLosDiseños_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("eba79109-100a-4de7-9ffa-4fd01ccc864b"))
              me.ID = new GUID("eba79109-100a-4de7-9ffa-4fd01ccc864b")
              me.Titulo  = "Diseños de complementos > Todos los Diseños"
          End sub
          Public Class DiseñosDeComplementosTodosLosDiseños_FilaC
              Public TextoPrincipal As String
              Public FechaUltimaModificacion As Date?
              Public ID As Guid
              Public FechaAltaSistema As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              End Sub
          End Class
      End Class
  End Class
End Class