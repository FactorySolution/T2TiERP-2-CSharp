﻿#pragma checksum "..\..\..\View\Menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "69F4C7F22989940892DF49781E421019"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cadastros.ViewModel;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
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


namespace Cadastros.View {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : Microsoft.Windows.Controls.Ribbon.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Cadastros.View.Menu Cadastros;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.Ribbon Ribbon;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem MenuItem1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonTab Comissoes;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonGroup GroupGeral;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonButton BotaoPerfil;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonButton BotaoMetas;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonGroup GroupSairProduto;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonButton BotaoSairProduto;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockPrincipal;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel dockModulo;
        
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
            System.Uri resourceLocater = new System.Uri("/Comissoes;component/view/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Menu.xaml"
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
            this.Cadastros = ((Cadastros.View.Menu)(target));
            return;
            case 2:
            this.Ribbon = ((Microsoft.Windows.Controls.Ribbon.Ribbon)(target));
            return;
            case 3:
            this.MenuItem1 = ((Microsoft.Windows.Controls.Ribbon.RibbonApplicationMenuItem)(target));
            
            #line 20 "..\..\..\View\Menu.xaml"
            this.MenuItem1.Click += new System.Windows.RoutedEventHandler(this.MenuItem1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Comissoes = ((Microsoft.Windows.Controls.Ribbon.RibbonTab)(target));
            return;
            case 5:
            this.GroupGeral = ((Microsoft.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 6:
            this.BotaoPerfil = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 33 "..\..\..\View\Menu.xaml"
            this.BotaoPerfil.Click += new System.Windows.RoutedEventHandler(this.BotaoPerfil_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BotaoMetas = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 37 "..\..\..\View\Menu.xaml"
            this.BotaoMetas.Click += new System.Windows.RoutedEventHandler(this.BotaoMetas_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GroupSairProduto = ((Microsoft.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 9:
            this.BotaoSairProduto = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 45 "..\..\..\View\Menu.xaml"
            this.BotaoSairProduto.Click += new System.Windows.RoutedEventHandler(this.MenuItem1_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dockPrincipal = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 11:
            this.dockModulo = ((System.Windows.Controls.DockPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
