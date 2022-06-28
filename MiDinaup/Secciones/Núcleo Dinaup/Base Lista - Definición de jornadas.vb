Partial Public Class SeccionesD
  Public Class DefinicionDeJornadasBaseListaD
      Public Shared _SeccionID As String = "605ee753-64fa-4cce-84e3-651382a794db"
      Public Shared _SeccionIDGUID As New Guid("605ee753-64fa-4cce-84e3-651382a794db")
      Public Class DefinicionDeJornadasBaseListaES
          Public shared _SeccionID as Guid = New Guid("605ee753-64fa-4cce-84e3-651382a794db")
          Public shared _Tabla$ = "tpr_7756c5exd_e"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7756c72wd"
      Public Shared FechaAlta_UTC$ = "pr_7756c7awd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7756cbewd"
      Public Shared Hasta$ = "pr_77730f0wd"
      Public Shared Desde$ = "pr_77730eewd"
      Public Shared ReferenciaDestinador$ = "pr_7756c86wd"
      Public Shared HoraLocal$ = "pr_77611d8wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7756cc6wd"
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
      Public Class DefinicionDeJornadasBaseListaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Hasta As Integer
          Public Desde As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
