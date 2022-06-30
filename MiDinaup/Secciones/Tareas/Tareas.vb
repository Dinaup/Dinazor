Partial Public Class SeccionesD
    Public Class TareasD
        Public Shared _SeccionID As String = "22aff5d9-acb9-4fa7-a9e0-1a4e297abfdb"
        Public Shared _SeccionIDGUID As New Guid("22aff5d9-acb9-4fa7-a9e0-1a4e297abfdb")
        Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Tareas_FormularioC
            Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, TareasES._SeccionID, "id", "")
            Dim API_VV = New DinaNETCore.API_VVC
            API_VV.Actualizar(Form_Nuevo)
            Return New Tareas_FormularioC(API_VV, API_VV.TokenListador)
        End Function
        Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Tareas_FormularioC
            Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, TareasES._SeccionID, Campo, Valor)
            Dim API_VV = New DinaNETCore.API_VVC
            API_VV.Actualizar(Form_Nuevo)
            Return New Tareas_FormularioC(API_VV, API_VV.TokenListador)
        End Function
        Public Class TareasES
            Public Shared _SeccionID As Guid = New Guid("22aff5d9-acb9-4fa7-a9e0-1a4e297abfdb")
            Public Shared _Tabla$ = "tpr_7735f41xd"
            Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7735fa1wd"
            Public Shared HoraLocal$ = "pr_77611bcwd"
            Public Shared ReferenciaDestinador$ = "pr_7735f69wd"
            Public Shared ReferenciaAutorDelAlta$ = "pr_7735f4dwd"
            Public Shared Fin_UTC$ = "pr_77362a1wd"
            Public Shared InformacionAdicional$ = "pr_7756c5cwd"
            Public Shared Inicio_UTC$ = "pr_773629dwd"
            Public Shared FechaAlta_UTC$ = "pr_7735f5dwd"
            Public Shared EmpleadoTieneAccesoWeb$ = "pr_7735fa5wd"
            Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7735f45wd"
            Public Shared Descripcion$ = "pr_7736299wd"
            Public Shared EvaluarEnAgenda$ = "pr_7bf48c7wd"
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
        Public Class TareasC
            Public AutorDelAltaTieneAccesoWeb As Boolean
            Public HoraLocal As Integer
            Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
            Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
            Public Fin_UTC As Date
            Public InformacionAdicional As String
            Public Inicio_UTC As Date
            Public FechaAlta_UTC As Date
            Public EmpleadoTieneAccesoWeb As Boolean
            Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
            Public Descripcion As String
            Public EvaluarEnAgenda As Boolean
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
        Public Class Tareas_FormularioC
            Inherits DinaNETCore.VentanaVirtualC
            Overrides Sub Evento_Actualizar()
            End Sub
            Public Property AutorDelAltaTieneAccesoWeb As Boolean
                Get
                    Return Me.GetValue_Boolean("pr_7735fa1wd")
                End Get
                Set(value As Boolean)
                    Me.SetValue_Boolean("pr_7735fa1wd", value)
                End Set
            End Property
            Public ReadOnly Property HoraLocal As Integer
                Get
                    Return Me.GetValue_Integer("pr_77611bcwd")
                End Get
            End Property
            Public ReadOnly Property ReferenciaDestinador As Guid
                Get
                    Return Me.GetValue_Guid("pr_7735f69wd")
                End Get
            End Property
            Public Property ReferenciaAutorDelAlta As Guid
                Get
                    Return Me.GetValue_Guid("pr_7735f4dwd")
                End Get
                Set(value As Guid)
                    Me.SetValue_Guid("pr_7735f4dwd", value)
                End Set
            End Property
            Public Property Fin_UTC As Date
                Get
                    Return Me.GetValue_DateTime("pr_77362a1wd")
                End Get
                Set(value As Date)
                    Me.SetValue_DateTime("pr_77362a1wd", value)
                End Set
            End Property
            Public Property InformacionAdicional As String
                Get
                    Return Me.GetValue_String("pr_7756c5cwd")
                End Get
                Set(value As String)
                    Me.SetValue_String("pr_7756c5cwd", value)
                End Set
            End Property
            Public Property Inicio_UTC As Date
                Get
                    Return Me.GetValue_DateTime("pr_773629dwd")
                End Get
                Set(value As Date)
                    Me.SetValue_DateTime("pr_773629dwd", value)
                End Set
            End Property
            Public Property FechaAlta_UTC As Date
                Get
                    Return Me.GetValue_DateTime("pr_7735f5dwd")
                End Get
                Set(value As Date)
                    Me.SetValue_DateTime("pr_7735f5dwd", value)
                End Set
            End Property
            Public Property EmpleadoTieneAccesoWeb As Boolean
                Get
                    Return Me.GetValue_Boolean("pr_7735fa5wd")
                End Get
                Set(value As Boolean)
                    Me.SetValue_Boolean("pr_7735fa5wd", value)
                End Set
            End Property
            Public Property ReferenciaEmpleadoPrincipal As Guid
                Get
                    Return Me.GetValue_Guid("pr_7735f45wd")
                End Get
                Set(value As Guid)
                    Me.SetValue_Guid("pr_7735f45wd", value)
                End Set
            End Property
            Public Property Descripcion As String
                Get
                    Return Me.GetValue_String("pr_7736299wd")
                End Get
                Set(value As String)
                    Me.SetValue_String("pr_7736299wd", value)
                End Set
            End Property
            Public Property EvaluarEnAgenda As Boolean
                Get
                    Return Me.GetValue_Boolean("pr_7bf48c7wd")
                End Get
                Set(value As Boolean)
                    Me.SetValue_Boolean("pr_7bf48c7wd", value)
                End Set
            End Property
            Public Property Prioridad As Integer
                Get
                    Return Me.GetValue_Integer("pr_60040481379")
                End Get
                Set(value As Integer)
                    Me.SetValue_Integer("pr_60040481379", value)
                End Set
            End Property
            Public Property ReferenciaEstado As Guid
                Get
                    Return Me.GetValue_Guid("pr_300404813818")
                End Get
                Set(value As Guid)
                    Me.SetValue_Guid("pr_300404813818", value)
                End Set
            End Property
            Public Property ReferenciaTipo As Guid
                Get
                    Return Me.GetValue_Guid("pr_300404813819")
                End Get
                Set(value As Guid)
                    Me.SetValue_Guid("pr_300404813819", value)
                End Set
            End Property
            Public ReadOnly Property ID As Guid
                Get
                    Return Me.GetValue_Guid("id")
                End Get
            End Property
            Public Property TextoPrincipal As String
                Get
                    Return Me.GetValue_String("nombre")
                End Get
                Set(value As String)
                    Me.SetValue_String("nombre", value)
                End Set
            End Property
            Public ReadOnly Property FechaAltaDato_UTC As Date
                Get
                    Return Me.GetValue_DateTime("fecha")
                End Get
            End Property
            Public ReadOnly Property FechaUltimaModificacion_UTC As Date
                Get
                    Return Me.GetValue_DateTime("fecham")
                End Get
            End Property
            Public ReadOnly Property Eliminado As Boolean
                Get
                    Return Me.GetValue_Boolean("eliminado")
                End Get
            End Property
            Public ReadOnly Property UsuarioCreadorDelDAto As Guid
                Get
                    Return Me.GetValue_Guid("usuarioid")
                End Get
            End Property
            Public Property Seccion As Guid
                Get
                    Return Me.GetValue_Guid("plantillapid")
                End Get
                Set(value As Guid)
                    Me.SetValue_Guid("plantillapid", value)
                End Set
            End Property
            Public Property Posicion As Integer
                Get
                    Return Me.GetValue_Integer("posicion")
                End Get
                Set(value As Integer)
                    Me.SetValue_Integer("posicion", value)
                End Set
            End Property
            Public ReadOnly Property Empresa As Guid
                Get
                    Return Me.GetValue_Guid("ubicacion")
                End Get
            End Property
            Public ReadOnly Property Modificado As Boolean
                Get
                    Return Me.GetValue_Boolean("modificado")
                End Get
            End Property
            Public ReadOnly Property FechaIndiceActividad_UTC As Date
                Get
                    Return Me.GetValue_DateTime("fechaia")
                End Get
            End Property
            Public ReadOnly Property Fechadesincronizacion_UTC As Date
                Get
                    Return Me.GetValue_DateTime("fechasyn")
                End Get
            End Property
            Sub New(___VV__ As DinaNETCore.API_VVC, _Token$)
                MyBase.New(___VV__, _Token)
                Me.Evento_Actualizar()
            End Sub
        End Class
    End Class
End Class
