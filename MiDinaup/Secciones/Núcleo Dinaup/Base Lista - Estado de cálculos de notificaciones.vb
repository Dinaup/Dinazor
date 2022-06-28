Partial Public Class SeccionesD
  Public Class EstadoDeCalculosDeNotificacionesBaseListaD
      Public Shared _SeccionID As String = "f853db28-0485-40df-8857-4c3ab2e4a919"
      Public Shared _SeccionIDGUID As New Guid("f853db28-0485-40df-8857-4c3ab2e4a919")
      Public Class EstadoDeCalculosDeNotificacionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("f853db28-0485-40df-8857-4c3ab2e4a919")
          Public shared _Tabla$ = "tpr_7cc8f45xd_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7cc8f67wd"
      Public Shared ReferenciaDestinador$ = "pr_7cc8f77wd"
      Public Shared HoraLocal$ = "pr_7cc8f6fwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7cc8f7fwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7cc8f6bwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7cc8f7dwd"
      Public Shared FechaAlta_UTC$ = "pr_7cc8f71wd"
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
      Public Shared RelacionElementoContenedorListador$ = "idrelacionlistador"
      Public Shared Listadoreliminado$ = "listadoreliminado"
      End Class
      Public Class EstadoDeCalculosDeNotificacionesBaseListaC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
          Public RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Listadoreliminado As Boolean
          Sub new()
          End Sub
      End Class
  End Class
End Class
