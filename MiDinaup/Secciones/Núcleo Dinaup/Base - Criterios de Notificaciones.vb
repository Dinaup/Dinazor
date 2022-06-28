Partial Public Class SeccionesD
  Public Class CriteriosDeNotificacionesBaseD
      Public Shared _SeccionID As String = "e231be6e-ae7c-4064-9618-dac6c456a87b"
      Public Shared _SeccionIDGUID As New Guid("e231be6e-ae7c-4064-9618-dac6c456a87b")
      Public Class CriteriosDeNotificacionesBaseES
          Public shared _SeccionID as Guid = New Guid("e231be6e-ae7c-4064-9618-dac6c456a87b")
          Public shared _Tabla$ = "tpr_733da88xd"
      Public Shared TituloNotificacion$ = "pr_738b686wd"
      Public Shared ReferenciaDestinador$ = "pr_733dab0wd"
      Public Shared HoraLocal$ = "pr_77611c0wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_733dae8wd"
      Public Shared EmpleadosANotificar$ = "pr_79d87edwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_733da94wd"
      Public Shared NotificacionActiva$ = "pr_733f513wd"
      Public Shared InformacionAdicional$ = "pr_7a3e977wd"
      Public Shared TipoDeEvento$ = "pr_79db217wd"
      Public Shared FechaAlta_UTC$ = "pr_733daa4wd"
      Public Shared ExportarEnModulos$ = "pr_733da9cwd"
      Public Shared Condicion$ = "pr_79d7f69wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_733daecwd"
      Public Shared IntervaloDeNotificacion$ = "pr_7c9df98wd"
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
      Public Class CriteriosDeNotificacionesBaseC
          Public TituloNotificacion As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadosANotificar As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NotificacionActiva As Boolean
          Public InformacionAdicional As String
          Public TipoDeEvento As Integer
          Public FechaAlta_UTC As Date
          Public Condicion As String
          Public EmpleadoTieneAccesoWeb As Boolean
          Public IntervaloDeNotificacion As String
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
