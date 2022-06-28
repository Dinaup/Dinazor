Partial Public Class SeccionesD
  Public Class PersonalizacionDeSeccionesBaseD
      Public Shared _SeccionID As String = "6e128aa3-858e-4562-8414-879ebf83e23e"
      Public Shared _SeccionIDGUID As New Guid("6e128aa3-858e-4562-8414-879ebf83e23e")
      Public Class PersonalizacionDeSeccionesBaseES
          Public shared _SeccionID as Guid = New Guid("6e128aa3-858e-4562-8414-879ebf83e23e")
          Public shared _Tabla$ = "tpr_7808436xd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_780843cwd"
      Public Shared PersonalizarDocumentoCompacto$ = "pr_795a9e9wd"
      Public Shared Color$ = "pr_7850c29wd"
      Public Shared FechaAlta_UTC$ = "pr_7808446wd"
      Public Shared ExportarEnModulos$ = "pr_7808442wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_780846awd"
      Public Shared ReferenciaTooltip$ = "pr_78513a4wd"
      Public Shared ReferenciaIcono$ = "pr_7850c27wd"
      Public Shared ReferenciaImpresionDefecto$ = "pr_7850c2bwd"
      Public Shared ActivarSistemaDeAgenda$ = "pr_7808470wd"
      Public Shared ReferenciaSeccionPersonalizada$ = "pr_78560d4wd"
      Public Shared HoraLocal$ = "pr_7808440wd"
      Public Shared ReferenciaDestinador$ = "pr_780844cwd"
      Public Shared ReferenciaDocumentoCompacto$ = "pr_7850c2dwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_780846ewd"
      Public Shared PersonalizarImpresion$ = "pr_795a9ebwd"
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
      Public Class PersonalizacionDeSeccionesBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PersonalizarDocumentoCompacto As Boolean
          Public Color As String
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaTooltip As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaImpresionDefecto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ActivarSistemaDeAgenda As Boolean
          Public ReferenciaSeccionPersonalizada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDocumentoCompacto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public PersonalizarImpresion As Boolean
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
