Partial Public Class SeccionesD
  Public Class DocumentosPrediseñadosBaseD
      Public Shared _SeccionID As String = "8ff1e68d-76e7-4a8c-ae2b-8ea0180a6c49"
      Public Shared _SeccionIDGUID As New Guid("8ff1e68d-76e7-4a8c-ae2b-8ea0180a6c49")
      Public Class DocumentosPrediseñadosBaseES
          Public shared _SeccionID as Guid = New Guid("8ff1e68d-76e7-4a8c-ae2b-8ea0180a6c49")
          Public shared _Tabla$ = "tpr_50040237495"
      Public Shared ReferenciaDestinador$ = "pr_500402374913"
      Public Shared FechaAlta_UTC$ = "pr_500402374912"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040237498"
      Public Shared ExportarEnModulos$ = "pr_500402374911"
      Public Shared HoraLocal$ = "pr_500402374910"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402374924"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500402374925"
      Public Shared Configuracion$ = "pr_500402374926"
      Public Shared IdentificadorDeConfiguracionSha1$ = "pr_500402374927"
      Public Shared Version$ = "pr_60040237493"
      Public Shared ReferenciaDocumentoPrediseñadoPrimeraVersion$ = "pr_60040237495"
      Public Shared Tipo$ = "pr_20040237527"
      Public Shared Archivado$ = "pr_20040237671"
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
      Public Class DocumentosPrediseñadosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Configuracion As String
          Public IdentificadorDeConfiguracionSha1 As String
          Public Version As Integer
          Public ReferenciaDocumentoPrediseñadoPrimeraVersion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Tipo As Integer
          Public Archivado As Boolean
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
