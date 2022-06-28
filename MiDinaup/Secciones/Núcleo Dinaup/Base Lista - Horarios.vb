Partial Public Class SeccionesD
  Public Class HorariosBaseListaD
      Public Shared _SeccionID As String = "cd8de914-43c4-492e-a984-03bcdfc3fba5"
      Public Shared _SeccionIDGUID As New Guid("cd8de914-43c4-492e-a984-03bcdfc3fba5")
      Public Class HorariosBaseListaES
          Public shared _SeccionID as Guid = New Guid("cd8de914-43c4-492e-a984-03bcdfc3fba5")
          Public shared _Tabla$ = "tpr_6351d72xd_e"
      Public Shared Observaciones$ = "pr_7772a97wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_183f7cdcfax30awd"
      Public Shared HoraLocal$ = "pr_776aeb2wd"
      Public Shared ReferenciaDestinador$ = "pr_183f7b1776x219wd"
      Public Shared ReferenciaJornada$ = "pr_7772a91wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_183f7b1731x1d7wd"
      Public Shared DiaDeLaSemana$ = "pr_7772a8fwd"
      Public Shared FechaAlta_UTC$ = "pr_183f7b1744x3dewd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_191d9b575ex1c2wd"
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
      Public Class HorariosBaseListaC
          Public Observaciones As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DiaDeLaSemana As Integer
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
