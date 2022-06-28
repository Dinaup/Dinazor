Partial Public Class SeccionesD
  Public Class DocumentosPrediseñadosBaseListaD
      Public Shared _SeccionID As String = "8f118566-97aa-4678-948d-109f0d68a88a"
      Public Shared _SeccionIDGUID As New Guid("8f118566-97aa-4678-948d-109f0d68a88a")
      Public Class DocumentosPrediseñadosBaseListaES
          Public shared _SeccionID as Guid = New Guid("8f118566-97aa-4678-948d-109f0d68a88a")
          Public shared _Tabla$ = "tpr_50040237495_e"
      Public Shared ReferenciaDestinador$ = "pr_500402374921"
      Public Shared FechaAlta_UTC$ = "pr_500402374920"
      Public Shared HoraLocal$ = "pr_500402374919"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500402374917"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402374922"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500402374923"
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
      Public Class DocumentosPrediseñadosBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
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
