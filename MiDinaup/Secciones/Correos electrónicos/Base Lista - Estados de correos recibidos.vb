Partial Public Class SeccionesD
  Public Class EstadosDeCorreosRecibidosBaseListaD
      Public Shared _SeccionID As String = "e9935998-9599-4d04-a241-cf2330af82f2"
      Public Shared _SeccionIDGUID As New Guid("e9935998-9599-4d04-a241-cf2330af82f2")
      Public Class EstadosDeCorreosRecibidosBaseListaES
          Public shared _SeccionID as Guid = New Guid("e9935998-9599-4d04-a241-cf2330af82f2")
          Public shared _Tabla$ = "tpr_40040257112_e"
      Public Shared ReferenciaDestinador$ = "pr_400402571127"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400402571123"
      Public Shared HoraLocal$ = "pr_400402571125"
      Public Shared FechaAlta_UTC$ = "pr_400402571126"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400402571128"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_400402571129"
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
      Public Class EstadosDeCorreosRecibidosBaseListaC
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
