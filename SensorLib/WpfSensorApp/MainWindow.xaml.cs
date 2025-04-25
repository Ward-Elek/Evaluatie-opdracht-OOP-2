using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SensorLib;

namespace WpfSensorApp
{
    public partial class MainWindow : Window
    {
        private List<ISensor> sensors = new();
        private ISensor selectedSensor = null;
        private string currentType = "";

        public MainWindow()
        {
            InitializeComponent();
            SensorDataGrid.ItemsSource = sensors;
        }

        private void SensorTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var typeItem = (ComboBoxItem)SensorTypeComboBox.SelectedItem;
            if (typeItem == null) return;

            currentType = typeItem.Content.ToString();
            UpdateSensorDetailsPanel();
        }

        private void UpdateSensorDetailsPanel()
        {
            SensorDetailsPanel.Children.Clear();

            switch (currentType)
            {
                case "LevelSensor":
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("LowLevel"));
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("HighLevel"));
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("Value"));
                    break;
                case "MoistureSensor":
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("Depth"));
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("Value"));
                    break;
                case "TempHumiSensor":
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("TempValue"));
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("HumiValue"));
                    break;
                case "UVSensor":
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("LowLevel"));
                    SensorDetailsPanel.Children.Add(CreateLabelAndTextbox("Value"));
                    break;
            }
        }

        private StackPanel CreateLabelAndTextbox(string label)
        {
            string unit = label switch
            {
                "LowLevel" when currentType == "LevelSensor" => " (liter)",
                "HighLevel" => " (liter)",
                "Value" when currentType == "LevelSensor" => " (liter)",
                "Depth" => " (cm)",
                "Value" when currentType == "MoistureSensor" => " (%)",
                "TempValue" => " (°C)",
                "HumiValue" => " (%)",
                "LowLevel" when currentType == "UVSensor" => " (UV-index)",
                "Value" when currentType == "UVSensor" => " (UV-index)",
                _ => ""
            };

            var panel = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 0, 0, 5) };
            panel.Children.Add(new Label { Content = $"{label}{unit}:", Width = 150 });
            panel.Children.Add(new TextBox { Name = label + "TextBox", Width = 150 });
            return panel;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var name = NameTextBox.Text;
            var location = LocationTextBox.Text;
            var typeItem = (ComboBoxItem)SensorTypeComboBox.SelectedItem;

            if (typeItem == null) return;

            ISensor sensor = null;
            string selectedType = typeItem.Content.ToString();

            try
            {
                switch (selectedType)
                {
                    case "LevelSensor":
                        sensor = new LevelSensor
                        {
                            Name = name,
                            Location = location,
                            Type = selectedType,
                            LowLevel = double.Parse(GetTextboxValue("LowLevel")),
                            HighLevel = double.Parse(GetTextboxValue("HighLevel")),
                            Value = double.Parse(GetTextboxValue("Value"))
                        };
                        break;
                    case "MoistureSensor":
                        sensor = new MoistureSensor
                        {
                            Name = name,
                            Location = location,
                            Type = selectedType,
                            Depth = int.Parse(GetTextboxValue("Depth")),
                            Value = double.Parse(GetTextboxValue("Value"))
                        };
                        break;
                    case "TempHumiSensor":
                        sensor = new TempHumiSensor
                        {
                            Name = name,
                            Location = location,
                            Type = selectedType,
                            TempValue = double.Parse(GetTextboxValue("TempValue")),
                            HumiValue = double.Parse(GetTextboxValue("HumiValue"))
                        };
                        break;
                    case "UVSensor":
                        sensor = new UVSensor
                        {
                            Name = name,
                            Location = location,
                            Type = selectedType,
                            LowLevel = double.Parse(GetTextboxValue("LowLevel")),
                            Value = double.Parse(GetTextboxValue("Value"))
                        };
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij aanmaken sensor: " + ex.Message);
                return;
            }

            if (sensor != null)
            {
                sensors.Add(sensor);
                RefreshSensorList();
                ClearInputFields();
            }
        }

        private string GetTextboxValue(string label)
        {
            foreach (var child in SensorDetailsPanel.Children)
            {
                if (child is StackPanel sp && sp.Children.Count == 2 && sp.Children[0] is Label lbl && lbl.Content.ToString().StartsWith(label))
                {
                    if (sp.Children[1] is TextBox tb)
                        return tb.Text;
                }
            }
            return "";
        }

        private void RefreshSensorList()
        {
            SensorDataGrid.ItemsSource = null;
            SensorDataGrid.ItemsSource = sensors;
        }

        private void ClearInputFields()
        {
            NameTextBox.Clear();
            LocationTextBox.Clear();
            SensorTypeComboBox.SelectedIndex = -1;
            SensorDetailsPanel.Children.Clear();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (SensorDataGrid.SelectedItem is ISensor sensor)
            {
                sensors.Remove(sensor);
                RefreshSensorList();
            }
        }
    }
}
