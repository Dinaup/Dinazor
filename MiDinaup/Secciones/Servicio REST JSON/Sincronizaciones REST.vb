Partial Public Class SeccionesD
  Public Class SincronizacionesRESTD
      Public Shared _SeccionID As String = "d590a6d8-f49a-4f4c-abdf-4e30e8ae81e5"
      Public Shared _SeccionIDGUID As New Guid("d590a6d8-f49a-4f4c-abdf-4e30e8ae81e5")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As SincronizacionesREST_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SincronizacionesRESTES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SincronizacionesREST_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As SincronizacionesREST_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SincronizacionesRESTES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SincronizacionesREST_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class SincronizacionesRESTES
          Public shared _SeccionID as Guid = New Guid("d590a6d8-f49a-4f4c-abdf-4e30e8ae81e5")
          Public shared _Tabla$ = "tpr_20040450401"
      Public Shared ReferenciaDestinador$ = "pr_200404504012"
      Public Shared HoraLocal$ = "pr_20040450409"
      Public Shared FechaAlta_UTC$ = "pr_200404504011"
      Public Shared ExportarEnModulos$ = "pr_200404504010"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200404504023"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040450407"
      Public Shared Detalles$ = "pr_30040450402"
      Public Shared ReferenciaSecccionDeDestino$ = "pr_30040450404"
      Public Shared MarcadorDePosicion$ = "pr_30040450405"
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
      Public Class SincronizacionesRESTC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Detalles As String
          Public ReferenciaSecccionDeDestino As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MarcadorDePosicion As String
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
      Public Class SincronizacionesREST_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200404504012")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_20040450409")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200404504011")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200404504011", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200404504023")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200404504023", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_20040450407")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040450407", value)
            End Set
          End Property
          Public property Detalles As String
            get
                return me.GetValue_String("pr_30040450402")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040450402", value)
            End Set
          End Property
          Public property ReferenciaSecccionDeDestino As Guid
            get
                return me.GetValue_Guid("pr_30040450404")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040450404", value)
            End Set
          End Property
          Public property MarcadorDePosicion As String
            get
                return me.GetValue_String("pr_30040450405")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040450405", value)
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
