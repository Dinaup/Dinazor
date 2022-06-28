Partial Public Class SeccionesD
  Public Class IntentosFallidosDeInicioDeSesionBaseListaD
      Public Shared _SeccionID As String = "54f620b4-57d0-4b7c-b7b4-3a9d7c28879d"
      Public Shared _SeccionIDGUID As New Guid("54f620b4-57d0-4b7c-b7b4-3a9d7c28879d")
      Public Class IntentosFallidosDeInicioDeSesionBaseListaES
          Public shared _SeccionID as Guid = New Guid("54f620b4-57d0-4b7c-b7b4-3a9d7c28879d")
          Public shared _Tabla$ = "tpr_10040178401_e"
      Public Shared HoraLocal$ = "pr_100401784019"
      Public Shared FechaAlta_UTC$ = "pr_100401784020"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100401784017"
      Public Shared FechaDato_UTC$ = "pr_100401784018"
      Public Shared ReferenciaDestinador$ = "pr_100401784021"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100401784023"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401784022"
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
      Public Class IntentosFallidosDeInicioDeSesionBaseListaC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
