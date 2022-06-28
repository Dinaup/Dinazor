Partial Public Class SeccionesD
  Public Class DatosFiscalesD
      Public Shared _SeccionID As String = "f3b161a4-dbe4-44ea-9259-b41dc8f88fc1"
      Public Shared _SeccionIDGUID As New Guid("f3b161a4-dbe4-44ea-9259-b41dc8f88fc1")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As DatosFiscales_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DatosFiscalesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DatosFiscales_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As DatosFiscales_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DatosFiscalesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DatosFiscales_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class DatosFiscalesES
          Public shared _SeccionID as Guid = New Guid("f3b161a4-dbe4-44ea-9259-b41dc8f88fc1")
          Public shared _Tabla$ = "tpr_20040138792"
      Public Shared Telefono$ = "pr_50040138793"
      Public Shared ReferenciaDestinador$ = "pr_200401387916"
      Public Shared ExportarEnModulos$ = "pr_200401387914"
      Public Shared FechaAlta_UTC$ = "pr_200401387915"
      Public Shared HoraLocal$ = "pr_200401387913"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401387927"
      Public Shared NIF$ = "pr_30040138792"
      Public Shared ApellidosYNombreORazonSocial$ = "pr_30040138791"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401387911"
      Public Shared Pais$ = "pr_30040138793"
      Public Shared Municipio$ = "pr_30040138794"
      Public Shared EntidadTieneAccesoWeb$ = "pr_30040138797"
      Public Shared DireccionCompleta$ = "pr_40040138792"
      Public Shared Provincia$ = "pr_40040138791"
      Public Shared CodigoPostal$ = "pr_30040138795"
      Public Shared ReferenciaEntidad$ = "pr_30040138796"
      Public Shared ReferenciaUbicacion$ = "pr_50040138795"
      Public Shared Numero$ = "pr_60040242243"
      Public Shared CodigoPais$ = "pr_60040241502"
      Public Shared CodigoProvincia$ = "pr_60040241501"
      Public Shared TipoNIF$ = "pr_50040241502"
      Public Shared Puerta$ = "pr_60040242241"
      Public Shared CPlazaAvda$ = "pr_60040242242"
      Public Shared Piso$ = "pr_60040242244"
      Public Shared Escalera$ = "pr_60040242245"
      Public Shared DomicilioDireccion$ = "pr_10040242251"
      Public Shared Movil$ = "pr_10040242252"
      Public Shared Fax$ = "pr_10040242253"
      Public Shared EditarDireccionCompleta$ = "pr_20040242251"
      Public Shared NIFIntracomunitario$ = "pr_40040251451"
      Public Shared EsUnaPersonaFisica$ = "pr_50040254941"
      Public Shared ApellidosPersonaFisica$ = "pr_40040254941"
      Public Shared NombrePersonaFisica$ = "pr_40040254942"
      Public Shared Tipo$ = "pr_40040254952"
      Public Shared CodigoMunicipio$ = "pr_20040275833"
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
      Public Class DatosFiscalesC
          Public Telefono As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public NIF As String
          Public ApellidosYNombreORazonSocial As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Pais As String
          Public Municipio As String
          Public EntidadTieneAccesoWeb As Boolean
          Public DireccionCompleta As String
          Public Provincia As String
          Public CodigoPostal As String
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Numero As String
          Public CodigoPais As String
          Public CodigoProvincia As String
          Public TipoNIF As String
          Public Puerta As String
          Public CPlazaAvda As String
          Public Piso As String
          Public Escalera As String
          Public DomicilioDireccion As String
          Public Movil As String
          Public Fax As String
          Public EditarDireccionCompleta As Boolean
          Public NIFIntracomunitario As String
          Public EsUnaPersonaFisica As Boolean
          Public ApellidosPersonaFisica As String
          Public NombrePersonaFisica As String
          Public Tipo As Integer
          Public CodigoMunicipio As String
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
      Public Class DatosFiscales_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Telefono As String
            get
                return me.GetValue_String("pr_50040138793")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138793", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200401387916")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200401387915")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200401387915", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_200401387913")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401387927")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401387927", value)
            End Set
          End Property
          Public property NIF As String
            get
                return me.GetValue_String("pr_30040138792")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138792", value)
            End Set
          End Property
          Public property ApellidosYNombreORazonSocial As String
            get
                return me.GetValue_String("pr_30040138791")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138791", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_200401387911")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_200401387911", value)
            End Set
          End Property
          Public property Pais As String
            get
                return me.GetValue_String("pr_30040138793")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138793", value)
            End Set
          End Property
          Public property Municipio As String
            get
                return me.GetValue_String("pr_30040138794")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138794", value)
            End Set
          End Property
          Public property EntidadTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040138797")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040138797", value)
            End Set
          End Property
          Public property DireccionCompleta As String
            get
                return me.GetValue_String("pr_40040138792")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040138792", value)
            End Set
          End Property
          Public property Provincia As String
            get
                return me.GetValue_String("pr_40040138791")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040138791", value)
            End Set
          End Property
          Public property CodigoPostal As String
            get
                return me.GetValue_String("pr_30040138795")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138795", value)
            End Set
          End Property
          Public property ReferenciaEntidad As Guid
            get
                return me.GetValue_Guid("pr_30040138796")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040138796", value)
            End Set
          End Property
          Public property ReferenciaUbicacion As Guid
            get
                return me.GetValue_Guid("pr_50040138795")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040138795", value)
            End Set
          End Property
          Public property Numero As String
            get
                return me.GetValue_String("pr_60040242243")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242243", value)
            End Set
          End Property
          Public property CodigoPais As String
            get
                return me.GetValue_String("pr_60040241502")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040241502", value)
            End Set
          End Property
          Public property CodigoProvincia As String
            get
                return me.GetValue_String("pr_60040241501")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040241501", value)
            End Set
          End Property
          Public property TipoNIF As String
            get
                return me.GetValue_String("pr_50040241502")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040241502", value)
            End Set
          End Property
          Public property Puerta As String
            get
                return me.GetValue_String("pr_60040242241")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242241", value)
            End Set
          End Property
          Public property CPlazaAvda As String
            get
                return me.GetValue_String("pr_60040242242")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242242", value)
            End Set
          End Property
          Public property Piso As String
            get
                return me.GetValue_String("pr_60040242244")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242244", value)
            End Set
          End Property
          Public property Escalera As String
            get
                return me.GetValue_String("pr_60040242245")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242245", value)
            End Set
          End Property
          Public property DomicilioDireccion As String
            get
                return me.GetValue_String("pr_10040242251")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040242251", value)
            End Set
          End Property
          Public property Movil As String
            get
                return me.GetValue_String("pr_10040242252")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040242252", value)
            End Set
          End Property
          Public property Fax As String
            get
                return me.GetValue_String("pr_10040242253")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040242253", value)
            End Set
          End Property
          Public property EditarDireccionCompleta As Boolean
            get
                return me.GetValue_Boolean("pr_20040242251")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040242251", value)
            End Set
          End Property
          Public property NIFIntracomunitario As String
            get
                return me.GetValue_String("pr_40040251451")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040251451", value)
            End Set
          End Property
          Public property EsUnaPersonaFisica As Boolean
            get
                return me.GetValue_Boolean("pr_50040254941")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040254941", value)
            End Set
          End Property
          Public property ApellidosPersonaFisica As String
            get
                return me.GetValue_String("pr_40040254941")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040254941", value)
            End Set
          End Property
          Public property NombrePersonaFisica As String
            get
                return me.GetValue_String("pr_40040254942")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040254942", value)
            End Set
          End Property
          Public property Tipo As Integer
            get
                return me.GetValue_Integer("pr_40040254952")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_40040254952", value)
            End Set
          End Property
          Public property CodigoMunicipio As String
            get
                return me.GetValue_String("pr_20040275833")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040275833", value)
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
