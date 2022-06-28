Partial Public Class SeccionesD
  Public Class AsignacionDeCorreosaARegistrosBaseD
      Public Shared _SeccionID As String = "742ceaf7-bfd8-4512-a146-862b92f4bed9"
      Public Shared _SeccionIDGUID As New Guid("742ceaf7-bfd8-4512-a146-862b92f4bed9")
      Public Class AsignacionDeCorreosaARegistrosBaseES
          Public shared _SeccionID as Guid = New Guid("742ceaf7-bfd8-4512-a146-862b92f4bed9")
          Public shared _Tabla$ = "tpr_30040452751"
      Public Shared ReferenciaDestinador$ = "pr_300404527512"
      Public Shared FechaAlta_UTC$ = "pr_300404527511"
      Public Shared ExportarEnModulos$ = "pr_300404527510"
      Public Shared HoraLocal$ = "pr_30040452759"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040452757"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300404527523"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_300404527524"
      Public Shared ReferenciaRegistroSeccion$ = "pr_300404527526"
      Public Shared NombreDeRegistro$ = "pr_300404527528"
      Public Shared ReferenciaRegistroRelacionado$ = "pr_300404527529"
      Public Shared ReferenciaCorreo$ = "pr_40040452751"
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
      Public Class AsignacionDeCorreosaARegistrosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaRegistroSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NombreDeRegistro As String
          Public ReferenciaRegistroRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
