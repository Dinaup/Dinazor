Partial Public Class SeccionesD
  Public Class EstadosDeRegistrosBaseListaD
      Public Shared _SeccionID As String = "613c493a-6280-434f-83bf-6407d316a41c"
      Public Shared _SeccionIDGUID As New Guid("613c493a-6280-434f-83bf-6407d316a41c")
      Public Class EstadosDeRegistrosBaseListaES
          Public shared _SeccionID as Guid = New Guid("613c493a-6280-434f-83bf-6407d316a41c")
          Public shared _Tabla$ = "tpr_50040382151_e"
      Public Shared ReferenciaDestinador$ = "pr_500403821520"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500403821516"
      Public Shared HoraLocal$ = "pr_500403821518"
      Public Shared FechaAlta_UTC$ = "pr_500403821519"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500403821524"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500403821521"
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
      Public Class EstadosDeRegistrosBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
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
