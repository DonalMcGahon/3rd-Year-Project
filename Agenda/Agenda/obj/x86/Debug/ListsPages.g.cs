﻿#pragma checksum "C:\Users\dmcga\OneDrive\Documents\GitHub\3rd-Year-Project\Agenda\Agenda\ListsPages.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02561093502C3FCEFFB091E7DC35A604"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agenda
{
    partial class ListsPages : 
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
                    this.pvtAgenda = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 2:
                {
                    this.pvtShopping = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 3:
                {
                    this.pvtFitness = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 4:
                {
                    this.pvtCalendar = (global::Windows.UI.Xaml.Controls.PivotItem)(target);
                }
                break;
            case 5:
                {
                    this.button4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 123 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button4).Click += this.button_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.button3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 110 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button3).Click += this.button_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 73 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button2).Click += this.button_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.AddGrocery = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 75 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.AddGrocery).TextChanged += this.AddGrocery_TextChanged;
                    #line default
                }
                break;
            case 9:
                {
                    this.done = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 76 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.done).Click += this.done_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.groceryList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 11:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.appBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 24 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.appBarButton).Click += this.appBarButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 28 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox).TextChanged += this.textBox_TextChanged;
                    #line default
                }
                break;
            case 15:
                {
                    this.textBlock_Copy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.textBox_Copy = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 30 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox_Copy).TextChanged += this.textBox_TextChanged;
                    #line default
                }
                break;
            case 17:
                {
                    this.button5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\ListsPages.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button5).Click += this.button5_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.myList = (global::Windows.UI.Xaml.Controls.ListView)(target);
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

