Partial Public Class SeccionesD
  Public Class MotivosDeAusenciasYRetrasosD
      Public Shared _SeccionID As String = "2f263d3e-0828-4cd2-a574-21d0f5673e6d"
      Public Shared _SeccionIDGUID As New Guid("2f263d3e-0828-4cd2-a574-21d0f5673e6d")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As MotivosDeAusenciasYRetrasos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, MotivosDeAusenciasYRetrasosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New MotivosDeAusenciasYRetrasos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As MotivosDeAusenciasYRetrasos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, MotivosDeAusenciasYRetrasosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New MotivosDeAusenciasYRetrasos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class MotivosDeAusenciasYRetrasosES
          Public shared _SeccionID as Guid = New Guid("2f263d3e-0828-4cd2-a574-21d0f5673e6d")
          Public shared _Tabla$ = "tpr_10040212243"
      Public Shared ReferenciaDestinador$ = "pr_100402122413"
      Public Shared HoraLocal$ = "pr_100402122410"
      Public Shared ExportarEnModulos$ = "pr_100402122411"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402122424"
      Public Shared FechaAlta_UTC$ = "pr_100402122412"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040212248"
      Public Shared Descripcion$ = "pr_20040347361"
      Public Shared CompatibleConCalendarioLaboral$ = "pr_20040347431"
      Public Shared ReferenciaIcono$ = "pr_30040347611"
      Public Shared Naturaleza$ = "pr_40040350274"
      Public Shared TipoIT$ = "pr_60040353383"
      Public Shared OcultarDeLaLeyendaDeCalendarioEnInformacionAdicionalDeNomina$ = "pr_20040353691"
      Public Shared ConservarHorasTrabajadasSegunElContratoPorDia$ = "pr_50040358476"
      Public Shared ModoDeCotizacion$ = "pr_30040360101"
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
      Public Class MotivosDeAusenciasYRetrasosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Descripcion As String
          Public CompatibleConCalendarioLaboral As Boolean
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Naturaleza As Integer
          Public TipoIT As Boolean
          Public OcultarDeLaLeyendaDeCalendarioEnInformacionAdicionalDeNomina As Boolean
          Public ConservarHorasTrabajadasSegunElContratoPorDia As Boolean
          Public ModoDeCotizacion As Integer
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
      Public Class MotivosDeAusenciasYRetrasos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100402122413")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_100402122410")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100402122424")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100402122424", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100402122412")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100402122412", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_10040212248")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040212248", value)
            End Set
          End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_20040347361")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040347361", value)
            End Set
          End Property
          Public property CompatibleConCalendarioLaboral As Boolean
            get
                return me.GetValue_Boolean("pr_20040347431")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040347431", value)
            End Set
          End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_30040347611")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040347611", value)
            End Set
          End Property
          Public property Naturaleza As Integer
            get
                return me.GetValue_Integer("pr_40040350274")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_40040350274", value)
            End Set
          End Property
          Public property TipoIT As Boolean
            get
                return me.GetValue_Boolean("pr_60040353383")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040353383", value)
            End Set
          End Property
          Public property OcultarDeLaLeyendaDeCalendarioEnInformacionAdicionalDeNomina As Boolean
            get
                return me.GetValue_Boolean("pr_20040353691")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040353691", value)
            End Set
          End Property
          Public property ConservarHorasTrabajadasSegunElContratoPorDia As Boolean
            get
                return me.GetValue_Boolean("pr_50040358476")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040358476", value)
            End Set
          End Property
          Public property ModoDeCotizacion As Integer
            get
                return me.GetValue_Integer("pr_30040360101")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_30040360101", value)
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
