﻿Partial Public Class SeccionesD
  Public Class BuzonesDeCorreoBaseListaD
      Public Shared _SeccionID As String = "d0c829e1-5831-439b-b9b8-487c67f5503c"
      Public Shared _SeccionIDGUID As New Guid("d0c829e1-5831-439b-b9b8-487c67f5503c")
      Public Class BuzonesDeCorreoBaseListaES
          Public shared _SeccionID as Guid = New Guid("d0c829e1-5831-439b-b9b8-487c67f5503c")
          Public shared _Tabla$ = "tpr_50040257403_e"
      Public Shared ReferenciaDestinador$ = "pr_500402574024"
      Public Shared FechaAlta_UTC$ = "pr_500402574023"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500402574020"
      Public Shared HoraLocal$ = "pr_500402574022"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402574025"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500402574026"
      Public Shared ReferenciaEmpleadoConAcceso$ = "pr_60040257415"
      Public Shared EmpleadoConAccesoTieneAccesoWeb$ = "pr_60040257416"
      Public Shared PuedeLeer$ = "pr_10040257421"
      Public Shared PuedeEnviar$ = "pr_10040257422"
      Public Shared ReferenciaCuentaDeCorreo$ = "pr_20040452586"
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
      Public Class BuzonesDeCorreoBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoConAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoConAccesoTieneAccesoWeb As Boolean
          Public PuedeLeer As Boolean
          Public PuedeEnviar As Boolean
          Public ReferenciaCuentaDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
