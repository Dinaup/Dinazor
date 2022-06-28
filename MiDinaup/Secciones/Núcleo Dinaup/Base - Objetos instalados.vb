Partial Public Class SeccionesD
  Public Class ObjetosInstaladosBaseD
      Public Shared _SeccionID As String = "7648f10f-cfeb-476e-bce5-1edb011a33fd"
      Public Shared _SeccionIDGUID As New Guid("7648f10f-cfeb-476e-bce5-1edb011a33fd")
      Public Class ObjetosInstaladosBaseES
          Public shared _SeccionID as Guid = New Guid("7648f10f-cfeb-476e-bce5-1edb011a33fd")
          Public shared _Tabla$ = "tpr_20040198072"
      Public Shared ReferenciaObjetoSeccion$ = "pr_200401980758"
      Public Shared ObjetoIDNube$ = "pr_200401980757"
      Public Shared ReferenciaObjeto$ = "pr_30040198071"
      Public Shared ReferenciaDestinador$ = "pr_200401980742"
      Public Shared FechaAlta_UTC$ = "pr_200401980741"
      Public Shared ExportarEnModulos$ = "pr_200401980740"
      Public Shared HoraLocal$ = "pr_200401980739"
      Public Shared FechaDato_UTC$ = "pr_200401980738"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401980737"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401980753"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401980754"
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
      Public Class ObjetosInstaladosBaseC
          Public ReferenciaObjetoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ObjetoIDNube As String
          Public ReferenciaObjeto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
          Sub new()
          End Sub
      End Class
  End Class
End Class
