Partial Public Class SeccionesD
  Public Class CronometrajesInternosD
      Public Shared _SeccionID As String = "1c19bc49-a8ea-4a88-9b1e-972629a31fd2"
      Public Shared _SeccionIDGUID As New Guid("1c19bc49-a8ea-4a88-9b1e-972629a31fd2")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CronometrajesInternos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CronometrajesInternosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CronometrajesInternos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CronometrajesInternos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CronometrajesInternosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CronometrajesInternos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CronometrajesInternosES
          Public shared _SeccionID as Guid = New Guid("1c19bc49-a8ea-4a88-9b1e-972629a31fd2")
          Public shared _Tabla$ = "tpr_30040429686"
      Public Shared ExportarEnModulos$ = "pr_300404296824"
      Public Shared HoraLocal$ = "pr_300404296823"
      Public Shared FechaAlta_UTC$ = "pr_300404296825"
      Public Shared ReferenciaAutorDelAlta$ = "pr_300404296821"
      Public Shared ReferenciaDestinador$ = "pr_300404296826"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300404296837"
      Public Shared ReferenciaCampo$ = "pr_40040429683"
      Public Shared InicioCronometro_UTC$ = "pr_40040429685"
      Public Shared Finalizado$ = "pr_400404296810"
      Public Shared ReferenciaServidor$ = "pr_40040429682"
      Public Shared FinCronometro_UTC$ = "pr_40040429686"
      Public Shared NombreDeRegistroCronometrado$ = "pr_40040429689"
      Public Shared MinutosCronometrados$ = "pr_40040429688"
      Public Shared ReferenciaSeccionDeDatoCronometrado$ = "pr_40040429681"
      Public Shared ReferenciaRegistroCronometrado$ = "pr_40040429684"
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
      Public Class CronometrajesInternosC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaCampo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public InicioCronometro_UTC As Date
          Public Finalizado As Boolean
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FinCronometro_UTC As Date
          Public NombreDeRegistroCronometrado As String
          Public MinutosCronometrados As Decimal
          Public ReferenciaSeccionDeDatoCronometrado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroCronometrado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class CronometrajesInternos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_300404296823")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_300404296825")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300404296825", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_300404296821")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300404296821", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_300404296826")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300404296837")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300404296837", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCampo As Guid
            get
                return me.GetValue_Guid("pr_40040429683")
            End Get   
        End Property
          Public property InicioCronometro_UTC As Date
            get
                return me.GetValue_DateTime("pr_40040429685")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_40040429685", value)
            End Set
          End Property
          Public property Finalizado As Boolean
            get
                return me.GetValue_Boolean("pr_400404296810")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400404296810", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_40040429682")
            End Get   
        End Property
          Public property FinCronometro_UTC As Date
            get
                return me.GetValue_DateTime("pr_40040429686")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_40040429686", value)
            End Set
          End Property
        Public ReadOnly property NombreDeRegistroCronometrado As String
            get
                return me.GetValue_String("pr_40040429689")
            End Get   
        End Property
        Public ReadOnly property MinutosCronometrados As Decimal
            get
                return me.GetValue_Decimal("pr_40040429688")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionDeDatoCronometrado As Guid
            get
                return me.GetValue_Guid("pr_40040429681")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroCronometrado As Guid
            get
                return me.GetValue_Guid("pr_40040429684")
            End Get   
        End Property
        Public ReadOnly property ID As Guid
            get
                return me.GetValue_Guid("id")
            End Get   
        End Property
          Public property TextoPrincipal As String
            get
                return me.GetValue_String("nombre")
            End Get
            Set(value As String)
                me.SetValue_String("nombre", value)
            End Set
          End Property
        Public ReadOnly property FechaAltaDato_UTC As Date
            get
                return me.GetValue_DateTime("fecha")
            End Get   
        End Property
        Public ReadOnly property FechaUltimaModificacion_UTC As Date
            get
                return me.GetValue_DateTime("fecham")
            End Get   
        End Property
        Public ReadOnly property Eliminado As Boolean
            get
                return me.GetValue_Boolean("eliminado")
            End Get   
        End Property
        Public ReadOnly property UsuarioCreadorDelDAto As Guid
            get
                return me.GetValue_Guid("usuarioid")
            End Get   
        End Property
          Public property Seccion As Guid
            get
                return me.GetValue_Guid("plantillapid")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("plantillapid", value)
            End Set
          End Property
          Public property Posicion As Integer
            get
                return me.GetValue_Integer("posicion")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("posicion", value)
            End Set
          End Property
        Public ReadOnly property Empresa As Guid
            get
                return me.GetValue_Guid("ubicacion")
            End Get   
        End Property
        Public ReadOnly property Modificado As Boolean
            get
                return me.GetValue_Boolean("modificado")
            End Get   
        End Property
        Public ReadOnly property FechaIndiceActividad_UTC As Date
            get
                return me.GetValue_DateTime("fechaia")
            End Get   
        End Property
        Public ReadOnly property Fechadesincronizacion_UTC As Date
            get
                return me.GetValue_DateTime("fechasyn")
            End Get   
        End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
