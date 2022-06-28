Partial Public Class SeccionesD
  Public Class IndiceDeEventosDeAgendaBaseListaD
      Public Shared _SeccionID As String = "82f567d9-f20c-41d6-aec6-288488a8f919"
      Public Shared _SeccionIDGUID As New Guid("82f567d9-f20c-41d6-aec6-288488a8f919")
      Public Class IndiceDeEventosDeAgendaBaseListaES
          Public shared _SeccionID as Guid = New Guid("82f567d9-f20c-41d6-aec6-288488a8f919")
          Public shared _Tabla$ = "tpr_7795877xd_e"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_77958a9wd"
      Public Shared ReferenciaDestinador$ = "pr_779588dwd"
      Public Shared HoraLocal$ = "pr_7795885wd"
      Public Shared FechaAlta_UTC$ = "pr_7795887wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_77958adwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7795881wd"
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
      Public Class IndiceDeEventosDeAgendaBaseListaC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
