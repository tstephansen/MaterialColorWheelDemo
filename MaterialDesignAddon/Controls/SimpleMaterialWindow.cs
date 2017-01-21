using System.Windows;
using System.Windows.Input;

namespace MaterialDesignAddon.Controls
{
    public class SimpleMaterialWindow : Window
    {
        static SimpleMaterialWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SimpleMaterialWindow),
                new FrameworkPropertyMetadata(typeof(SimpleMaterialWindow)));
        }
        
        public SimpleMaterialWindow()
        {
            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, CloseWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, MaximizeWindow,
                CanResizeWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, MinimizeWindow,
                CanMinimizeWindow));
            CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, RestoreWindow,
                CanResizeWindow));
        }
        
        public static readonly DependencyProperty StatusBarItemsProperty = DependencyProperty.Register(
            "StatusBarItems", typeof(MaterialStatusBar), typeof(SimpleMaterialWindow),
            new PropertyMetadata(default(MaterialStatusBar)));
        
        public MaterialStatusBar StatusBarItems
        {
            get { return (MaterialStatusBar)GetValue(StatusBarItemsProperty); }
            set { SetValue(StatusBarItemsProperty, value); }
        }

        #region Window Commands
        private void CanResizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ResizeMode == ResizeMode.CanResize || ResizeMode == ResizeMode.CanResizeWithGrip;
        }

        private void CanMinimizeWindow(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ResizeMode != ResizeMode.NoResize;
        }

        private void CloseWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void MaximizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MaximizeWindow(this);
        }

        private void MinimizeWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void RestoreWindow(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.RestoreWindow(this);
        }
        #endregion
    }
}
