Partial Public Class SeccionesD
  Public Class EnumeracionesNativasBaseListaD
      Public Shared _SeccionID As String = "209d0ce4-9b1d-4404-9625-ac6876f64420"
      Public Shared _SeccionIDGUID As New Guid("209d0ce4-9b1d-4404-9625-ac6876f64420")
      Public Class EnumeracionesNativasBaseListaES
          Public shared _SeccionID as Guid = New Guid("209d0ce4-9b1d-4404-9625-ac6876f64420")
          Public shared _Tabla$ = "tpr_40040447692_e"
      Public Shared FechaAlta_UTC$ = "pr_400404476920"
      Public Shared HoraLocal$ = "pr_400404476919"
      Public Shared ReferenciaDestinador$ = "pr_400404476921"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400404476917"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400404476922"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_400404476923"
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
      Public Class EnumeracionesNativasBaseListaC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
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
