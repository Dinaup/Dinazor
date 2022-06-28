Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeAgendaBaseD
      Public Shared _SeccionID As String = "857c0641-69e7-4118-81be-980b6b4a691d"
      Public Shared _SeccionIDGUID As New Guid("857c0641-69e7-4118-81be-980b6b4a691d")
      Public Class RegistrosDeActividadDeAgendaBaseES
          Public shared _SeccionID as Guid = New Guid("857c0641-69e7-4118-81be-980b6b4a691d")
          Public shared _Tabla$ = "tpr_7c25e52xd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7c25e8cwd"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_7c27cebwd"
      Public Shared ReferenciaAgendaElemento$ = "pr_7c27ce9wd"
      Public Shared HoraLocal$ = "pr_7c25e64wd"
      Public Shared ReferenciaDestinador$ = "pr_7c25e72wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7c25e5cwd"
      Public Shared VecesFoco$ = "pr_7c48d94wd"
      Public Shared AgendaNombre$ = "pr_7c28201wd"
      Public Shared SegundosActividad$ = "pr_7c48d92wd"
      Public Shared FinalizacionInesperada$ = "pr_7c49705wd"
      Public Shared ExportarEnModulos$ = "pr_7c25e66wd"
      Public Shared FechaAlta_UTC$ = "pr_7c25e6cwd"
      Public Shared TiempoEjecucion$ = "pr_7c49703wd"
      Public Shared FechaDato_UTC$ = "pr_7c25e62wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7c25e88wd"
      Public Shared SegundosAbierto$ = "pr_7c48d8ewd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7c25e60wd"
      Public Shared ReferenciaSeccionAgenda$ = "pr_7c27ce7wd"
      Public Shared ReferenciaServidor$ = "pr_50040212263"
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
      Public Class RegistrosDeActividadDeAgendaBaseC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAgendaElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public VecesFoco As Integer
          Public AgendaNombre As String
          Public SegundosActividad As Integer
          Public FinalizacionInesperada As Boolean
          Public FechaAlta_UTC As Date
          Public TiempoEjecucion As Decimal
          Public FechaDato_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public SegundosAbierto As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionAgenda As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
