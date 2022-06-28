Partial Public Class SeccionesD
  Public Class PermisosPuntualesAInformesBaseListaD
      Public Shared _SeccionID As String = "d8e9f455-5af9-460c-b01a-4821bd7d3ef5"
      Public Shared _SeccionIDGUID As New Guid("d8e9f455-5af9-460c-b01a-4821bd7d3ef5")
      Public Class PermisosPuntualesAInformesBaseListaES
          Public shared _SeccionID as Guid = New Guid("d8e9f455-5af9-460c-b01a-4821bd7d3ef5")
          Public shared _Tabla$ = "tpr_7ac1b8axd_e"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7ac1bc2wd"
      Public Shared ReferenciaDestinador$ = "pr_7ac1bb8wd"
      Public Shared HoraLocal$ = "pr_7ac1bb0wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7ac1bacwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7ac1bbewd"
      Public Shared FechaAlta_UTC$ = "pr_7ac1bb2wd"
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
      Public Class PermisosPuntualesAInformesBaseListaC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
