Partial Public Class SeccionesD
  Public Class SCIntegridadDeRegistrosD
      Public Shared _SeccionID As String = "8e24e6b9-3326-4a1e-a1e3-0fb884ee08dc"
      Public Shared _SeccionIDGUID As New Guid("8e24e6b9-3326-4a1e-a1e3-0fb884ee08dc")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As SCIntegridadDeRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SCIntegridadDeRegistrosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SCIntegridadDeRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As SCIntegridadDeRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SCIntegridadDeRegistrosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SCIntegridadDeRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class SCIntegridadDeRegistrosES
          Public shared _SeccionID as Guid = New Guid("8e24e6b9-3326-4a1e-a1e3-0fb884ee08dc")
          Public shared _Tabla$ = "tpr_71aeb47xd"
      Public Shared ReferenciaReferenciaUbicacionServidorCentralObsoleto$ = "pr_71af6f1wd"
      Public Shared FechaReparacionUTC_UTC$ = "pr_71b0451wd"
      Public Shared TablaOSeccion$ = "pr_71af6f5wd"
      Public Shared CRCServidorCentral$ = "pr_71b0441wd"
      Public Shared Estado$ = "pr_71b0449wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_71aeb53wd"
      Public Shared FechaResincronizacion_UTC$ = "pr_71b044dwd"
      Public Shared MarcadorFechaMaxima_UTC$ = "pr_724e037wd"
      Public Shared MarcadorFechaSynMaximaSCUTC_UTC$ = "pr_724f40dwd"
      Public Shared CRCServidorLocal$ = "pr_71b0445wd"
      Public Shared FechaAlta_UTC$ = "pr_71aeb63wd"
      Public Shared FechaDato_UTC$ = "pr_71aeb57wd"
      Public Shared ReferenciaRegistroID$ = "pr_71bcd28wd"
      Public Shared Detalles$ = "pr_724f415wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_71aeba7wd"
      Public Shared MarcadorFechaSynMaximaSRVUTC_UTC$ = "pr_724f411wd"
      Public Shared ReferenciaDestinador$ = "pr_71aeb6fwd"
      Public Shared HoraLocal$ = "pr_776ae76wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_71aeb4fwd"
      Public Shared ReferenciaServidorSRV$ = "pr_10040212261"
      Public Shared ReferenciaServidorSC$ = "pr_10040212262"
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
      Public Class SCIntegridadDeRegistrosC
          Public ReferenciaReferenciaUbicacionServidorCentralObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaReparacionUTC_UTC As Date
          Public TablaOSeccion As String
          Public CRCServidorCentral As String
          Public Estado As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaResincronizacion_UTC As Date
          Public MarcadorFechaMaxima_UTC As Date
          Public MarcadorFechaSynMaximaSCUTC_UTC As Date
          Public CRCServidorLocal As String
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public ReferenciaRegistroID As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Detalles As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public MarcadorFechaSynMaximaSRVUTC_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidorSRV As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidorSC As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class SCIntegridadDeRegistros_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of SCIntegridadDeRegistrosListaD.SCIntegridadDeRegistrosLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of SCIntegridadDeRegistrosListaD.SCIntegridadDeRegistrosLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New SCIntegridadDeRegistrosListaD.SCIntegridadDeRegistrosLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaReferenciaUbicacionServidorCentralObsoleto As Guid
            get
                return me.GetValue_Guid("pr_71af6f1wd")
            End Get   
        End Property
        Public ReadOnly property FechaReparacionUTC_UTC As Date
            get
                return me.GetValue_DateTime("pr_71b0451wd")
            End Get   
        End Property
        Public ReadOnly property TablaOSeccion As String
            get
                return me.GetValue_String("pr_71af6f5wd")
            End Get   
        End Property
        Public ReadOnly property CRCServidorCentral As String
            get
                return me.GetValue_String("pr_71b0441wd")
            End Get   
        End Property
        Public ReadOnly property Estado As Integer
            get
                return me.GetValue_Integer("pr_71b0449wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_71aeb53wd")
            End Get   
        End Property
        Public ReadOnly property FechaResincronizacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_71b044dwd")
            End Get   
        End Property
        Public ReadOnly property MarcadorFechaMaxima_UTC As Date
            get
                return me.GetValue_DateTime("pr_724e037wd")
            End Get   
        End Property
        Public ReadOnly property MarcadorFechaSynMaximaSCUTC_UTC As Date
            get
                return me.GetValue_DateTime("pr_724f40dwd")
            End Get   
        End Property
        Public ReadOnly property CRCServidorLocal As String
            get
                return me.GetValue_String("pr_71b0445wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_71aeb63wd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_71aeb57wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroID As Guid
            get
                return me.GetValue_Guid("pr_71bcd28wd")
            End Get   
        End Property
        Public ReadOnly property Detalles As String
            get
                return me.GetValue_String("pr_724f415wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_71aeba7wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_71aeba7wd", value)
            End Set
          End Property
        Public ReadOnly property MarcadorFechaSynMaximaSRVUTC_UTC As Date
            get
                return me.GetValue_DateTime("pr_724f411wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_71aeb6fwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae76wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_71aeb4fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidorSRV As Guid
            get
                return me.GetValue_Guid("pr_10040212261")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidorSC As Guid
            get
                return me.GetValue_Guid("pr_10040212262")
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
