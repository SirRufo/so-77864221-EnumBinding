using System.ComponentModel;

using WpfApp.Utils;

namespace WpfApp.Enums
{
    [TypeConverter( typeof( EnumDescriptionTypeConverter ) )]
    public enum IVAC_VT_SHIFT_SPD
    {
        [Description( "16.1299991607666" )]
        DATA16,
        [Description( "32.130001068115234" )]
        DATA32,
    }
}
