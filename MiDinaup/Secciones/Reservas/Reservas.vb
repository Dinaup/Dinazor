   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class ReservasD
      Public Class Reservas_ConListaC
      Public Listador as ReservasC
      Public Lista As New List(of ReservasListaD.ReservasListaC)
        sub new(_listador  as ReservasC, _lista as List(of ReservasListaD.ReservasListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "b5a49957-7bc2-4e31-9657-0b0191607da2"
      Public Shared _SeccionIDGUID As New Guid("b5a49957-7bc2-4e31-9657-0b0191607da2")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of ReservasC )) 
          Dim R As New List(Of ReservasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ReservasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New ReservasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  Reservas_ConListaC)) 
          Dim R As New List(Of Reservas_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ReservasES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New ReservasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of ReservasListaD.ReservasListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New ReservasListaD.ReservasListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New Reservas_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ReservasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ReservasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ReservasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ReservasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As Reservas_ConListaC, Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of Reservas_ConListaC)({DAtos}), CampoWhere, CampoWhereLista)
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of Reservas_ConListaC), Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.Listador.ToDic 
               If Actual.Lista.TieneDatos Then  
                   For Each ActualLista In Actual.Lista  
                       RegistroActual.dinaup_lista_datos.Add(ActualLista.ToDic) 
                   Next 
               End If 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ReservasES._SeccionID, Importar, CampoWhere, CampoWhereLista) 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Reservas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ReservasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Reservas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Reservas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ReservasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Reservas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ReservasES
          Public shared _SeccionID as Guid = New Guid("b5a49957-7bc2-4e31-9657-0b0191607da2")
          Public shared _Tabla$ = "tpr_30040105551"
      Public Shared ReferenciaPresupuestoDeVentaReferenciaDeOrigen$ = "pr_10040105962"
      Public Shared ClienteTieneAccesoWeb$ = "pr_500401057768"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300401055525"
      Public Shared LimiteFechaDeValidez_UTC$ = "pr_500401057770"
      Public Shared ReferenciaNumeracionSerie$ = "pr_500401057766"
      Public Shared NReservaNumerico$ = "pr_500401057769"
      Public Shared HoraLocal$ = "pr_30040105555"
      Public Shared ReferenciaDestinador$ = "pr_300401055510"
      Public Shared NReservaTexto$ = "pr_500401057772"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040105552"
      Public Shared ReferenciaTipoDeMovimiento$ = "pr_500401057765"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040105551"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_500401057763"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_300401055527"
      Public Shared FechaAlta_UTC$ = "pr_30040105557"
      Public Shared FechaDato_UTC$ = "pr_30040105554"
      Public Shared Observaciones$ = "pr_500401057771"
      Public Shared CantidadDeProductos$ = "pr_500401057760"
      Public Shared ReferenciaCliente$ = "pr_500401057764"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040105553"
      Public Shared DiasDeValidez$ = "pr_60040176513"
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
      Public Class ReservasC
      Inherits Base_DatoC
          <DisplayName("Presupuesto de venta (Referencia de Origen)")>
          Public Property ReferenciaPresupuestoDeVentaReferenciaDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPresupuestoDeVentaReferenciaDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPresupuestoDeVentaReferenciaDeOrigen"",""etiqueta"": ""Presupuesto de venta (Referencia de Origen)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""titulo"": ""Base - Presupuestos de venta"",""iconoid"": ""9dbff307-faa5-4795-a496-c8334f0fa5f3"",""etiquetasingular"": ""Presupuesto de venta"",""etiquetaplural"": ""Presupuestos de venta"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de venta (Referencia de Origen)"",""descripcion"": """",""keyword"": ""ReferenciaPresupuestoDeVentaReferenciaDeOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPresupuestoDeVentaReferenciaDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPresupuestoDeVentaReferenciaDeOrigen
          <DisplayName("Cliente Tiene Acceso web")>
          Public Property ClienteTieneAccesoWeb As Boolean
          Public Shared ___ClienteTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ClienteTieneAccesoWeb"",""etiqueta"": ""Cliente Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cliente Tiene Acceso web"",""descripcion"": """",""keyword"": ""ClienteTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ClienteTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ClienteTieneAccesoWeb
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <Description("Fecha límite en la que la reserva deja de tener validez.")>
          <DisplayName("Límite fecha de validez")>
          Public Property LimiteFechaDeValidez_UTC As Date?
          Public Shared ___LimiteFechaDeValidez_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""LimiteFechaDeValidez_UTC"",""etiqueta"": ""Límite fecha de validez"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Límite fecha de validez"",""descripcion"": """",""keyword"": ""LimiteFechaDeValidez_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __LimiteFechaDeValidez_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___LimiteFechaDeValidez_UTC
          <DisplayName("Numeración / Serie")>
          Public Property ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaNumeracionSerie As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaNumeracionSerie"",""etiqueta"": ""Numeración / Serie"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""titulo"": ""Base - Numeraciones / Series"",""iconoid"": ""5ae6b089-a12a-417c-92c2-d64de875e355"",""etiquetasingular"": ""Numeración / Serie"",""etiquetaplural"": ""Numeraciones / Series"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Numeración / Serie"",""descripcion"": """",""keyword"": ""ReferenciaNumeracionSerie"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaNumeracionSerie
          <Description("Es el número secuencial que el sistema emite cada vez que se realiza una transacción.")>
          <DisplayName("Nº Reserva (Numérico)")>
          Public Property NReservaNumerico As Integer
          Public Shared ___NReservaNumerico As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NReservaNumerico"",""etiqueta"": ""Nº Reserva (Numérico)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº Reserva (Numérico)"",""descripcion"": """",""keyword"": ""NReservaNumerico"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NReservaNumerico As DinaNETCore.APID.DinaupAPI_CampoC = ___NReservaNumerico
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Nº Reserva (Texto)")>
          Public Property NReservaTexto As String
          Public Shared ___NReservaTexto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NReservaTexto"",""etiqueta"": ""Nº Reserva (Texto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº Reserva (Texto)"",""descripcion"": """",""keyword"": ""NReservaTexto"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NReservaTexto As DinaNETCore.APID.DinaupAPI_CampoC = ___NReservaTexto
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Tipo de movimiento")>
          Public Property ReferenciaTipoDeMovimiento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeMovimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeMovimiento"",""etiqueta"": ""Tipo de movimiento"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""titulo"": ""Base - Tipos de movimiento"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de movimiento"",""etiquetaplural"": ""Tipos de movimiento"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de movimiento"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeMovimiento"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeMovimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeMovimiento
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <Description("Número total de productos.")>
          <DisplayName("Cantidad de Productos")>
          Public Property CantidadDeProductos As Decimal
          Public Shared ___CantidadDeProductos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductos"",""etiqueta"": ""Cantidad de Productos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de Productos"",""descripcion"": """",""keyword"": ""CantidadDeProductos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductos As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductos
          <DisplayName("Cliente")>
          Public Property ReferenciaCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCliente"",""etiqueta"": ""Cliente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cliente"",""descripcion"": """",""keyword"": ""ReferenciaCliente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCliente
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Días de validez")>
          Public Property DiasDeValidez As Integer
          Public Shared ___DiasDeValidez As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DiasDeValidez"",""etiqueta"": ""Días de validez"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Días de validez"",""descripcion"": """",""keyword"": ""DiasDeValidez"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DiasDeValidez As DinaNETCore.APID.DinaupAPI_CampoC = ___DiasDeValidez
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b5a49957-7bc2-4e31-9657-0b0191607da2"",""titulo"": ""Reservas"",""iconoid"": ""51822e7b-2d6f-4193-bff6-57a07cdcd886"",""etiquetasingular"": ""Reserva"",""etiquetaplural"": ""Reservas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b5a49957-7bc2-4e31-9657-0b0191607da2"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Referencia")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Referencia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Referencia"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TextoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___TextoPrincipal
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha Alta Dato")>
          Public Property FechaAltaDato_UTC As Date
          Public Shared ___FechaAltaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAltaDato_UTC"",""etiqueta"": ""Fecha Alta Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta Dato"",""descripcion"": """",""keyword"": ""FechaAltaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAltaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAltaDato_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Editado")>
          Public Property FechaUltimaModificacion_UTC As Date
          Public Shared ___FechaUltimaModificacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaUltimaModificacion_UTC"",""etiqueta"": ""Editado"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Editado"",""descripcion"": """",""keyword"": ""FechaUltimaModificacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaUltimaModificacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaUltimaModificacion_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Eliminado")>
          Public Property Eliminado As Boolean
          Public Shared ___Eliminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": true,""keyword"": ""Eliminado"",""etiqueta"": ""Eliminado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Eliminado"",""descripcion"": """",""keyword"": ""Eliminado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Eliminado As DinaNETCore.APID.DinaupAPI_CampoC = ___Eliminado
          <ReadOnlyAttribute(True)>
          <DisplayName("Usuario Creador del dato")>
          Public Property UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___UsuarioCreadorDelDAto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UsuarioCreadorDelDAto"",""etiqueta"": ""Usuario Creador del dato"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Usuario Creador del dato"",""descripcion"": """",""keyword"": ""UsuarioCreadorDelDAto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_CampoC = ___UsuarioCreadorDelDAto
          <DisplayName("Sección (Relación Sistema)")>
          Public Property Seccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___Seccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Seccion"",""etiqueta"": ""Sección (Relación Sistema)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección (Relación Sistema)"",""descripcion"": """",""keyword"": ""Seccion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Seccion As DinaNETCore.APID.DinaupAPI_CampoC = ___Seccion
          <DisplayName("Posición (Orden)")>
          Public Property Posicion As Decimal
          Public Shared ___Posicion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Posicion"",""etiqueta"": ""Posición (Orden)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Posición (Orden)"",""descripcion"": """",""keyword"": ""Posicion"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Posicion As DinaNETCore.APID.DinaupAPI_CampoC = ___Posicion
          <ReadOnlyAttribute(True)>
          <DisplayName("Empresa")>
          Public Property Empresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___Empresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Empresa"",""etiqueta"": ""Empresa"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""titulo"": ""Empresas administradas"",""iconoid"": ""b788149e-1c15-4807-9a25-72adf3333e5b"",""etiquetasingular"": ""Empresa administrada"",""etiquetaplural"": ""Empresas administradas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa"",""descripcion"": """",""keyword"": ""Empresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Empresa As DinaNETCore.APID.DinaupAPI_CampoC = ___Empresa
          <ReadOnlyAttribute(True)>
          <DisplayName("Modificado")>
          Public Property Modificado As Boolean
          Public Shared ___Modificado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Modificado"",""etiqueta"": ""Modificado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificado"",""descripcion"": """",""keyword"": ""Modificado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Modificado As DinaNETCore.APID.DinaupAPI_CampoC = ___Modificado
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha Indice Actividad")>
          Public Property FechaIndiceActividad_UTC As Date
          Public Shared ___FechaIndiceActividad_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaIndiceActividad_UTC"",""etiqueta"": ""Fecha Indice Actividad"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Indice Actividad"",""descripcion"": """",""keyword"": ""FechaIndiceActividad_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaIndiceActividad_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaIndiceActividad_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha de Sincronización")>
          Public Property Fechadesincronizacion_UTC As Date
          Public Shared ___Fechadesincronizacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Fechadesincronizacion_UTC"",""etiqueta"": ""Fecha de Sincronización"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de Sincronización"",""descripcion"": """",""keyword"": ""Fechadesincronizacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __Fechadesincronizacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___Fechadesincronizacion_UTC
          Overrides Sub CargarDatos(_Datos as Dic(of string,string))
          me.ReferenciaPresupuestoDeVentaReferenciaDeOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105962"), _Datos.Leer_String("pr_10040105962.nombre"))
          me.ClienteTieneAccesoWeb = _Datos.Leer_Boolean("pr_500401057768")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_300401055525")
          me.LimiteFechaDeValidez_UTC = _Datos.Leer_DateTime_Nulable("pr_500401057770")
          me.ReferenciaNumeracionSerie = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401057766"), _Datos.Leer_String("pr_500401057766.nombre"))
          me.NReservaNumerico = _Datos.Leer_Integer("pr_500401057769")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_30040105555")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401055510"), _Datos.Leer_String("pr_300401055510.nombre"))
          me.NReservaTexto = _Datos.Leer_String("pr_500401057772")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040105552"), _Datos.Leer_String("pr_30040105552.nombre"))
          me.ReferenciaTipoDeMovimiento = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401057765"), _Datos.Leer_String("pr_500401057765.nombre"))
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040105551"), _Datos.Leer_String("pr_30040105551.nombre"))
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401057763"), _Datos.Leer_String("pr_500401057763.nombre"))
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_300401055527")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_30040105557")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_30040105554")
          me.Observaciones = _Datos.Leer_String("pr_500401057771")
          me.CantidadDeProductos = _Datos.Leer_Decimal("pr_500401057760")
          me.ReferenciaCliente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401057764"), _Datos.Leer_String("pr_500401057764.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040105553"), _Datos.Leer_String("pr_30040105553.nombre"))
          me.DiasDeValidez = _Datos.Leer_Integer("pr_60040176513")
          me.ID = _Datos.Leer_Guid("id")
          me.TextoPrincipal = _Datos.Leer_String("nombre")
          me.FechaAltaDato_UTC = _Datos.Leer_DateTime("fecha")
          me.FechaUltimaModificacion_UTC = _Datos.Leer_DateTime("fecham")
          me.Eliminado = _Datos.Leer_Boolean("eliminado")
          me.UsuarioCreadorDelDAto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("usuarioid"), _Datos.Leer_String("usuarioid.nombre"))
          me.Seccion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("plantillapid"), _Datos.Leer_String("plantillapid.nombre"))
          me.Posicion = _Datos.Leer_Decimal("posicion")
          me.Empresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("ubicacion"), _Datos.Leer_String("ubicacion.nombre"))
          me.Modificado = _Datos.Leer_Boolean("modificado")
          me.FechaIndiceActividad_UTC = _Datos.Leer_DateTime("fechaia")
          me.Fechadesincronizacion_UTC = _Datos.Leer_DateTime("fechasyn")
          End Sub
          Overrides Function ToDic() as Dic(of String,String)
           dim R as new Dic(of String,String)
         If Me.ReferenciaPresupuestoDeVentaReferenciaDeOrigen IsNot nothing then
           R.add("pr_10040105962",me.ReferenciaPresupuestoDeVentaReferenciaDeOrigen.ID.STR())
         Else
           R.add("pr_10040105962","")
         End if
         R.add("pr_500401057768", me.ClienteTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_300401055525", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_500401057770", me.LimiteFechaDeValidez_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaNumeracionSerie IsNot nothing then
           R.add("pr_500401057766",me.ReferenciaNumeracionSerie.ID.STR())
         Else
           R.add("pr_500401057766","")
         End if
         R.add("pr_500401057769", me.NReservaNumerico.AdaptarMySQL_Integer())
         R.add("pr_30040105555", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_300401055510",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_300401055510","")
         End if
         R.add("pr_500401057772", me.NReservaTexto.AdaptarMySQL_String())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_30040105552",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_30040105552","")
         End if
         If Me.ReferenciaTipoDeMovimiento IsNot nothing then
           R.add("pr_500401057765",me.ReferenciaTipoDeMovimiento.ID.STR())
         Else
           R.add("pr_500401057765","")
         End if
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_30040105551",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_30040105551","")
         End if
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_500401057763",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_500401057763","")
         End if
         R.add("pr_300401055527", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_30040105557", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040105554", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_500401057771", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_500401057760", me.CantidadDeProductos.AdaptarMySQL_Decimal())
         If Me.ReferenciaCliente IsNot nothing then
           R.add("pr_500401057764",me.ReferenciaCliente.ID.STR())
         Else
           R.add("pr_500401057764","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_30040105553",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_30040105553","")
         End if
         R.add("pr_60040176513", me.DiasDeValidez.AdaptarMySQL_Integer())
         R.add("id", me.ID.AdaptarMySQL_Guid())
         R.add("nombre", me.TextoPrincipal.AdaptarMySQL_String())
         R.add("fecha", me.FechaAltaDato_UTC.AdaptarMySQL_DateTime())
         R.add("fecham", me.FechaUltimaModificacion_UTC.AdaptarMySQL_DateTime())
         R.add("eliminado", me.Eliminado.AdaptarMySQL_Boolean())
         If Me.UsuarioCreadorDelDAto IsNot nothing then
           R.add("usuarioid",me.UsuarioCreadorDelDAto.ID.STR())
         Else
           R.add("usuarioid","")
         End if
         If Me.Seccion IsNot nothing then
           R.add("plantillapid",me.Seccion.ID.STR())
         Else
           R.add("plantillapid","")
         End if
         R.add("posicion", me.Posicion.AdaptarMySQL_Decimal())
         If Me.Empresa IsNot nothing then
           R.add("ubicacion",me.Empresa.ID.STR())
         Else
           R.add("ubicacion","")
         End if
         R.add("modificado", me.Modificado.AdaptarMySQL_Boolean())
         R.add("fechaia", me.FechaIndiceActividad_UTC.AdaptarMySQL_DateTime())
         R.add("fechasyn", me.Fechadesincronizacion_UTC.AdaptarMySQL_DateTime())
            Return R
          End Function
          Sub new()
          End Sub
      End Class
      Public Class Reservas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of ReservasListaD.ReservasLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of ReservasListaD.ReservasLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New ReservasListaD.ReservasLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


          Public property ReferenciaPresupuestoDeVentaReferenciaDeOrigen As Guid
            get
                return me.GetValue_Guid("pr_10040105962")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040105962", value)
            End Set
          End Property
          Public property ClienteTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500401057768")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401057768", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300401055525")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300401055525", value)
            End Set
          End Property
        Public ReadOnly property LimiteFechaDeValidez_UTC As Date
            get
                return me.GetValue_DateTime("pr_500401057770")
            End Get   
        End Property
          Public property ReferenciaNumeracionSerie As Guid
            get
                return me.GetValue_Guid("pr_500401057766")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401057766", value)
            End Set
          End Property
          Public property NReservaNumerico As Integer
            get
                return me.GetValue_Int("pr_500401057769")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_500401057769", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_30040105555")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_300401055510")
            End Get   
        End Property
          Public property NReservaTexto As String
            get
                return me.GetValue_String("pr_500401057772")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500401057772", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040105552")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040105552", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTipoDeMovimiento As Guid
            get
                return me.GetValue_Guid("pr_500401057765")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040105551")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040105551", value)
            End Set
          End Property
          Public property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_500401057763")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401057763", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300401055527")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300401055527", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040105557")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040105557", value)
            End Set
          End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040105554")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040105554", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_500401057771")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500401057771", value)
            End Set
          End Property
        Public ReadOnly property CantidadDeProductos As Decimal
            get
                return me.GetValue_Decimal("pr_500401057760")
            End Get   
        End Property
          Public property ReferenciaCliente As Guid
            get
                return me.GetValue_Guid("pr_500401057764")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401057764", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040105553")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040105553", value)
            End Set
          End Property
          Public property DiasDeValidez As Integer
            get
                return me.GetValue_Int("pr_60040176513")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_60040176513", value)
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
          Public property Posicion As Decimal
            get
                return me.GetValue_Decimal("posicion")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("posicion", value)
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
