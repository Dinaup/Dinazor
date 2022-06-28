Partial Public Class SeccionesD
  Public Class ChatMensajesD
      Public Shared _SeccionID As String = "98ab3d9c-03d7-4a5e-9597-2a82095bb08b"
      Public Shared _SeccionIDGUID As New Guid("98ab3d9c-03d7-4a5e-9597-2a82095bb08b")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ChatMensajes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ChatMensajesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ChatMensajes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ChatMensajes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ChatMensajesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ChatMensajes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ChatMensajesES
          Public shared _SeccionID as Guid = New Guid("98ab3d9c-03d7-4a5e-9597-2a82095bb08b")
          Public shared _Tabla$ = "tpr_4f133f0wc"
      Public Shared Tipo$ = "pr_1a3d742384x22awd"
      Public Shared NombreArchivoDatoAdjunto$ = "pr_4f1404dx14bwc"
      Public Shared ReferenciaDatoAdjunto$ = "pr_72ede71wd"
      Public Shared ReferenciaDestinador$ = "pr_14630fbafdg12dwd"
      Public Shared HoraLocal$ = "pr_776af28wd"
      Public Shared CRCArchivoObsoleto$ = "pr_4f13f34x195wc"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314ae2dh2cewd"
      Public Shared ReferenciaSeccionAdjunta$ = "pr_72edd08wd"
      Public Shared MensajeOculto$ = "pr_4f140cbx31bwc"
      Public Shared TamañoArchivoObsoleto$ = "pr_1a195a208cx20awd"
      Public Shared ReferenciaMensajeAnterior$ = "pr_4f13e9bx2a3wc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b3f3bbg94wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3d455g35bwd"
      Public Shared FechaDato_UTC$ = "pr_14630fba5bx286wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59f4dxbdwd"
      Public Shared Mensaje$ = "pr_4f139a3x2ffwc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fb9d5h3d5wd"
      Public Shared ReferenciaChatSala$ = "pr_4f13d3fx139wc"
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
      Public Class ChatMensajesC
          Public Tipo As Integer
          Public NombreArchivoDatoAdjunto As String
          Public ReferenciaDatoAdjunto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public CRCArchivoObsoleto As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaSeccionAdjunta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MensajeOculto As Boolean
          Public TamañoArchivoObsoleto As Integer
          Public ReferenciaMensajeAnterior As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Mensaje As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaChatSala As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class ChatMensajes_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property Tipo As Integer
            get
                return me.GetValue_Integer("pr_1a3d742384x22awd")
            End Get   
        End Property
        Public ReadOnly property NombreArchivoDatoAdjunto As String
            get
                return me.GetValue_String("pr_4f1404dx14bwc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDatoAdjunto As Guid
            get
                return me.GetValue_Guid("pr_72ede71wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14630fbafdg12dwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776af28wd")
            End Get   
        End Property
        Public ReadOnly property CRCArchivoObsoleto As String
            get
                return me.GetValue_String("pr_4f13f34x195wc")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314ae2dh2cewd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314ae2dh2cewd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSeccionAdjunta As Guid
            get
                return me.GetValue_Guid("pr_72edd08wd")
            End Get   
        End Property
          Public property MensajeOculto As Boolean
            get
                return me.GetValue_Boolean("pr_4f140cbx31bwc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4f140cbx31bwc", value)
            End Set
          End Property
        Public ReadOnly property TamañoArchivoObsoleto As Integer
            get
                return me.GetValue_Integer("pr_1a195a208cx20awd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaMensajeAnterior As Guid
            get
                return me.GetValue_Guid("pr_4f13e9bx2a3wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b3f3bbg94wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3d455g35bwd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_14630fba5bx286wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b59f4dxbdwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b59f4dxbdwd", value)
            End Set
          End Property
        Public ReadOnly property Mensaje As String
            get
                return me.GetValue_String("pr_4f139a3x2ffwc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14630fb9d5h3d5wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaChatSala As Guid
            get
                return me.GetValue_Guid("pr_4f13d3fx139wc")
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
