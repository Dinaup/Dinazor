Partial Public Class SeccionesD
  Public Class IntervaloBaseD
      Public Shared _SeccionID As String = "b0e1a6c0-5168-4efb-8a23-b670cc7dc3ae"
      Public Shared _SeccionIDGUID As New Guid("b0e1a6c0-5168-4efb-8a23-b670cc7dc3ae")
      Public Class IntervaloBaseES
          Public shared _SeccionID as Guid = New Guid("b0e1a6c0-5168-4efb-8a23-b670cc7dc3ae")
          Public shared _Tabla$ = "tpr_60040131551001"
      Public Shared ReferenciaDestinador$ = "pr_60040131551015"
      Public Shared ExportarEnModulos$ = "pr_60040131551013"
      Public Shared FechaAlta_UTC$ = "pr_60040131551014"
      Public Shared ReferenciaAutorDelAlta$ = "pr_60040131551010"
      Public Shared HoraLocal$ = "pr_60040131551012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_60040131551021"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_60040131551022"
      Public Shared Observaciones$ = "pr_10040131563"
      Public Shared IdentificadorDeConfiguracionSha1$ = "pr_10040131564"
      Public Shared Configuracion$ = "pr_10040131567"
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
      Public Class IntervaloBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Observaciones As String
          Public IdentificadorDeConfiguracionSha1 As String
          Public Configuracion As String
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
