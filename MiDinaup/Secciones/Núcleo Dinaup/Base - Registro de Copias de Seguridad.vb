Partial Public Class SeccionesD
  Public Class RegistroDeCopiasDeSeguridadBaseD
      Public Shared _SeccionID As String = "ee1d2152-21e6-4dd5-ae0a-7fd7dc17ce72"
      Public Shared _SeccionIDGUID As New Guid("ee1d2152-21e6-4dd5-ae0a-7fd7dc17ce72")
      Public Class RegistroDeCopiasDeSeguridadBaseES
          Public shared _SeccionID as Guid = New Guid("ee1d2152-21e6-4dd5-ae0a-7fd7dc17ce72")
          Public shared _Tabla$ = "tpr_10040269571"
      Public Shared ReferenciaDestinador$ = "pr_100402695712"
      Public Shared FechaAlta_UTC$ = "pr_100402695711"
      Public Shared HoraLocal$ = "pr_10040269579"
      Public Shared ExportarEnModulos$ = "pr_100402695710"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040269577"
      Public Shared FechaDato_UTC$ = "pr_10040269578"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402695723"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100402695724"
      Public Shared ExisteArchivo$ = "pr_20040269571"
      Public Shared Ubicacion$ = "pr_20040269572"
      Public Shared ReferenciaServidor$ = "pr_20040269574"
      Public Shared ContieneLosArchivos$ = "pr_30040269571"
      Public Shared ContieneDatos$ = "pr_30040269572"
      Public Shared TiempoEmpleadoEnHacerLaCopiaDeSeguridad$ = "pr_40040269573"
      Public Shared TiempoEmpleadoEnComprimir$ = "pr_40040269574"
      Public Shared TamañoCopia$ = "pr_40040269571"
      Public Shared TamañoCopiaSinComprimir$ = "pr_40040269572"
      Public Shared TiempoEmpleadoEnGuardar$ = "pr_40040269575"
      Public Shared TiempoTotalEmpleado$ = "pr_60040269571"
      Public Shared InformacionAdicional$ = "pr_60040269573"
      Public Shared DinaupVersion$ = "pr_60040269574"
      Public Shared DinaupRevision$ = "pr_60040269575"
      Public Shared TipoDeCopia$ = "pr_20040269586"
      Public Shared SHA1$ = "pr_60040276312"
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
      Public Class RegistroDeCopiasDeSeguridadBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ExisteArchivo As Boolean
          Public Ubicacion As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ContieneLosArchivos As Boolean
          Public ContieneDatos As Boolean
          Public TiempoEmpleadoEnHacerLaCopiaDeSeguridad As Decimal
          Public TiempoEmpleadoEnComprimir As Decimal
          Public TamañoCopia As Decimal
          Public TamañoCopiaSinComprimir As Decimal
          Public TiempoEmpleadoEnGuardar As Decimal
          Public TiempoTotalEmpleado As Decimal
          Public InformacionAdicional As String
          Public DinaupVersion As Integer
          Public DinaupRevision As Integer
          Public TipoDeCopia As Integer
          Public SHA1 As String
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
