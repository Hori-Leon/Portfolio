using Portfolio.Helper;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Widgets.Viewmodels
{
    class ChartSlotViewmodel : ObservableObject
    {
        private WpfPlot _ChartModel;
        public WpfPlot ChartModel
        {
            get { return _ChartModel; }
            private set
            {
                if (value != _ChartModel)
                {
                    _ChartModel = value;
                    OnPropertyChanged("ChartModel");
                }
            }
        }

    }
}
