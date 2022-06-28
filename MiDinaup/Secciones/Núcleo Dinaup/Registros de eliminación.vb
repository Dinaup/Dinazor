Partial Public Class SeccionesD
  Public Class RegistrosDeEliminacionD
      Public Shared _SeccionID As String = "e1556eb8-d914-453b-982a-b3ad48985ae4"
      Public Shared _SeccionIDGUID As New Guid("e1556eb8-d914-453b-982a-b3ad48985ae4")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosDeEliminacion_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeEliminacionES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeEliminacion_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosDeEliminacion_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeEliminacionES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeEliminacion_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosDeEliminacionES
          Public shared _SeccionID as Guid = New Guid("e1556eb8-d914-453b-982a-b3ad48985ae4")
          Public shared _Tabla$ = "tpr_40a2d01wc"
      Public Shared NombreDato$ = "pr_4713bdex307wc"
      Public Shared FechaDato_UTC$ = "pr_1463107681x368wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3f003x288wd"
      Public Shared ReferenciaElemento$ = "pr_40a65b6xa2wc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b597f5g348wd"
      Public Shared ReferenciaSeccion$ = "pr_40a655fx2wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463107650x3c2wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149084hb3wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42855x76wd"
      Public Shared HoraLocal$ = "pr_776ae2awd"
      Public Shared ReferenciaDestinador$ = "pr_146310770cx134wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b4282dx21fwd"
      Public Shared ReferenciaRegistroDeAcceso$ = "pr_185b356df1x299wd"
      Public Shared TipoDeAccion$ = "pr_7c20d03wd"
      Public Shared ReferenciaServidor$ = "pr_50040212261"
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
      Public Class RegistrosDeEliminacionC
          Public NombreDato As String
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoDeAccion As Integer
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class RegistrosDeEliminacion_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property NombreDato As String
            get
                return me.GetValue_String("pr_4713bdex307wc")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1463107681x368wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3f003x288wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaElemento As Guid
            get
                return me.GetValue_Guid("pr_40a65b6xa2wc")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b597f5g348wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b597f5g348wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSeccion As Guid
            get
                return me.GetValue_Guid("pr_40a655fx2wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463107650x3c2wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1463149084hb3wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1463149084hb3wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b42855x76wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae2awd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_146310770cx134wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b4282dx21fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroDeAcceso As Guid
            get
                return me.GetValue_Guid("pr_185b356df1x299wd")
            End Get   
        End Property
        Public ReadOnly property TipoDeAccion As Integer
            get
                return me.GetValue_Integer("pr_7c20d03wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_50040212261")
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
