Partial Public Class SeccionesD
  Public Class PermisosPuntualesAInformesBaseD
      Public Shared _SeccionID As String = "7aebe829-9c5a-4dbc-a816-6115079b7527"
      Public Shared _SeccionIDGUID As New Guid("7aebe829-9c5a-4dbc-a816-6115079b7527")
      Public Class PermisosPuntualesAInformesBaseES
          Public shared _SeccionID as Guid = New Guid("7aebe829-9c5a-4dbc-a816-6115079b7527")
          Public shared _Tabla$ = "tpr_7ac1b8axd"
      Public Shared Informes$ = "pr_7ac1e98wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7ac1b94wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7ac1bc4wd"
      Public Shared FechaAlta_UTC$ = "pr_7ac1ba0wd"
      Public Shared ExportarEnModulos$ = "pr_7ac1b9awd"
      Public Shared FechaDeInicio_UTC$ = "pr_30040104951"
      Public Shared Observaciones$ = "pr_30040104956"
      Public Shared ReferenciaDestinador$ = "pr_7ac1ba6wd"
      Public Shared HoraLocal$ = "pr_7ac1b98wd"
      Public Shared FechaDeFin_UTC$ = "pr_30040104952"
      Public Shared EmpleadosPermiso$ = "pr_7ac1e96wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7ac1bc0wd"
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
      Public Class PermisosPuntualesAInformesBaseC
          Public Informes As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public FechaDeInicio_UTC As Date
          Public Observaciones As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaDeFin_UTC As Date
          Public EmpleadosPermiso As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
