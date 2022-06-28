Partial Public Class SeccionesD
  Public Class CuentasCreadasRemotamenteBaseListaD
      Public Shared _SeccionID As String = "cd12814d-c1fa-44e4-a619-7272b3032392"
      Public Shared _SeccionIDGUID As New Guid("cd12814d-c1fa-44e4-a619-7272b3032392")
      Public Class CuentasCreadasRemotamenteBaseListaES
          Public shared _SeccionID as Guid = New Guid("cd12814d-c1fa-44e4-a619-7272b3032392")
          Public shared _Tabla$ = "tpr_50040480343_e"
      Public Shared ReferenciaDestinador$ = "pr_500404803424"
      Public Shared FechaAlta_UTC$ = "pr_500404803423"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500404803420"
      Public Shared HoraLocal$ = "pr_500404803422"
      Public Shared FechaDato_UTC$ = "pr_500404803421"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500404803425"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500404803426"
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
      Public Class CuentasCreadasRemotamenteBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
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
