Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeArchivosBaseD
      Public Shared _SeccionID As String = "4d6d2d8f-6215-4604-acbb-31bd0707db4d"
      Public Shared _SeccionIDGUID As New Guid("4d6d2d8f-6215-4604-acbb-31bd0707db4d")
      Public Class RegistrosDeActividadDeArchivosBaseES
          Public shared _SeccionID as Guid = New Guid("4d6d2d8f-6215-4604-acbb-31bd0707db4d")
          Public shared _Tabla$ = "tpr_76da49fxd"
      Public Shared FinalizacionInesperada$ = "pr_7c4970dwd"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_7c28350wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_76da4d3wd"
      Public Shared TipoDeEvento$ = "pr_7c34961wd"
      Public Shared ReferenciaRegistrosOrigenAcceso$ = "pr_7c28352wd"
      Public Shared SegundosAbierto$ = "pr_7c49e3bwd"
      Public Shared FechaDato_UTC$ = "pr_76da4d7wd"
      Public Shared ExportarEnModulos$ = "pr_76da4dbwd"
      Public Shared FechaAlta_UTC$ = "pr_76da4e3wd"
      Public Shared TiempoEjecucion$ = "pr_7c4970bwd"
      Public Shared VecesFoco$ = "pr_7c49e37wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_76da4ffwd"
      Public Shared SegundosActividad$ = "pr_7c49e39wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_76da4cbwd"
      Public Shared ReferenciaArchivo$ = "pr_76df4cbwd"
      Public Shared NombreDeRegistroDeOrigen$ = "pr_7c28356wd"
      Public Shared DuracionTransferenciaDeDatos$ = "pr_7c343aewd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_76da507wd"
      Public Shared ReferenciaRegistroOrigenAccesoSeccion$ = "pr_7c28354wd"
      Public Shared TransferenciaDeDatosKBs$ = "pr_7c343b0wd"
      Public Shared HoraLocal$ = "pr_77611e4wd"
      Public Shared ReferenciaDestinador$ = "pr_76da4efwd"
      Public Shared ReferenciaServidor$ = "pr_60040212261"
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
      Public Class RegistrosDeActividadDeArchivosBaseC
          Public FinalizacionInesperada As Boolean
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoDeEvento As Integer
          Public ReferenciaRegistrosOrigenAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public SegundosAbierto As Integer
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public TiempoEjecucion As Decimal
          Public VecesFoco As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public SegundosActividad As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaArchivo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NombreDeRegistroDeOrigen As String
          Public DuracionTransferenciaDeDatos As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaRegistroOrigenAccesoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TransferenciaDeDatosKBs As Decimal
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
