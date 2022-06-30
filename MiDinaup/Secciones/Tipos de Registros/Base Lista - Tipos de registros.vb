Partial Public Class SeccionesD
  Public Class TiposDeRegistrosBaseListaD
      Public Shared _SeccionID As String = "771f838a-7195-47bf-9918-28f1f0f0a06b"
      Public Shared _SeccionIDGUID As New Guid("771f838a-7195-47bf-9918-28f1f0f0a06b")
      Public Class TiposDeRegistrosBaseListaES
          Public shared _SeccionID as Guid = New Guid("771f838a-7195-47bf-9918-28f1f0f0a06b")
          Public shared _Tabla$ = "tpr_50010427301_e"
      Public Shared HoraLocal$ = "pr_500104273020"
      Public Shared ReferenciaDestinador$ = "pr_500104273022"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500104273018"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500104273023"
      Public Shared FechaAlta_UTC$ = "pr_500104273021"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500104273024"
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
      Public Class TiposDeRegistrosBaseListaC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
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
