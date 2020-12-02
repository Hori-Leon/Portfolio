using MaterialDesignThemes.Wpf;
using Portfolio.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Pages.Viewmodels
{
    class ChartDemoPageViewmodel : ObservableObject, IPageViewModel
    {
        public string PageName => "Chart Demonstrations";

        public PackIconKind PageIcon => PackIconKind.ChartLine;

        public ChartDemoPageViewmodel()
        {

        }
    }
}
