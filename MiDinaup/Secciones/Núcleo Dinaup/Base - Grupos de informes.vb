Partial Public Class SeccionesD
  Public Class GruposDeInformesBaseD
      Public Shared _SeccionID As String = "0d22a34c-0183-408b-97c9-62d1ce10a8f4"
      Public Shared _SeccionIDGUID As New Guid("0d22a34c-0183-408b-97c9-62d1ce10a8f4")
      Public Class GruposDeInformesBaseES
          Public shared _SeccionID as Guid = New Guid("0d22a34c-0183-408b-97c9-62d1ce10a8f4")
          Public shared _Tabla$ = "tpr_20040104791"
      Public Shared ExportarEnModulos$ = "pr_20040104796"
      Public Shared FechaAlta_UTC$ = "pr_20040104797"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401047928"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040104793"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401047926"
      Public Shared HoraLocal$ = "pr_20040104795"
      Public Shared ReferenciaDestinador$ = "pr_200401047910"
      Public Shared Observaciones$ = "pr_300401049511"
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
      Public Class GruposDeInformesBaseC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
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
