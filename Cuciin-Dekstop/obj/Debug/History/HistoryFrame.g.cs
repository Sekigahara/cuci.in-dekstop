﻿#pragma checksum "..\..\..\History\HistoryFrame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC1D13C01D1F90D9942643A64E67449B5FCA489FD0AD47C4327510AC593DC063"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cuciin_Dekstop.History;
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
using Velacro.UIElements.Basic;


namespace Cuciin_Dekstop.History {
    
    
    /// <summary>
    /// HistoryFrame
    /// </summary>
    public partial class HistoryFrame : Velacro.UIElements.Basic.MyPage, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 17 "..\..\..\History\HistoryFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dashboard_btn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\History\HistoryFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button history_btn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\History\HistoryFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout_btn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\History\HistoryFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid data_grid_transaction;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\History\HistoryFrame.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button about_us_btn_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Cuciin-Dekstop;component/history/historyframe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\History\HistoryFrame.xaml"
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
            this.dashboard_btn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\History\HistoryFrame.xaml"
            this.dashboard_btn.Click += new System.Windows.RoutedEventHandler(this.dashboard_btn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.history_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\History\HistoryFrame.xaml"
            this.history_btn.Click += new System.Windows.RoutedEventHandler(this.history_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logout_btn = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\History\HistoryFrame.xaml"
            this.logout_btn.Click += new System.Windows.RoutedEventHandler(this.logout_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.data_grid_transaction = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.about_us_btn_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\History\HistoryFrame.xaml"
            this.about_us_btn_Copy.Click += new System.Windows.RoutedEventHandler(this.about_us_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 5:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 38 "..\..\..\History\HistoryFrame.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.Row_DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

