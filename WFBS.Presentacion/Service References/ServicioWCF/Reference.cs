﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFBS.Presentacion.ServicioWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioWCF.IServicioWFBS")]
    public interface IServicioWFBS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/CrearCompetenciaResponse")]
        bool CrearCompetencia(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/CrearCompetenciaResponse")]
        System.Threading.Tasks.Task<bool> CrearCompetenciaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarCompetenciaResponse")]
        bool ActualizarCompetencia(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarCompetenciaResponse")]
        System.Threading.Tasks.Task<bool> ActualizarCompetenciaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarCompetenciaResponse")]
        bool EliminarCompetencia(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarCompetenciaResponse")]
        System.Threading.Tasks.Task<bool> EliminarCompetenciaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/LeerCompetenciaResponse")]
        string LeerCompetencia(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerCompetencia", ReplyAction="http://tempuri.org/IServicioWFBS/LeerCompetenciaResponse")]
        System.Threading.Tasks.Task<string> LeerCompetenciaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerCompetencias", ReplyAction="http://tempuri.org/IServicioWFBS/LeerCompetenciasResponse")]
        string LeerCompetencias();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerCompetencias", ReplyAction="http://tempuri.org/IServicioWFBS/LeerCompetenciasResponse")]
        System.Threading.Tasks.Task<string> LeerCompetenciasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/CrearHabilidadResponse")]
        bool CrearHabilidad(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/CrearHabilidadResponse")]
        System.Threading.Tasks.Task<bool> CrearHabilidadAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarHabilidadResponse")]
        bool ActualizarHabilidad(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarHabilidadResponse")]
        System.Threading.Tasks.Task<bool> ActualizarHabilidadAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarHabilidadResponse")]
        bool EliminarHabilidad(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarHabilidadResponse")]
        System.Threading.Tasks.Task<bool> EliminarHabilidadAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/LeerHabilidadResponse")]
        string LeerHabilidad(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerHabilidad", ReplyAction="http://tempuri.org/IServicioWFBS/LeerHabilidadResponse")]
        System.Threading.Tasks.Task<string> LeerHabilidadAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerHabilidades", ReplyAction="http://tempuri.org/IServicioWFBS/LeerHabilidadesResponse")]
        string LeerHabilidades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerHabilidades", ReplyAction="http://tempuri.org/IServicioWFBS/LeerHabilidadesResponse")]
        System.Threading.Tasks.Task<string> LeerHabilidadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerHabPorCom", ReplyAction="http://tempuri.org/IServicioWFBS/LeerHabPorComResponse")]
        string LeerHabPorCom(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerHabPorCom", ReplyAction="http://tempuri.org/IServicioWFBS/LeerHabPorComResponse")]
        System.Threading.Tasks.Task<string> LeerHabPorComAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/CrearPeriodoEvaluacionResponse")]
        bool CrearPeriodoEvaluacion(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/CrearPeriodoEvaluacionResponse")]
        System.Threading.Tasks.Task<bool> CrearPeriodoEvaluacionAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarPeriodoEvaluacionResponse")]
        bool ActualizarPeriodoEvaluacion(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarPeriodoEvaluacionResponse")]
        System.Threading.Tasks.Task<bool> ActualizarPeriodoEvaluacionAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarPeriodoEvaluacionResponse")]
        bool EliminarPeriodoEvaluacion(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarPeriodoEvaluacionResponse")]
        System.Threading.Tasks.Task<bool> EliminarPeriodoEvaluacionAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPeriodoEvaluacionResponse")]
        string LeerPeriodoEvaluacion(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPeriodoEvaluacion", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPeriodoEvaluacionResponse")]
        System.Threading.Tasks.Task<string> LeerPeriodoEvaluacionAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPeriodosEvaluaciones", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPeriodosEvaluacionesResponse")]
        string LeerPeriodosEvaluaciones();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPeriodosEvaluaciones", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPeriodosEvaluacionesResponse")]
        System.Threading.Tasks.Task<string> LeerPeriodosEvaluacionesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ValidarUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/ValidarUsuarioResponse")]
        bool ValidarUsuario(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ValidarUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/ValidarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> ValidarUsuarioAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/Desactivado", ReplyAction="http://tempuri.org/IServicioWFBS/DesactivadoResponse")]
        bool Desactivado(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/Desactivado", ReplyAction="http://tempuri.org/IServicioWFBS/DesactivadoResponse")]
        System.Threading.Tasks.Task<bool> DesactivadoAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/CrearUsuarioResponse")]
        bool CrearUsuario(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/CrearUsuarioResponse")]
        System.Threading.Tasks.Task<bool> CrearUsuarioAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarUsuarioResponse")]
        bool ActualizarUsuario(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> ActualizarUsuarioAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarUsuarioResponse")]
        bool EliminarUsuario(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarUsuarioResponse")]
        System.Threading.Tasks.Task<bool> EliminarUsuarioAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/LeerUsuarioResponse")]
        string LeerUsuario(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerUsuario", ReplyAction="http://tempuri.org/IServicioWFBS/LeerUsuarioResponse")]
        System.Threading.Tasks.Task<string> LeerUsuarioAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerUsuarios", ReplyAction="http://tempuri.org/IServicioWFBS/LeerUsuariosResponse")]
        string LeerUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerUsuarios", ReplyAction="http://tempuri.org/IServicioWFBS/LeerUsuariosResponse")]
        System.Threading.Tasks.Task<string> LeerUsuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearArea", ReplyAction="http://tempuri.org/IServicioWFBS/CrearAreaResponse")]
        bool CrearArea(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearArea", ReplyAction="http://tempuri.org/IServicioWFBS/CrearAreaResponse")]
        System.Threading.Tasks.Task<bool> CrearAreaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarArea", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarAreaResponse")]
        bool ActualizarArea(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarArea", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarAreaResponse")]
        System.Threading.Tasks.Task<bool> ActualizarAreaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarArea", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarAreaResponse")]
        bool EliminarArea(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarArea", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarAreaResponse")]
        System.Threading.Tasks.Task<bool> EliminarAreaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerArea", ReplyAction="http://tempuri.org/IServicioWFBS/LeerAreaResponse")]
        string LeerArea(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerArea", ReplyAction="http://tempuri.org/IServicioWFBS/LeerAreaResponse")]
        System.Threading.Tasks.Task<string> LeerAreaAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerAreas", ReplyAction="http://tempuri.org/IServicioWFBS/LeerAreasResponse")]
        string LeerAreas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerAreas", ReplyAction="http://tempuri.org/IServicioWFBS/LeerAreasResponse")]
        System.Threading.Tasks.Task<string> LeerAreasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/CrearPerfildeCargoResponse")]
        bool CrearPerfildeCargo(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/CrearPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/CrearPerfildeCargoResponse")]
        System.Threading.Tasks.Task<bool> CrearPerfildeCargoAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarPerfildeCargoResponse")]
        bool ActualizarPerfildeCargo(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/ActualizarPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/ActualizarPerfildeCargoResponse")]
        System.Threading.Tasks.Task<bool> ActualizarPerfildeCargoAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarPerfildeCargoResponse")]
        bool EliminarPerfildeCargo(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/EliminarPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/EliminarPerfildeCargoResponse")]
        System.Threading.Tasks.Task<bool> EliminarPerfildeCargoAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPerfildeCargoResponse")]
        string LeerPerfildeCargo(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPerfildeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPerfildeCargoResponse")]
        System.Threading.Tasks.Task<string> LeerPerfildeCargoAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPerfilesdeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPerfilesdeCargoResponse")]
        string LeerPerfilesdeCargo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioWFBS/LeerPerfilesdeCargo", ReplyAction="http://tempuri.org/IServicioWFBS/LeerPerfilesdeCargoResponse")]
        System.Threading.Tasks.Task<string> LeerPerfilesdeCargoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioWFBSChannel : WFBS.Presentacion.ServicioWCF.IServicioWFBS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioWFBSClient : System.ServiceModel.ClientBase<WFBS.Presentacion.ServicioWCF.IServicioWFBS>, WFBS.Presentacion.ServicioWCF.IServicioWFBS {
        
        public ServicioWFBSClient() {
        }
        
        public ServicioWFBSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioWFBSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWFBSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioWFBSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CrearCompetencia(string xml) {
            return base.Channel.CrearCompetencia(xml);
        }
        
        public System.Threading.Tasks.Task<bool> CrearCompetenciaAsync(string xml) {
            return base.Channel.CrearCompetenciaAsync(xml);
        }
        
        public bool ActualizarCompetencia(string xml) {
            return base.Channel.ActualizarCompetencia(xml);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarCompetenciaAsync(string xml) {
            return base.Channel.ActualizarCompetenciaAsync(xml);
        }
        
        public bool EliminarCompetencia(string xml) {
            return base.Channel.EliminarCompetencia(xml);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarCompetenciaAsync(string xml) {
            return base.Channel.EliminarCompetenciaAsync(xml);
        }
        
        public string LeerCompetencia(string xml) {
            return base.Channel.LeerCompetencia(xml);
        }
        
        public System.Threading.Tasks.Task<string> LeerCompetenciaAsync(string xml) {
            return base.Channel.LeerCompetenciaAsync(xml);
        }
        
        public string LeerCompetencias() {
            return base.Channel.LeerCompetencias();
        }
        
        public System.Threading.Tasks.Task<string> LeerCompetenciasAsync() {
            return base.Channel.LeerCompetenciasAsync();
        }
        
        public bool CrearHabilidad(string xml) {
            return base.Channel.CrearHabilidad(xml);
        }
        
        public System.Threading.Tasks.Task<bool> CrearHabilidadAsync(string xml) {
            return base.Channel.CrearHabilidadAsync(xml);
        }
        
        public bool ActualizarHabilidad(string xml) {
            return base.Channel.ActualizarHabilidad(xml);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarHabilidadAsync(string xml) {
            return base.Channel.ActualizarHabilidadAsync(xml);
        }
        
        public bool EliminarHabilidad(string xml) {
            return base.Channel.EliminarHabilidad(xml);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarHabilidadAsync(string xml) {
            return base.Channel.EliminarHabilidadAsync(xml);
        }
        
        public string LeerHabilidad(string xml) {
            return base.Channel.LeerHabilidad(xml);
        }
        
        public System.Threading.Tasks.Task<string> LeerHabilidadAsync(string xml) {
            return base.Channel.LeerHabilidadAsync(xml);
        }
        
        public string LeerHabilidades() {
            return base.Channel.LeerHabilidades();
        }
        
        public System.Threading.Tasks.Task<string> LeerHabilidadesAsync() {
            return base.Channel.LeerHabilidadesAsync();
        }
        
        public string LeerHabPorCom(int id) {
            return base.Channel.LeerHabPorCom(id);
        }
        
        public System.Threading.Tasks.Task<string> LeerHabPorComAsync(int id) {
            return base.Channel.LeerHabPorComAsync(id);
        }
        
        public bool CrearPeriodoEvaluacion(string xml) {
            return base.Channel.CrearPeriodoEvaluacion(xml);
        }
        
        public System.Threading.Tasks.Task<bool> CrearPeriodoEvaluacionAsync(string xml) {
            return base.Channel.CrearPeriodoEvaluacionAsync(xml);
        }
        
        public bool ActualizarPeriodoEvaluacion(string xml) {
            return base.Channel.ActualizarPeriodoEvaluacion(xml);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarPeriodoEvaluacionAsync(string xml) {
            return base.Channel.ActualizarPeriodoEvaluacionAsync(xml);
        }
        
        public bool EliminarPeriodoEvaluacion(string xml) {
            return base.Channel.EliminarPeriodoEvaluacion(xml);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarPeriodoEvaluacionAsync(string xml) {
            return base.Channel.EliminarPeriodoEvaluacionAsync(xml);
        }
        
        public string LeerPeriodoEvaluacion(string xml) {
            return base.Channel.LeerPeriodoEvaluacion(xml);
        }
        
        public System.Threading.Tasks.Task<string> LeerPeriodoEvaluacionAsync(string xml) {
            return base.Channel.LeerPeriodoEvaluacionAsync(xml);
        }
        
        public string LeerPeriodosEvaluaciones() {
            return base.Channel.LeerPeriodosEvaluaciones();
        }
        
        public System.Threading.Tasks.Task<string> LeerPeriodosEvaluacionesAsync() {
            return base.Channel.LeerPeriodosEvaluacionesAsync();
        }
        
        public bool ValidarUsuario(string xml) {
            return base.Channel.ValidarUsuario(xml);
        }
        
        public System.Threading.Tasks.Task<bool> ValidarUsuarioAsync(string xml) {
            return base.Channel.ValidarUsuarioAsync(xml);
        }
        
        public bool Desactivado(string xml) {
            return base.Channel.Desactivado(xml);
        }
        
        public System.Threading.Tasks.Task<bool> DesactivadoAsync(string xml) {
            return base.Channel.DesactivadoAsync(xml);
        }
        
        public bool CrearUsuario(string xml) {
            return base.Channel.CrearUsuario(xml);
        }
        
        public System.Threading.Tasks.Task<bool> CrearUsuarioAsync(string xml) {
            return base.Channel.CrearUsuarioAsync(xml);
        }
        
        public bool ActualizarUsuario(string xml) {
            return base.Channel.ActualizarUsuario(xml);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarUsuarioAsync(string xml) {
            return base.Channel.ActualizarUsuarioAsync(xml);
        }
        
        public bool EliminarUsuario(string xml) {
            return base.Channel.EliminarUsuario(xml);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarUsuarioAsync(string xml) {
            return base.Channel.EliminarUsuarioAsync(xml);
        }
        
        public string LeerUsuario(string xml) {
            return base.Channel.LeerUsuario(xml);
        }
        
        public System.Threading.Tasks.Task<string> LeerUsuarioAsync(string xml) {
            return base.Channel.LeerUsuarioAsync(xml);
        }
        
        public string LeerUsuarios() {
            return base.Channel.LeerUsuarios();
        }
        
        public System.Threading.Tasks.Task<string> LeerUsuariosAsync() {
            return base.Channel.LeerUsuariosAsync();
        }
        
        public bool CrearArea(string xml) {
            return base.Channel.CrearArea(xml);
        }
        
        public System.Threading.Tasks.Task<bool> CrearAreaAsync(string xml) {
            return base.Channel.CrearAreaAsync(xml);
        }
        
        public bool ActualizarArea(string xml) {
            return base.Channel.ActualizarArea(xml);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarAreaAsync(string xml) {
            return base.Channel.ActualizarAreaAsync(xml);
        }
        
        public bool EliminarArea(string xml) {
            return base.Channel.EliminarArea(xml);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAreaAsync(string xml) {
            return base.Channel.EliminarAreaAsync(xml);
        }
        
        public string LeerArea(string xml) {
            return base.Channel.LeerArea(xml);
        }
        
        public System.Threading.Tasks.Task<string> LeerAreaAsync(string xml) {
            return base.Channel.LeerAreaAsync(xml);
        }
        
        public string LeerAreas() {
            return base.Channel.LeerAreas();
        }
        
        public System.Threading.Tasks.Task<string> LeerAreasAsync() {
            return base.Channel.LeerAreasAsync();
        }
        
        public bool CrearPerfildeCargo(string xml) {
            return base.Channel.CrearPerfildeCargo(xml);
        }
        
        public System.Threading.Tasks.Task<bool> CrearPerfildeCargoAsync(string xml) {
            return base.Channel.CrearPerfildeCargoAsync(xml);
        }
        
        public bool ActualizarPerfildeCargo(string xml) {
            return base.Channel.ActualizarPerfildeCargo(xml);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarPerfildeCargoAsync(string xml) {
            return base.Channel.ActualizarPerfildeCargoAsync(xml);
        }
        
        public bool EliminarPerfildeCargo(string xml) {
            return base.Channel.EliminarPerfildeCargo(xml);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarPerfildeCargoAsync(string xml) {
            return base.Channel.EliminarPerfildeCargoAsync(xml);
        }
        
        public string LeerPerfildeCargo(string xml) {
            return base.Channel.LeerPerfildeCargo(xml);
        }
        
        public System.Threading.Tasks.Task<string> LeerPerfildeCargoAsync(string xml) {
            return base.Channel.LeerPerfildeCargoAsync(xml);
        }
        
        public string LeerPerfilesdeCargo() {
            return base.Channel.LeerPerfilesdeCargo();
        }
        
        public System.Threading.Tasks.Task<string> LeerPerfilesdeCargoAsync() {
            return base.Channel.LeerPerfilesdeCargoAsync();
        }
    }
}