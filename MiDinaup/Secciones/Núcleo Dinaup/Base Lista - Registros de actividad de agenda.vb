Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeAgendaBaseListaD
      Public Shared _SeccionID As String = "d9df88a5-7490-4a6b-9514-b15a756d35c3"
      Public Shared _SeccionIDGUID As New Guid("d9df88a5-7490-4a6b-9514-b15a756d35c3")
      Public Class RegistrosDeActividadDeAgendaBaseListaES
          Public shared _SeccionID as Guid = New Guid("d9df88a5-7490-4a6b-9514-b15a756d35c3")
          Public shared _Tabla$ = "tpr_7c25e52xd_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7c25e74wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7c25e8awd"
      Public Shared HoraLocal$ = "pr_7c25e7cwd"
      Public Shared ReferenciaDestinador$ = "pr_7c25e84wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7c25e78wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7c25e86wd"
      Public Shared FechaDato_UTC$ = "pr_7c25e7awd"
      Public Shared FechaAlta_UTC$ = "pr_7c25e7ewd"
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
      Public Class RegistrosDeActividadDeAgendaBaseListaC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
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
