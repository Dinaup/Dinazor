Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class RolesDeUsuarioTodosLosRolesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of RolesDeUsuarioTodosLosRoles_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c557a347-955e-4810-b743-6936d7624f31"))
              me.ID = new GUID("c557a347-955e-4810-b743-6936d7624f31")
              me.Titulo  = "Roles de usuario > Todos los Roles"
          End sub
          <ProtoContract>
          Public Class RolesDeUsuarioTodosLosRoles_FilaC
                <ProtoMember(100)>  Public FechaAltaSistema As DateTime
                <ProtoMember(101)>  Public TextoPrincipal As String
                <ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(103)>  Public ID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of RolesDeUsuarioTodosLosRoles_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New RolesDeUsuarioTodosLosRoles_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class