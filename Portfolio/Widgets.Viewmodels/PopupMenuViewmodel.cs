using MaterialDesignThemes.Wpf;
using Portfolio.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Widgets.Viewmodels
{
    class PopupMenuViewmodel : ObservableObject
    {
        public string PopupName { get; set; }
        public PackIconKind PopupIcon { get; set; }

        private List<IPageViewModel> _PageList = new List<IPageViewModel>();
        public List<IPageViewModel> PageList
        {
            get
            {
                if (_PageList == null)
                    _PageList = new List<IPageViewModel>();

                return _PageList;
            }
        }

        public PopupMenuViewmodel(string _mPopupName, PackIconKind _mPopupIcon)
        {
            PopupName = _mPopupName;
            PopupIcon = _mPopupIcon;
        }

        public void AddMenu(IPageViewModel _mPageVM)
        {
            PageList.Add(_mPageVM);
        }

    }
}
