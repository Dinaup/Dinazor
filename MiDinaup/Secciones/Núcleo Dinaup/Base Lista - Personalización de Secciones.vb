Partial Public Class SeccionesD
  Public Class PersonalizacionDeSeccionesBaseListaD
      Public Shared _SeccionID As String = "1e129d33-0cc0-4a41-905c-ad9a27384165"
      Public Shared _SeccionIDGUID As New Guid("1e129d33-0cc0-4a41-905c-ad9a27384165")
      Public Class PersonalizacionDeSeccionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("1e129d33-0cc0-4a41-905c-ad9a27384165")
          Public shared _Tabla$ = "tpr_7808436xd_e"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7808468wd"
      Public Shared FechaAlta_UTC$ = "pr_7808460wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_780845awd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_780846cwd"
      Public Shared HoraLocal$ = "pr_780845ewd"
      Public Shared ReferenciaDestinador$ = "pr_7808466wd"
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
      Public Class PersonalizacionDeSeccionesBaseListaC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
