Partial Public Class SeccionesD
  Public Class GruposDeEmpleadosBaseListaD
      Public Shared _SeccionID As String = "d1adce2e-abce-4250-8790-ed8f2abcc2a3"
      Public Shared _SeccionIDGUID As New Guid("d1adce2e-abce-4250-8790-ed8f2abcc2a3")
      Public Class GruposDeEmpleadosBaseListaES
          Public shared _SeccionID as Guid = New Guid("d1adce2e-abce-4250-8790-ed8f2abcc2a3")
          Public shared _Tabla$ = "tpr_77c24dcxd_e"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_77c2510wd"
      Public Shared ReferenciaEmpleadoMiembro$ = "pr_79ea8dawd"
      Public Shared ReferenciaDestinador$ = "pr_77c24eewd"
      Public Shared HoraLocal$ = "pr_77c24e6wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_77c24e2wd"
      Public Shared EmpleadoMiembroTieneAccesoWeb$ = "pr_79ea8dcwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_77c2514wd"
      Public Shared FechaAlta_UTC$ = "pr_77c24e8wd"
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
      Public Class GruposDeEmpleadosBaseListaC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoMiembro As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoMiembroTieneAccesoWeb As Boolean
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
