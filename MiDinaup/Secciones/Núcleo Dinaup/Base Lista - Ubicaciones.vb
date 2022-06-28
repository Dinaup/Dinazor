Partial Public Class SeccionesD
  Public Class UbicacionesBaseListaD
      Public Shared _SeccionID As String = "d8104805-6e4a-4929-833f-eada15b873db"
      Public Shared _SeccionIDGUID As New Guid("d8104805-6e4a-4929-833f-eada15b873db")
      Public Class UbicacionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("d8104805-6e4a-4929-833f-eada15b873db")
          Public shared _Tabla$ = "tpr_1549n_e"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149f51x263wd"
      Public Shared ReferenciaDestinador$ = "pr_14631041dbx209wd"
      Public Shared HoraLocal$ = "pr_776ae92wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463104125g3bcwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59c24x2e0wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e664x314wd"
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
      Public Class UbicacionesBaseListaC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
