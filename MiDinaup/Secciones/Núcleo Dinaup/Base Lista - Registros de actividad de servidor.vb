﻿Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeServidorBaseListaD
      Public Shared _SeccionID As String = "e6616056-4c4f-4c33-ab2c-2daf0347ea21"
      Public Shared _SeccionIDGUID As New Guid("e6616056-4c4f-4c33-ab2c-2daf0347ea21")
      Public Class RegistrosDeActividadDeServidorBaseListaES
          Public shared _SeccionID as Guid = New Guid("e6616056-4c4f-4c33-ab2c-2daf0347ea21")
          Public shared _Tabla$ = "tpr_70b1f89xd_e"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_70b1fc1wd"
      Public Shared FechaDato_UTC$ = "pr_70b1fc9wd"
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
      Public Class RegistrosDeActividadDeServidorBaseListaC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
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
