Partial Public Class SeccionesD
  Public Class FuncionesJSONBaseListaD
      Public Shared _SeccionID As String = "02f73441-89bb-4f80-a60b-31149fc478a7"
      Public Shared _SeccionIDGUID As New Guid("02f73441-89bb-4f80-a60b-31149fc478a7")
      Public Class FuncionesJSONBaseListaES
          Public shared _SeccionID as Guid = New Guid("02f73441-89bb-4f80-a60b-31149fc478a7")
          Public shared _Tabla$ = "tpr_60040133853_e"
      Public Shared ReferenciaDestinador$ = "pr_600401338512"
      Public Shared FechaAlta_UTC$ = "pr_600401338511"
      Public Shared HoraLocal$ = "pr_600401338510"
      Public Shared ReferenciaAutorDelAlta$ = "pr_60040133858"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600401338528"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_600401338529"
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
      Public Class FuncionesJSONBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
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
