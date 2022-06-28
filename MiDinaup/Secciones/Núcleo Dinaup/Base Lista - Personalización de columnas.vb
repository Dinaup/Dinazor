Partial Public Class SeccionesD
  Public Class PersonalizacionDeColumnasBaseListaD
      Public Shared _SeccionID As String = "1a51d849-0260-469a-b18d-5ab90156bf99"
      Public Shared _SeccionIDGUID As New Guid("1a51d849-0260-469a-b18d-5ab90156bf99")
      Public Class PersonalizacionDeColumnasBaseListaES
          Public shared _SeccionID as Guid = New Guid("1a51d849-0260-469a-b18d-5ab90156bf99")
          Public shared _Tabla$ = "tpr_7833a70xd_e"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7833aa2wd"
      Public Shared FechaAlta_UTC$ = "pr_7833a9awd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7833a94wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7833aa6wd"
      Public Shared ReferenciaDestinador$ = "pr_7833aa0wd"
      Public Shared HoraLocal$ = "pr_7833a98wd"
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
      Public Class PersonalizacionDeColumnasBaseListaC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
