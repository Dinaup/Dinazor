Partial Public Class SeccionesD
  Public Class EstadosDeRegistrosBaseD
      Public Shared _SeccionID As String = "ae55d37a-9b63-4927-acd4-6a6e1926d4a3"
      Public Shared _SeccionIDGUID As New Guid("ae55d37a-9b63-4927-acd4-6a6e1926d4a3")
      Public Class EstadosDeRegistrosBaseES
          Public shared _SeccionID as Guid = New Guid("ae55d37a-9b63-4927-acd4-6a6e1926d4a3")
          Public shared _Tabla$ = "tpr_50040382151"
      Public Shared ReferenciaDestinador$ = "pr_500403821512"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040382157"
      Public Shared FechaAlta_UTC$ = "pr_500403821511"
      Public Shared HoraLocal$ = "pr_50040382159"
      Public Shared ExportarEnModulos$ = "pr_500403821510"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500403821523"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500403821522"
      Public Shared Estado$ = "pr_20040382221"
      Public Shared Observaciones$ = "pr_20040382222"
      Public Shared TituloObsoleto$ = "pr_30040384562"
      Public Shared ReferenciaIcono$ = "pr_400103845414"
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
      Public Class EstadosDeRegistrosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Estado As Integer
          Public Observaciones As String
          Public TituloObsoleto As String
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
