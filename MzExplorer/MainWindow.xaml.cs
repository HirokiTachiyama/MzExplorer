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
        public static string MzProjectFilePath = string.Empty;
        public static string MzProjectDirectory = string.Empty;


        public MainWindow()
        {
            InitializeComponent();

            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "N/A";
            BuildInfoTextBlock.Text = $"MzExplorer Version: v{version}.{BuildInfo.BuildCount} / Build: {BuildInfo.BuildDateTime}";
        }

        private void SelectMZProject_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "RPG Maker MZ Project File (*.rpgproject)|*.rpgproject";
            if (dialog.ShowDialog() == true)
            {
                MzProjectFilePath = dialog.FileName;
                MzProjectDirectory = System.IO.Path.GetDirectoryName(MzProjectFilePath) ?? string.Empty;
                SelectedFileNameTextBlock.Text = MzProjectDirectory;
            }
        }

    }
}
