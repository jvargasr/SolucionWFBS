﻿#pragma checksum "..\..\..\Page\MantenedorArea.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "79BAA4C204CCC87A078EC6F2AEC51BF0"
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
    /// MantenedorArea
    /// </summary>
    public partial class MantenedorArea : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Page\MantenedorArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUserInfo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Page\MantenedorArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarArea;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Page\MantenedorArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgArea;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Page\MantenedorArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificarArea;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Page\MantenedorArea.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarArea;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Page\MantenedorArea.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WFBS.Presentacion;component/page/mantenedorarea.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page\MantenedorArea.xaml"
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
            this.btnAgregarArea = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Page\MantenedorArea.xaml"
            this.btnAgregarArea.Click += new System.Windows.RoutedEventHandler(this.btnAgregarArea_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgArea = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\..\Page\MantenedorArea.xaml"
            this.dgArea.Loaded += new System.Windows.RoutedEventHandler(this.dgArea_Loaded);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Page\MantenedorArea.xaml"
            this.dgArea.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.dgArea_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnModificarArea = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Page\MantenedorArea.xaml"
            this.btnModificarArea.Click += new System.Windows.RoutedEventHandler(this.btnModificarArea_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEliminarArea = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Page\MantenedorArea.xaml"
            this.btnEliminarArea.Click += new System.Windows.RoutedEventHandler(this.btnEliminarArea_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnVolver = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Page\MantenedorArea.xaml"
            this.btnVolver.Click += new System.Windows.RoutedEventHandler(this.btnVolver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

