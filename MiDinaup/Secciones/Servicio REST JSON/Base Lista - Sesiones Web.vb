﻿Partial Public Class SeccionesD
  Public Class SesionesWebBaseListaD
      Public Shared _SeccionID As String = "a8b09778-9f84-4172-b193-2ddc87cf3d5d"
      Public Shared _SeccionIDGUID As New Guid("a8b09778-9f84-4172-b193-2ddc87cf3d5d")
      Public Class SesionesWebBaseListaES
          Public shared _SeccionID as Guid = New Guid("a8b09778-9f84-4172-b193-2ddc87cf3d5d")
          Public shared _Tabla$ = "tpr_50040177761_e"
      Public Shared ReferenciaDestinador$ = "pr_500401777620"
      Public Shared FechaAlta_UTC$ = "pr_500401777619"
      Public Shared HoraLocal$ = "pr_500401777618"
      Public Shared FechaDato_UTC$ = "pr_500401777617"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500401777616"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401777621"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500401777622"
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
      Public Class SesionesWebBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
