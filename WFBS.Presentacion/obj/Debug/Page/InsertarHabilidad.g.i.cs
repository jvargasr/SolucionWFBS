﻿#pragma checksum "..\..\..\Page\InsertarHabilidad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "412C9704CAA4F197CF67362AF6AC11C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MasterPages.Master;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MasterPages.Page {
    
    
    /// <summary>
    /// InsertarHabilidad
    /// </summary>
    public partial class InsertarHabilidad : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUserInfo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbId_Competencia;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbOrden;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbAlternativa;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbId_Competencia;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbOrden;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAlternativa;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Page\InsertarHabilidad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIngresar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WFBS.Presentacion;component/page/insertarhabilidad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page\InsertarHabilidad.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblUserInfo = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lbId_Competencia = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lbOrden = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbAlternativa = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.cmbId_Competencia = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\Page\InsertarHabilidad.xaml"
            this.cmbId_Competencia.Loaded += new System.Windows.RoutedEventHandler(this.cmbId_Competencia_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cmbOrden = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Page\InsertarHabilidad.xaml"
            this.cmbOrden.Loaded += new System.Windows.RoutedEventHandler(this.cmbOrden_Loaded);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtAlternativa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnLimpiar = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Page\InsertarHabilidad.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnIngresar = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Page\InsertarHabilidad.xaml"
            this.btnIngresar.Click += new System.Windows.RoutedEventHandler(this.btnIngresar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

