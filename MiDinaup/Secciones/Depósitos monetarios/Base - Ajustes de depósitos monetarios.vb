   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class AjustesDeDepositosMonetariosBaseD
      Public Class AjustesDeDepositosMonetariosBase_ConListaC
      Public Listador as AjustesDeDepositosMonetariosBaseC
      Public Lista As New List(of AjustesDeDepositosMonetariosBaseListaD.AjustesDeDepositosMonetariosBaseListaC)
        sub new(_listador  as AjustesDeDepositosMonetariosBaseC, _lista as List(of AjustesDeDepositosMonetariosBaseListaD.AjustesDeDepositosMonetariosBaseListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "e311faf7-2b95-4470-85de-2fdbeb836e93"
      Public Shared _SeccionIDGUID As New Guid("e311faf7-2b95-4470-85de-2fdbeb836e93")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of AjustesDeDepositosMonetariosBaseC )) 
          Dim R As New List(Of AjustesDeDepositosMonetariosBaseC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(AjustesDeDepositosMonetariosBaseES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New AjustesDeDepositosMonetariosBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  AjustesDeDepositosMonetariosBase_ConListaC)) 
          Dim R As New List(Of AjustesDeDepositosMonetariosBase_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(AjustesDeDepositosMonetariosBaseES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New AjustesDeDepositosMonetariosBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of AjustesDeDepositosMonetariosBaseListaD.AjustesDeDepositosMonetariosBaseListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New AjustesDeDepositosMonetariosBaseListaD.AjustesDeDepositosMonetariosBaseListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New AjustesDeDepositosMonetariosBase_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Class AjustesDeDepositosMonetariosBaseES
          Public shared _SeccionID as Guid = New Guid("e311faf7-2b95-4470-85de-2fdbeb836e93")
          Public shared _Tabla$ = "tpr_66bf9bd5"
      Public Shared ReferenciaMetodoDePagoRetiroObsoleto$ = "pr_18f0f3013cx28wd"
      Public Shared ReferenciaMetodoDePago$ = "pr_18f0f0d1b9x1c5wd"
      Public Shared EntidadAfectadaTieneAccesoWeb$ = "pr_146310d74ah378wd"
      Public Shared FechaDeTramitacionYValidacionRetiroObsoleto_UTC$ = "pr_18f1071b69x351wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b42362x268wd"
      Public Shared ImporteImporteRetiro$ = "pr_18f0fdf68dx109wd"
      Public Shared RetiroEstadoObsoleto$ = "pr_18f103b1dfx3e3wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42384x298wd"
      Public Shared ReferenciaTransaccionInterna$ = "pr_20040106091"
      Public Shared ReferenciaChequeOPagareRetiro$ = "pr_18f100e8a6x20dwd"
      Public Shared ReferenciaDestinador$ = "pr_14631065ecx3d0wd"
      Public Shared HoraLocal$ = "pr_776ae4ewd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14631497aexdfwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310652fx381wd"
      Public Shared FechaDeTramitacionYValidacion_UTC$ = "pr_18f107b182x130wd"
      Public Shared FechaDeVencimiento$ = "pr_18f104e2d3x292wd"
      Public Shared ImporteTotalAjustado$ = "pr_66c1fa79"
      Public Shared TodoTramitadoYValidadoObsoleto$ = "pr_472c360x3a1wc"
      Public Shared ReferenciaChequeOPagare$ = "pr_18f0ffc487xcfwd"
      Public Shared ImporteImporteAfectadoADeposito$ = "pr_2479n"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ed43x1d9wd"
      Public Shared ImporteImporteIngreso$ = "pr_18f0f7f0a1x389wd"
      Public Shared ExportarEnModulos$ = "pr_1463106585x2f9wd"
      Public Shared ReferenciaTransaccionSecundaria$ = "pr_10040114146"
      Public Shared ReferenciaDepositoMonetario$ = "pr_2303n"
      Public Shared FechaDato_UTC$ = "pr_1463106559xf2wd"
      Public Shared Estado$ = "pr_18f101d739x391wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b590a9g2aewd"
      Public Shared Observaciones$ = "pr_66c2edd5"
      Public Shared ReferenciaMovimientoEntreDepositos$ = "pr_4e54e6ax84wc"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_442d246x126wc"
      Public Shared ImporteTotalPagadoTramitado$ = "pr_472c014x7bwc"
      Public Shared ImporteImporteAfectadoADepositoTramitado$ = "pr_2361n"
      Public Shared ReferenciaEntidadAfectada$ = "pr_2430"
      Public Shared FechaDeVencimientoRetiroObsoleto$ = "pr_18f105796fx20cwd"
      Public Shared FechaContable$ = "pr_10040135712"
      Public Shared ReferenciaEmpleadoQueTramitaYValida$ = "pr_60040141241"
      Public Shared EmpleadoQueTramitaYValidaTieneAccesoWeb$ = "pr_60040141242"
      Public Shared FechaLocalDeTramitacionYValidacion$ = "pr_20040141264"
      Public Shared Concepto$ = "pr_60040263353"
      Public Shared ReferenciaMovimientoBancario$ = "pr_30040264608"
      Public Shared ReferenciaAsientoContable$ = "pr_60040135502"
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
      Public Class AjustesDeDepositosMonetariosBaseC
      Inherits Base_DatoC
          <DisplayName("Método de pago (Retiro) (Obsoleto)")>
          Public Property ReferenciaMetodoDePagoRetiroObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMetodoDePagoRetiroObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMetodoDePagoRetiroObsoleto"",""etiqueta"": ""Método de pago (Retiro) (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""titulo"": ""Base - Métodos de pago"",""iconoid"": ""f72dab6e-3c9f-47cf-a0dd-d27ce9cd64b8"",""etiquetasingular"": ""Método de pago"",""etiquetaplural"": ""Métodos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Método de pago (Retiro) (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaMetodoDePagoRetiroObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMetodoDePagoRetiroObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMetodoDePagoRetiroObsoleto
          <DisplayName("Método de pago")>
          Public Property ReferenciaMetodoDePago As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMetodoDePago As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMetodoDePago"",""etiqueta"": ""Método de pago"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""titulo"": ""Base - Métodos de pago"",""iconoid"": ""f72dab6e-3c9f-47cf-a0dd-d27ce9cd64b8"",""etiquetasingular"": ""Método de pago"",""etiquetaplural"": ""Métodos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Método de pago"",""descripcion"": """",""keyword"": ""ReferenciaMetodoDePago"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMetodoDePago As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMetodoDePago
          <DisplayName("Entidad afectada Tiene Acceso web")>
          Public Property EntidadAfectadaTieneAccesoWeb As Boolean
          Public Shared ___EntidadAfectadaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadAfectadaTieneAccesoWeb"",""etiqueta"": ""Entidad afectada Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad afectada Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadAfectadaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadAfectadaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadAfectadaTieneAccesoWeb
          <DisplayName("Fecha de tramitación y validación (Retiro) (Obsoleto)")>
          Public Property FechaDeTramitacionYValidacionRetiroObsoleto_UTC As Date?
          Public Shared ___FechaDeTramitacionYValidacionRetiroObsoleto_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeTramitacionYValidacionRetiroObsoleto_UTC"",""etiqueta"": ""Fecha de tramitación y validación (Retiro) (Obsoleto)"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de tramitación y validación (Retiro) (Obsoleto)"",""descripcion"": """",""keyword"": ""FechaDeTramitacionYValidacionRetiroObsoleto_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeTramitacionYValidacionRetiroObsoleto_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeTramitacionYValidacionRetiroObsoleto_UTC
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Importe (Retiro)")>
          Public Property ImporteImporteRetiro As Decimal
          Public Shared ___ImporteImporteRetiro As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteRetiro"",""etiqueta"": ""Importe (Retiro)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe (Retiro)"",""descripcion"": """",""keyword"": ""ImporteImporteRetiro"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteRetiro As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteRetiro
          <DisplayName("Retiro Estado (Obsoleto)")>
          Public Property RetiroEstadoObsoleto As EnumTramitacionE
          Public Shared ___RetiroEstadoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RetiroEstadoObsoleto"",""etiqueta"": ""Retiro Estado (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 48,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""Pendiente"",""Tramitado"",""Cancelado""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/48_0.png"",""https://cdn.dinaup.com/ico/enums/48_1.png"",""https://cdn.dinaup.com/ico/enums/48_2.png"",""https://cdn.dinaup.com/ico/enums/48_3.png""],""filtro"": {""titulo"": ""Retiro Estado (Obsoleto)"",""descripcion"": """",""keyword"": ""RetiroEstadoObsoleto"",""formato"": 2,""rol"": 48,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tramitación"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Pendiente""},{""valor"": 2, ""titulo"": ""Tramitado""},{""valor"": 3, ""titulo"": ""Cancelado""}]}},""solovalorespredefinidos"": true}")
          Public  __RetiroEstadoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___RetiroEstadoObsoleto
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Transacción interna")>
          Public Property ReferenciaTransaccionInterna As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTransaccionInterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTransaccionInterna"",""etiqueta"": ""Transacción interna"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b7035ff9-705a-4029-b857-6ff808fe3db7"",""titulo"": ""Base - Transacciones monetarias internas"",""iconoid"": ""c17a70cf-f1f8-410e-ad7d-c07041338177"",""etiquetasingular"": ""Transacción monetaria interna"",""etiquetaplural"": ""Transacciones monetarias internas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b7035ff9-705a-4029-b857-6ff808fe3db7"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Transacción interna"",""descripcion"": """",""keyword"": ""ReferenciaTransaccionInterna"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTransaccionInterna As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTransaccionInterna
          <DisplayName("Cheque o pagaré (Retiro)")>
          Public Property ReferenciaChequeOPagareRetiro As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaChequeOPagareRetiro As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaChequeOPagareRetiro"",""etiqueta"": ""Cheque o pagaré (Retiro)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c898ba20-5858-41d1-a368-0fd478150623"",""titulo"": ""Base - Cheques y Pagares"",""iconoid"": ""6ca6f3c8-0971-4221-bebe-489130891aad"",""etiquetasingular"": ""Documento de pago"",""etiquetaplural"": ""Documentos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c898ba20-5858-41d1-a368-0fd478150623"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cheque o pagaré (Retiro)"",""descripcion"": """",""keyword"": ""ReferenciaChequeOPagareRetiro"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaChequeOPagareRetiro As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaChequeOPagareRetiro
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Fecha de tramitación y validación")>
          Public Property FechaDeTramitacionYValidacion_UTC As Date?
          Public Shared ___FechaDeTramitacionYValidacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeTramitacionYValidacion_UTC"",""etiqueta"": ""Fecha de tramitación y validación"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de tramitación y validación"",""descripcion"": """",""keyword"": ""FechaDeTramitacionYValidacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeTramitacionYValidacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeTramitacionYValidacion_UTC
          <DisplayName("Fecha de vencimiento")>
          Public Property FechaDeVencimiento As Date?
          Public Shared ___FechaDeVencimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimiento"",""etiqueta"": ""Fecha de vencimiento"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento"",""descripcion"": """",""keyword"": ""FechaDeVencimiento"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimiento
          <DisplayName("Total Ajustado")>
          Public Property ImporteTotalAjustado As Decimal
          Public Shared ___ImporteTotalAjustado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalAjustado"",""etiqueta"": ""Total Ajustado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Ajustado"",""descripcion"": """",""keyword"": ""ImporteTotalAjustado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalAjustado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalAjustado
          <DisplayName("Todo tramitado y validado (Obsoleto)")>
          Public Property TodoTramitadoYValidadoObsoleto As Boolean
          Public Shared ___TodoTramitadoYValidadoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TodoTramitadoYValidadoObsoleto"",""etiqueta"": ""Todo tramitado y validado (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Todo tramitado y validado (Obsoleto)"",""descripcion"": """",""keyword"": ""TodoTramitadoYValidadoObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TodoTramitadoYValidadoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___TodoTramitadoYValidadoObsoleto
          <DisplayName("Cheque o Pagaré")>
          Public Property ReferenciaChequeOPagare As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaChequeOPagare As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaChequeOPagare"",""etiqueta"": ""Cheque o Pagaré"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c898ba20-5858-41d1-a368-0fd478150623"",""titulo"": ""Base - Cheques y Pagares"",""iconoid"": ""6ca6f3c8-0971-4221-bebe-489130891aad"",""etiquetasingular"": ""Documento de pago"",""etiquetaplural"": ""Documentos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c898ba20-5858-41d1-a368-0fd478150623"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cheque o Pagaré"",""descripcion"": """",""keyword"": ""ReferenciaChequeOPagare"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaChequeOPagare As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaChequeOPagare
          <DisplayName("Importe afectado a depósito")>
          Public Property ImporteImporteAfectadoADeposito As Decimal
          Public Shared ___ImporteImporteAfectadoADeposito As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteAfectadoADeposito"",""etiqueta"": ""Importe afectado a depósito"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe afectado a depósito"",""descripcion"": """",""keyword"": ""ImporteImporteAfectadoADeposito"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteAfectadoADeposito As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteAfectadoADeposito
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Importe ingreso")>
          Public Property ImporteImporteIngreso As Decimal
          Public Shared ___ImporteImporteIngreso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteIngreso"",""etiqueta"": ""Importe ingreso"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe ingreso"",""descripcion"": """",""keyword"": ""ImporteImporteIngreso"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteIngreso As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteIngreso
          <DisplayName("Transacción secundaria")>
          Public Property ReferenciaTransaccionSecundaria As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTransaccionSecundaria As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTransaccionSecundaria"",""etiqueta"": ""Transacción secundaria"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b7035ff9-705a-4029-b857-6ff808fe3db7"",""titulo"": ""Base - Transacciones monetarias internas"",""iconoid"": ""c17a70cf-f1f8-410e-ad7d-c07041338177"",""etiquetasingular"": ""Transacción monetaria interna"",""etiquetaplural"": ""Transacciones monetarias internas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b7035ff9-705a-4029-b857-6ff808fe3db7"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Transacción secundaria"",""descripcion"": """",""keyword"": ""ReferenciaTransaccionSecundaria"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTransaccionSecundaria As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTransaccionSecundaria
          <DisplayName("Depósito monetario")>
          Public Property ReferenciaDepositoMonetario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDepositoMonetario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDepositoMonetario"",""etiqueta"": ""Depósito monetario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""titulo"": ""Base - Depósitos monetarios"",""iconoid"": ""f037928c-b088-47e4-a79e-3d217109403b"",""etiquetasingular"": ""Depósito monetario"",""etiquetaplural"": ""Depósitos monetarios"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Depósito monetario"",""descripcion"": """",""keyword"": ""ReferenciaDepositoMonetario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDepositoMonetario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDepositoMonetario
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Estado")>
          Public Property Estado As EnumTramitacionE
          Public Shared ___Estado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Estado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 48,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""Pendiente"",""Tramitado"",""Cancelado""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/48_0.png"",""https://cdn.dinaup.com/ico/enums/48_1.png"",""https://cdn.dinaup.com/ico/enums/48_2.png"",""https://cdn.dinaup.com/ico/enums/48_3.png""],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""Estado"",""formato"": 2,""rol"": 48,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tramitación"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Pendiente""},{""valor"": 2, ""titulo"": ""Tramitado""},{""valor"": 3, ""titulo"": ""Cancelado""}]}},""solovalorespredefinidos"": true}")
          Public  __Estado As DinaNETCore.APID.DinaupAPI_CampoC = ___Estado
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Movimiento entre depósitos")>
          Public Property ReferenciaMovimientoEntreDepositos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMovimientoEntreDepositos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMovimientoEntreDepositos"",""etiqueta"": ""Movimiento entre depósitos"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a1c1f109-60a0-410f-b57f-c4be58076bc6"",""titulo"": ""Base - Movimientos entre depósitos"",""iconoid"": ""785140a2-201c-4c46-b40b-ec7d8940a0f0"",""etiquetasingular"": ""Movimiento entre depósitos"",""etiquetaplural"": ""Movimientos entre depósitos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a1c1f109-60a0-410f-b57f-c4be58076bc6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Movimiento entre depósitos"",""descripcion"": """",""keyword"": ""ReferenciaMovimientoEntreDepositos"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMovimientoEntreDepositos As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMovimientoEntreDepositos
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <DisplayName("Total pagado (Tramitado)")>
          Public Property ImporteTotalPagadoTramitado As Decimal
          Public Shared ___ImporteTotalPagadoTramitado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalPagadoTramitado"",""etiqueta"": ""Total pagado (Tramitado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total pagado (Tramitado)"",""descripcion"": """",""keyword"": ""ImporteTotalPagadoTramitado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalPagadoTramitado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalPagadoTramitado
          <DisplayName("Importe afectado a depósito (Tramitado)")>
          Public Property ImporteImporteAfectadoADepositoTramitado As Decimal
          Public Shared ___ImporteImporteAfectadoADepositoTramitado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteAfectadoADepositoTramitado"",""etiqueta"": ""Importe afectado a depósito (Tramitado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe afectado a depósito (Tramitado)"",""descripcion"": """",""keyword"": ""ImporteImporteAfectadoADepositoTramitado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteAfectadoADepositoTramitado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteAfectadoADepositoTramitado
          <DisplayName("Entidad afectada")>
          Public Property ReferenciaEntidadAfectada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidadAfectada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidadAfectada"",""etiqueta"": ""Entidad afectada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad afectada"",""descripcion"": """",""keyword"": ""ReferenciaEntidadAfectada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidadAfectada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidadAfectada
          <DisplayName("Fecha de vencimiento (Retiro) (Obsoleto)")>
          Public Property FechaDeVencimientoRetiroObsoleto As Date?
          Public Shared ___FechaDeVencimientoRetiroObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimientoRetiroObsoleto"",""etiqueta"": ""Fecha de vencimiento (Retiro) (Obsoleto)"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento (Retiro) (Obsoleto)"",""descripcion"": """",""keyword"": ""FechaDeVencimientoRetiroObsoleto"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimientoRetiroObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimientoRetiroObsoleto
          <DisplayName("Fecha contable")>
          Public Property FechaContable As Date?
          Public Shared ___FechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaContable"",""etiqueta"": ""Fecha contable"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 69,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha contable"",""descripcion"": """",""keyword"": ""FechaContable"",""formato"": 7,""rol"": 69,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaContable
          <DisplayName("Empleado que tramita y valida")>
          Public Property ReferenciaEmpleadoQueTramitaYValida As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoQueTramitaYValida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoQueTramitaYValida"",""etiqueta"": ""Empleado que tramita y valida"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que tramita y valida"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoQueTramitaYValida"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoQueTramitaYValida As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoQueTramitaYValida
          <DisplayName("Empleado que tramita y valida Tiene Acceso web")>
          Public Property EmpleadoQueTramitaYValidaTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoQueTramitaYValidaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoQueTramitaYValidaTieneAccesoWeb"",""etiqueta"": ""Empleado que tramita y valida Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que tramita y valida Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoQueTramitaYValidaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoQueTramitaYValidaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoQueTramitaYValidaTieneAccesoWeb
          <DisplayName("Fecha local de tramitación y validación")>
          Public Property FechaLocalDeTramitacionYValidacion As Date?
          Public Shared ___FechaLocalDeTramitacionYValidacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaLocalDeTramitacionYValidacion"",""etiqueta"": ""Fecha local de tramitación y validación"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha local de tramitación y validación"",""descripcion"": """",""keyword"": ""FechaLocalDeTramitacionYValidacion"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaLocalDeTramitacionYValidacion As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaLocalDeTramitacionYValidacion
          <DisplayName("Concepto")>
          Public Property Concepto As String
          Public Shared ___Concepto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Concepto"",""etiqueta"": ""Concepto"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Concepto"",""descripcion"": """",""keyword"": ""Concepto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Concepto As DinaNETCore.APID.DinaupAPI_CampoC = ___Concepto
          <DisplayName("Movimiento bancario")>
          Public Property ReferenciaMovimientoBancario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMovimientoBancario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMovimientoBancario"",""etiqueta"": ""Movimiento bancario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""974c8356-c1e9-4f0a-8c94-7d24ef2f19ce"",""titulo"": ""Base - Movimientos bancarios"",""iconoid"": ""73edff4d-02b1-4f53-b998-1e19b0865ae4"",""etiquetasingular"": ""Movimiento bancario"",""etiquetaplural"": ""Movimientos bancarios"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""974c8356-c1e9-4f0a-8c94-7d24ef2f19ce"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Movimiento bancario"",""descripcion"": """",""keyword"": ""ReferenciaMovimientoBancario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMovimientoBancario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMovimientoBancario
          <DisplayName("Asiento contable")>
          Public Property ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAsientoContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAsientoContable"",""etiqueta"": ""Asiento contable"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""titulo"": ""Base - Asientos contables"",""iconoid"": ""226684b8-fe3c-46a7-8f24-7462e48c0027"",""etiquetasingular"": ""Asiento contable"",""etiquetaplural"": ""Asientos contables"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asiento contable"",""descripcion"": """",""keyword"": ""ReferenciaAsientoContable"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAsientoContable
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e311faf7-2b95-4470-85de-2fdbeb836e93"",""titulo"": ""Base - Ajustes de depósitos monetarios"",""iconoid"": ""34622279-e1ff-466d-9cde-e08864b50304"",""etiquetasingular"": ""Ajuste de depósito monetario"",""etiquetaplural"": ""Ajustes de depósito monetario"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e311faf7-2b95-4470-85de-2fdbeb836e93"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaMetodoDePagoRetiroObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_18f0f3013cx28wd"), _Datos.Leer_String("pr_18f0f3013cx28wd.nombre"))
          me.ReferenciaMetodoDePago = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_18f0f0d1b9x1c5wd"), _Datos.Leer_String("pr_18f0f0d1b9x1c5wd.nombre"))
          me.EntidadAfectadaTieneAccesoWeb = _Datos.Leer_Boolean("pr_146310d74ah378wd")
          me.FechaDeTramitacionYValidacionRetiroObsoleto_UTC = _Datos.Leer_DateTime_Nulable("pr_18f1071b69x351wd")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1464b42362x268wd"), _Datos.Leer_String("pr_1464b42362x268wd.nombre"))
          me.ImporteImporteRetiro = _Datos.Leer_Decimal("pr_18f0fdf68dx109wd")
          me.RetiroEstadoObsoleto = _Datos.Leer_EnumTramitacionE("pr_18f103b1dfx3e3wd")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1464b42384x298wd"), _Datos.Leer_String("pr_1464b42384x298wd.nombre"))
          me.ReferenciaTransaccionInterna = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040106091"), _Datos.Leer_String("pr_20040106091.nombre"))
          me.ReferenciaChequeOPagareRetiro = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_18f100e8a6x20dwd"), _Datos.Leer_String("pr_18f100e8a6x20dwd.nombre"))
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_14631065ecx3d0wd"), _Datos.Leer_String("pr_14631065ecx3d0wd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae4ewd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_14631497aexdfwd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_146310652fx381wd"), _Datos.Leer_String("pr_146310652fx381wd.nombre"))
          me.FechaDeTramitacionYValidacion_UTC = _Datos.Leer_DateTime_Nulable("pr_18f107b182x130wd")
          me.FechaDeVencimiento = _Datos.Leer_Date_Nulable("pr_18f104e2d3x292wd")
          me.ImporteTotalAjustado = _Datos.Leer_Decimal("pr_66c1fa79")
          me.TodoTramitadoYValidadoObsoleto = _Datos.Leer_Boolean("pr_472c360x3a1wc")
          me.ReferenciaChequeOPagare = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_18f0ffc487xcfwd"), _Datos.Leer_String("pr_18f0ffc487xcfwd.nombre"))
          me.ImporteImporteAfectadoADeposito = _Datos.Leer_Decimal("pr_2479n")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3ed43x1d9wd")
          me.ImporteImporteIngreso = _Datos.Leer_Decimal("pr_18f0f7f0a1x389wd")
          me.ReferenciaTransaccionSecundaria = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040114146"), _Datos.Leer_String("pr_10040114146.nombre"))
          me.ReferenciaDepositoMonetario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_2303n"), _Datos.Leer_String("pr_2303n.nombre"))
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_1463106559xf2wd")
          me.Estado = _Datos.Leer_EnumTramitacionE("pr_18f101d739x391wd")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_1464b590a9g2aewd")
          me.Observaciones = _Datos.Leer_String("pr_66c2edd5")
          me.ReferenciaMovimientoEntreDepositos = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4e54e6ax84wc"), _Datos.Leer_String("pr_4e54e6ax84wc.nombre"))
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_442d246x126wc"), _Datos.Leer_String("pr_442d246x126wc.nombre"))
          me.ImporteTotalPagadoTramitado = _Datos.Leer_Decimal("pr_472c014x7bwc")
          me.ImporteImporteAfectadoADepositoTramitado = _Datos.Leer_Decimal("pr_2361n")
          me.ReferenciaEntidadAfectada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_2430"), _Datos.Leer_String("pr_2430.nombre"))
          me.FechaDeVencimientoRetiroObsoleto = _Datos.Leer_Date_Nulable("pr_18f105796fx20cwd")
          me.FechaContable = _Datos.Leer_Date_Nulable("pr_10040135712")
          me.ReferenciaEmpleadoQueTramitaYValida = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040141241"), _Datos.Leer_String("pr_60040141241.nombre"))
          me.EmpleadoQueTramitaYValidaTieneAccesoWeb = _Datos.Leer_Boolean("pr_60040141242")
          me.FechaLocalDeTramitacionYValidacion = _Datos.Leer_Date_Nulable("pr_20040141264")
          me.Concepto = _Datos.Leer_String("pr_60040263353")
          me.ReferenciaMovimientoBancario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040264608"), _Datos.Leer_String("pr_30040264608.nombre"))
          me.ReferenciaAsientoContable = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040135502"), _Datos.Leer_String("pr_60040135502.nombre"))
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
         If Me.ReferenciaMetodoDePagoRetiroObsoleto IsNot nothing then
           R.add("pr_18f0f3013cx28wd",me.ReferenciaMetodoDePagoRetiroObsoleto.ID.STR())
         Else
           R.add("pr_18f0f3013cx28wd","")
         End if
         If Me.ReferenciaMetodoDePago IsNot nothing then
           R.add("pr_18f0f0d1b9x1c5wd",me.ReferenciaMetodoDePago.ID.STR())
         Else
           R.add("pr_18f0f0d1b9x1c5wd","")
         End if
         R.add("pr_146310d74ah378wd", me.EntidadAfectadaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_18f1071b69x351wd", me.FechaDeTramitacionYValidacionRetiroObsoleto_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_1464b42362x268wd",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_1464b42362x268wd","")
         End if
         R.add("pr_18f0fdf68dx109wd", me.ImporteImporteRetiro.AdaptarMySQL_Decimal())
         R.add("pr_18f103b1dfx3e3wd", me.RetiroEstadoObsoleto.AdaptarMySQL_EnumTramitacionE())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_1464b42384x298wd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_1464b42384x298wd","")
         End if
         If Me.ReferenciaTransaccionInterna IsNot nothing then
           R.add("pr_20040106091",me.ReferenciaTransaccionInterna.ID.STR())
         Else
           R.add("pr_20040106091","")
         End if
         If Me.ReferenciaChequeOPagareRetiro IsNot nothing then
           R.add("pr_18f100e8a6x20dwd",me.ReferenciaChequeOPagareRetiro.ID.STR())
         Else
           R.add("pr_18f100e8a6x20dwd","")
         End if
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_14631065ecx3d0wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_14631065ecx3d0wd","")
         End if
         R.add("pr_776ae4ewd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_14631497aexdfwd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_146310652fx381wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_146310652fx381wd","")
         End if
         R.add("pr_18f107b182x130wd", me.FechaDeTramitacionYValidacion_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_18f104e2d3x292wd", me.FechaDeVencimiento.AdaptarMySQL_Date_Nulable())
         R.add("pr_66c1fa79", me.ImporteTotalAjustado.AdaptarMySQL_Decimal())
         R.add("pr_472c360x3a1wc", me.TodoTramitadoYValidadoObsoleto.AdaptarMySQL_Boolean())
         If Me.ReferenciaChequeOPagare IsNot nothing then
           R.add("pr_18f0ffc487xcfwd",me.ReferenciaChequeOPagare.ID.STR())
         Else
           R.add("pr_18f0ffc487xcfwd","")
         End if
         R.add("pr_2479n", me.ImporteImporteAfectadoADeposito.AdaptarMySQL_Decimal())
         R.add("pr_14c9f3ed43x1d9wd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_18f0f7f0a1x389wd", me.ImporteImporteIngreso.AdaptarMySQL_Decimal())
         If Me.ReferenciaTransaccionSecundaria IsNot nothing then
           R.add("pr_10040114146",me.ReferenciaTransaccionSecundaria.ID.STR())
         Else
           R.add("pr_10040114146","")
         End if
         If Me.ReferenciaDepositoMonetario IsNot nothing then
           R.add("pr_2303n",me.ReferenciaDepositoMonetario.ID.STR())
         Else
           R.add("pr_2303n","")
         End if
         R.add("pr_1463106559xf2wd", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_18f101d739x391wd", me.Estado.AdaptarMySQL_EnumTramitacionE())
         R.add("pr_1464b590a9g2aewd", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_66c2edd5", me.Observaciones.AdaptarMySQL_String())
         If Me.ReferenciaMovimientoEntreDepositos IsNot nothing then
           R.add("pr_4e54e6ax84wc",me.ReferenciaMovimientoEntreDepositos.ID.STR())
         Else
           R.add("pr_4e54e6ax84wc","")
         End if
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_442d246x126wc",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_442d246x126wc","")
         End if
         R.add("pr_472c014x7bwc", me.ImporteTotalPagadoTramitado.AdaptarMySQL_Decimal())
         R.add("pr_2361n", me.ImporteImporteAfectadoADepositoTramitado.AdaptarMySQL_Decimal())
         If Me.ReferenciaEntidadAfectada IsNot nothing then
           R.add("pr_2430",me.ReferenciaEntidadAfectada.ID.STR())
         Else
           R.add("pr_2430","")
         End if
         R.add("pr_18f105796fx20cwd", me.FechaDeVencimientoRetiroObsoleto.AdaptarMySQL_Date_Nulable())
         R.add("pr_10040135712", me.FechaContable.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaEmpleadoQueTramitaYValida IsNot nothing then
           R.add("pr_60040141241",me.ReferenciaEmpleadoQueTramitaYValida.ID.STR())
         Else
           R.add("pr_60040141241","")
         End if
         R.add("pr_60040141242", me.EmpleadoQueTramitaYValidaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_20040141264", me.FechaLocalDeTramitacionYValidacion.AdaptarMySQL_Date_Nulable())
         R.add("pr_60040263353", me.Concepto.AdaptarMySQL_String())
         If Me.ReferenciaMovimientoBancario IsNot nothing then
           R.add("pr_30040264608",me.ReferenciaMovimientoBancario.ID.STR())
         Else
           R.add("pr_30040264608","")
         End if
         If Me.ReferenciaAsientoContable IsNot nothing then
           R.add("pr_60040135502",me.ReferenciaAsientoContable.ID.STR())
         Else
           R.add("pr_60040135502","")
         End if
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
  End Class
End Class
