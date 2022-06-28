Partial Public Class SeccionesD
  Public Class IntervaloBaseListaD
      Public Shared _SeccionID As String = "f8370aef-c771-437d-9e90-7b751034dffd"
      Public Shared _SeccionIDGUID As New Guid("f8370aef-c771-437d-9e90-7b751034dffd")
      Public Class IntervaloBaseListaES
          Public shared _SeccionID as Guid = New Guid("f8370aef-c771-437d-9e90-7b751034dffd")
          Public shared _Tabla$ = "tpr_60040131551001_e"
      Public Shared HoraLocal$ = "pr_60040131551005"
      Public Shared FechaAlta_UTC$ = "pr_60040131551006"
      Public Shared ReferenciaDestinador$ = "pr_60040131551007"
      Public Shared ReferenciaAutorDelAlta$ = "pr_60040131551003"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_60040131551023"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_60040131551024"
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
      Public Class IntervaloBaseListaC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
