// Updated by XamlIntelliSenseFileGenerator 29-04-2021 15:30:15
#pragma checksum "..\..\AnalyseECG.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9B4C9875DD9990E0C7A35D4A874EAAC7F4408215FAAB55047AF862AD5063EC7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EKG_GUI;
using LiveCharts.Wpf;
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


namespace EKG_GUI
{


    /// <summary>
    /// AnalyseECG
    /// </summary>
    public partial class AnalyseECG : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 11 "..\..\AnalyseECG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart Blodsukkergraf;

#line default
#line hidden


#line 13 "..\..\AnalyseECG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.LineSeries ecgLine;

#line default
#line hidden


#line 17 "..\..\AnalyseECG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCPR;

#line default
#line hidden


#line 18 "..\..\AnalyseECG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCPRnub;

#line default
#line hidden


#line 19 "..\..\AnalyseECG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSearch;

#line default
#line hidden


#line 20 "..\..\AnalyseECG.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EKG_GUI;component/analyseecg.xaml", System.UriKind.Relative);

#line 1 "..\..\AnalyseECG.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 10 "..\..\AnalyseECG.xaml"
                    ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);

#line default
#line hidden
                    return;
                case 2:
                    this.Blodsukkergraf = ((LiveCharts.Wpf.CartesianChart)(target));
                    return;
                case 3:
                    this.ecgLine = ((LiveCharts.Wpf.LineSeries)(target));
                    return;
                case 4:
                    this.LabelCPR = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.tbCPRnub = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.btSearch = ((System.Windows.Controls.Button)(target));
                    return;
                case 7:
                    this.label = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox tbPatinentNummer;
        internal System.Windows.Controls.TextBox tbTilstand;
    }
}

