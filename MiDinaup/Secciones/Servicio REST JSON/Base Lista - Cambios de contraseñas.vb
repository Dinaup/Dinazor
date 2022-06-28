Partial Public Class SeccionesD
  Public Class CambiosDeContraseñasBaseListaD
      Public Shared _SeccionID As String = "e2888bf4-b731-44b1-a1e9-a8575e4f66c1"
      Public Shared _SeccionIDGUID As New Guid("e2888bf4-b731-44b1-a1e9-a8575e4f66c1")
      Public Class CambiosDeContraseñasBaseListaES
          Public shared _SeccionID as Guid = New Guid("e2888bf4-b731-44b1-a1e9-a8575e4f66c1")
          Public shared _Tabla$ = "tpr_60040474803_e"
      Public Shared FechaAlta_UTC$ = "pr_600404748022"
      Public Shared ReferenciaDestinador$ = "pr_600404748023"
      Public Shared FechaDato_UTC$ = "pr_600404748020"
      Public Shared ReferenciaAutorDelAlta$ = "pr_600404748019"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600404748024"
      Public Shared HoraLocal$ = "pr_600404748021"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_600404748025"
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
      Public Class CambiosDeContraseñasBaseListaC
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
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
