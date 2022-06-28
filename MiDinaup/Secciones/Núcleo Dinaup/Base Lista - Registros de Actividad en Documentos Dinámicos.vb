Partial Public Class SeccionesD
  Public Class RegistrosDeActividadEnDocumentosDinamicosBaseListaD
      Public Shared _SeccionID As String = "4850cc53-190a-46f0-b5cb-734f6de747e5"
      Public Shared _SeccionIDGUID As New Guid("4850cc53-190a-46f0-b5cb-734f6de747e5")
      Public Class RegistrosDeActividadEnDocumentosDinamicosBaseListaES
          Public shared _SeccionID as Guid = New Guid("4850cc53-190a-46f0-b5cb-734f6de747e5")
          Public shared _Tabla$ = "tpr_60040358903_e"
      Public Shared ReferenciaDestinador$ = "pr_600403589028"
      Public Shared FechaAlta_UTC$ = "pr_600403589027"
      Public Shared FechaDato_UTC$ = "pr_600403589025"
      Public Shared HoraLocal$ = "pr_600403589026"
      Public Shared ReferenciaAutorDelAlta$ = "pr_600403589024"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_600403589022"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600403589029"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_600403589023"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_600403589030"
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
      Public Class RegistrosDeActividadEnDocumentosDinamicosBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
