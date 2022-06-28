Partial Public Class SeccionesD
  Public Class CuentasDeCorreoElectronicoBaseD
      Public Shared _SeccionID As String = "e80ad188-9d6d-4b05-a7fb-e498cef51598"
      Public Shared _SeccionIDGUID As New Guid("e80ad188-9d6d-4b05-a7fb-e498cef51598")
      Public Class CuentasDeCorreoElectronicoBaseES
          Public shared _SeccionID as Guid = New Guid("e80ad188-9d6d-4b05-a7fb-e498cef51598")
          Public shared _Tabla$ = "tpr_30040163371001"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371008"
      Public Shared FechaAlta_UTC$ = "pr_30040163371014"
      Public Shared ExportarEnModulos$ = "pr_30040163371013"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371010"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371009"
      Public Shared ReferenciaDestinador$ = "pr_30040163371015"
      Public Shared HoraLocal$ = "pr_30040163371012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371021"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371022"
      Public Shared DireccionDeCorreo$ = "pr_60040164231004"
      Public Shared DireccionSMTP$ = "pr_10040164242"
      Public Shared Contraseña$ = "pr_10040164241"
      Public Shared ActivarSSLEnSMPT$ = "pr_10040164243"
      Public Shared Puerto$ = "pr_10040164244"
      Public Shared Configuracion$ = "pr_30040164802"
      Public Shared NumeroMaximoDeEnviosDeEmailsPorDia$ = "pr_50040165184"
      Public Shared NumeroMaximoDeEnviosDeEmailsPorHora$ = "pr_50040165183"
      Public Shared ReferenciaImagenPrevia$ = "pr_500401652940"
      Public Shared Protocolo$ = "pr_60040255942"
      Public Shared DescargarCorreosRecibidos$ = "pr_10040257112"
      Public Shared ReferenciaServidorEncargado$ = "pr_20040257112"
      Public Shared PuertoIMAP$ = "pr_40040257402"
      Public Shared ServidorIMAP$ = "pr_40040257404"
      Public Shared ActivarSSLEnIMAP$ = "pr_40040257403"
      Public Shared ReferenciaBuzonPredeterminado$ = "pr_600402574032"
      Public Shared ReferenciaBuzonPrincipal$ = "pr_40040391503"
      Public Shared ResponderA$ = "pr_50040408061"
      Public Shared FiltrarEnviadosA$ = "pr_50040408062"
      Public Shared DireccionDeEnvioAlias$ = "pr_30040408073"
      Public Shared DescargarCorreosEnviados$ = "pr_60040452763"
      Public Shared ReferenciaEstadoInicialCorreosEnviados$ = "pr_60040452765"
      Public Shared ReferenciaEstadoInicialCorreosRecibidos$ = "pr_10040452771"
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
      Public Class CuentasDeCorreoElectronicoBaseC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public DireccionDeCorreo As String
          Public DireccionSMTP As String
          Public Contraseña As String
          Public ActivarSSLEnSMPT As Boolean
          Public Puerto As Integer
          Public Configuracion As String
          Public NumeroMaximoDeEnviosDeEmailsPorDia As Integer
          Public NumeroMaximoDeEnviosDeEmailsPorHora As Integer
          Public ReferenciaImagenPrevia As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Protocolo As Integer
          Public DescargarCorreosRecibidos As Boolean
          Public ReferenciaServidorEncargado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuertoIMAP As Integer
          Public ServidorIMAP As String
          Public ActivarSSLEnIMAP As Boolean
          Public ReferenciaBuzonPredeterminado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaBuzonPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ResponderA As String
          Public FiltrarEnviadosA As String
          Public DireccionDeEnvioAlias As String
          Public DescargarCorreosEnviados As Boolean
          Public ReferenciaEstadoInicialCorreosEnviados As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEstadoInicialCorreosRecibidos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
