Partial Public Class SeccionesD
  Public Class IndiceDeFuerasDeHorarioBaseListaD
      Public Shared _SeccionID As String = "dc5f2700-ae0b-4000-a292-982ceb3bdc65"
      Public Shared _SeccionIDGUID As New Guid("dc5f2700-ae0b-4000-a292-982ceb3bdc65")
      Public Class IndiceDeFuerasDeHorarioBaseListaES
          Public shared _SeccionID as Guid = New Guid("dc5f2700-ae0b-4000-a292-982ceb3bdc65")
          Public shared _Tabla$ = "tpr_7b8b167xd_e"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7b8b19fwd"
      Public Shared HoraLocal$ = "pr_7b8b18dwd"
      Public Shared ReferenciaDestinador$ = "pr_7b8b195wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7b8b189wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7b8b19bwd"
      Public Shared FechaAlta_UTC$ = "pr_7b8b18fwd"
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
      Public Class IndiceDeFuerasDeHorarioBaseListaC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
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
