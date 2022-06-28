Partial Public Class SeccionesD
  Public Class CuentasDeCorreoElectronicoBaseListaD
      Public Shared _SeccionID As String = "2c789494-95c4-4eef-bd6f-b3f0251045cc"
      Public Shared _SeccionIDGUID As New Guid("2c789494-95c4-4eef-bd6f-b3f0251045cc")
      Public Class CuentasDeCorreoElectronicoBaseListaES
          Public shared _SeccionID as Guid = New Guid("2c789494-95c4-4eef-bd6f-b3f0251045cc")
          Public shared _Tabla$ = "tpr_30040163371001_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371001"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371003"
      Public Shared FechaAlta_UTC$ = "pr_30040163371006"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371002"
      Public Shared HoraLocal$ = "pr_30040163371005"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371023"
      Public Shared ReferenciaDestinador$ = "pr_30040163371007"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371024"
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
      Public Class CuentasDeCorreoElectronicoBaseListaC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
