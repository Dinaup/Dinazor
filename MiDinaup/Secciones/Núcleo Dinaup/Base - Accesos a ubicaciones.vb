Partial Public Class SeccionesD
  Public Class AccesosAUbicacionesBaseD
      Public Shared _SeccionID As String = "4661d9eb-7888-4747-b096-04ff049775ff"
      Public Shared _SeccionIDGUID As New Guid("4661d9eb-7888-4747-b096-04ff049775ff")
      Public Class AccesosAUbicacionesBaseES
          Public shared _SeccionID as Guid = New Guid("4661d9eb-7888-4747-b096-04ff049775ff")
          Public shared _Tabla$ = "tpr_30040480302"
      Public Shared FechaAlta_UTC$ = "pr_30040480301013"
      Public Shared ReferenciaDestinador$ = "pr_30040480301014"
      Public Shared ExportarEnModulos$ = "pr_30040480301012"
      Public Shared HoraLocal$ = "pr_30040480301011"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040480301009"
      Public Shared FechaDato_UTC$ = "pr_30040480301010"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040480301007"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040480301025"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040480301008"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040480301026"
      Public Shared PermisoValidoDesde_UTC$ = "pr_20040480312"
      Public Shared PermisoValidoHasta_UTC$ = "pr_20040480313"
      Public Shared Vigente$ = "pr_20040480316"
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
      Public Class AccesosAUbicacionesBaseC
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public PermisoValidoDesde_UTC As Date
          Public PermisoValidoHasta_UTC As Date
          Public Vigente As Boolean
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
