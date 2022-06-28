Partial Public Class SeccionesD
  Public Class PermisosPuntualesAPlantillasDeImpresionBaseListaD
      Public Shared _SeccionID As String = "aab68b21-624c-402f-8c50-1265dbbfa66a"
      Public Shared _SeccionIDGUID As New Guid("aab68b21-624c-402f-8c50-1265dbbfa66a")
      Public Class PermisosPuntualesAPlantillasDeImpresionBaseListaES
          Public shared _SeccionID as Guid = New Guid("aab68b21-624c-402f-8c50-1265dbbfa66a")
          Public shared _Tabla$ = "tpr_40040108252_e"
      Public Shared ReferenciaDestinador$ = "pr_400401082551"
      Public Shared HoraLocal$ = "pr_400401082549"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400401082554"
      Public Shared FechaAlta_UTC$ = "pr_400401082550"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_400401082553"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400401082547"
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
      Public Class PermisosPuntualesAPlantillasDeImpresionBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
