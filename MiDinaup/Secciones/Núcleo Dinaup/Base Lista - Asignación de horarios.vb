Partial Public Class SeccionesD
  Public Class AsignacionDeHorariosBaseListaD
      Public Shared _SeccionID As String = "ae52d5d9-f35c-46b3-ae87-a4daacc1c704"
      Public Shared _SeccionIDGUID As New Guid("ae52d5d9-f35c-46b3-ae87-a4daacc1c704")
      Public Class AsignacionDeHorariosBaseListaES
          Public shared _SeccionID as Guid = New Guid("ae52d5d9-f35c-46b3-ae87-a4daacc1c704")
          Public shared _Tabla$ = "tpr_20040102881_e"
      Public Shared HoraLocal$ = "pr_200401028821"
      Public Shared ReferenciaDestinador$ = "pr_200401028825"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401028829"
      Public Shared FechaAlta_UTC$ = "pr_200401028822"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401028827"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401028819"
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
      Public Class AsignacionDeHorariosBaseListaC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
