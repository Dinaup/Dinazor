Partial Public Class SeccionesD
    Public Class TareasBaseD
        Public Shared _SeccionID As String = "e4b3dbe4-83c6-44af-b275-af1f6689bf73"
        Public Shared _SeccionIDGUID As New Guid("e4b3dbe4-83c6-44af-b275-af1f6689bf73")
        Public Class TareasBaseES
            Public Shared _SeccionID As Guid = New Guid("e4b3dbe4-83c6-44af-b275-af1f6689bf73")
            Public Shared _Tabla$ = "tpr_7735f41xd"
            Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7735f45wd"
            Public Shared HoraLocal$ = "pr_77611bcwd"
            Public Shared ReferenciaDestinador$ = "pr_7735f69wd"
            Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7735fa1wd"
            Public Shared ReferenciaAutorDelAlta$ = "pr_7735f4dwd"
            Public Shared EvaluarEnAgenda$ = "pr_7bf48c7wd"
            Public Shared ExportarEnModulos$ = "pr_7735f55wd"
            Public Shared FechaAlta_UTC$ = "pr_7735f5dwd"
            Public Shared EmpleadoTieneAccesoWeb$ = "pr_7735fa5wd"
            Public Shared Fin_UTC$ = "pr_77362a1wd"
            Public Shared Descripcion$ = "pr_7736299wd"
            Public Shared InformacionAdicional$ = "pr_7756c5cwd"
            Public Shared Inicio_UTC$ = "pr_773629dwd"
            Public Shared Prioridad$ = "pr_60040481379"
            Public Shared ReferenciaEstado$ = "pr_300404813818"
            Public Shared ReferenciaTipo$ = "pr_300404813819"
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
        Public Class TareasBaseC
            Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
            Public HoraLocal As Integer
            Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
            Public AutorDelAltaTieneAccesoWeb As Boolean
            Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
            Public EvaluarEnAgenda As Boolean
            Public FechaAlta_UTC As Date
            Public EmpleadoTieneAccesoWeb As Boolean
            Public Fin_UTC As Date
            Public Descripcion As String
            Public InformacionAdicional As String
            Public Inicio_UTC As Date
            Public Prioridad As Integer
            Public ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
            Public ReferenciaTipo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
            Sub New()
            End Sub
        End Class
    End Class
End Class
