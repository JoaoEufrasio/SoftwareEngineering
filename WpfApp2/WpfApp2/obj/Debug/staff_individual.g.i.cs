﻿#pragma checksum "..\..\staff_individual.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4C5765134F0154969CB18E85728CC9C4"
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
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp2.Window1 staff_details;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_bookings;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_patients;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_home;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar staff_calendar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem date_shift;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ScrollBar shift_list_scroller;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label staff_shift_week;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\staff_individual.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox staff_details_box;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/staff_individual.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\staff_individual.xaml"
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
            this.staff_details = ((WpfApp2.Window1)(target));
            return;
            case 2:
            this.bt_bookings = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\staff_individual.xaml"
            this.bt_bookings.Click += new System.Windows.RoutedEventHandler(this.btn_ookings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_patients = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.bt_home = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.staff_calendar = ((System.Windows.Controls.Calendar)(target));
            return;
            case 6:
            
            #line 14 "..\..\staff_individual.xaml"
            ((System.Windows.Controls.ListView)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.date_shift = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 20 "..\..\staff_individual.xaml"
            this.date_shift.Selected += new System.Windows.RoutedEventHandler(this.ListBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 8:
            this.shift_list_scroller = ((System.Windows.Controls.Primitives.ScrollBar)(target));
            return;
            case 9:
            this.staff_shift_week = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.staff_details_box = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\staff_individual.xaml"
            this.staff_details_box.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

