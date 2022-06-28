Partial Public Class SeccionesD
  Public Class AnotacionesInternasD
      Public Shared _SeccionID As String = "bc58c60f-7fe4-4c91-9f54-ed25d19c74e0"
      Public Shared _SeccionIDGUID As New Guid("bc58c60f-7fe4-4c91-9f54-ed25d19c74e0")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AnotacionesInternas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AnotacionesInternasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AnotacionesInternas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AnotacionesInternas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AnotacionesInternasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AnotacionesInternas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AnotacionesInternasES
          Public shared _SeccionID as Guid = New Guid("bc58c60f-7fe4-4c91-9f54-ed25d19c74e0")
          Public shared _Tabla$ = "tpr_72cffdfxd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_72d000bwd"
      Public Shared ReferenciaDestinador$ = "pr_72d002fwd"
      Public Shared ReferenciaDatoOrigenDeAnotacion$ = "pr_72fa897wd"
      Public Shared HoraLocal$ = "pr_77611e8wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_72d0043wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_72d0013wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_72d003fwd"
      Public Shared FechaAlta_UTC$ = "pr_72d0023wd"
      Public Shared FechaDato_UTC$ = "pr_72d0017wd"
      Public Shared ReferenciaSeccionOrigenDeAnotacion$ = "pr_72fa89bwd"
      Public Shared MostrarEnDocumentacion$ = "pr_60040161126"
      Public Shared MostrarComoComentario$ = "pr_20040161137"
      Public Shared Comentario$ = "pr_72ed0f9wd"
      Public Shared GaleriaDeFotos$ = "pr_400404794517"
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
      Public Class AnotacionesInternasC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDatoOrigenDeAnotacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public ReferenciaSeccionOrigenDeAnotacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MostrarEnDocumentacion As Boolean
          Public MostrarComoComentario As Boolean
          Public Comentario As String
          Public GaleriaDeFotos As Boolean
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
      Public Class AnotacionesInternas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of AnotacionesInternasListaD.AnotacionesInternasLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of AnotacionesInternasListaD.AnotacionesInternasLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New AnotacionesInternasListaD.AnotacionesInternasLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_72d000bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_72d002fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDatoOrigenDeAnotacion As Guid
            get
                return me.GetValue_Guid("pr_72fa897wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_77611e8wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_72d0043wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_72d0043wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_72d0013wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_72d003fwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_72d003fwd", value)
            End Set
          End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_72d0023wd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_72d0017wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionOrigenDeAnotacion As Guid
            get
                return me.GetValue_Guid("pr_72fa89bwd")
            End Get   
        End Property
          Public property MostrarEnDocumentacion As Boolean
            get
                return me.GetValue_Boolean("pr_60040161126")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040161126", value)
            End Set
          End Property
          Public property MostrarComoComentario As Boolean
            get
                return me.GetValue_Boolean("pr_20040161137")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040161137", value)
            End Set
          End Property
          Public property Comentario As String
            get
                return me.GetValue_String("pr_72ed0f9wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_72ed0f9wd", value)
            End Set
          End Property
          Public property GaleriaDeFotos As Boolean
            get
                return me.GetValue_Boolean("pr_400404794517")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400404794517", value)
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
