Partial Public Class SeccionesD
  Public Class EmpresasAdministradasBaseListaD
      Public Shared _SeccionID As String = "56e93db1-fbc2-4564-83b9-5b644d8da53f"
      Public Shared _SeccionIDGUID As New Guid("56e93db1-fbc2-4564-83b9-5b644d8da53f")
      Public Class EmpresasAdministradasBaseListaES
          Public shared _SeccionID as Guid = New Guid("56e93db1-fbc2-4564-83b9-5b644d8da53f")
          Public shared _Tabla$ = "tpr_30040180812_e"
      Public Shared HoraLocal$ = "pr_30040180811005"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040180811023"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040180811003"
      Public Shared ReferenciaDestinador$ = "pr_30040180811007"
      Public Shared FechaAlta_UTC$ = "pr_30040180811006"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040180811024"
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
      Public Class EmpresasAdministradasBaseListaC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
