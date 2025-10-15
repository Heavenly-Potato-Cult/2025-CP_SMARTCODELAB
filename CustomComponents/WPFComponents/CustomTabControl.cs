using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Wpf = System.Windows;
using WpfControls = System.Windows.Controls;

namespace SmartCodeLab.CustomComponents.WPFComponents
{
    public partial class CustomTabControl : UserControl
    {
        private ElementHost elementHost;
        private WpfControls.TabControl wpfTabControl;

        public CustomTabControl()
        {
            InitializeComponent();
            InitializeWpfTabControl();
        }

        private void InitializeWpfTabControl()
        {
            wpfTabControl = new WpfControls.TabControl();
            StyleWpfTabControl();

            elementHost = new ElementHost
            {
                Dock = DockStyle.Fill,
                Child = wpfTabControl
            };
            Controls.Add(elementHost);
        }

        public void AddTab(string title, Control winFormsControl)
        {
            var tab = new WpfControls.TabItem();

            // Header
            var headerBorder = new WpfControls.Border
            {
                Background = new Wpf.Media.SolidColorBrush(Wpf.Media.Color.FromRgb(245, 245, 245)),
                Padding = new Wpf.Thickness(10, 3, 10, 3),
                Margin = new Wpf.Thickness(2, 2, 2, 0),
                CornerRadius = new Wpf.CornerRadius(0)
            };

            var headerPanel = new WpfControls.Grid
            {
                VerticalAlignment = Wpf.VerticalAlignment.Center
            };

            headerPanel.ColumnDefinitions.Add(new WpfControls.ColumnDefinition { Width = new Wpf.GridLength(1, Wpf.GridUnitType.Star) });
            headerPanel.ColumnDefinitions.Add(new WpfControls.ColumnDefinition { Width = Wpf.GridLength.Auto });

            var textBlock = new WpfControls.TextBlock
            {
                Text = title,
                Foreground = new Wpf.Media.SolidColorBrush(Wpf.Media.Colors.Black),
                FontWeight = Wpf.FontWeights.SemiBold,
                Margin = new Wpf.Thickness(5, 0, 10, 0),
                VerticalAlignment = Wpf.VerticalAlignment.Center
            };

            var closeBtn = new WpfControls.Button
            {
                Content = "✕",
                Foreground = new Wpf.Media.SolidColorBrush(Wpf.Media.Color.FromRgb(120, 120, 120)),
                Background = Wpf.Media.Brushes.Transparent,
                BorderThickness = new Wpf.Thickness(0),
                FontSize = 12,
                Width = 20,
                Height = 20,
                Cursor = Wpf.Input.Cursors.Hand,
                HorizontalAlignment = Wpf.HorizontalAlignment.Right,
                VerticalAlignment = Wpf.VerticalAlignment.Center,
                Padding = new Wpf.Thickness(0)
            };

            closeBtn.MouseEnter += (s, e) =>
                closeBtn.Foreground = new Wpf.Media.SolidColorBrush(Wpf.Media.Colors.Red);
            closeBtn.MouseLeave += (s, e) =>
                closeBtn.Foreground = new Wpf.Media.SolidColorBrush(Wpf.Media.Color.FromRgb(120, 120, 120));
            closeBtn.Click += (s, e) => wpfTabControl.Items.Remove(tab);


            WpfControls.Grid.SetColumn(textBlock, 0);
            WpfControls.Grid.SetColumn(closeBtn, 1);
            headerPanel.Children.Add(textBlock);
            headerPanel.Children.Add(closeBtn);
            headerBorder.Child = headerPanel;
            tab.Header = headerBorder;

            // Content
            var wfHost = new WindowsFormsHost { Child = winFormsControl };
            tab.Content = wfHost;

            wpfTabControl.Items.Add(tab);
            wpfTabControl.SelectionChanged += (s, e) => RefreshTabVisuals();
            RefreshTabVisuals();
        }
        private void TabSelectionChanged(object sender, WpfControls.SelectionChangedEventArgs e)
        {
            RefreshTabVisuals();
        }

        private void RefreshTabVisuals()
        {
            foreach (WpfControls.TabItem item in wpfTabControl.Items)
            {
                if (item.Header is WpfControls.Border border)
                {
                    bool isSelected = item.IsSelected;

                    border.Background = new Wpf.Media.SolidColorBrush(
                        isSelected
                            ? Wpf.Media.Color.FromRgb(255, 255, 255) // active tab background
                            : Wpf.Media.Color.FromRgb(245, 245, 245)); // normal tab background

                    border.BorderBrush = isSelected
                        ? new Wpf.Media.SolidColorBrush(Wpf.Media.Color.FromRgb(0, 120, 215)) // straight blue line
                        : Wpf.Media.Brushes.Transparent;

                    border.BorderThickness = isSelected ? new Wpf.Thickness(0, 0, 0, 2) : new Wpf.Thickness(0);
                    border.CornerRadius = new Wpf.CornerRadius(0); // ensure no curve
                    border.Margin = new Wpf.Thickness(2, 0, 2, 0);
                }
            }
        }

        private void StyleWpfTabControl()
        {
            wpfTabControl.Background = new Wpf.Media.SolidColorBrush(Wpf.Media.Color.FromRgb(250, 250, 250));
            wpfTabControl.BorderThickness = new Wpf.Thickness(0);
            wpfTabControl.Padding = new Wpf.Thickness(0);
            wpfTabControl.Margin = new Wpf.Thickness(0);

            var style = new System.Windows.Style(typeof(WpfControls.TabItem));
            style.Setters.Add(new System.Windows.Setter(WpfControls.TabItem.BorderThicknessProperty, new Wpf.Thickness(0)));
            style.Setters.Add(new System.Windows.Setter(WpfControls.TabItem.PaddingProperty, new Wpf.Thickness(0)));
            style.Setters.Add(new System.Windows.Setter(WpfControls.TabItem.MarginProperty, new Wpf.Thickness(0, 0, 4, 0)));
            wpfTabControl.ItemContainerStyle = style;
        }

        public int TabCount => wpfTabControl.Items.Count;
        public void RemoveAllTabs() => wpfTabControl.Items.Clear();
    }
}
