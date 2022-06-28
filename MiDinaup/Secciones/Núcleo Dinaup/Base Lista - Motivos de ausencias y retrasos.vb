Partial Public Class SeccionesD
  Public Class MotivosDeAusenciasYRetrasosBaseListaD
      Public Shared _SeccionID As String = "2b4cc994-b07d-4e7c-b914-426fdf9d4975"
      Public Shared _SeccionIDGUID As New Guid("2b4cc994-b07d-4e7c-b914-426fdf9d4975")
      Public Class MotivosDeAusenciasYRetrasosBaseListaES
          Public shared _SeccionID as Guid = New Guid("2b4cc994-b07d-4e7c-b914-426fdf9d4975")
          Public shared _Tabla$ = "tpr_10040212243_e"
      Public Shared ReferenciaDestinador$ = "pr_100402122421"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100402122417"
      Public Shared FechaAlta_UTC$ = "pr_100402122420"
      Public Shared HoraLocal$ = "pr_100402122419"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402122422"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100402122423"
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
      Public Class MotivosDeAusenciasYRetrasosBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
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
