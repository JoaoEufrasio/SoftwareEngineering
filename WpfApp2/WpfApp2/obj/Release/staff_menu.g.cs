﻿#pragma checksum "..\..\staff_menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2DB6C066EBFA94E78971B70C15C19BBD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp2.MainWindow Staff_Screen;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_bookings;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_patients;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_home;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_bar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView staff_on_duty_list;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem staff_name_id_shift;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ScrollBar duty_list_scroller;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\staff_menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label staff_on_duty_date;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/staff_menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\staff_menu.xaml"
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
            this.Staff_Screen = ((WpfApp2.MainWindow)(target));
            return;
            case 2:
            this.btn_bookings = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\staff_menu.xaml"
            this.btn_bookings.Click += new System.Windows.RoutedEventHandler(this.btn_bookings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_patients = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\staff_menu.xaml"
            this.btn_patients.Click += new System.Windows.RoutedEventHandler(this.btn_patients_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_home = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.search_bar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.staff_on_duty_list = ((System.Windows.Controls.ListView)(target));
            
            #line 23 "..\..\staff_menu.xaml"
            this.staff_on_duty_list.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.staff_on_duty_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.staff_name_id_shift = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 32 "..\..\staff_menu.xaml"
            this.staff_name_id_shift.Selected += new System.Windows.RoutedEventHandler(this.staff_name_id_shift_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.duty_list_scroller = ((System.Windows.Controls.Primitives.ScrollBar)(target));
            return;
            case 9:
            this.staff_on_duty_date = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

