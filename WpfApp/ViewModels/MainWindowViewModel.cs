using WpfApp.Enums;

namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        [Reactive] public IVAC_VT_SHIFT_SPD VTShiftSPD { get; set; } = IVAC_VT_SHIFT_SPD.DATA16;
    }
}