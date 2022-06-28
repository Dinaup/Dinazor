Partial Public Class SeccionesD
  Public Class IntegridadDeExistenciaBaseD
      Public Shared _SeccionID As String = "69eedb25-1369-421e-948f-30abcc65232e"
      Public Shared _SeccionIDGUID As New Guid("69eedb25-1369-421e-948f-30abcc65232e")
      Public Class IntegridadDeExistenciaBaseES
          Public shared _SeccionID as Guid = New Guid("69eedb25-1369-421e-948f-30abcc65232e")
          Public shared _Tabla$ = "tpr_71ae9ebxd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_71aea1fwd"
      Public Shared ReferenciaRegistroID$ = "pr_71bcd24wd"
      Public Shared FechaReparacionObsoleto_UTC$ = "pr_71af6d9wd"
      Public Shared FechaReparacionUTC_UTC$ = "pr_71af6ddwd"
      Public Shared FechaDato_UTC$ = "pr_71aea23wd"
      Public Shared ReferenciaLocalizadoEnUbicacionObsoleto$ = "pr_71af6d5wd"
      Public Shared ExportarEnModulos$ = "pr_71aea27wd"
      Public Shared FechaAlta_UTC$ = "pr_71aea2fwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_71aea4bwd"
      Public Shared Estado$ = "pr_71af6e1wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_71aea1bwd"
      Public Shared ReferenciaDestinador$ = "pr_71aea3bwd"
      Public Shared HoraLocal$ = "pr_776af18wd"
      Public Shared SeccionOTabla$ = "pr_71af6cdwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_71aea53wd"
      Public Shared ReferenciaServidorDondeFalta$ = "pr_20040212261"
      Public Shared ReferenciaServidorDondeExiste$ = "pr_20040212262"
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
      Public Class IntegridadDeExistenciaBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroID As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaReparacionObsoleto_UTC As Date
          Public FechaReparacionUTC_UTC As Date
          Public FechaDato_UTC As Date
          Public ReferenciaLocalizadoEnUbicacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Estado As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public SeccionOTabla As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaServidorDondeFalta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidorDondeExiste As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
