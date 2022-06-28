Partial Public Class SeccionesD
  Public Class RegistrosSincronizadosD
      Public Shared _SeccionID As String = "1e1d5c48-5b51-486f-9de7-a0f400aff7cc"
      Public Shared _SeccionIDGUID As New Guid("1e1d5c48-5b51-486f-9de7-a0f400aff7cc")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosSincronizados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosSincronizadosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosSincronizados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosSincronizados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosSincronizadosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosSincronizados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosSincronizadosES
          Public shared _SeccionID as Guid = New Guid("1e1d5c48-5b51-486f-9de7-a0f400aff7cc")
          Public shared _Tabla$ = "tpr_30040450401"
      Public Shared ReferenciaDestinador$ = "pr_300404504017"
      Public Shared ExportarEnModulos$ = "pr_300404504015"
      Public Shared FechaAlta_UTC$ = "pr_300404504016"
      Public Shared HoraLocal$ = "pr_300404504014"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300404504028"
      Public Shared ReferenciaAutorDelAlta$ = "pr_300404504012"
      Public Shared ReferenciaSincronizador$ = "pr_300404504032"
      Public Shared IDOrigen$ = "pr_300404504033"
      Public Shared ReferenciaSeccionDestino$ = "pr_40040450401"
      Public Shared ReferenciaDatoDestino$ = "pr_40040450403"
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
      Public Class RegistrosSincronizadosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSincronizador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IDOrigen As String
          Public ReferenciaSeccionDestino As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDatoDestino As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class RegistrosSincronizados_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_300404504017")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_300404504016")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300404504016", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_300404504014")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300404504028")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300404504028", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_300404504012")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300404504012", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSincronizador As Guid
            get
                return me.GetValue_Guid("pr_300404504032")
            End Get   
        End Property
        Public ReadOnly property IDOrigen As String
            get
                return me.GetValue_String("pr_300404504033")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionDestino As Guid
            get
                return me.GetValue_Guid("pr_40040450401")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDatoDestino As Guid
            get
                return me.GetValue_Guid("pr_40040450403")
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
