Partial Public Class SeccionesD
  Public Class SeccionDePruebasJSOND
      Public Shared _SeccionID As String = "3aa455c1-c14c-437a-8e85-45bc2521f433"
      Public Shared _SeccionIDGUID As New Guid("3aa455c1-c14c-437a-8e85-45bc2521f433")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As SeccionDePruebasJSON_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SeccionDePruebasJSONES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SeccionDePruebasJSON_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As SeccionDePruebasJSON_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SeccionDePruebasJSONES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SeccionDePruebasJSON_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class SeccionDePruebasJSONES
          Public shared _SeccionID as Guid = New Guid("3aa455c1-c14c-437a-8e85-45bc2521f433")
          Public shared _Tabla$ = "tpr_20040140791003"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040140798"
      Public Shared FechaAlta_UTC$ = "pr_200401407912"
      Public Shared ReferenciaDestinador$ = "pr_200401407913"
      Public Shared CampoDecimal$ = "pr_300401407938"
      Public Shared CampoDeTipoEnumeracionMeses$ = "pr_40040140791"
      Public Shared ExportarEnModulos$ = "pr_200401407911"
      Public Shared HoraLocal$ = "pr_200401407910"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401407924"
      Public Shared TextoDePrueba$ = "pr_200401407926"
      Public Shared TextoMultilinea$ = "pr_200401407927"
      Public Shared CasillaSiNoDePrueba$ = "pr_200401407928"
      Public Shared HoraConSegundos$ = "pr_200401407930"
      Public Shared HoraSinSegundos$ = "pr_300401407935"
      Public Shared FechaDePrueba$ = "pr_200401407929"
      Public Shared FechaYHoraSinSegundos_UTC$ = "pr_300401407936"
      Public Shared FechaYHoraConSegundos_UTC$ = "pr_300401407937"
      Public Shared ReferenciaEjemploDeCampoRelacionado$ = "pr_500401798922"
      Public Shared IDExterna$ = "pr_10040452015"
      Public Shared FechaModificacionExterna_UTC$ = "pr_10040452014"
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
      Public Class SeccionDePruebasJSONC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CampoDecimal As Decimal
          Public CampoDeTipoEnumeracionMeses As Integer
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public TextoDePrueba As String
          Public TextoMultilinea As String
          Public CasillaSiNoDePrueba As Boolean
          Public HoraConSegundos As Integer
          Public HoraSinSegundos As Integer
          Public FechaDePrueba As Date
          Public FechaYHoraSinSegundos_UTC As Date
          Public FechaYHoraConSegundos_UTC As Date
          Public ReferenciaEjemploDeCampoRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IDExterna As Integer
          Public FechaModificacionExterna_UTC As Date
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
      Public Class SeccionDePruebasJSON_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of SeccionDePruebasJSONListaD.SeccionDePruebasJSONLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of SeccionDePruebasJSONListaD.SeccionDePruebasJSONLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New SeccionDePruebasJSONListaD.SeccionDePruebasJSONLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_20040140798")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040140798", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200401407912")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200401407912", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200401407913")
            End Get   
        End Property
          Public property CampoDecimal As Decimal
            get
                return me.GetValue_Decimal("pr_300401407938")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_300401407938", value)
            End Set
          End Property
          Public property CampoDeTipoEnumeracionMeses As Integer
            get
                return me.GetValue_Integer("pr_40040140791")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_40040140791", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_200401407910")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401407924")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401407924", value)
            End Set
          End Property
          Public property TextoDePrueba As String
            get
                return me.GetValue_String("pr_200401407926")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200401407926", value)
            End Set
          End Property
          Public property TextoMultilinea As String
            get
                return me.GetValue_String("pr_200401407927")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200401407927", value)
            End Set
          End Property
          Public property CasillaSiNoDePrueba As Boolean
            get
                return me.GetValue_Boolean("pr_200401407928")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401407928", value)
            End Set
          End Property
          Public property HoraConSegundos As Integer
            get
                return me.GetValue_Integer("pr_200401407930")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_200401407930", value)
            End Set
          End Property
          Public property HoraSinSegundos As Integer
            get
                return me.GetValue_Integer("pr_300401407935")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_300401407935", value)
            End Set
          End Property
          Public property FechaDePrueba As Date
            get
                return me.GetValue_Date("pr_200401407929")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_200401407929", value)
            End Set
          End Property
          Public property FechaYHoraSinSegundos_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401407936")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300401407936", value)
            End Set
          End Property
          Public property FechaYHoraConSegundos_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401407937")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300401407937", value)
            End Set
          End Property
          Public property ReferenciaEjemploDeCampoRelacionado As Guid
            get
                return me.GetValue_Guid("pr_500401798922")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401798922", value)
            End Set
          End Property
          Public property IDExterna As Integer
            get
                return me.GetValue_Integer("pr_10040452015")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_10040452015", value)
            End Set
          End Property
          Public property FechaModificacionExterna_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040452014")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040452014", value)
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
