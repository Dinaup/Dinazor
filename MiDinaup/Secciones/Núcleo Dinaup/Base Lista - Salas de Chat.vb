Partial Public Class SeccionesD
  Public Class SalasDeChatBaseListaD
      Public Shared _SeccionID As String = "086a2714-af6d-4a1b-82b8-a1dfacda99f2"
      Public Shared _SeccionIDGUID As New Guid("086a2714-af6d-4a1b-82b8-a1dfacda99f2")
      Public Class SalasDeChatBaseListaES
          Public shared _SeccionID as Guid = New Guid("086a2714-af6d-4a1b-82b8-a1dfacda99f2")
          Public shared _Tabla$ = "tpr_4f0f6dfwc_e"
      Public Shared FechaDato_UTC$ = "pr_14630fb30ex36cwd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3d368x83wd"
      Public Shared RecibidoHastaObsoleto_UTC$ = "pr_4f105e9x2edwc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59f4dgbdwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fb2e2x342wd"
      Public Shared ParticipanteTieneAccesoWeb$ = "pr_146310df5cx25wd"
      Public Shared PuedeAgregarParticipantes$ = "pr_4f1030ex252wc"
      Public Shared ReferenciaParticipante$ = "pr_4f1001dx1e1wc"
      Public Shared PuedeSilenciarLaSala$ = "pr_1a195e534fx1bwd"
      Public Shared PuedeEnviarMensajes$ = "pr_1a01911320x30bwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314aeb7x5dwd"
      Public Shared PuedeGestionarMensajesOcultos$ = "pr_1a1eee7cadx308wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b3f1dag29fwd"
      Public Shared PuedeExpulsarAParticipantes$ = "pr_4f10360x25fwc"
      Public Shared DentroDeSala$ = "pr_4f0ff21x26ewc"
      Public Shared ReferenciaDestinador$ = "pr_14630fb38bx91wd"
      Public Shared HoraLocal$ = "pr_776af3awd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b3f1dax29fwd"
      Public Shared MensajesVisibleDesde_UTC$ = "pr_70ee28fwd"
      Public Shared MensajesVisiblesDesdeObsoleto_UTC$ = "pr_1a01934f88x3b0wd"
      Public Shared PuedePersonalizarLaSala$ = "pr_4f1042fx341wc"
      Public Shared LeidoHastaObsoleto_UTC$ = "pr_4f10656x257wc"
      Public Shared PuedeModificarPermisosDeOtrosParticipantes$ = "pr_4f104d2x7awc"
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
      Public Class SalasDeChatBaseListaC
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public RecibidoHastaObsoleto_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ParticipanteTieneAccesoWeb As Boolean
          Public PuedeAgregarParticipantes As Boolean
          Public ReferenciaParticipante As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuedeSilenciarLaSala As Boolean
          Public PuedeEnviarMensajes As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public PuedeGestionarMensajesOcultos As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuedeExpulsarAParticipantes As Boolean
          Public DentroDeSala As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MensajesVisibleDesde_UTC As Date
          Public MensajesVisiblesDesdeObsoleto_UTC As Date
          Public PuedePersonalizarLaSala As Boolean
          Public LeidoHastaObsoleto_UTC As Date
          Public PuedeModificarPermisosDeOtrosParticipantes As Boolean
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
