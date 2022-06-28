Partial Public Class SeccionesD
  Public Class RegistroDeActividadBaseD
      Public Shared _SeccionID As String = "ccc3961c-ea12-490a-828f-656776cf2f19"
      Public Shared _SeccionIDGUID As New Guid("ccc3961c-ea12-490a-828f-656776cf2f19")
      Public Class RegistroDeActividadBaseES
          Public shared _SeccionID as Guid = New Guid("ccc3961c-ea12-490a-828f-656776cf2f19")
          Public shared _Tabla$ = "tpr_407f801wc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b41092x328wd"
      Public Shared TipoDeAccion$ = "pr_7c20cf7wd"
      Public Shared FinalizacionInesperada$ = "pr_4d832fcx2fawc"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314ac52h261wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b410d0x38cwd"
      Public Shared TiempoEjecucion$ = "pr_4d83377x2a6wc"
      Public Shared HoraLocal$ = "pr_776aebawd"
      Public Shared ReferenciaDestinador$ = "pr_146310256ex24dwd"
      Public Shared HaImprimido$ = "pr_40a64ccx59wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310243ex306wd"
      Public Shared ReferenciaElemento$ = "pr_407fc81x1a3wc"
      Public Shared ReferenciaPermisoPuntual$ = "pr_73b8379wd"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_185b34608cx16bwd"
      Public Shared VecesFoco$ = "pr_407faadx2a4wc"
      Public Shared SegundosAbierto$ = "pr_407fa69x1e3wc"
      Public Shared ReferenciaSeccion$ = "pr_407fc0ex312wc"
      Public Shared SegundosActividad$ = "pr_407fa49x391wc"
      Public Shared FechaDato_UTC$ = "pr_1463102482xbcwd"
      Public Shared ExportarEnModulos$ = "pr_1463102482gbcwd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e26dg13bwd"
      Public Shared ElementoNombre$ = "pr_47137adx73wc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59d72x51wd"
      Public Shared ReferenciaServidor$ = "pr_40040212261"
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
      Public Class RegistroDeActividadBaseC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoDeAccion As Integer
          Public FinalizacionInesperada As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TiempoEjecucion As Decimal
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HaImprimido As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPermisoPuntual As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public VecesFoco As Integer
          Public SegundosAbierto As Integer
          Public ReferenciaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public SegundosActividad As Integer
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ElementoNombre As String
          Public EmpleadoTieneAccesoWeb As Boolean
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
