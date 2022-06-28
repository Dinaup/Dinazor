Partial Public Class SeccionesD
  Public Class BuzonesDeCorreoBaseD
      Public Shared _SeccionID As String = "7e428fbb-1432-4807-b4d3-739346f15f37"
      Public Shared _SeccionIDGUID As New Guid("7e428fbb-1432-4807-b4d3-739346f15f37")
      Public Class BuzonesDeCorreoBaseES
          Public shared _SeccionID as Guid = New Guid("7e428fbb-1432-4807-b4d3-739346f15f37")
          Public shared _Tabla$ = "tpr_50040257403"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500402574011"
      Public Shared ReferenciaDestinador$ = "pr_500402574016"
      Public Shared FechaAlta_UTC$ = "pr_500402574015"
      Public Shared HoraLocal$ = "pr_500402574013"
      Public Shared ExportarEnModulos$ = "pr_500402574014"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402574027"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500402574028"
      Public Shared ReferenciaCuentaDeCorreo$ = "pr_600402574029"
      Public Shared EtiquetaDelBuzon$ = "pr_40040257411"
      Public Shared ReferenciaEmpresaALaQueAsociarLosCorreos$ = "pr_60040257411"
      Public Shared BuzonDesactivado$ = "pr_40040257422"
      Public Shared ReferenciaSeccionDeDestino1$ = "pr_40040257431"
      Public Shared ReferenciaSeccionDeDestino2$ = "pr_40040257432"
      Public Shared ReferenciaSeccionDeDestino3$ = "pr_40040257433"
      Public Shared ReferenciaSeccionDeDestino4$ = "pr_40040257434"
      Public Shared ReferenciaSeccionDeDestino5$ = "pr_40040257435"
      Public Shared ReferenciaSeccionDeDestino6$ = "pr_40040257436"
      Public Shared ReferenciaEntidadALaQueAsociarLosCorreos$ = "pr_60040257448"
      Public Shared EntidadALaQueAsociarLosCorreosTieneAccesoWeb$ = "pr_60040257449"
      Public Shared ReferenciaEstadoParaNuevos$ = "pr_10040257451"
      Public Shared PermisosDeLectura$ = "pr_60040257881"
      Public Shared PermisosDeEnvio$ = "pr_60040257882"
      Public Shared EtiquetaComoAliasRecomendado$ = "pr_20040474821"
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
      Public Class BuzonesDeCorreoBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaCuentaDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EtiquetaDelBuzon As String
          Public ReferenciaEmpresaALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public BuzonDesactivado As Boolean
          Public ReferenciaSeccionDeDestino1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino4 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino5 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino6 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEntidadALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadALaQueAsociarLosCorreosTieneAccesoWeb As Boolean
          Public ReferenciaEstadoParaNuevos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PermisosDeLectura As Integer
          Public PermisosDeEnvio As Integer
          Public EtiquetaComoAliasRecomendado As Boolean
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
