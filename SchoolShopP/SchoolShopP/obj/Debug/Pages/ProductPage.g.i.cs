﻿#pragma checksum "..\..\..\Pages\ProductPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E0B98884FF8921F893895445B171893178E058BE82B2216EDC0A8175132AC7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SchoolShopP.Page;
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


namespace SchoolShopP.Page {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearhBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DownButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton UpButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ManufComboBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CancelFilter;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AmountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewProducts;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel EmptyPanel;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProductButton;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteProductButton;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Pages\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditProductButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SchoolShopP;component/pages/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ProductPage.xaml"
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
            
            #line 8 "..\..\..\Pages\ProductPage.xaml"
            ((SchoolShopP.Page.ProductPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearhBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\Pages\ProductPage.xaml"
            this.SearhBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearhBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DownButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 27 "..\..\..\Pages\ProductPage.xaml"
            this.DownButton.Checked += new System.Windows.RoutedEventHandler(this.DownButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 30 "..\..\..\Pages\ProductPage.xaml"
            this.UpButton.Checked += new System.Windows.RoutedEventHandler(this.UpButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ManufComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\Pages\ProductPage.xaml"
            this.ManufComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ManufComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CancelFilter = ((System.Windows.Controls.TextBlock)(target));
            
            #line 39 "..\..\..\Pages\ProductPage.xaml"
            this.CancelFilter.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CancelFilter_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AmountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ListViewProducts = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.EmptyPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.AddProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\Pages\ProductPage.xaml"
            this.AddProductButton.Click += new System.Windows.RoutedEventHandler(this.AddProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DeleteProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\Pages\ProductPage.xaml"
            this.DeleteProductButton.Click += new System.Windows.RoutedEventHandler(this.DeleteProductButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.EditProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Pages\ProductPage.xaml"
            this.EditProductButton.Click += new System.Windows.RoutedEventHandler(this.EditProductButton_Click);
            
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
            switch (connectionId)
            {
            case 9:
            
            #line 72 "..\..\..\Pages\ProductPage.xaml"
            ((System.Windows.Controls.Border)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ProductBorder_PreviewMouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
