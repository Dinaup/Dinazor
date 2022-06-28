Partial Public Class SeccionesD
  Public Class FormatoContenidoD
      Public Shared _SeccionID As String = "f7fc99cd-ded9-4cfc-a72e-64abdf011d7b"
      Public Shared _SeccionIDGUID As New Guid("f7fc99cd-ded9-4cfc-a72e-64abdf011d7b")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As FormatoContenido_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, FormatoContenidoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New FormatoContenido_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As FormatoContenido_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, FormatoContenidoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New FormatoContenido_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class FormatoContenidoES
          Public shared _SeccionID as Guid = New Guid("f7fc99cd-ded9-4cfc-a72e-64abdf011d7b")
          Public shared _Tabla$ = "tpr_1026n"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e0d2x1a5wd"
      Public Shared ExportarEnModulos$ = "pr_1463101975x277wd"
      Public Shared Multiplicador$ = "pr_1029n"
      Public Shared NombreEsFemenino$ = "pr_48e03d2x3a2wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463101930x3ddwd"
      Public Shared ReferenciaIcono$ = "pr_48df098x39cwc"
      Public Shared NombrePlural$ = "pr_48e043fx101wc"
      Public Shared HoraLocal$ = "pr_776aed0wd"
      Public Shared ReferenciaDestinador$ = "pr_146310199di8fwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149f1axd8wd"
      Public Shared NombreSingular$ = "pr_48e0410x383wc"
      Public Shared EsEspecialUnidades$ = "pr_490a12cx2ecwc"
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
      Public Class FormatoContenidoC
          Public FechaAlta_UTC As Date
          Public Multiplicador As Decimal
          Public NombreEsFemenino As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NombrePlural As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public NombreSingular As String
          Public EsEspecialUnidades As Boolean
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
      Public Class FormatoContenido_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3e0d2x1a5wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3e0d2x1a5wd", value)
            End Set
          End Property
        Public ReadOnly property Multiplicador As Decimal
            get
                return me.GetValue_Decimal("pr_1029n")
            End Get   
        End Property
          Public property NombreEsFemenino As Boolean
            get
                return me.GetValue_Boolean("pr_48e03d2x3a2wc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_48e03d2x3a2wc", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463101930x3ddwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1463101930x3ddwd", value)
            End Set
          End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_48df098x39cwc")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_48df098x39cwc", value)
            End Set
          End Property
          Public property NombrePlural As String
            get
                return me.GetValue_String("pr_48e043fx101wc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_48e043fx101wc", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aed0wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_146310199di8fwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1463149f1axd8wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1463149f1axd8wd", value)
            End Set
          End Property
          Public property NombreSingular As String
            get
                return me.GetValue_String("pr_48e0410x383wc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_48e0410x383wc", value)
            End Set
          End Property
          Public property EsEspecialUnidades As Boolean
            get
                return me.GetValue_Boolean("pr_490a12cx2ecwc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_490a12cx2ecwc", value)
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
