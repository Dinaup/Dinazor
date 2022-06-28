Partial Public Class SeccionesD
  Public Class SeccionDePruebasJSONBaseListaD
      Public Shared _SeccionID As String = "227b8254-4581-451b-8c18-e0afb1137467"
      Public Shared _SeccionIDGUID As New Guid("227b8254-4581-451b-8c18-e0afb1137467")
      Public Class SeccionDePruebasJSONBaseListaES
          Public shared _SeccionID as Guid = New Guid("227b8254-4581-451b-8c18-e0afb1137467")
          Public shared _Tabla$ = "tpr_20040140791003_e"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401407917"
      Public Shared ReferenciaDestinador$ = "pr_200401407921"
      Public Shared HoraLocal$ = "pr_200401407919"
      Public Shared FechaAlta_UTC$ = "pr_200401407920"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401407922"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401407923"
      Public Shared ValorDePrueba$ = "pr_40040140796"
      Public Shared IDExterna$ = "pr_30040452011"
      Public Shared FechaModificacionExterna_UTC$ = "pr_30040452013"
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
      Public Class SeccionDePruebasJSONBaseListaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ValorDePrueba As String
          Public IDExterna As Integer
          Public FechaModificacionExterna_UTC As Date
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
