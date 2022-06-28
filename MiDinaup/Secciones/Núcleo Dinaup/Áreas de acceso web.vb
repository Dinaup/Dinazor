Partial Public Class SeccionesD
  Public Class AreasDeAccesoWebD
      Public Shared _SeccionID As String = "d62290ec-652d-4afd-933e-695235972ff1"
      Public Shared _SeccionIDGUID As New Guid("d62290ec-652d-4afd-933e-695235972ff1")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AreasDeAccesoWeb_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AreasDeAccesoWebES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AreasDeAccesoWeb_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AreasDeAccesoWeb_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AreasDeAccesoWebES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AreasDeAccesoWeb_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AreasDeAccesoWebES
          Public shared _SeccionID as Guid = New Guid("d62290ec-652d-4afd-933e-695235972ff1")
          Public shared _Tabla$ = "tpr_536e7f7wd"
      Public Shared ReferenciaDestinador$ = "pr_14630fca3fx2fwd"
      Public Shared HoraLocal$ = "pr_776af12wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149566h1e3wd"
      Public Shared ReferenciaFuncionAPIParaLoginObsoleto$ = "pr_148e29b6c0xd0wd"
      Public Shared DireccionWebURL$ = "pr_145f025afcx1cawd"
      Public Shared ReferenciaFuncionAPIParaNoEncontradasObsoleto$ = "pr_148e269484x12bwd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3d61fg31dwd"
      Public Shared ExportarEnModulos$ = "pr_14630fc9d2x180wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fc95fgacwd"
      Public Shared ReferenciaFuncionAPIParaErrorGenericoObsoleto$ = "pr_148e279b2fx111wd"
      Public Shared APIKey$ = "pr_148e42ba7ex1efwd"
      Public Shared DireccionesIPEnListaBlanca$ = "pr_60040138065"
      Public Shared TodasLasConexionesLocalesObsoleto$ = "pr_60040138064"
      Public Shared ActivarListaBlanca$ = "pr_60040138063"
      Public Shared EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb$ = "pr_20040140786"
      Public Shared ReferenciaUbicacionPorDefectoObsoleto$ = "pr_20040140787"
      Public Shared ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto$ = "pr_20040140785"
      Public Shared ReferenciaServidor$ = "pr_20040212264"
      Public Shared ReferenciaEmpresaPorDefectoObsoleto$ = "pr_40040371423"
      Public Shared DireccionCDN$ = "pr_20040433039"
      Public Shared ReferenciaCorreoNotificaciones$ = "pr_10040474833"
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
      Public Class AreasDeAccesoWebC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaFuncionAPIParaLoginObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DireccionWebURL As String
          Public ReferenciaFuncionAPIParaNoEncontradasObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaFuncionAPIParaErrorGenericoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public APIKey As String
          Public DireccionesIPEnListaBlanca As String
          Public TodasLasConexionesLocalesObsoleto As Boolean
          Public ActivarListaBlanca As Boolean
          Public EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPorDefectoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpresaPorDefectoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DireccionCDN As String
          Public ReferenciaCorreoNotificaciones As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class AreasDeAccesoWeb_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of AreasDeAccesoWebListaD.AreasDeAccesoWebLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of AreasDeAccesoWebListaD.AreasDeAccesoWebLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New AreasDeAccesoWebListaD.AreasDeAccesoWebLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14630fca3fx2fwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776af12wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1463149566h1e3wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1463149566h1e3wd", value)
            End Set
          End Property
          Public property ReferenciaFuncionAPIParaLoginObsoleto As Guid
            get
                return me.GetValue_Guid("pr_148e29b6c0xd0wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_148e29b6c0xd0wd", value)
            End Set
          End Property
          Public property DireccionWebURL As String
            get
                return me.GetValue_String("pr_145f025afcx1cawd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_145f025afcx1cawd", value)
            End Set
          End Property
          Public property ReferenciaFuncionAPIParaNoEncontradasObsoleto As Guid
            get
                return me.GetValue_Guid("pr_148e269484x12bwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_148e269484x12bwd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3d61fg31dwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3d61fg31dwd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14630fc95fgacwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14630fc95fgacwd", value)
            End Set
          End Property
          Public property ReferenciaFuncionAPIParaErrorGenericoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_148e279b2fx111wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_148e279b2fx111wd", value)
            End Set
          End Property
        Public ReadOnly property APIKey As String
            get
                return me.GetValue_String("pr_148e42ba7ex1efwd")
            End Get   
        End Property
          Public property DireccionesIPEnListaBlanca As String
            get
                return me.GetValue_String("pr_60040138065")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040138065", value)
            End Set
          End Property
          Public property TodasLasConexionesLocalesObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_60040138064")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040138064", value)
            End Set
          End Property
          Public property ActivarListaBlanca As Boolean
            get
                return me.GetValue_Boolean("pr_60040138063")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040138063", value)
            End Set
          End Property
          Public property EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040140786")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040140786", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPorDefectoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040140787")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040140787", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040140785")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040140785", value)
            End Set
          End Property
          Public property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_20040212264")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040212264", value)
            End Set
          End Property
          Public property ReferenciaEmpresaPorDefectoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_40040371423")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040371423", value)
            End Set
          End Property
          Public property DireccionCDN As String
            get
                return me.GetValue_String("pr_20040433039")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040433039", value)
            End Set
          End Property
          Public property ReferenciaCorreoNotificaciones As Guid
            get
                return me.GetValue_Guid("pr_10040474833")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040474833", value)
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
