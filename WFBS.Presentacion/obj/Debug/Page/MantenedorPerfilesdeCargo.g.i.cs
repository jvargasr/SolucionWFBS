﻿#pragma checksum "..\..\..\Page\MantenedorPerfilesdeCargo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A39DAAD790D5A9EEA1F1B062730D7246"
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
    /// MantenedorPerfilesdeCargo
    /// </summary>
    public partial class MantenedorPerfilesdeCargo : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUserInfo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarPerfildeCargo;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPerfildeCargo;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificarPerfildeCargo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarPerfildeCargo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVolver;
        
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
            System.Uri resourceLocater = new System.Uri("/WFBS.Presentacion;component/page/mantenedorperfilesdecargo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
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
            this.btnAgregarPerfildeCargo = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
            this.btnAgregarPerfildeCargo.Click += new System.Windows.RoutedEventHandler(this.btnAgregaPerfildeCargo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgPerfildeCargo = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
            this.dgPerfildeCargo.Loaded += new System.Windows.RoutedEventHandler(this.dgPerfildeCargo_Loaded);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
            this.dgPerfildeCargo.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.dgPerfildeCargo_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnModificarPerfildeCargo = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
            this.btnModificarPerfildeCargo.Click += new System.Windows.RoutedEventHandler(this.btnModificarPerfildeCargo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEliminarPerfildeCargo = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
            this.btnEliminarPerfildeCargo.Click += new System.Windows.RoutedEventHandler(this.btnEliminarPerfildeCargo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Page\MantenedorPerfilesdeCargo.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.btnVolver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
