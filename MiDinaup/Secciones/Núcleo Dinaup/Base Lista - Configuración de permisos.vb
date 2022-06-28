﻿Partial Public Class SeccionesD
  Public Class ConfiguracionDePermisosBaseListaD
      Public Shared _SeccionID As String = "122e5aed-dbb7-4cd5-9714-240ffa4de2f8"
      Public Shared _SeccionIDGUID As New Guid("122e5aed-dbb7-4cd5-9714-240ffa4de2f8")
      Public Class ConfiguracionDePermisosBaseListaES
          Public shared _SeccionID as Guid = New Guid("122e5aed-dbb7-4cd5-9714-240ffa4de2f8")
          Public shared _Tabla$ = "tpr_20040110491_e"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401104923"
      Public Shared FechaAlta_UTC$ = "pr_20040110498"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040110495"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401104922"
      Public Shared ReferenciaDestinador$ = "pr_20040110499"
      Public Shared HoraLocal$ = "pr_20040110497"
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
      Public Class ConfiguracionDePermisosBaseListaC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
