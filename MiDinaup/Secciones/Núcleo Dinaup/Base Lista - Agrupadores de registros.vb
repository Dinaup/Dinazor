Partial Public Class SeccionesD
  Public Class AgrupadoresDeRegistrosBaseListaD
      Public Shared _SeccionID As String = "7824657d-c66f-488c-9cea-38e5962402ff"
      Public Shared _SeccionIDGUID As New Guid("7824657d-c66f-488c-9cea-38e5962402ff")
      Public Class AgrupadoresDeRegistrosBaseListaES
          Public shared _SeccionID as Guid = New Guid("7824657d-c66f-488c-9cea-38e5962402ff")
          Public shared _Tabla$ = "tpr_7795803xd_e"
      Public Shared ReferenciaAutorDelAlta$ = "pr_779581fwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7795837wd"
      Public Shared FechaAlta_UTC$ = "pr_7795825wd"
      Public Shared ReferenciaDestinador$ = "pr_779582bwd"
      Public Shared HoraLocal$ = "pr_7795823wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_779583bwd"
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
      Public Class AgrupadoresDeRegistrosBaseListaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
