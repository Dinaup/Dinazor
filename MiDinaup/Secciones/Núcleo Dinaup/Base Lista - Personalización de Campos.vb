Partial Public Class SeccionesD
  Public Class PersonalizacionDeCamposBaseListaD
      Public Shared _SeccionID As String = "e1ebba04-2843-48f0-bbf4-23d2339f5e3a"
      Public Shared _SeccionIDGUID As New Guid("e1ebba04-2843-48f0-bbf4-23d2339f5e3a")
      Public Class PersonalizacionDeCamposBaseListaES
          Public shared _SeccionID as Guid = New Guid("e1ebba04-2843-48f0-bbf4-23d2339f5e3a")
          Public shared _Tabla$ = "tpr_780923cxd_e"
      Public Shared ReferenciaDestinador$ = "pr_7809264wd"
      Public Shared HoraLocal$ = "pr_780925cwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7809270wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7809258wd"
      Public Shared FechaAlta_UTC$ = "pr_780925ewd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7809274wd"
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
      Public Class PersonalizacionDeCamposBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
