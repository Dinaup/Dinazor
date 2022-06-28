Partial Public Class SeccionesD
  Public Class ActividadesDeInformesBaseD
      Public Shared _SeccionID As String = "d014e45b-de83-41b5-95cd-5fd0e3d63c53"
      Public Shared _SeccionIDGUID As New Guid("d014e45b-de83-41b5-95cd-5fd0e3d63c53")
      Public Class ActividadesDeInformesBaseES
          Public shared _SeccionID as Guid = New Guid("d014e45b-de83-41b5-95cd-5fd0e3d63c53")
          Public shared _Tabla$ = "tpr_40a1e3fwc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b413bah2f7wd"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_185b31d232x2cwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14631491edh3a4wd"
      Public Shared ReferenciaDestinador$ = "pr_1463103011ge9wd"
      Public Shared HoraLocal$ = "pr_776aeaawd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b4143exfcwd"
      Public Shared DuracionVisitaSegundos$ = "pr_40a239bx155wc"
      Public Shared ReferenciaInforme$ = "pr_40a22c4x241wc"
      Public Shared HaImprimido$ = "pr_40a6468xf1wc"
      Public Shared TiempoEjecucion$ = "pr_4d8406dx301wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463102f2ex39cwd"
      Public Shared ReferenciaPermisoPuntual$ = "pr_7c20d01wd"
      Public Shared FinalizacionInesperada$ = "pr_4d84155x34cwc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b598fdh3e0wd"
      Public Shared ExportarEnModulos$ = "pr_1463102f73g1e4wd"
      Public Shared TiempoActividadSegundo$ = "pr_40a23e2x3cdwc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e43bx101wd"
      Public Shared Pagina$ = "pr_40a240bx2a2wc"
      Public Shared FechaDato_UTC$ = "pr_1463102f73x1e4wd"
      Public Shared ReferenciaServidor$ = "pr_50040212262"
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
      Public Class ActividadesDeInformesBaseC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DuracionVisitaSegundos As Integer
          Public ReferenciaInforme As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HaImprimido As Boolean
          Public TiempoEjecucion As Decimal
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPermisoPuntual As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FinalizacionInesperada As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public TiempoActividadSegundo As Integer
          Public FechaAlta_UTC As Date
          Public Pagina As Integer
          Public FechaDato_UTC As Date
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
