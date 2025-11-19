using Microsoft.Win32;
using MzExplorer.Properties;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace MzExplorer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "N/A";
            BuildInfoTextBlock.Text = $"MzExplorer Version: v{version}.{BuildInfo.BuildCount} / Build: {BuildInfo.BuildDateTime}";
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                SelectedFileNameTextBlock.Text = System.IO.Path.GetFileName(dialog.FileName);
            }
        }

    }
}
