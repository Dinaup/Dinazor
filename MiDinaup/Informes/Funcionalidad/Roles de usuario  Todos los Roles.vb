Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class RolesDeUsuarioTodosLosRolesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of RolesDeUsuarioTodosLosRoles_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of RolesDeUsuarioTodosLosRoles_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New RolesDeUsuarioTodosLosRoles_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c557a347-955e-4810-b743-6936d7624f31"))
              me.ID = new GUID("c557a347-955e-4810-b743-6936d7624f31")
              me.Titulo  = "Roles de usuario > Todos los Roles"
          End sub
          Public Class RolesDeUsuarioTodosLosRoles_FilaC
              Public FechaAltaSistema As Date?
              Public TextoPrincipal As String
              Public FechaUltimaModificacion As Date?
              Public ID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              End Sub
          End Class
      End Class
  End Class
End Class