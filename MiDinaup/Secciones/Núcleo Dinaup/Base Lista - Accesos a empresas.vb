Partial Public Class SeccionesD
  Public Class AccesosAEmpresasBaseListaD
      Public Shared _SeccionID As String = "a45a524c-299e-40d0-9d75-cded3d1f0776"
      Public Shared _SeccionIDGUID As New Guid("a45a524c-299e-40d0-9d75-cded3d1f0776")
      Public Class AccesosAEmpresasBaseListaES
          Public shared _SeccionID as Guid = New Guid("a45a524c-299e-40d0-9d75-cded3d1f0776")
          Public shared _Tabla$ = "tpr_50040291741_e"
      Public Shared FechaAlta_UTC$ = "pr_500402917419"
      Public Shared HoraLocal$ = "pr_500402917418"
      Public Shared ReferenciaDestinador$ = "pr_500402917420"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500402917416"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_500402917414"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402917421"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500402917422"
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
      Public Class AccesosAEmpresasBaseListaC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
