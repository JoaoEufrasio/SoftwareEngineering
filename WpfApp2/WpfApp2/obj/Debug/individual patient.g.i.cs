﻿#pragma checksum "..\..\individual patient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "23051F7C2321061AB2C7D16F568A664C"
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
    /// individual_patient
    /// </summary>
    public partial class individual_patient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfApp2.individual_patient individual_screen;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_home;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_booking;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_staff;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_test;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_patient_record;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView prescriptions_list;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ScrollBar prescription_scroll_bar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label prescriptions;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image edit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image back_page;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ScrollBar booking_scroll_bar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\individual patient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label booking;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/individual%20patient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\individual patient.xaml"
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
            this.individual_screen = ((WpfApp2.individual_patient)(target));
            return;
            case 2:
            this.bt_home = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\individual patient.xaml"
            this.bt_home.Click += new System.Windows.RoutedEventHandler(this.bt_home_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bt_booking = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\individual patient.xaml"
            this.bt_booking.Click += new System.Windows.RoutedEventHandler(this.bt_booking_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bt_staff = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\individual patient.xaml"
            this.bt_staff.Click += new System.Windows.RoutedEventHandler(this.bt_staff_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bt_test = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.bt_patient_record = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.prescriptions_list = ((System.Windows.Controls.ListView)(target));
            return;
            case 8:
            this.prescription_scroll_bar = ((System.Windows.Controls.Primitives.ScrollBar)(target));
            return;
            case 9:
            this.prescriptions = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.edit = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.back_page = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            
            #line 34 "..\..\individual patient.xaml"
            ((System.Windows.Controls.ListBoxItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.ListBoxItem_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            this.booking_scroll_bar = ((System.Windows.Controls.Primitives.ScrollBar)(target));
            return;
            case 14:
            this.booking = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

