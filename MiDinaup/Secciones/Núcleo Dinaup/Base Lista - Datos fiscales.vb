Partial Public Class SeccionesD
  Public Class DatosFiscalesBaseListaD
      Public Shared _SeccionID As String = "e55c08cf-1390-4777-9b3a-ea307bd0e3ed"
      Public Shared _SeccionIDGUID As New Guid("e55c08cf-1390-4777-9b3a-ea307bd0e3ed")
      Public Class DatosFiscalesBaseListaES
          Public shared _SeccionID as Guid = New Guid("e55c08cf-1390-4777-9b3a-ea307bd0e3ed")
          Public shared _Tabla$ = "tpr_20040138792_e"
      Public Shared ReferenciaDestinador$ = "pr_200401387924"
      Public Shared FechaAlta_UTC$ = "pr_200401387923"
      Public Shared HoraLocal$ = "pr_200401387922"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401387926"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401387925"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401387920"
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
      Public Class DatosFiscalesBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
