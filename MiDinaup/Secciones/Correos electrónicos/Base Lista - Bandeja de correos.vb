Partial Public Class SeccionesD
  Public Class BandejaDeCorreosBaseListaD
      Public Shared _SeccionID As String = "cf8df0d6-b719-449b-b1c6-ff9e60f469cd"
      Public Shared _SeccionIDGUID As New Guid("cf8df0d6-b719-449b-b1c6-ff9e60f469cd")
      Public Class BandejaDeCorreosBaseListaES
          Public shared _SeccionID as Guid = New Guid("cf8df0d6-b719-449b-b1c6-ff9e60f469cd")
          Public shared _Tabla$ = "tpr_20040257111_e"
      Public Shared ReferenciaDestinador$ = "pr_200402571122"
      Public Shared HoraLocal$ = "pr_200402571120"
      Public Shared FechaDato_UTC$ = "pr_200402571119"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200402571118"
      Public Shared FechaAlta_UTC$ = "pr_200402571121"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200402571123"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200402571124"
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
      Public Class BandejaDeCorreosBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
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
