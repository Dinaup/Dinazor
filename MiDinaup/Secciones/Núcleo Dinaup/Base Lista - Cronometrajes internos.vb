Partial Public Class SeccionesD
  Public Class CronometrajesInternosBaseListaD
      Public Shared _SeccionID As String = "30853e83-997a-4b31-911b-d1d502d8c46e"
      Public Shared _SeccionIDGUID As New Guid("30853e83-997a-4b31-911b-d1d502d8c46e")
      Public Class CronometrajesInternosBaseListaES
          Public shared _SeccionID as Guid = New Guid("30853e83-997a-4b31-911b-d1d502d8c46e")
          Public shared _Tabla$ = "tpr_30040429686_e"
      Public Shared ReferenciaDestinador$ = "pr_300404296834"
      Public Shared HoraLocal$ = "pr_300404296832"
      Public Shared ReferenciaAutorDelAlta$ = "pr_300404296830"
      Public Shared FechaAlta_UTC$ = "pr_300404296833"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300404296835"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_300404296836"
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
      Public Class CronometrajesInternosBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
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
