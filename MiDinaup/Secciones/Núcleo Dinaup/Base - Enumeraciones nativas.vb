Partial Public Class SeccionesD
  Public Class EnumeracionesNativasBaseD
      Public Shared _SeccionID As String = "b5bcf7d2-4928-4308-aff4-cec7025f289f"
      Public Shared _SeccionIDGUID As New Guid("b5bcf7d2-4928-4308-aff4-cec7025f289f")
      Public Class EnumeracionesNativasBaseES
          Public shared _SeccionID as Guid = New Guid("b5bcf7d2-4928-4308-aff4-cec7025f289f")
          Public shared _Tabla$ = "tpr_40040447692"
      Public Shared ReferenciaDestinador$ = "pr_400404476913"
      Public Shared FechaAlta_UTC$ = "pr_400404476912"
      Public Shared ExportarEnModulos$ = "pr_400404476911"
      Public Shared HoraLocal$ = "pr_400404476910"
      Public Shared ReferenciaAutorDelAlta$ = "pr_40040447698"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400404476924"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_400404476925"
      Public Shared IDEnumRolCampo$ = "pr_50040447693"
      Public Shared Titulo$ = "pr_50040447694"
      Public Shared Descripcion$ = "pr_60040447692"
      Public Shared EnumeracionObsoleta$ = "pr_40040447914"
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
      Public Class EnumeracionesNativasBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public IDEnumRolCampo As Integer
          Public Titulo As String
          Public Descripcion As String
          Public EnumeracionObsoleta As Boolean
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
