Partial Public Class SeccionesD
  Public Class EstadoDeCalculosDeNotificacionesBaseD
      Public Shared _SeccionID As String = "4dfcdaaa-258f-4ad7-8841-9787ad0e2182"
      Public Shared _SeccionIDGUID As New Guid("4dfcdaaa-258f-4ad7-8841-9787ad0e2182")
      Public Class EstadoDeCalculosDeNotificacionesBaseES
          Public shared _SeccionID as Guid = New Guid("4dfcdaaa-258f-4ad7-8841-9787ad0e2182")
          Public shared _Tabla$ = "tpr_7cc8f45xd"
      Public Shared FechaDeUltimoCalculo_UTC$ = "pr_7ccad27wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7cc8f4fwd"
      Public Shared ExportarEnModulos$ = "pr_7cc8f55wd"
      Public Shared FechaAlta_UTC$ = "pr_7cc8f5bwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7cc8f7bwd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7cc8f4bwd"
      Public Shared ReferenciaConfiguracionDeNotificacion$ = "pr_7ccad29wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7cc8f79wd"
      Public Shared HoraLocal$ = "pr_7cc8f53wd"
      Public Shared ReferenciaDestinador$ = "pr_7cc8f61wd"
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
      Public Class EstadoDeCalculosDeNotificacionesBaseC
          Public FechaDeUltimoCalculo_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaConfiguracionDeNotificacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
