   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class PlazosPresentacionDeModelosFiscalesListaD
      Public Shared _SeccionID As String = "6eb9d6e9-14b4-4e3e-b096-12361447e555"
      Public Shared _SeccionIDGUID As New Guid("6eb9d6e9-14b4-4e3e-b096-12361447e555")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of PlazosPresentacionDeModelosFiscalesListaC )) 
          Dim R As New List(Of PlazosPresentacionDeModelosFiscalesListaC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(PlazosPresentacionDeModelosFiscalesListaES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New PlazosPresentacionDeModelosFiscalesListaC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Class PlazosPresentacionDeModelosFiscalesListaES
          Public shared _SeccionID as Guid = New Guid("6eb9d6e9-14b4-4e3e-b096-12361447e555")
          Public shared _Tabla$ = "tpr_40040185361_e"
      Public Shared ReferenciaDestinador$ = "pr_400401853620"
      Public Shared FechaAlta_UTC$ = "pr_400401853619"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400401853616"
      Public Shared HoraLocal$ = "pr_400401853618"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400401853621"
      Public Shared MesDeInicioDePlazo$ = "pr_50040185362"
      Public Shared DiaInicioDePlazo$ = "pr_50040185364"
      Public Shared MesDeFinDePlazo$ = "pr_50040185363"
      Public Shared DiaFinDePlazo$ = "pr_10040185375"
      Public Shared InicioDePlazoEnAñoSiguiente$ = "pr_30040237224"
      Public Shared FinDePlazoEnAñoSiguiente$ = "pr_30040237222"
      Public Shared PeriodoAPresentar$ = "pr_50040237904"
      Public Shared PeriodoRelativoAlInicioDeEjercicio$ = "pr_30040237911"
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
      Public Shared RelacionElementoContenedorListador$ = "idrelacionlistador"
      Public Shared Listadoreliminado$ = "listadoreliminado"
      End Class
      Public Class PlazosPresentacionDeModelosFiscalesListaC
      Inherits Base_DatoC
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Mes de Inicio de plazo")>
          Public Property MesDeInicioDePlazo As EnumMesE
          Public Shared ___MesDeInicioDePlazo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MesDeInicioDePlazo"",""etiqueta"": ""Mes de Inicio de plazo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 24,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5,6,7,8,9,10,11,12],""predefinidos_textos"": [""Indefinido"",""Enero"",""Febrero"",""Marzo"",""Abril"",""Mayo"",""Junio"",""Julio"",""Agosto"",""Septiembre"",""Octubre"",""Noviembre"",""Diciembre""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/24_0.png"",""https://cdn.dinaup.com/ico/enums/24_1.png"",""https://cdn.dinaup.com/ico/enums/24_2.png"",""https://cdn.dinaup.com/ico/enums/24_3.png"",""https://cdn.dinaup.com/ico/enums/24_4.png"",""https://cdn.dinaup.com/ico/enums/24_5.png"",""https://cdn.dinaup.com/ico/enums/24_6.png"",""https://cdn.dinaup.com/ico/enums/24_7.png"",""https://cdn.dinaup.com/ico/enums/24_8.png"",""https://cdn.dinaup.com/ico/enums/24_9.png"",""https://cdn.dinaup.com/ico/enums/24_10.png"",""https://cdn.dinaup.com/ico/enums/24_11.png"",""https://cdn.dinaup.com/ico/enums/24_12.png""],""filtro"": {""titulo"": ""Mes de Inicio de plazo"",""descripcion"": """",""keyword"": ""MesDeInicioDePlazo"",""formato"": 2,""rol"": 24,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Mes"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Enero""},{""valor"": 2, ""titulo"": ""Febrero""},{""valor"": 3, ""titulo"": ""Marzo""},{""valor"": 4, ""titulo"": ""Abril""},{""valor"": 5, ""titulo"": ""Mayo""},{""valor"": 6, ""titulo"": ""Junio""},{""valor"": 7, ""titulo"": ""Julio""},{""valor"": 8, ""titulo"": ""Agosto""},{""valor"": 9, ""titulo"": ""Septiembre""},{""valor"": 10, ""titulo"": ""Octubre""},{""valor"": 11, ""titulo"": ""Noviembre""},{""valor"": 12, ""titulo"": ""Diciembre""}]}},""solovalorespredefinidos"": true}")
          Public  __MesDeInicioDePlazo As DinaNETCore.APID.DinaupAPI_CampoC = ___MesDeInicioDePlazo
          <DisplayName("Día inicio de plazo")>
          Public Property DiaInicioDePlazo As Integer
          Public Shared ___DiaInicioDePlazo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DiaInicioDePlazo"",""etiqueta"": ""Día inicio de plazo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Día inicio de plazo"",""descripcion"": """",""keyword"": ""DiaInicioDePlazo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DiaInicioDePlazo As DinaNETCore.APID.DinaupAPI_CampoC = ___DiaInicioDePlazo
          <DisplayName("Mes de fin de plazo")>
          Public Property MesDeFinDePlazo As EnumMesE
          Public Shared ___MesDeFinDePlazo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MesDeFinDePlazo"",""etiqueta"": ""Mes de fin de plazo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 24,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5,6,7,8,9,10,11,12],""predefinidos_textos"": [""Indefinido"",""Enero"",""Febrero"",""Marzo"",""Abril"",""Mayo"",""Junio"",""Julio"",""Agosto"",""Septiembre"",""Octubre"",""Noviembre"",""Diciembre""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/24_0.png"",""https://cdn.dinaup.com/ico/enums/24_1.png"",""https://cdn.dinaup.com/ico/enums/24_2.png"",""https://cdn.dinaup.com/ico/enums/24_3.png"",""https://cdn.dinaup.com/ico/enums/24_4.png"",""https://cdn.dinaup.com/ico/enums/24_5.png"",""https://cdn.dinaup.com/ico/enums/24_6.png"",""https://cdn.dinaup.com/ico/enums/24_7.png"",""https://cdn.dinaup.com/ico/enums/24_8.png"",""https://cdn.dinaup.com/ico/enums/24_9.png"",""https://cdn.dinaup.com/ico/enums/24_10.png"",""https://cdn.dinaup.com/ico/enums/24_11.png"",""https://cdn.dinaup.com/ico/enums/24_12.png""],""filtro"": {""titulo"": ""Mes de fin de plazo"",""descripcion"": """",""keyword"": ""MesDeFinDePlazo"",""formato"": 2,""rol"": 24,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Mes"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Enero""},{""valor"": 2, ""titulo"": ""Febrero""},{""valor"": 3, ""titulo"": ""Marzo""},{""valor"": 4, ""titulo"": ""Abril""},{""valor"": 5, ""titulo"": ""Mayo""},{""valor"": 6, ""titulo"": ""Junio""},{""valor"": 7, ""titulo"": ""Julio""},{""valor"": 8, ""titulo"": ""Agosto""},{""valor"": 9, ""titulo"": ""Septiembre""},{""valor"": 10, ""titulo"": ""Octubre""},{""valor"": 11, ""titulo"": ""Noviembre""},{""valor"": 12, ""titulo"": ""Diciembre""}]}},""solovalorespredefinidos"": true}")
          Public  __MesDeFinDePlazo As DinaNETCore.APID.DinaupAPI_CampoC = ___MesDeFinDePlazo
          <DisplayName("Día fin de plazo")>
          Public Property DiaFinDePlazo As Integer
          Public Shared ___DiaFinDePlazo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DiaFinDePlazo"",""etiqueta"": ""Día fin de plazo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Día fin de plazo"",""descripcion"": """",""keyword"": ""DiaFinDePlazo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DiaFinDePlazo As DinaNETCore.APID.DinaupAPI_CampoC = ___DiaFinDePlazo
          <DisplayName("Inicio de plazo en Año siguiente")>
          Public Property InicioDePlazoEnAñoSiguiente As Boolean
          Public Shared ___InicioDePlazoEnAñoSiguiente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""InicioDePlazoEnAñoSiguiente"",""etiqueta"": ""Inicio de plazo en Año siguiente"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Inicio de plazo en Año siguiente"",""descripcion"": """",""keyword"": ""InicioDePlazoEnAñoSiguiente"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __InicioDePlazoEnAñoSiguiente As DinaNETCore.APID.DinaupAPI_CampoC = ___InicioDePlazoEnAñoSiguiente
          <DisplayName("Fin de plazo en Año siguiente")>
          Public Property FinDePlazoEnAñoSiguiente As Boolean
          Public Shared ___FinDePlazoEnAñoSiguiente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FinDePlazoEnAñoSiguiente"",""etiqueta"": ""Fin de plazo en Año siguiente"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fin de plazo en Año siguiente"",""descripcion"": """",""keyword"": ""FinDePlazoEnAñoSiguiente"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __FinDePlazoEnAñoSiguiente As DinaNETCore.APID.DinaupAPI_CampoC = ___FinDePlazoEnAñoSiguiente
          <DisplayName("Periodo a presentar")>
          Public Property PeriodoAPresentar As EnumIntervaloContablePeriodosE
          Public Shared ___PeriodoAPresentar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PeriodoAPresentar"",""etiqueta"": ""Periodo a presentar"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 80,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25],""predefinidos_textos"": [""Indefinido"",""Año"",""Mes 1"",""Mes 2"",""Mes 3"",""Mes 4"",""Mes 5"",""Mes 6"",""Mes 7"",""Mes 8"",""Mes 9"",""Mes 10"",""Mes 11"",""Mes 12"",""Bimestre 1"",""Bimestre 2"",""Bimestre 3"",""Bimestre 4"",""Bimestre 5"",""Bimestre 6"",""Trimestre 1"",""Trimestre 2"",""Trimestre 3"",""Trimestre 4"",""Semestre 1"",""Semestre 2""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/80_0.png"",""https://cdn.dinaup.com/ico/enums/80_1.png"",""https://cdn.dinaup.com/ico/enums/80_2.png"",""https://cdn.dinaup.com/ico/enums/80_3.png"",""https://cdn.dinaup.com/ico/enums/80_4.png"",""https://cdn.dinaup.com/ico/enums/80_5.png"",""https://cdn.dinaup.com/ico/enums/80_6.png"",""https://cdn.dinaup.com/ico/enums/80_7.png"",""https://cdn.dinaup.com/ico/enums/80_8.png"",""https://cdn.dinaup.com/ico/enums/80_9.png"",""https://cdn.dinaup.com/ico/enums/80_10.png"",""https://cdn.dinaup.com/ico/enums/80_11.png"",""https://cdn.dinaup.com/ico/enums/80_12.png"",""https://cdn.dinaup.com/ico/enums/80_13.png"",""https://cdn.dinaup.com/ico/enums/80_14.png"",""https://cdn.dinaup.com/ico/enums/80_15.png"",""https://cdn.dinaup.com/ico/enums/80_16.png"",""https://cdn.dinaup.com/ico/enums/80_17.png"",""https://cdn.dinaup.com/ico/enums/80_18.png"",""https://cdn.dinaup.com/ico/enums/80_19.png"",""https://cdn.dinaup.com/ico/enums/80_20.png"",""https://cdn.dinaup.com/ico/enums/80_21.png"",""https://cdn.dinaup.com/ico/enums/80_22.png"",""https://cdn.dinaup.com/ico/enums/80_23.png"",""https://cdn.dinaup.com/ico/enums/80_24.png"",""https://cdn.dinaup.com/ico/enums/80_25.png""],""filtro"": {""titulo"": ""Periodo a presentar"",""descripcion"": """",""keyword"": ""PeriodoAPresentar"",""formato"": 2,""rol"": 80,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Intervalo Contable (Periodos)"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Año""},{""valor"": 2, ""titulo"": ""Mes 1""},{""valor"": 3, ""titulo"": ""Mes 2""},{""valor"": 4, ""titulo"": ""Mes 3""},{""valor"": 5, ""titulo"": ""Mes 4""},{""valor"": 6, ""titulo"": ""Mes 5""},{""valor"": 7, ""titulo"": ""Mes 6""},{""valor"": 8, ""titulo"": ""Mes 7""},{""valor"": 9, ""titulo"": ""Mes 8""},{""valor"": 10, ""titulo"": ""Mes 9""},{""valor"": 11, ""titulo"": ""Mes 10""},{""valor"": 12, ""titulo"": ""Mes 11""},{""valor"": 13, ""titulo"": ""Mes 12""},{""valor"": 14, ""titulo"": ""Bimestre 1""},{""valor"": 15, ""titulo"": ""Bimestre 2""},{""valor"": 16, ""titulo"": ""Bimestre 3""},{""valor"": 17, ""titulo"": ""Bimestre 4""},{""valor"": 18, ""titulo"": ""Bimestre 5""},{""valor"": 19, ""titulo"": ""Bimestre 6""},{""valor"": 20, ""titulo"": ""Trimestre 1""},{""valor"": 21, ""titulo"": ""Trimestre 2""},{""valor"": 22, ""titulo"": ""Trimestre 3""},{""valor"": 23, ""titulo"": ""Trimestre 4""},{""valor"": 24, ""titulo"": ""Semestre 1""},{""valor"": 25, ""titulo"": ""Semestre 2""}]}},""solovalorespredefinidos"": true}")
          Public  __PeriodoAPresentar As DinaNETCore.APID.DinaupAPI_CampoC = ___PeriodoAPresentar
          <Description("Cuando esta opción está marcada se comprende que el periodo a presentar se calculará de manera relativa al inicio del ejercicio." & vbCrLf & "De tal modo que, si el ejercicio empieza el 6 de Enero, el primer trimestre  será desde '' 6 de Enero hasta 5 de Marzo """)>
          <DisplayName("Periodo relativo al inicio de ejercicio")>
          Public Property PeriodoRelativoAlInicioDeEjercicio As Boolean
          Public Shared ___PeriodoRelativoAlInicioDeEjercicio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PeriodoRelativoAlInicioDeEjercicio"",""etiqueta"": ""Periodo relativo al inicio de ejercicio"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Periodo relativo al inicio de ejercicio"",""descripcion"": """",""keyword"": ""PeriodoRelativoAlInicioDeEjercicio"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PeriodoRelativoAlInicioDeEjercicio As DinaNETCore.APID.DinaupAPI_CampoC = ___PeriodoRelativoAlInicioDeEjercicio
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""6eb9d6e9-14b4-4e3e-b096-12361447e555"",""titulo"": ""Lista - Plazos presentación de modelos fiscales"",""iconoid"": ""eb519fc4-c3f0-4f21-8708-9bb6936da891"",""etiquetasingular"": ""Plazo de presentación de modelo fiscal"",""etiquetaplural"": ""Plazos presentación de modelos fiscales"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""6eb9d6e9-14b4-4e3e-b096-12361447e555"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Título")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Título"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Título"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          <ReadOnlyAttribute(True)>
          <DisplayName("Plazo de presentación de modelo fiscal (Listador) (Relación)")>
          Public Property RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___RelacionElementoContenedorListador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RelacionElementoContenedorListador"",""etiqueta"": ""Plazo de presentación de modelo fiscal (Listador) (Relación)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c3ec8d52-568f-419a-802a-c091a7891d45"",""titulo"": ""Plazos presentación de modelos fiscales"",""iconoid"": ""eb519fc4-c3f0-4f21-8708-9bb6936da891"",""etiquetasingular"": ""Plazo de presentación de modelo fiscal"",""etiquetaplural"": ""Plazos presentación de modelos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c3ec8d52-568f-419a-802a-c091a7891d45"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Plazo de presentación de modelo fiscal (Listador) (Relación)"",""descripcion"": """",""keyword"": ""RelacionElementoContenedorListador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_CampoC = ___RelacionElementoContenedorListador
          <DisplayName("Plazo de presentación de modelo fiscal (Listador) Eliminadoo *")>
          Public Property Listadoreliminado As Boolean
          Public Shared ___Listadoreliminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Listadoreliminado"",""etiqueta"": ""Plazo de presentación de modelo fiscal (Listador) Eliminadoo *"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Plazo de presentación de modelo fiscal (Listador) Eliminadoo *"",""descripcion"": """",""keyword"": ""Listadoreliminado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Listadoreliminado As DinaNETCore.APID.DinaupAPI_CampoC = ___Listadoreliminado
          Overrides Sub CargarDatos(_Datos as Dic(of string,string))
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_400401853620"), _Datos.Leer_String("pr_400401853620.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_400401853619")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_400401853616"), _Datos.Leer_String("pr_400401853616.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_400401853618")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_400401853621")
          me.MesDeInicioDePlazo = _Datos.Leer_EnumMesE("pr_50040185362")
          me.DiaInicioDePlazo = _Datos.Leer_Integer("pr_50040185364")
          me.MesDeFinDePlazo = _Datos.Leer_EnumMesE("pr_50040185363")
          me.DiaFinDePlazo = _Datos.Leer_Integer("pr_10040185375")
          me.InicioDePlazoEnAñoSiguiente = _Datos.Leer_Boolean("pr_30040237224")
          me.FinDePlazoEnAñoSiguiente = _Datos.Leer_Boolean("pr_30040237222")
          me.PeriodoAPresentar = _Datos.Leer_EnumIntervaloContablePeriodosE("pr_50040237904")
          me.PeriodoRelativoAlInicioDeEjercicio = _Datos.Leer_Boolean("pr_30040237911")
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
          me.RelacionElementoContenedorListador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("idrelacionlistador"), _Datos.Leer_String("idrelacionlistador.nombre"))
          me.Listadoreliminado = _Datos.Leer_Boolean("listadoreliminado")
          End Sub
          Overrides Function ToDic() as Dic(of String,String)
           dim R as new Dic(of String,String)
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_400401853620",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_400401853620","")
         End if
         R.add("pr_400401853619", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_400401853616",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_400401853616","")
         End if
         R.add("pr_400401853618", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_400401853621", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_50040185362", me.MesDeInicioDePlazo.AdaptarMySQL_EnumMesE())
         R.add("pr_50040185364", me.DiaInicioDePlazo.AdaptarMySQL_Integer())
         R.add("pr_50040185363", me.MesDeFinDePlazo.AdaptarMySQL_EnumMesE())
         R.add("pr_10040185375", me.DiaFinDePlazo.AdaptarMySQL_Integer())
         R.add("pr_30040237224", me.InicioDePlazoEnAñoSiguiente.AdaptarMySQL_Boolean())
         R.add("pr_30040237222", me.FinDePlazoEnAñoSiguiente.AdaptarMySQL_Boolean())
         R.add("pr_50040237904", me.PeriodoAPresentar.AdaptarMySQL_EnumIntervaloContablePeriodosE())
         R.add("pr_30040237911", me.PeriodoRelativoAlInicioDeEjercicio.AdaptarMySQL_Boolean())
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
         If Me.RelacionElementoContenedorListador IsNot nothing then
           R.add("idrelacionlistador",me.RelacionElementoContenedorListador.ID.STR())
         Else
           R.add("idrelacionlistador","")
         End if
         R.add("listadoreliminado", me.Listadoreliminado.AdaptarMySQL_Boolean())
            Return R
          End Function
          Sub new()
          End Sub
      End Class
      Public Class PlazosPresentacionDeModelosFiscalesLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_400401853620")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_400401853619")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_400401853619", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_400401853616")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_400401853616", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_400401853618")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_400401853621")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400401853621", value)
            End Set
          End Property
          Public property MesDeInicioDePlazo__Int as Integer
            get
                return me.GetValue_Int("pr_50040185362")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_50040185362", value)
            End Set
          End Property
          Public property MesDeInicioDePlazo As EnumMesE
            get
                return me.GetValue_Int("pr_50040185362")
            End Get
            Set(value As EnumMesE)
                me.SetValue_Int("pr_50040185362", value)
            End Set
          End Property
          Public property DiaInicioDePlazo As Integer
            get
                return me.GetValue_Int("pr_50040185364")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_50040185364", value)
            End Set
          End Property
          Public property MesDeFinDePlazo__Int as Integer
            get
                return me.GetValue_Int("pr_50040185363")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_50040185363", value)
            End Set
          End Property
          Public property MesDeFinDePlazo As EnumMesE
            get
                return me.GetValue_Int("pr_50040185363")
            End Get
            Set(value As EnumMesE)
                me.SetValue_Int("pr_50040185363", value)
            End Set
          End Property
          Public property DiaFinDePlazo As Integer
            get
                return me.GetValue_Int("pr_10040185375")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_10040185375", value)
            End Set
          End Property
          Public property InicioDePlazoEnAñoSiguiente As Boolean
            get
                return me.GetValue_Boolean("pr_30040237224")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040237224", value)
            End Set
          End Property
          Public property FinDePlazoEnAñoSiguiente As Boolean
            get
                return me.GetValue_Boolean("pr_30040237222")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040237222", value)
            End Set
          End Property
          Public property PeriodoAPresentar__Int as Integer
            get
                return me.GetValue_Int("pr_50040237904")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_50040237904", value)
            End Set
          End Property
          Public property PeriodoAPresentar As EnumIntervaloContablePeriodosE
            get
                return me.GetValue_Int("pr_50040237904")
            End Get
            Set(value As EnumIntervaloContablePeriodosE)
                me.SetValue_Int("pr_50040237904", value)
            End Set
          End Property
          Public property PeriodoRelativoAlInicioDeEjercicio As Boolean
            get
                return me.GetValue_Boolean("pr_30040237911")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040237911", value)
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
        Public ReadOnly property RelacionElementoContenedorListador As Guid
            get
                return me.GetValue_Guid("idrelacionlistador")
            End Get   
        End Property
          Public property Listadoreliminado As Boolean
            get
                return me.GetValue_Boolean("listadoreliminado")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("listadoreliminado", value)
            End Set
          End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
