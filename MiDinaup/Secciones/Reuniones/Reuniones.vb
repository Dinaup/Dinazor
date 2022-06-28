Partial Public Class SeccionesD
  Public Class ReunionesD
      Public Shared _SeccionID As String = "da328e6a-2f0a-4b12-adfe-12ef1c1e9ae6"
      Public Shared _SeccionIDGUID As New Guid("da328e6a-2f0a-4b12-adfe-12ef1c1e9ae6")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Reuniones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ReunionesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Reuniones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Reuniones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ReunionesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Reuniones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ReunionesES
          Public shared _SeccionID as Guid = New Guid("da328e6a-2f0a-4b12-adfe-12ef1c1e9ae6")
          Public shared _Tabla$ = "tpr_7c1098axd"
      Public Shared ReunionDesde_UTC$ = "pr_7c1135fwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7c10994wd"
      Public Shared MostrarEnAgenda$ = "pr_7c11363wd"
      Public Shared FechaAlta_UTC$ = "pr_7c109a0wd"
      Public Shared ReunionHasta_UTC$ = "pr_7c11361wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7c109c4wd"
      Public Shared HoraLocal$ = "pr_7c10998wd"
      Public Shared ReferenciaDestinador$ = "pr_7c109a6wd"
      Public Shared ReferenciaPuntosATratar$ = "pr_10040147532"
      Public Shared ReunionCancelada$ = "pr_20040147531"
      Public Shared Detalles$ = "pr_50040404252"
      Public Shared Conclusiones$ = "pr_60040404251"
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
      Public Class ReunionesC
          Public ReunionDesde_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MostrarEnAgenda As Boolean
          Public FechaAlta_UTC As Date
          Public ReunionHasta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPuntosATratar As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReunionCancelada As Boolean
          Public Detalles As String
          Public Conclusiones As String
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
      Public Class Reuniones_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of ReunionesListaD.ReunionesLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of ReunionesListaD.ReunionesLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New ReunionesListaD.ReunionesLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


          Public property ReunionDesde_UTC As Date
            get
                return me.GetValue_DateTime("pr_7c1135fwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7c1135fwd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7c10994wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7c10994wd", value)
            End Set
          End Property
          Public property MostrarEnAgenda As Boolean
            get
                return me.GetValue_Boolean("pr_7c11363wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7c11363wd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7c109a0wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7c109a0wd", value)
            End Set
          End Property
          Public property ReunionHasta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7c11361wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7c11361wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7c109c4wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7c109c4wd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7c10998wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7c109a6wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaPuntosATratar As Guid
            get
                return me.GetValue_Guid("pr_10040147532")
            End Get   
        End Property
          Public property ReunionCancelada As Boolean
            get
                return me.GetValue_Boolean("pr_20040147531")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040147531", value)
            End Set
          End Property
          Public property Detalles As String
            get
                return me.GetValue_String("pr_50040404252")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040404252", value)
            End Set
          End Property
          Public property Conclusiones As String
            get
                return me.GetValue_String("pr_60040404251")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040404251", value)
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
