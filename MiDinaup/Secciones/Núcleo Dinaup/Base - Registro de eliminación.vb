Partial Public Class SeccionesD
  Public Class RegistroDeEliminacionBaseD
      Public Shared _SeccionID As String = "ecea0569-3c97-4e43-ad12-2fc75e554986"
      Public Shared _SeccionIDGUID As New Guid("ecea0569-3c97-4e43-ad12-2fc75e554986")
      Public Class RegistroDeEliminacionBaseES
          Public shared _SeccionID as Guid = New Guid("ecea0569-3c97-4e43-ad12-2fc75e554986")
          Public shared _Tabla$ = "tpr_40a2d01wc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b4282dx21fwd"
      Public Shared TipoDeAccion$ = "pr_7c20d03wd"
      Public Shared ReferenciaRegistroDeAcceso$ = "pr_185b356df1x299wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42855x76wd"
      Public Shared HoraLocal$ = "pr_776ae2awd"
      Public Shared ReferenciaDestinador$ = "pr_146310770cx134wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149084hb3wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463107650x3c2wd"
      Public Shared ReferenciaSeccion$ = "pr_40a655fx2wc"
      Public Shared FechaDato_UTC$ = "pr_1463107681x368wd"
      Public Shared ExportarEnModulos$ = "pr_146310769dx16ewd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3f003x288wd"
      Public Shared ReferenciaElemento$ = "pr_40a65b6xa2wc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b597f5g348wd"
      Public Shared NombreDato$ = "pr_4713bdex307wc"
      Public Shared ReferenciaServidor$ = "pr_50040212261"
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
      End Class
      Public Class RegistroDeEliminacionBaseC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoDeAccion As Integer
          Public ReferenciaRegistroDeAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public NombreDato As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
          Sub new()
          End Sub
      End Class
  End Class
End Class
