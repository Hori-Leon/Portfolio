using MaterialDesignThemes.Wpf;

namespace Portfolio.Helper
{
    public interface IPageViewModel
    {
        string PageName { get; }

        PackIconKind PageIcon { get; }
    }
}
