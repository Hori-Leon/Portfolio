using MaterialDesignThemes.Wpf;
using Portfolio.Helper;
using Portfolio.Pages.Viewmodels;
using Portfolio.Widgets.Viewmodels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Portfolio
{
    class MainWindowViewModel : ObservableObject
    {
        #region NavigationProperties

        public PopupMenuViewmodel PopupPt_1 { get; } = new PopupMenuViewmodel("Apps",PackIconKind.Apps);

        private IPageViewModel _CurrentPageViewModel;
        public IPageViewModel CurrentPageViewModel
        {
            get => _CurrentPageViewModel;
            set
            {
                if (_CurrentPageViewModel != value)
                {
                    _CurrentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        private ICommand _ChangePageCmd;
        public ICommand ChangePageCmd
        {
            get
            {
                if (_ChangePageCmd == null)
                {
                    _ChangePageCmd = new BaseCommand(
                        p => {
                            var TargetPage = ((IPageViewModel)p);
                            if (PopupPt_1.PageList.Contains(TargetPage))
                                CurrentPageViewModel = PopupPt_1.PageList
                                    .FirstOrDefault(vm => vm == TargetPage);
                        },
                        p => p is IPageViewModel);
                }

                return _ChangePageCmd;
            }
        }

        #endregion
        public MainWindowViewModel()
        {
            PopupPt_1.AddMenu(new ChartDemoPageViewmodel());
        }

    }
}
