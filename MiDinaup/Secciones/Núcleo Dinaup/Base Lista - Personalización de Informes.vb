Partial Public Class SeccionesD
  Public Class PersonalizacionDeInformesBaseListaD
      Public Shared _SeccionID As String = "df45fc82-a042-4a41-aff1-1ea9037cacc3"
      Public Shared _SeccionIDGUID As New Guid("df45fc82-a042-4a41-aff1-1ea9037cacc3")
      Public Class PersonalizacionDeInformesBaseListaES
          Public shared _SeccionID as Guid = New Guid("df45fc82-a042-4a41-aff1-1ea9037cacc3")
          Public shared _Tabla$ = "tpr_78331e0xd_e"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7833214wd"
      Public Shared HoraLocal$ = "pr_78331eawd"
      Public Shared ReferenciaDestinador$ = "pr_78331f2wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_78331e6wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7833218wd"
      Public Shared FechaAlta_UTC$ = "pr_78331ecwd"
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
      Public Class PersonalizacionDeInformesBaseListaC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
