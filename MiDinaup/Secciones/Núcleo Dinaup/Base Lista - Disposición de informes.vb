﻿Partial Public Class SeccionesD
  Public Class DisposicionDeInformesBaseListaD
      Public Shared _SeccionID As String = "096d87a2-52f1-4c92-b5dc-f20ee44559e1"
      Public Shared _SeccionIDGUID As New Guid("096d87a2-52f1-4c92-b5dc-f20ee44559e1")
      Public Class DisposicionDeInformesBaseListaES
          Public shared _SeccionID as Guid = New Guid("096d87a2-52f1-4c92-b5dc-f20ee44559e1")
          Public shared _Tabla$ = "tpr_10040166171_e"
      Public Shared FechaAlta_UTC$ = "pr_100401661719"
      Public Shared ReferenciaDestinador$ = "pr_100401661720"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100401661716"
      Public Shared HoraLocal$ = "pr_100401661718"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401661721"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100401661722"
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
      Public Class DisposicionDeInformesBaseListaC
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
