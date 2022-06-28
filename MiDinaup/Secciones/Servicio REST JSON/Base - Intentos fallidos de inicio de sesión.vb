Partial Public Class SeccionesD
  Public Class IntentosFallidosDeInicioDeSesionBaseD
      Public Shared _SeccionID As String = "8a8a8ee7-9afc-4fb8-9352-7ced4c71cd2d"
      Public Shared _SeccionIDGUID As New Guid("8a8a8ee7-9afc-4fb8-9352-7ced4c71cd2d")
      Public Class IntentosFallidosDeInicioDeSesionBaseES
          Public shared _SeccionID as Guid = New Guid("8a8a8ee7-9afc-4fb8-9352-7ced4c71cd2d")
          Public shared _Tabla$ = "tpr_10040178401"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040178408"
      Public Shared ReferenciaDestinador$ = "pr_100401784013"
      Public Shared FechaAlta_UTC$ = "pr_100401784012"
      Public Shared HoraLocal$ = "pr_100401784010"
      Public Shared ExportarEnModulos$ = "pr_100401784011"
      Public Shared FechaDato_UTC$ = "pr_10040178409"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401784024"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100401784025"
      Public Shared Usuario$ = "pr_20040178402"
      Public Shared ReferenciaEntidad$ = "pr_20040178401"
      Public Shared EntidadTieneAccesoWeb$ = "pr_20040178403"
      Public Shared DireccionIP$ = "pr_20040178404"
      Public Shared Aplicacion$ = "pr_20040178405"
      Public Shared Navegador$ = "pr_20040178406"
      Public Shared ReferenciaServidor$ = "pr_40040218984"
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
      Public Class IntentosFallidosDeInicioDeSesionBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Usuario As String
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadTieneAccesoWeb As Boolean
          Public DireccionIP As String
          Public Aplicacion As String
          Public Navegador As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
