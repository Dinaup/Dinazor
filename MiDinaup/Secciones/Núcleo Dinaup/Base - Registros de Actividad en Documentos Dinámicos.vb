Partial Public Class SeccionesD
  Public Class RegistrosDeActividadEnDocumentosDinamicosBaseD
      Public Shared _SeccionID As String = "bafabfa9-37a8-4013-b424-6c3cca9921c9"
      Public Shared _SeccionIDGUID As New Guid("bafabfa9-37a8-4013-b424-6c3cca9921c9")
      Public Class RegistrosDeActividadEnDocumentosDinamicosBaseES
          Public shared _SeccionID as Guid = New Guid("bafabfa9-37a8-4013-b424-6c3cca9921c9")
          Public shared _Tabla$ = "tpr_60040358903"
      Public Shared FechaDato_UTC$ = "pr_600403589016"
      Public Shared ReferenciaAutorDelAlta$ = "pr_600403589015"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_600403589013"
      Public Shared ReferenciaDestinador$ = "pr_600403589020"
      Public Shared FechaAlta_UTC$ = "pr_600403589019"
      Public Shared ExportarEnModulos$ = "pr_600403589018"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_600403589014"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600403589031"
      Public Shared HoraLocal$ = "pr_600403589017"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_600403589032"
      Public Shared ReferenciaArchivo$ = "pr_100403589137"
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
      Public Class RegistrosDeActividadEnDocumentosDinamicosBaseC
          Public FechaDato_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaArchivo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
