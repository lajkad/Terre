﻿#pragma checksum "F:\Terre\france\nice\ProjectNice\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "039DF24959C4A52A59D54C337DB8F09E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectNice
{
    partial class MainPage : 
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
                    this.bgDark = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.gridResults = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.gridOptions = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.rptDecimalNumbers = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                }
                break;
            case 5:
                {
                    this.Max = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 87 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Max).TextChanged += this.Min_TextChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.Min = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 84 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.Min).TextChanged += this.Min_TextChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.txtSortedNumbers = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.TelaNumeroSorteado = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.txtClean = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 51 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtClean).Click += this.txtClean_Click;
                    #line 51 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtClean).PointerMoved += this.txtClean_PointerMoved;
                    #line 51 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtClean).PointerExited += this.txtClean_PointerExited;
                    #line default
                }
                break;
            case 10:
                {
                    this.txtSort = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 58 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtSort).Click += this.Button_Click;
                    #line 58 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtSort).PointerMoved += this.txtSort_PointerMoved;
                    #line 58 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtSort).PointerExited += this.txtSort_PointerExited;
                    #line default
                }
                break;
            case 11:
                {
                    this.txtSettings = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 65 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtSettings).Click += this.txtSettings_Click;
                    #line 65 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtSettings).PointerMoved += this.txtSettings_PointerMoved;
                    #line 65 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.txtSettings).PointerExited += this.txtSettings_PointerExited;
                    #line default
                }
                break;
            case 12:
                {
                    this.Ad = (global::Microsoft.Advertising.WinRT.UI.AdControl)(target);
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
