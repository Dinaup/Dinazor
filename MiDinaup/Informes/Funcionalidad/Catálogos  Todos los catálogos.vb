Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CatalogosTodosLosCatalogosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CatalogosTodosLosCatalogos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CatalogosTodosLosCatalogos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CatalogosTodosLosCatalogos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e33d9547-d22c-47f5-87ca-ab7efc7896a6"))
              me.ID = new GUID("e33d9547-d22c-47f5-87ca-ab7efc7896a6")
              me.Titulo  = "Catálogos > Todos los catálogos"
          End sub
          Public Class CatalogosTodosLosCatalogos_FilaC
              Public TextoPrincipal As String
              Public FechaUltimaModificacion As Date?
              Public SeccionPrincipal As String
              Public SeccionID As Guid
              Public ID As Guid
              Public FechaAltaSistema As Date?
              Public SecciondecatalogoID As Guid
              Public SecciondeCatalogo As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.SeccionPrincipal = o("SeccionPrincipal").STR
              Me.SeccionID = o("SeccionID").ToGuid
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.SecciondecatalogoID = o("SecciondecatalogoID").ToGuid
              Me.SecciondeCatalogo = o("SecciondeCatalogo").STR
              End Sub
          End Class
      End Class
  End Class
End Class