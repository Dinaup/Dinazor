Partial Public Class SeccionesD
  Public Class MotivosDeHorasExtrasBaseListaD
      Public Shared _SeccionID As String = "c32ecdac-7315-49b6-b7ac-3d78ef47fd63"
      Public Shared _SeccionIDGUID As New Guid("c32ecdac-7315-49b6-b7ac-3d78ef47fd63")
      Public Class MotivosDeHorasExtrasBaseListaES
          Public shared _SeccionID as Guid = New Guid("c32ecdac-7315-49b6-b7ac-3d78ef47fd63")
          Public shared _Tabla$ = "tpr_10040212244_e"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100402122441"
      Public Shared FechaAlta_UTC$ = "pr_100402122444"
      Public Shared HoraLocal$ = "pr_100402122443"
      Public Shared ReferenciaDestinador$ = "pr_100402122445"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402122446"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100402122447"
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
      Public Class MotivosDeHorasExtrasBaseListaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
