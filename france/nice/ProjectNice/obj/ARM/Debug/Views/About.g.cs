﻿#pragma checksum "F:\uwp.vtnorton.terre\Terre\CoreWin10\Views\About.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B0580E191B8AA482EBF9809F6FB9E72A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreWin10.Views
{
    partial class About : 
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
                    global::Windows.UI.Xaml.Controls.HyperlinkButton element1 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 235 "..\..\..\Views\About.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)element1).Click += this.HyperlinkButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.Ad = (global::Microsoft.Advertising.WinRT.UI.AdControl)(target);
                }
                break;
            case 3:
                {
                    this.SocialNetworks = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.Twitter = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 5:
                {
                    this.Site = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 6:
                {
                    this.Rio = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 7:
                {
                    this.Pasadena = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 8:
                {
                    this.Nice = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 9:
                {
                    this.Lyon = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 10:
                {
                    this.LasVegas = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 11:
                {
                    this.Douai = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 12:
                {
                    this.txtThisAppName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.txtThisAppVersion = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.txtThisAppDescription = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.RateThisApp = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    #line 31 "..\..\..\Views\About.xaml"
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.RateThisApp).Click += this.RateThisApp_Click;
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

