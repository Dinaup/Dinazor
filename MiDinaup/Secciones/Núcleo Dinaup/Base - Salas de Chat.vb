Partial Public Class SeccionesD
  Public Class SalasDeChatBaseD
      Public Shared _SeccionID As String = "e8bb58cb-11a2-4891-a990-cad2fed0b6f2"
      Public Shared _SeccionIDGUID As New Guid("e8bb58cb-11a2-4891-a990-cad2fed0b6f2")
      Public Class SalasDeChatBaseES
          Public shared _SeccionID as Guid = New Guid("e8bb58cb-11a2-4891-a990-cad2fed0b6f2")
          Public shared _Tabla$ = "tpr_4f0f6dfwc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b4264ege0wd"
      Public Shared ReferenciaImagenDeSala$ = "pr_4f0f8bax1a8wc"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b4264ehe0wd"
      Public Shared ReferenciaDestinador$ = "pr_14631071e6x31ewd"
      Public Shared TotalParticipantesEnSala$ = "pr_4f0f9b4x186wc"
      Public Shared ParticipantesFueraDeSala$ = "pr_4f0f9fex383wc"
      Public Shared HoraLocal$ = "pr_776ae32wd"
      Public Shared SalaArchivada$ = "pr_1a01ad7603xfcwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314933dx2acwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14631070b4h371wd"
      Public Shared FechaDato_UTC$ = "pr_14631070b4i371wd"
      Public Shared ExportarEnModulos$ = "pr_146310714ax1b8wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ef0cx38fwd"
      Public Shared TotalParticipantes$ = "pr_4f0f927xbewc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59a53i123wd"
      Public Shared Descripcion$ = "pr_4f0f877x2eewc"
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
      Public Class SalasDeChatBaseC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaImagenDeSala As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TotalParticipantesEnSala As Integer
          Public ParticipantesFueraDeSala As Integer
          Public HoraLocal As Integer
          Public SalaArchivada As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public TotalParticipantes As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Descripcion As String
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
