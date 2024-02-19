using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Kwadrat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
                
            for (int i = 0; i < 10; i++)
            {
                GameGrid.ColumnDefinitions.Add(new ColumnDefinition());
                GameGrid.RowDefinitions.Add(new RowDefinition());
            }

            var random = new Random();
            
            // Fill grid with random numbers
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var randomNumber = random.Next(0, 100);
                    var button = new Button
                    {
                        Content = $"{randomNumber}",
                        HorizontalContentAlignment = HorizontalAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Center
                    };
                    button.Click += (sender, args) =>
                    {
                        Button sendedButton = (Button) sender;
                        sendedButton.Background = Brushes.Red;
                    };
                    Grid.SetColumn(button, i);
                    Grid.SetRow(button, j);
                    GameGrid.Children.Add(button);
                }
            }
        }
    }
}