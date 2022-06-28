Partial Public Class SeccionesD
  Public Class PermisosPuntualesAPlantillasDeImpresionD
      Public Shared _SeccionID As String = "32f8daa8-b83d-46e6-8a7c-efa3cce75f71"
      Public Shared _SeccionIDGUID As New Guid("32f8daa8-b83d-46e6-8a7c-efa3cce75f71")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PermisosPuntualesAPlantillasDeImpresion_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PermisosPuntualesAPlantillasDeImpresionES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PermisosPuntualesAPlantillasDeImpresion_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PermisosPuntualesAPlantillasDeImpresion_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PermisosPuntualesAPlantillasDeImpresionES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PermisosPuntualesAPlantillasDeImpresion_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PermisosPuntualesAPlantillasDeImpresionES
          Public shared _SeccionID as Guid = New Guid("32f8daa8-b83d-46e6-8a7c-efa3cce75f71")
          Public shared _Tabla$ = "tpr_40040108252"
      Public Shared Observaciones$ = "pr_10040108261"
      Public Shared ExportarEnModulos$ = "pr_400401082537"
      Public Shared FechaAlta_UTC$ = "pr_400401082538"
      Public Shared PlantillasDeImpresion$ = "pr_400401082556"
      Public Shared EmpleadosPermiso$ = "pr_400401082557"
      Public Shared FechaDeInicio_UTC$ = "pr_10040108263"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400401082534"
      Public Shared FechaDeFin_UTC$ = "pr_10040108264"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400401082552"
      Public Shared ReferenciaDestinador$ = "pr_400401082539"
      Public Shared HoraLocal$ = "pr_400401082536"
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
      Public Class PermisosPuntualesAPlantillasDeImpresionC
          Public Observaciones As String
          Public FechaAlta_UTC As Date
          Public PlantillasDeImpresion As String
          Public EmpleadosPermiso As String
          Public FechaDeInicio_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDeFin_UTC As Date
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
          Sub new()
          End Sub
      End Class
      Public Class PermisosPuntualesAPlantillasDeImpresion_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_10040108261")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040108261", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_400401082538")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_400401082538", value)
            End Set
          End Property
          Public property PlantillasDeImpresion As String
            get
                return me.GetValue_String("pr_400401082556")
            End Get
            Set(value As String)
                me.SetValue_String("pr_400401082556", value)
            End Set
          End Property
          Public property EmpleadosPermiso As String
            get
                return me.GetValue_String("pr_400401082557")
            End Get
            Set(value As String)
                me.SetValue_String("pr_400401082557", value)
            End Set
          End Property
          Public property FechaDeInicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040108263")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040108263", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_400401082534")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_400401082534", value)
            End Set
          End Property
          Public property FechaDeFin_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040108264")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040108264", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_400401082552")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400401082552", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_400401082539")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_400401082536")
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
