Partial Public Class SeccionesD
  Public Class SincronizacionesRESTBaseListaD
      Public Shared _SeccionID As String = "270550fe-181a-4e90-a6fc-a1d39c0ab591"
      Public Shared _SeccionIDGUID As New Guid("270550fe-181a-4e90-a6fc-a1d39c0ab591")
      Public Class SincronizacionesRESTBaseListaES
          Public shared _SeccionID as Guid = New Guid("270550fe-181a-4e90-a6fc-a1d39c0ab591")
          Public shared _Tabla$ = "tpr_20040450401_e"
      Public Shared ReferenciaDestinador$ = "pr_200404504020"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200404504016"
      Public Shared FechaAlta_UTC$ = "pr_200404504019"
      Public Shared HoraLocal$ = "pr_200404504018"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200404504021"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200404504022"
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
      Public Class SincronizacionesRESTBaseListaC
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
