﻿#pragma checksum "..\..\..\Views\RibbonMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E51CB1D1A6B1B476CBE698083B646F30C3DEBB8CC7D82A5B0BFD01CF6DF60058"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using Prism.Unity;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace WPF_Project.Views {
    
    
    /// <summary>
    /// RibbonMenu
    /// </summary>
    public partial class RibbonMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Views\RibbonMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton Save;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\RibbonMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonSplitButton Undo;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\RibbonMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonSplitButton Redo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\RibbonMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup ClipboardGroup;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\RibbonMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup Employee;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Views\RibbonMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup EmployeeGroup;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Views\RibbonMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonGroup StudentGroup;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Project;component/views/ribbonmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RibbonMenu.xaml"
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
            this.Save = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            return;
            case 2:
            this.Undo = ((System.Windows.Controls.Ribbon.RibbonSplitButton)(target));
            return;
            case 3:
            this.Redo = ((System.Windows.Controls.Ribbon.RibbonSplitButton)(target));
            return;
            case 4:
            this.ClipboardGroup = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 5:
            this.Employee = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 6:
            this.EmployeeGroup = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            case 7:
            this.StudentGroup = ((System.Windows.Controls.Ribbon.RibbonGroup)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
