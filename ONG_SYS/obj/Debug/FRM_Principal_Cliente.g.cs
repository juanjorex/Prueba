﻿#pragma checksum "..\..\FRM_Principal_Cliente.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CE71D6A76D776A2273B8B8C47C9A438BC8A5CD8AC643EF6174A5350C3590454A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ONG_SYS;
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


namespace ONG_SYS {
    
    
    /// <summary>
    /// FRM_Principal_Cliente
    /// </summary>
    public partial class FRM_Principal_Cliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\FRM_Principal_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Nuevo_Cliente;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\FRM_Principal_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Administracion_Clientes;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\FRM_Principal_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_regresar_AC;
        
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
            System.Uri resourceLocater = new System.Uri("/ONG_SYS;component/frm_principal_cliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FRM_Principal_Cliente.xaml"
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
            this.BTN_Nuevo_Cliente = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\FRM_Principal_Cliente.xaml"
            this.BTN_Nuevo_Cliente.Click += new System.Windows.RoutedEventHandler(this.BTN_Nuevo_Cliente_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_Administracion_Clientes = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\FRM_Principal_Cliente.xaml"
            this.btn_Administracion_Clientes.Click += new System.Windows.RoutedEventHandler(this.btn_Administracion_Clientes_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_regresar_AC = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\FRM_Principal_Cliente.xaml"
            this.btn_regresar_AC.Click += new System.Windows.RoutedEventHandler(this.btn_regresar_AC_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

