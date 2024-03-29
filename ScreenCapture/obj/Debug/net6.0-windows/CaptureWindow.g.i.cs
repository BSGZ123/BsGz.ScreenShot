﻿#pragma checksum "..\..\..\CaptureWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "012D01A3D74A63399761DF6DE6D07492D9B5224A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using ScreenCapture;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using ViewModel.Base;


namespace ScreenCapture {
    
    
    /// <summary>
    /// CaptureWindow
    /// </summary>
    public partial class CaptureWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Back;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imageSourceGrid;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageSourceBack;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas inkCanvasMeasure;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ButtonsPanel;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas ClipBorderCanvas;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\CaptureWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ScreenCapture.TextBlockBox input;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ScreenCapture;component/capturewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CaptureWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Back = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 65 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDown);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseUp);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imageSourceGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.imageSourceBack = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.inkCanvasMeasure = ((System.Windows.Controls.InkCanvas)(target));
            return;
            case 6:
            this.ButtonsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            
            #line 84 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnRectClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 86 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCircleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 88 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnArrowClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 90 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnPenClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 92 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnTextClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 94 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnMosaicClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 96 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDownLoadClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 98 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDingClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 100 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCloseClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 102 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCopyClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this.ClipBorderCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 18:
            
            #line 115 "..\..\..\CaptureWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnBorderMouseDown);
            
            #line default
            #line hidden
            return;
            case 19:
            this.input = ((ScreenCapture.TextBlockBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

