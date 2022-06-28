Partial Public Class SeccionesD
  Public Class EntidadesD
      Public Shared _SeccionID As String = "eec5029a-440d-4505-8560-b88b3ff5917d"
      Public Shared _SeccionIDGUID As New Guid("eec5029a-440d-4505-8560-b88b3ff5917d")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Entidades_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EntidadesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Entidades_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Entidades_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EntidadesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Entidades_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EntidadesES
          Public shared _SeccionID as Guid = New Guid("eec5029a-440d-4505-8560-b88b3ff5917d")
          Public shared _Tabla$ = "tpr_2c597b"
      Public Shared AmbitoDeActividad$ = "pr_2222"
      Public Shared NDeSocio$ = "pr_2216"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ea9cg142wd"
      Public Shared FechaDeNacimiento$ = "pr_2c619d"
      Public Shared PaginaWeb$ = "pr_2225"
      Public Shared ReferenciaFoto$ = "pr_5f05940d"
      Public Shared ReferenciaCodigo$ = "pr_2c5e9f"
      Public Shared VIP$ = "pr_6122d4fd"
      Public Shared EstadoCivil$ = "pr_5f0bfbe5"
      Public Shared Profesion$ = "pr_2c60b5"
      Public Shared ReferenciaComercialEncargado$ = "pr_14109n"
      Public Shared NIFObsoleto$ = "pr_2c5a37"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463105af0x146wd"
      Public Shared Observaciones$ = "pr_2c6251"
      Public Shared ReferenciaDestinador$ = "pr_1463105b91g1f2wd"
      Public Shared Particular$ = "pr_20040105072"
      Public Shared HoraLocal$ = "pr_776ae62wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42080x42wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14631496d2x222wd"
      Public Shared ComercialEncargadoTieneAccesoWeb$ = "pr_146310d66bg40wd"
      Public Shared NombreFiscalObsoleto$ = "pr_50040108211"
      Public Shared Contacto$ = "pr_20040105071"
      Public Shared Proveedor$ = "pr_20040105073"
      Public Shared Cliente$ = "pr_400401177028"
      Public Shared ImporteSaldoAcumulado$ = "pr_2c6229"
      Public Shared ReferenciaDatosFiscales$ = "pr_40040138793"
      Public Shared Fabricante$ = "pr_60040146992"
      Public Shared Autor$ = "pr_60040146993"
      Public Shared NumeroDeRegistroDeComercioNRC$ = "pr_30040181602"
      Public Shared EsUnaEntidadJuridica$ = "pr_60040222581"
      Public Shared ReferenciaRepresentanteLegal$ = "pr_20040242777"
      Public Shared RepresentanteLegalTieneAccesoWeb$ = "pr_20040242778"
      Public Shared NCliente$ = "pr_10040325042"
      Public Shared NProveedor$ = "pr_10040325041"
      Public Shared EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb$ = "pr_20040414082"
      Public Shared ReferenciaEmpresaPrincipalEnLaQueTrabaja$ = "pr_20040414081"
      Public Shared PuedeConectarAWeb$ = "pr_3ffdcd7x257wc"
      Public Shared ContraseñaObsoleto$ = "pr_14196n"
      Public Shared IdentificadorAcceso$ = "pr_2bba690w12"
      Public Shared ContraseñaAccesoSistema$ = "pr_3ffd627x9ewc"
      Public Shared MotivoDeBloqueoAccesoWeb$ = "pr_10040218972"
      Public Shared SolicitarCambioDeContraseñaAlIniciarSesion$ = "pr_30040419861"
      Public Shared ReferenciaRol$ = "pr_74e2013wd"
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
      Public Class EntidadesC
          Public AmbitoDeActividad As String
          Public NDeSocio As Integer
          Public FechaAlta_UTC As Date
          Public FechaDeNacimiento As Date
          Public PaginaWeb As String
          Public ReferenciaFoto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCodigo As String
          Public VIP As Boolean
          Public EstadoCivil As String
          Public Profesion As String
          Public ReferenciaComercialEncargado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NIFObsoleto As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Particular As Boolean
          Public HoraLocal As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ComercialEncargadoTieneAccesoWeb As Boolean
          Public NombreFiscalObsoleto As String
          Public Contacto As Boolean
          Public Proveedor As Boolean
          Public Cliente As Boolean
          Public ImporteSaldoAcumulado As Decimal
          Public ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Fabricante As Boolean
          Public Autor As Boolean
          Public NumeroDeRegistroDeComercioNRC As String
          Public EsUnaEntidadJuridica As Boolean
          Public ReferenciaRepresentanteLegal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RepresentanteLegalTieneAccesoWeb As Boolean
          Public NCliente As String
          Public NProveedor As String
          Public EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb As Boolean
          Public ReferenciaEmpresaPrincipalEnLaQueTrabaja As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuedeConectarAWeb As Boolean
          Public ContraseñaObsoleto As String
          Public IdentificadorAcceso As String
          Public ContraseñaAccesoSistema As String
          Public MotivoDeBloqueoAccesoWeb As String
          Public SolicitarCambioDeContraseñaAlIniciarSesion As Boolean
          Public ReferenciaRol As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class Entidades_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property AmbitoDeActividad As String
            get
                return me.GetValue_String("pr_2222")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2222", value)
            End Set
          End Property
          Public property NDeSocio As Integer
            get
                return me.GetValue_Integer("pr_2216")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_2216", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3ea9cg142wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3ea9cg142wd", value)
            End Set
          End Property
          Public property FechaDeNacimiento As Date
            get
                return me.GetValue_Date("pr_2c619d")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_2c619d", value)
            End Set
          End Property
          Public property PaginaWeb As String
            get
                return me.GetValue_String("pr_2225")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2225", value)
            End Set
          End Property
          Public property ReferenciaFoto As Guid
            get
                return me.GetValue_Guid("pr_5f05940d")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_5f05940d", value)
            End Set
          End Property
          Public property ReferenciaCodigo As String
            get
                return me.GetValue_String("pr_2c5e9f")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c5e9f", value)
            End Set
          End Property
          Public property VIP As Boolean
            get
                return me.GetValue_Boolean("pr_6122d4fd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_6122d4fd", value)
            End Set
          End Property
          Public property EstadoCivil As String
            get
                return me.GetValue_String("pr_5f0bfbe5")
            End Get
            Set(value As String)
                me.SetValue_String("pr_5f0bfbe5", value)
            End Set
          End Property
          Public property Profesion As String
            get
                return me.GetValue_String("pr_2c60b5")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c60b5", value)
            End Set
          End Property
          Public property ReferenciaComercialEncargado As Guid
            get
                return me.GetValue_Guid("pr_14109n")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14109n", value)
            End Set
          End Property
          Public property NIFObsoleto As String
            get
                return me.GetValue_String("pr_2c5a37")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c5a37", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463105af0x146wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1463105af0x146wd", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_2c6251")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c6251", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463105b91g1f2wd")
            End Get   
        End Property
          Public property Particular As Boolean
            get
                return me.GetValue_Boolean("pr_20040105072")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040105072", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae62wd")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b42080x42wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b42080x42wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_14631496d2x222wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14631496d2x222wd", value)
            End Set
          End Property
          Public property ComercialEncargadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146310d66bg40wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146310d66bg40wd", value)
            End Set
          End Property
          Public property NombreFiscalObsoleto As String
            get
                return me.GetValue_String("pr_50040108211")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040108211", value)
            End Set
          End Property
          Public property Contacto As Boolean
            get
                return me.GetValue_Boolean("pr_20040105071")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040105071", value)
            End Set
          End Property
          Public property Proveedor As Boolean
            get
                return me.GetValue_Boolean("pr_20040105073")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040105073", value)
            End Set
          End Property
          Public property Cliente As Boolean
            get
                return me.GetValue_Boolean("pr_400401177028")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400401177028", value)
            End Set
          End Property
        Public ReadOnly property ImporteSaldoAcumulado As Decimal
            get
                return me.GetValue_Decimal("pr_2c6229")
            End Get   
        End Property
          Public property ReferenciaDatosFiscales As Guid
            get
                return me.GetValue_Guid("pr_40040138793")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040138793", value)
            End Set
          End Property
          Public property Fabricante As Boolean
            get
                return me.GetValue_Boolean("pr_60040146992")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040146992", value)
            End Set
          End Property
          Public property Autor As Boolean
            get
                return me.GetValue_Boolean("pr_60040146993")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040146993", value)
            End Set
          End Property
          Public property NumeroDeRegistroDeComercioNRC As String
            get
                return me.GetValue_String("pr_30040181602")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040181602", value)
            End Set
          End Property
          Public property EsUnaEntidadJuridica As Boolean
            get
                return me.GetValue_Boolean("pr_60040222581")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040222581", value)
            End Set
          End Property
          Public property ReferenciaRepresentanteLegal As Guid
            get
                return me.GetValue_Guid("pr_20040242777")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040242777", value)
            End Set
          End Property
          Public property RepresentanteLegalTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040242778")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040242778", value)
            End Set
          End Property
          Public property NCliente As String
            get
                return me.GetValue_String("pr_10040325042")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040325042", value)
            End Set
          End Property
          Public property NProveedor As String
            get
                return me.GetValue_String("pr_10040325041")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040325041", value)
            End Set
          End Property
          Public property EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040414082")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040414082", value)
            End Set
          End Property
          Public property ReferenciaEmpresaPrincipalEnLaQueTrabaja As Guid
            get
                return me.GetValue_Guid("pr_20040414081")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040414081", value)
            End Set
          End Property
          Public property PuedeConectarAWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3ffdcd7x257wc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3ffdcd7x257wc", value)
            End Set
          End Property
          Public property ContraseñaObsoleto As String
            get
                return me.GetValue_String("pr_14196n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_14196n", value)
            End Set
          End Property
          Public property IdentificadorAcceso As String
            get
                return me.GetValue_String("pr_2bba690w12")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2bba690w12", value)
            End Set
          End Property
          Public property ContraseñaAccesoSistema As String
            get
                return me.GetValue_String("pr_3ffd627x9ewc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_3ffd627x9ewc", value)
            End Set
          End Property
          Public property MotivoDeBloqueoAccesoWeb As String
            get
                return me.GetValue_String("pr_10040218972")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040218972", value)
            End Set
          End Property
          Public property SolicitarCambioDeContraseñaAlIniciarSesion As Boolean
            get
                return me.GetValue_Boolean("pr_30040419861")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040419861", value)
            End Set
          End Property
          Public property ReferenciaRol As Guid
            get
                return me.GetValue_Guid("pr_74e2013wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_74e2013wd", value)
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
