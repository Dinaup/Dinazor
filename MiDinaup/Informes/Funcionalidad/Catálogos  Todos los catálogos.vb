Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CatalogosTodosLosCatalogosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CatalogosTodosLosCatalogos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e33d9547-d22c-47f5-87ca-ab7efc7896a6"))
              me.ID = new GUID("e33d9547-d22c-47f5-87ca-ab7efc7896a6")
              me.Titulo  = "Catálogos > Todos los catálogos"
          End sub
          <ProtoContract>
          Public Class CatalogosTodosLosCatalogos_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(102)>  Public SeccionPrincipal As String
                <ProtoMember(103)>  Public SeccionID As Guid
                <ProtoMember(104)>  Public ID As Guid
                <ProtoMember(105)>  Public FechaAltaSistema As DateTime
                <ProtoMember(106)>  Public SecciondecatalogoID As Guid
                <ProtoMember(107)>  Public SecciondeCatalogo As String
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
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CatalogosTodosLosCatalogos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CatalogosTodosLosCatalogos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class