Partial Public Class SeccionesD
  Public Class ServidoresD
      Public Shared _SeccionID As String = "9f55454c-023c-4049-b7b6-a1c29a8905b2"
      Public Shared _SeccionIDGUID As New Guid("9f55454c-023c-4049-b7b6-a1c29a8905b2")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Servidores_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ServidoresES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Servidores_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Servidores_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ServidoresES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Servidores_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ServidoresES
          Public shared _SeccionID as Guid = New Guid("9f55454c-023c-4049-b7b6-a1c29a8905b2")
          Public shared _Tabla$ = "tpr_10040209432"
      Public Shared ReferenciaDestinador$ = "pr_100402094322"
      Public Shared ExportarEnModulos$ = "pr_100402094320"
      Public Shared FechaAlta_UTC$ = "pr_100402094321"
      Public Shared HoraLocal$ = "pr_100402094319"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402094333"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100402094317"
      Public Shared FechaDeCreacion_UTC$ = "pr_60040209431"
      Public Shared Serie$ = "pr_60040209433"
      Public Shared FechaReferenciaRecepcionSC_UTC$ = "pr_10040209448"
      Public Shared Guid4$ = "pr_10040209441"
      Public Shared Guid2$ = "pr_10040209444"
      Public Shared Guid3$ = "pr_10040209442"
      Public Shared FechaSISC_UTC$ = "pr_10040209449"
      Public Shared FechaReferenciaEnvioSC_UTC$ = "pr_10040209447"
      Public Shared Guid1$ = "pr_10040209443"
      Public Shared EsServidorCentral$ = "pr_10040209445"
      Public Shared ReferenciaServidorSC$ = "pr_10040209446"
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
      Public Class ServidoresC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDeCreacion_UTC As Date
          Public Serie As String
          Public FechaReferenciaRecepcionSC_UTC As Date
          Public Guid4 As String
          Public Guid2 As String
          Public Guid3 As String
          Public FechaSISC_UTC As Date
          Public FechaReferenciaEnvioSC_UTC As Date
          Public Guid1 As String
          Public EsServidorCentral As Boolean
          Public ReferenciaServidorSC As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class Servidores_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100402094322")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100402094321")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_100402094319")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100402094333")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100402094333", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_100402094317")
            End Get   
        End Property
        Public ReadOnly property FechaDeCreacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_60040209431")
            End Get   
        End Property
        Public ReadOnly property Serie As String
            get
                return me.GetValue_String("pr_60040209433")
            End Get   
        End Property
          Public property FechaReferenciaRecepcionSC_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040209448")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040209448", value)
            End Set
          End Property
          Public property Guid4 As String
            get
                return me.GetValue_String("pr_10040209441")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040209441", value)
            End Set
          End Property
          Public property Guid2 As String
            get
                return me.GetValue_String("pr_10040209444")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040209444", value)
            End Set
          End Property
          Public property Guid3 As String
            get
                return me.GetValue_String("pr_10040209442")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040209442", value)
            End Set
          End Property
          Public property FechaSISC_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040209449")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040209449", value)
            End Set
          End Property
          Public property FechaReferenciaEnvioSC_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040209447")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040209447", value)
            End Set
          End Property
          Public property Guid1 As String
            get
                return me.GetValue_String("pr_10040209443")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040209443", value)
            End Set
          End Property
          Public property EsServidorCentral As Boolean
            get
                return me.GetValue_Boolean("pr_10040209445")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040209445", value)
            End Set
          End Property
          Public property ReferenciaServidorSC As Guid
            get
                return me.GetValue_Guid("pr_10040209446")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040209446", value)
            End Set
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
