using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SimpleMVVMExample
{


    /// <summary>
    /// Interaction logic for ApplicationView.xaml
    /// </summary>
    public partial class ApplicationView : Window
    {
        private double restoreTop;
        private FrameworkElement caption;
        private Button closeButton;

        public ApplicationView()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            RegisterCaption();
            RegisterCloseButton();
        }
        private void RegisterCloseButton()
        {
            closeButton = (Button)GetTemplateChild("PART_WindowCaptionCloseButton");

            if (closeButton != null)
            {
                closeButton.Click += (sender, e) => Close();
            }
        }
        private void RegisterCaption()
        {
            caption = (FrameworkElement)GetTemplateChild("PART_WindowCaption");

            if (caption != null)
            {
                caption.MouseLeftButtonDown += (sender, e) =>
                {
                    restoreTop = e.GetPosition(this).Y;
                    if (e.ClickCount == 2 && e.ChangedButton == System.Windows.Input.MouseButton.Left && (ResizeMode != ResizeMode.CanMinimize && ResizeMode != ResizeMode.NoResize))
                    {
                        if (WindowState != System.Windows.WindowState.Maximized)
                            WindowState = System.Windows.WindowState.Maximized;
                        else
                            WindowState = System.Windows.WindowState.Normal;
                        return;
                    }
                    DragMove();
                };

                caption.MouseMove += (sender, e) =>
                {
                    if (e.LeftButton == MouseButtonState.Pressed && caption.IsMouseOver)
                    {
                        if (WindowState == WindowState.Maximized)
                        {
                            WindowState = WindowState.Normal;
                            Top = restoreTop - 10;
                            DragMove();
                        }
                    }
                };
            }
        }  
    }
}
