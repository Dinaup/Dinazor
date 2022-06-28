Partial Public Class SeccionesD
  Public Class RegistrosSincronizadosBaseD
      Public Shared _SeccionID As String = "5c9b88b7-f8be-46fe-b2a5-5d64f9711d65"
      Public Shared _SeccionIDGUID As New Guid("5c9b88b7-f8be-46fe-b2a5-5d64f9711d65")
      Public Class RegistrosSincronizadosBaseES
          Public shared _SeccionID as Guid = New Guid("5c9b88b7-f8be-46fe-b2a5-5d64f9711d65")
          Public shared _Tabla$ = "tpr_30040450401"
      Public Shared ReferenciaDestinador$ = "pr_300404504017"
      Public Shared FechaAlta_UTC$ = "pr_300404504016"
      Public Shared ReferenciaAutorDelAlta$ = "pr_300404504012"
      Public Shared HoraLocal$ = "pr_300404504014"
      Public Shared ExportarEnModulos$ = "pr_300404504015"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300404504028"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_300404504029"
      Public Shared ReferenciaSincronizador$ = "pr_300404504032"
      Public Shared IDOrigen$ = "pr_300404504033"
      Public Shared ReferenciaSeccionDestino$ = "pr_40040450401"
      Public Shared ReferenciaDatoDestino$ = "pr_40040450403"
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
      Public Class RegistrosSincronizadosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaSincronizador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IDOrigen As String
          Public ReferenciaSeccionDestino As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDatoDestino As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
