Partial Public Class SeccionesD
  Public Class ConfiguracionDeSistemaBaseD
      Public Shared _SeccionID As String = "de57325e-dc66-4782-aa5b-18fa69ed6c11"
      Public Shared _SeccionIDGUID As New Guid("de57325e-dc66-4782-aa5b-18fa69ed6c11")
      Public Class ConfiguracionDeSistemaBaseES
          Public shared _SeccionID as Guid = New Guid("de57325e-dc66-4782-aa5b-18fa69ed6c11")
          Public shared _Tabla$ = "tpr_41de99bwc"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149967g39wd"
      Public Shared HoraLocal$ = "pr_776ae72wd"
      Public Shared ReferenciaDestinador$ = "pr_146310522cx110wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310514ex29fwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59300x7fwd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e8f9x1a5wd"
      Public Shared ExportarEnModulos$ = "pr_1463105196g222wd"
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
      Public Class ConfiguracionDeSistemaBaseC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
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
