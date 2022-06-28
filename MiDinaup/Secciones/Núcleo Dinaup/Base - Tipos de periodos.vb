Partial Public Class SeccionesD
  Public Class TiposDePeriodosBaseD
      Public Shared _SeccionID As String = "55e73c69-0b56-4439-8b1a-7a791120d2d8"
      Public Shared _SeccionIDGUID As New Guid("55e73c69-0b56-4439-8b1a-7a791120d2d8")
      Public Class TiposDePeriodosBaseES
          Public shared _SeccionID as Guid = New Guid("55e73c69-0b56-4439-8b1a-7a791120d2d8")
          Public shared _Tabla$ = "tpr_30040113831001"
      Public Shared Meses$ = "pr_50040113833"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040113831012"
      Public Shared Años$ = "pr_50040113831"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040113831023"
      Public Shared ExportarEnModulos$ = "pr_30040113831015"
      Public Shared FechaAlta_UTC$ = "pr_30040113831016"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040113831021"
      Public Shared Dias$ = "pr_50040113832"
      Public Shared HoraLocal$ = "pr_30040113831014"
      Public Shared ReferenciaDestinador$ = "pr_30040113831017"
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
      Public Class TiposDePeriodosBaseC
          Public Meses As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Años As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Dias As Integer
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
