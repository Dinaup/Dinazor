   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class ArrendamientosD
      Public Shared _SeccionID As String = "c25d921d-357b-44c6-a9be-5a61878d300b"
      Public Shared _SeccionIDGUID As New Guid("c25d921d-357b-44c6-a9be-5a61878d300b")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of ArrendamientosC )) 
          Dim R As New List(Of ArrendamientosC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ArrendamientosES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New ArrendamientosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ArrendamientosC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ArrendamientosC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ArrendamientosC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ArrendamientosES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Arrendamientos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ArrendamientosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Arrendamientos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Arrendamientos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ArrendamientosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Arrendamientos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ArrendamientosES
          Public shared _SeccionID as Guid = New Guid("c25d921d-357b-44c6-a9be-5a61878d300b")
          Public shared _Tabla$ = "tpr_10040244941"
      Public Shared ReferenciaRetencion$ = "pr_10040251098"
      Public Shared ReferenciaCategoriaDeCompra$ = "pr_30040251091"
      Public Shared ReferenciaDestinador$ = "pr_100402449412"
      Public Shared ExportarEnModulos$ = "pr_100402449410"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040244947"
      Public Shared FechaAlta_UTC$ = "pr_100402449411"
      Public Shared HoraLocal$ = "pr_10040244949"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402449423"
      Public Shared SituacionCodigo$ = "pr_100402449426"
      Public Shared TipoDeVia$ = "pr_20040244941"
      Public Shared TipoDeNumeracion$ = "pr_20040244947"
      Public Shared CalificadorDelNumero$ = "pr_20040244948"
      Public Shared NumeroDeCasa$ = "pr_20040244949"
      Public Shared ReferenciaCatastral$ = "pr_100402449427"
      Public Shared Puerta$ = "pr_20040244942"
      Public Shared Planta$ = "pr_20040244943"
      Public Shared Escalera$ = "pr_20040244944"
      Public Shared EntidadArrendadoraTieneAccesoWeb$ = "pr_30040244943"
      Public Shared Portal$ = "pr_20040244945"
      Public Shared Bloque$ = "pr_20040244946"
      Public Shared ComplementoDomicilio$ = "pr_200402449410"
      Public Shared LocalidadPoblacion$ = "pr_200402449411"
      Public Shared NombreDelMunicipio$ = "pr_200402449412"
      Public Shared CodigoMunicipio$ = "pr_200402449413"
      Public Shared CodigoPostal$ = "pr_200402449416"
      Public Shared InicioContrato$ = "pr_30040244945"
      Public Shared Provincia$ = "pr_200402449414"
      Public Shared ProvinciaCodigo$ = "pr_200402449415"
      Public Shared NombreDeViaPublica$ = "pr_30040244941"
      Public Shared ReferenciaEntidadArrendadora$ = "pr_30040244942"
      Public Shared FinContrato$ = "pr_30040244944"
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
      Public Class ArrendamientosC
      Inherits Base_DatoC
          <DisplayName("Retención")>
          Public Property ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRetencion"",""etiqueta"": ""Retención"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""titulo"": ""Base - Retenciones"",""iconoid"": ""13560fd4-34fc-42bc-b12d-007e26e5f428"",""etiquetasingular"": ""Retención"",""etiquetaplural"": ""Retenciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Retención"",""descripcion"": """",""keyword"": ""ReferenciaRetencion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRetencion
          <DisplayName("Categoría de compra")>
          Public Property ReferenciaCategoriaDeCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCategoriaDeCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCategoriaDeCompra"",""etiqueta"": ""Categoría de compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e42cfcc0-282e-4e01-8973-abe0cd6f5231"",""titulo"": ""Base - Categorías de Compra"",""iconoid"": ""bc114f16-6aa6-4f43-9ef7-f99f41567980"",""etiquetasingular"": ""Categoría de Compra"",""etiquetaplural"": ""Categorías de Compra"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e42cfcc0-282e-4e01-8973-abe0cd6f5231"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Categoría de compra"",""descripcion"": """",""keyword"": ""ReferenciaCategoriaDeCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCategoriaDeCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCategoriaDeCompra
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Situación (Código)")>
          Public Property SituacionCodigo As String
          Public Shared ___SituacionCodigo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SituacionCodigo"",""etiqueta"": ""Situación (Código)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Situación (Código)"",""descripcion"": """",""keyword"": ""SituacionCodigo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SituacionCodigo As DinaNETCore.APID.DinaupAPI_CampoC = ___SituacionCodigo
          <DisplayName("Tipo de vía")>
          Public Property TipoDeVia As String
          Public Shared ___TipoDeVia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoDeVia"",""etiqueta"": ""Tipo de vía"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de vía"",""descripcion"": """",""keyword"": ""TipoDeVia"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TipoDeVia As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoDeVia
          <Description("Se consignará el tipo de numeración (Valores: NÚM ; KM. ; S/N; etc.).")>
          <DisplayName("Tipo de numeración")>
          Public Property TipoDeNumeracion As String
          Public Shared ___TipoDeNumeracion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoDeNumeracion"",""etiqueta"": ""Tipo de numeración"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de numeración"",""descripcion"": """",""keyword"": ""TipoDeNumeracion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TipoDeNumeracion As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoDeNumeracion
          <Description("Se consignará el calificador del número (valores BIS; DUP; MOD; ANT; etc / metros si Tipo Numer = KM.)")>
          <DisplayName("Calificador del número")>
          Public Property CalificadorDelNumero As String
          Public Shared ___CalificadorDelNumero As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CalificadorDelNumero"",""etiqueta"": ""Calificador del número"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Calificador del número"",""descripcion"": """",""keyword"": ""CalificadorDelNumero"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CalificadorDelNumero As DinaNETCore.APID.DinaupAPI_CampoC = ___CalificadorDelNumero
          <Description("Se consignará el número de casa o punto kilométrico.")>
          <DisplayName("Número de casa")>
          Public Property NumeroDeCasa As String
          Public Shared ___NumeroDeCasa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeCasa"",""etiqueta"": ""Número de casa"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de casa"",""descripcion"": """",""keyword"": ""NumeroDeCasa"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeCasa As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeCasa
          <DisplayName("Referencia catastral")>
          Public Property ReferenciaCatastral As String
          Public Shared ___ReferenciaCatastral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCatastral"",""etiqueta"": ""Referencia catastral"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Referencia catastral"",""descripcion"": """",""keyword"": ""ReferenciaCatastral"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCatastral As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCatastral
          <DisplayName("Puerta")>
          Public Property Puerta As String
          Public Shared ___Puerta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Puerta"",""etiqueta"": ""Puerta"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puerta"",""descripcion"": """",""keyword"": ""Puerta"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Puerta As DinaNETCore.APID.DinaupAPI_CampoC = ___Puerta
          <DisplayName("Planta")>
          Public Property Planta As String
          Public Shared ___Planta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Planta"",""etiqueta"": ""Planta"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Planta"",""descripcion"": """",""keyword"": ""Planta"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Planta As DinaNETCore.APID.DinaupAPI_CampoC = ___Planta
          <DisplayName("Escalera")>
          Public Property Escalera As String
          Public Shared ___Escalera As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Escalera"",""etiqueta"": ""Escalera"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Escalera"",""descripcion"": """",""keyword"": ""Escalera"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Escalera As DinaNETCore.APID.DinaupAPI_CampoC = ___Escalera
          <DisplayName("Entidad arrendadora Tiene Acceso web")>
          Public Property EntidadArrendadoraTieneAccesoWeb As Boolean
          Public Shared ___EntidadArrendadoraTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadArrendadoraTieneAccesoWeb"",""etiqueta"": ""Entidad arrendadora Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad arrendadora Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadArrendadoraTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadArrendadoraTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadArrendadoraTieneAccesoWeb
          <DisplayName("Portal")>
          Public Property Portal As String
          Public Shared ___Portal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Portal"",""etiqueta"": ""Portal"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Portal"",""descripcion"": """",""keyword"": ""Portal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Portal As DinaNETCore.APID.DinaupAPI_CampoC = ___Portal
          <DisplayName("Bloque")>
          Public Property Bloque As String
          Public Shared ___Bloque As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Bloque"",""etiqueta"": ""Bloque"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Bloque"",""descripcion"": """",""keyword"": ""Bloque"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Bloque As DinaNETCore.APID.DinaupAPI_CampoC = ___Bloque
          <Description("Datos complementarios del domicilio. Valores: Literal libre.(Ejemplos: ""Urbanización ..........""; ""Centro Comercial........, local ..........""; ""Mercado de .......... puesto nº .........""; ""Edificio .........""; etc).")>
          <DisplayName("Complemento domicilio")>
          Public Property ComplementoDomicilio As String
          Public Shared ___ComplementoDomicilio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ComplementoDomicilio"",""etiqueta"": ""Complemento domicilio"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Complemento domicilio"",""descripcion"": """",""keyword"": ""ComplementoDomicilio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ComplementoDomicilio As DinaNETCore.APID.DinaupAPI_CampoC = ___ComplementoDomicilio
          <Description("Se consignará el nombre de la localidad, de la población, etc, si es distinta al Municipio")>
          <DisplayName("Localidad / Población")>
          Public Property LocalidadPoblacion As String
          Public Shared ___LocalidadPoblacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""LocalidadPoblacion"",""etiqueta"": ""Localidad / Población"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Localidad / Población"",""descripcion"": """",""keyword"": ""LocalidadPoblacion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __LocalidadPoblacion As DinaNETCore.APID.DinaupAPI_CampoC = ___LocalidadPoblacion
          <Description("Se consignará el nombre de municipio" & vbCrLf & "Se consignará el correspondiente al inmueble arrendado.")>
          <DisplayName("Nombre del municipio")>
          Public Property NombreDelMunicipio As String
          Public Shared ___NombreDelMunicipio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombreDelMunicipio"",""etiqueta"": ""Nombre del municipio"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre del municipio"",""descripcion"": """",""keyword"": ""NombreDelMunicipio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombreDelMunicipio As DinaNETCore.APID.DinaupAPI_CampoC = ___NombreDelMunicipio
          <Description("Se consignará el CODIGO de municipio normalizado según Instituto Nacional de Estadística (INE).")>
          <DisplayName("Código municipio")>
          Public Property CodigoMunicipio As String
          Public Shared ___CodigoMunicipio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoMunicipio"",""etiqueta"": ""Código municipio"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código municipio"",""descripcion"": """",""keyword"": ""CodigoMunicipio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoMunicipio As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoMunicipio
          <Description("Se consignará el código postal correspondiente a la dirección del inmueble arrendado.")>
          <DisplayName("Código postal")>
          Public Property CodigoPostal As String
          Public Shared ___CodigoPostal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostal"",""etiqueta"": ""Código postal"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal"",""descripcion"": """",""keyword"": ""CodigoPostal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostal As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostal
          <DisplayName("Inicio contrato")>
          Public Property InicioContrato As Date?
          Public Shared ___InicioContrato As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""InicioContrato"",""etiqueta"": ""Inicio contrato"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Inicio contrato"",""descripcion"": """",""keyword"": ""InicioContrato"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __InicioContrato As DinaNETCore.APID.DinaupAPI_CampoC = ___InicioContrato
          <DisplayName("Provincia")>
          Public Property Provincia As String
          Public Shared ___Provincia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Provincia"",""etiqueta"": ""Provincia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 84,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia"",""descripcion"": """",""keyword"": ""Provincia"",""formato"": 5,""rol"": 84,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Provincia As DinaNETCore.APID.DinaupAPI_CampoC = ___Provincia
          <DisplayName("Provincia Código")>
          Public Property ProvinciaCodigo As String
          Public Shared ___ProvinciaCodigo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaCodigo"",""etiqueta"": ""Provincia Código"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 86,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia Código"",""descripcion"": """",""keyword"": ""ProvinciaCodigo"",""formato"": 5,""rol"": 86,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaCodigo As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaCodigo
          <DisplayName("Nombre de vía pública")>
          Public Property NombreDeViaPublica As String
          Public Shared ___NombreDeViaPublica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombreDeViaPublica"",""etiqueta"": ""Nombre de vía pública"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre de vía pública"",""descripcion"": """",""keyword"": ""NombreDeViaPublica"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombreDeViaPublica As DinaNETCore.APID.DinaupAPI_CampoC = ___NombreDeViaPublica
          <DisplayName("Entidad arrendadora")>
          Public Property ReferenciaEntidadArrendadora As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidadArrendadora As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidadArrendadora"",""etiqueta"": ""Entidad arrendadora"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad arrendadora"",""descripcion"": """",""keyword"": ""ReferenciaEntidadArrendadora"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidadArrendadora As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidadArrendadora
          <DisplayName("Fin contrato")>
          Public Property FinContrato As Date?
          Public Shared ___FinContrato As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FinContrato"",""etiqueta"": ""Fin contrato"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fin contrato"",""descripcion"": """",""keyword"": ""FinContrato"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FinContrato As DinaNETCore.APID.DinaupAPI_CampoC = ___FinContrato
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c25d921d-357b-44c6-a9be-5a61878d300b"",""titulo"": ""Arrendamientos"",""iconoid"": ""d375c3af-9675-4a22-a6ae-8d6cad100b19"",""etiquetasingular"": ""Arrendamiento"",""etiquetaplural"": ""Arrendamientos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c25d921d-357b-44c6-a9be-5a61878d300b"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Nombre")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Nombre"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaRetencion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040251098"), _Datos.Leer_String("pr_10040251098.nombre"))
          me.ReferenciaCategoriaDeCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040251091"), _Datos.Leer_String("pr_30040251091.nombre"))
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100402449412"), _Datos.Leer_String("pr_100402449412.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040244947"), _Datos.Leer_String("pr_10040244947.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_100402449411")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_10040244949")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_100402449423")
          me.SituacionCodigo = _Datos.Leer_String("pr_100402449426")
          me.TipoDeVia = _Datos.Leer_String("pr_20040244941")
          me.TipoDeNumeracion = _Datos.Leer_String("pr_20040244947")
          me.CalificadorDelNumero = _Datos.Leer_String("pr_20040244948")
          me.NumeroDeCasa = _Datos.Leer_String("pr_20040244949")
          me.ReferenciaCatastral = _Datos.Leer_String("pr_100402449427")
          me.Puerta = _Datos.Leer_String("pr_20040244942")
          me.Planta = _Datos.Leer_String("pr_20040244943")
          me.Escalera = _Datos.Leer_String("pr_20040244944")
          me.EntidadArrendadoraTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040244943")
          me.Portal = _Datos.Leer_String("pr_20040244945")
          me.Bloque = _Datos.Leer_String("pr_20040244946")
          me.ComplementoDomicilio = _Datos.Leer_String("pr_200402449410")
          me.LocalidadPoblacion = _Datos.Leer_String("pr_200402449411")
          me.NombreDelMunicipio = _Datos.Leer_String("pr_200402449412")
          me.CodigoMunicipio = _Datos.Leer_String("pr_200402449413")
          me.CodigoPostal = _Datos.Leer_String("pr_200402449416")
          me.InicioContrato = _Datos.Leer_Date_Nulable("pr_30040244945")
          me.Provincia = _Datos.Leer_String("pr_200402449414")
          me.ProvinciaCodigo = _Datos.Leer_String("pr_200402449415")
          me.NombreDeViaPublica = _Datos.Leer_String("pr_30040244941")
          me.ReferenciaEntidadArrendadora = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040244942"), _Datos.Leer_String("pr_30040244942.nombre"))
          me.FinContrato = _Datos.Leer_Date_Nulable("pr_30040244944")
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
         If Me.ReferenciaRetencion IsNot nothing then
           R.add("pr_10040251098",me.ReferenciaRetencion.ID.STR())
         Else
           R.add("pr_10040251098","")
         End if
         If Me.ReferenciaCategoriaDeCompra IsNot nothing then
           R.add("pr_30040251091",me.ReferenciaCategoriaDeCompra.ID.STR())
         Else
           R.add("pr_30040251091","")
         End if
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_100402449412",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_100402449412","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_10040244947",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_10040244947","")
         End if
         R.add("pr_100402449411", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_10040244949", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_100402449423", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_100402449426", me.SituacionCodigo.AdaptarMySQL_String())
         R.add("pr_20040244941", me.TipoDeVia.AdaptarMySQL_String())
         R.add("pr_20040244947", me.TipoDeNumeracion.AdaptarMySQL_String())
         R.add("pr_20040244948", me.CalificadorDelNumero.AdaptarMySQL_String())
         R.add("pr_20040244949", me.NumeroDeCasa.AdaptarMySQL_String())
         R.add("pr_100402449427", me.ReferenciaCatastral.AdaptarMySQL_String())
         R.add("pr_20040244942", me.Puerta.AdaptarMySQL_String())
         R.add("pr_20040244943", me.Planta.AdaptarMySQL_String())
         R.add("pr_20040244944", me.Escalera.AdaptarMySQL_String())
         R.add("pr_30040244943", me.EntidadArrendadoraTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_20040244945", me.Portal.AdaptarMySQL_String())
         R.add("pr_20040244946", me.Bloque.AdaptarMySQL_String())
         R.add("pr_200402449410", me.ComplementoDomicilio.AdaptarMySQL_String())
         R.add("pr_200402449411", me.LocalidadPoblacion.AdaptarMySQL_String())
         R.add("pr_200402449412", me.NombreDelMunicipio.AdaptarMySQL_String())
         R.add("pr_200402449413", me.CodigoMunicipio.AdaptarMySQL_String())
         R.add("pr_200402449416", me.CodigoPostal.AdaptarMySQL_String())
         R.add("pr_30040244945", me.InicioContrato.AdaptarMySQL_Date_Nulable())
         R.add("pr_200402449414", me.Provincia.AdaptarMySQL_String())
         R.add("pr_200402449415", me.ProvinciaCodigo.AdaptarMySQL_String())
         R.add("pr_30040244941", me.NombreDeViaPublica.AdaptarMySQL_String())
         If Me.ReferenciaEntidadArrendadora IsNot nothing then
           R.add("pr_30040244942",me.ReferenciaEntidadArrendadora.ID.STR())
         Else
           R.add("pr_30040244942","")
         End if
         R.add("pr_30040244944", me.FinContrato.AdaptarMySQL_Date_Nulable())
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
      Public Class Arrendamientos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaRetencion As Guid
            get
                return me.GetValue_Guid("pr_10040251098")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040251098", value)
            End Set
          End Property
          Public property ReferenciaCategoriaDeCompra As Guid
            get
                return me.GetValue_Guid("pr_30040251091")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040251091", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100402449412")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_10040244947")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040244947", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100402449411")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100402449411", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_10040244949")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100402449423")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100402449423", value)
            End Set
          End Property
          Public property SituacionCodigo As String
            get
                return me.GetValue_String("pr_100402449426")
            End Get
            Set(value As String)
                me.SetValue_String("pr_100402449426", value)
            End Set
          End Property
          Public property TipoDeVia As String
            get
                return me.GetValue_String("pr_20040244941")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244941", value)
            End Set
          End Property
          Public property TipoDeNumeracion As String
            get
                return me.GetValue_String("pr_20040244947")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244947", value)
            End Set
          End Property
          Public property CalificadorDelNumero As String
            get
                return me.GetValue_String("pr_20040244948")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244948", value)
            End Set
          End Property
          Public property NumeroDeCasa As String
            get
                return me.GetValue_String("pr_20040244949")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244949", value)
            End Set
          End Property
          Public property ReferenciaCatastral As String
            get
                return me.GetValue_String("pr_100402449427")
            End Get
            Set(value As String)
                me.SetValue_String("pr_100402449427", value)
            End Set
          End Property
          Public property Puerta As String
            get
                return me.GetValue_String("pr_20040244942")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244942", value)
            End Set
          End Property
          Public property Planta As String
            get
                return me.GetValue_String("pr_20040244943")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244943", value)
            End Set
          End Property
          Public property Escalera As String
            get
                return me.GetValue_String("pr_20040244944")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244944", value)
            End Set
          End Property
          Public property EntidadArrendadoraTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040244943")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040244943", value)
            End Set
          End Property
          Public property Portal As String
            get
                return me.GetValue_String("pr_20040244945")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244945", value)
            End Set
          End Property
          Public property Bloque As String
            get
                return me.GetValue_String("pr_20040244946")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040244946", value)
            End Set
          End Property
          Public property ComplementoDomicilio As String
            get
                return me.GetValue_String("pr_200402449410")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200402449410", value)
            End Set
          End Property
          Public property LocalidadPoblacion As String
            get
                return me.GetValue_String("pr_200402449411")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200402449411", value)
            End Set
          End Property
          Public property NombreDelMunicipio As String
            get
                return me.GetValue_String("pr_200402449412")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200402449412", value)
            End Set
          End Property
          Public property CodigoMunicipio As String
            get
                return me.GetValue_String("pr_200402449413")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200402449413", value)
            End Set
          End Property
          Public property CodigoPostal As String
            get
                return me.GetValue_String("pr_200402449416")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200402449416", value)
            End Set
          End Property
          Public property InicioContrato As Date
            get
                return me.GetValue_Date("pr_30040244945")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_30040244945", value)
            End Set
          End Property
          Public property Provincia As String
            get
                return me.GetValue_String("pr_200402449414")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200402449414", value)
            End Set
          End Property
          Public property ProvinciaCodigo As String
            get
                return me.GetValue_String("pr_200402449415")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200402449415", value)
            End Set
          End Property
          Public property NombreDeViaPublica As String
            get
                return me.GetValue_String("pr_30040244941")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040244941", value)
            End Set
          End Property
          Public property ReferenciaEntidadArrendadora As Guid
            get
                return me.GetValue_Guid("pr_30040244942")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040244942", value)
            End Set
          End Property
          Public property FinContrato As Date
            get
                return me.GetValue_Date("pr_30040244944")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_30040244944", value)
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
