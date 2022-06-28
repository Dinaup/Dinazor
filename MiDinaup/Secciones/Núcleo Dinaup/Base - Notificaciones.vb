Partial Public Class SeccionesD
  Public Class NotificacionesBaseD
      Public Shared _SeccionID As String = "ad79395d-3e3d-4fe3-a2f9-28f95db59e30"
      Public Shared _SeccionIDGUID As New Guid("ad79395d-3e3d-4fe3-a2f9-28f95db59e30")
      Public Class NotificacionesBaseES
          Public shared _SeccionID as Guid = New Guid("ad79395d-3e3d-4fe3-a2f9-28f95db59e30")
          Public shared _Tabla$ = "tpr_737d4c8xd"
      Public Shared HoraLocal$ = "pr_77611d0wd"
      Public Shared ReferenciaDestinador$ = "pr_737d4f8wd"
      Public Shared ReferenciaReferenciaSeccionDatoRelativo$ = "pr_737de0awd"
      Public Shared ReferenciaConfiguracionDeNotificacion$ = "pr_737ddfewd"
      Public Shared NotificacionLocal$ = "pr_7a54d71wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_737d528wd"
      Public Shared NombreDatoRelativo$ = "pr_737de02wd"
      Public Shared CantidadDeNotificaciones$ = "pr_7a545d3wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_737d4d4wd"
      Public Shared NotificacionFinalizada$ = "pr_7a1855awd"
      Public Shared FechaDato_UTC$ = "pr_737d4e0wd"
      Public Shared ExportarEnModulos$ = "pr_737d4e4wd"
      Public Shared FechaAlta_UTC$ = "pr_737d4ecwd"
      Public Shared ReferenciaReferenciaDatoRelativo$ = "pr_737de06wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_737d530wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_737d4dcwd"
      Public Shared FechaDeLectura_UTC$ = "pr_737ddeawd"
      Public Shared FechaDeNotificacion_UTC$ = "pr_7a18558wd"
      Public Shared CausanteTieneAccesoWeb$ = "pr_10040155921002"
      Public Shared ReferenciaCausante$ = "pr_10040155921001"
      Public Shared Descripcion$ = "pr_500404126517"
      Public Shared ID$ = "id"
      Public Shared TextoPrincipal$ = "nombre"
      Public Shared FechaAltaDato_UTC$ = "fecha"
      Public Shared FechaUltimaModificacion_UTC$ = "fecham"
      Public Shared Eliminado$ = "eliminado"
      Public Shared UsuarioCreadorDelDAto$ = "usuarioid"
      Public Shared Seccion$ = "plantillapid"
      Public Shared Posicion$ = "posicion"
      Public Shared Empresa$ = "ubicacion"
      Public Shared Modificado$ = "modificado"
      Public Shared FechaIndiceActividad_UTC$ = "fechaia"
      Public Shared Fechadesincronizacion_UTC$ = "fechasyn"
      End Class
      Public Class NotificacionesBaseC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaReferenciaSeccionDatoRelativo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaConfiguracionDeNotificacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NotificacionLocal As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public NombreDatoRelativo As String
          Public CantidadDeNotificaciones As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NotificacionFinalizada As Boolean
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaReferenciaDatoRelativo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDeLectura_UTC As Date
          Public FechaDeNotificacion_UTC As Date
          Public CausanteTieneAccesoWeb As Boolean
          Public ReferenciaCausante As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Descripcion As String
          Public ID As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TextoPrincipal As String
          Public FechaAltaDato_UTC As Date
          Public FechaUltimaModificacion_UTC As Date
          Public Eliminado As Boolean
          Public UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Seccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Posicion As Integer
          Public Empresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Modificado As Boolean
          Public FechaIndiceActividad_UTC As Date
          Public Fechadesincronizacion_UTC As Date
          Sub new()
          End Sub
      End Class
  End Class
End Class
