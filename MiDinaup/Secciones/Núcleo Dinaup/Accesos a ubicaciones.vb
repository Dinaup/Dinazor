Partial Public Class SeccionesD
  Public Class AccesosAUbicacionesD
      Public Shared _SeccionID As String = "3535c836-0642-44be-806b-220abab28bc1"
      Public Shared _SeccionIDGUID As New Guid("3535c836-0642-44be-806b-220abab28bc1")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AccesosAUbicaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AccesosAUbicacionesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AccesosAUbicaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AccesosAUbicaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AccesosAUbicacionesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AccesosAUbicaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AccesosAUbicacionesES
          Public shared _SeccionID as Guid = New Guid("3535c836-0642-44be-806b-220abab28bc1")
          Public shared _Tabla$ = "tpr_30040480302"
      Public Shared HoraLocal$ = "pr_30040480301011"
      Public Shared FechaAlta_UTC$ = "pr_30040480301013"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040480301008"
      Public Shared ReferenciaDestinador$ = "pr_30040480301014"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040480301025"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040480301026"
      Public Shared FechaDato_UTC$ = "pr_30040480301010"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040480301009"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040480301007"
      Public Shared PermisoValidoDesde_UTC$ = "pr_20040480312"
      Public Shared PermisoValidoHasta_UTC$ = "pr_20040480313"
      Public Shared Vigente$ = "pr_20040480316"
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
      Public Class AccesosAUbicacionesC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PermisoValidoDesde_UTC As Date
          Public PermisoValidoHasta_UTC As Date
          Public Vigente As Boolean
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
      Public Class AccesosAUbicaciones_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_30040480301011")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040480301013")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040480301013", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040480301008")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040480301008", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_30040480301014")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040480301025")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040480301025", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040480301026")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040480301026", value)
            End Set
          End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040480301010")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040480301010", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040480301009")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040480301009", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040480301007")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040480301007", value)
            End Set
          End Property
          Public property PermisoValidoDesde_UTC As Date
            get
                return me.GetValue_DateTime("pr_20040480312")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_20040480312", value)
            End Set
          End Property
          Public property PermisoValidoHasta_UTC As Date
            get
                return me.GetValue_DateTime("pr_20040480313")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_20040480313", value)
            End Set
          End Property
          Public property Vigente As Boolean
            get
                return me.GetValue_Boolean("pr_20040480316")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040480316", value)
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
