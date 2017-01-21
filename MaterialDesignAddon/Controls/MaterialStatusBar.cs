using System.Windows;
using System.Windows.Controls;

namespace MaterialDesignAddon.Controls
{
    public class MaterialStatusBar : ContentControl
    {
        static MaterialStatusBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaterialStatusBar),
                new FrameworkPropertyMetadata(typeof(MaterialStatusBar)));
        }
    }
}
