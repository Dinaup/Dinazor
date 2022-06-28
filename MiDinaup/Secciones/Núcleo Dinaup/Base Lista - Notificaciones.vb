Partial Public Class SeccionesD
  Public Class NotificacionesBaseListaD
      Public Shared _SeccionID As String = "19a32369-130c-4447-90df-d0627bbaf087"
      Public Shared _SeccionIDGUID As New Guid("19a32369-130c-4447-90df-d0627bbaf087")
      Public Class NotificacionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("19a32369-130c-4447-90df-d0627bbaf087")
          Public shared _Tabla$ = "tpr_737d4c8xd_e"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_737d524wd"
      Public Shared FechaDato_UTC$ = "pr_737d508wd"
      Public Shared FechaAlta_UTC$ = "pr_737d50cwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_737d504wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_737d52cwd"
      Public Shared ReferenciaDestinador$ = "pr_737d518wd"
      Public Shared HoraLocal$ = "pr_7761204wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_737d4fcwd"
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
      Public Class NotificacionesBaseListaC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
