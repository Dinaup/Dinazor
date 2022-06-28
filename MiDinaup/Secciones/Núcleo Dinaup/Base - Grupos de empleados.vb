Partial Public Class SeccionesD
  Public Class GruposDeEmpleadosBaseD
      Public Shared _SeccionID As String = "b3f5fa0e-3755-43c9-8b55-1c61c26bfcad"
      Public Shared _SeccionIDGUID As New Guid("b3f5fa0e-3755-43c9-8b55-1c61c26bfcad")
      Public Class GruposDeEmpleadosBaseES
          Public shared _SeccionID as Guid = New Guid("b3f5fa0e-3755-43c9-8b55-1c61c26bfcad")
          Public shared _Tabla$ = "tpr_77c24dcxd"
      Public Shared ReferenciaDestinador$ = "pr_77c2508wd"
      Public Shared HoraLocal$ = "pr_77c24fcwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_77c250ewd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_77c2512wd"
      Public Shared FechaAlta_UTC$ = "pr_77c2502wd"
      Public Shared ExportarEnModulos$ = "pr_77c24fewd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_77c24f8wd"
      Public Shared Detalles$ = "pr_300401049510"
      Public Shared CantidadDeMiembros$ = "pr_30040181611"
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
      Public Class GruposDeEmpleadosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Detalles As String
          Public CantidadDeMiembros As Integer
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
