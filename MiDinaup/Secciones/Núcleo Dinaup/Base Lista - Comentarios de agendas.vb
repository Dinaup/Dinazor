Partial Public Class SeccionesD
  Public Class ComentariosDeAgendasBaseListaD
      Public Shared _SeccionID As String = "fb93a274-57ee-4c32-ae4a-970261e36dab"
      Public Shared _SeccionIDGUID As New Guid("fb93a274-57ee-4c32-ae4a-970261e36dab")
      Public Class ComentariosDeAgendasBaseListaES
          Public shared _SeccionID as Guid = New Guid("fb93a274-57ee-4c32-ae4a-970261e36dab")
          Public shared _Tabla$ = "tpr_7ccd47fxd_e"
      Public Shared ReferenciaDestinador$ = "pr_7ccd4b1wd"
      Public Shared HoraLocal$ = "pr_7ccd4a9wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7ccd4b7wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7ccd4a5wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7ccd4b3wd"
      Public Shared FechaAlta_UTC$ = "pr_7ccd4abwd"
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
      Public Class ComentariosDeAgendasBaseListaC
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
