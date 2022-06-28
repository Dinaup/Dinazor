Partial Public Class SeccionesD
  Public Class DisposicionDeInformesBaseD
      Public Shared _SeccionID As String = "1825f272-e127-4dbe-a53d-c9f39cfd2b25"
      Public Shared _SeccionIDGUID As New Guid("1825f272-e127-4dbe-a53d-c9f39cfd2b25")
      Public Class DisposicionDeInformesBaseES
          Public shared _SeccionID as Guid = New Guid("1825f272-e127-4dbe-a53d-c9f39cfd2b25")
          Public shared _Tabla$ = "tpr_10040166171"
      Public Shared ReferenciaDestinador$ = "pr_100401661712"
      Public Shared FechaAlta_UTC$ = "pr_100401661711"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040166177"
      Public Shared ExportarEnModulos$ = "pr_100401661710"
      Public Shared HoraLocal$ = "pr_10040166179"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401661723"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100401661724"
      Public Shared ReferenciaInforme$ = "pr_100401661727"
      Public Shared Activo$ = "pr_100401661728"
      Public Shared ReferenciaIcono$ = "pr_100401661729"
      Public Shared ConfiguracionSHA1$ = "pr_20040166171"
      Public Shared Configuracion$ = "pr_20040166172"
      Public Shared Titulo$ = "pr_20040166173"
      Public Shared Descripcion$ = "pr_20040166174"
      Public Shared ConvertirEnDisposicionPorDefecto$ = "pr_20040279921"
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
      Public Class DisposicionDeInformesBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaInforme As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Activo As Boolean
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ConfiguracionSHA1 As String
          Public Configuracion As String
          Public Titulo As String
          Public Descripcion As String
          Public ConvertirEnDisposicionPorDefecto As Boolean
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
