﻿#pragma checksum "F:\Terre\usa\pasadena\ProjectPasadena\MasterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "86D2912CEAFC741BB89A675A4EB8A323"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPasadena
{
    partial class MasterPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MySliptView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.VisualState000min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.VisualState641min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.VisualState941min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.stpHome = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 46 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHome).PointerMoved += this.stpHome_PointerMoved;
                    #line 46 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHome).PointerExited += this.stpHome_PointerExited;
                    #line 46 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHome).Tapped += this.xtnHome_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.stpHelp = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 65 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHelp).Tapped += this.btnHelp_Click;
                    #line 65 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHelp).PointerMoved += this.stpHelp_PointerMoved;
                    #line 65 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHelp).PointerExited += this.stpHelp_PointerExited;
                    #line default
                }
                break;
            case 8:
                {
                    this.stpAbout = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 84 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpAbout).Tapped += this.btnAbout_Click;
                    #line 84 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpAbout).PointerMoved += this.stpAbout_PointerMoved;
                    #line 84 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpAbout).PointerExited += this.stpAbout_PointerExited;
                    #line default
                }
                break;
            case 9:
                {
                    this.gridAbout = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.btnAbout = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 11:
                {
                    this.txtAbout = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.gridHelp = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13:
                {
                    this.btnHelp = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 14:
                {
                    this.txtHelp = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.gridHome = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16:
                {
                    this.btnHome = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 17:
                {
                    this.txtHome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.btnMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMenu).Click += this.btnMenu_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.mainFrame = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 20:
                {
                    this.frameBody = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 21:
                {
                    this.btnMenu2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 114 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMenu2).Click += this.btnMenu_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

