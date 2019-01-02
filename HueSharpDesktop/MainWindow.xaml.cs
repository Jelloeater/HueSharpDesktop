using System;
using System.Windows;
using System.Windows.Controls;
using libs;


namespace HueSharpDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.Add_Buttons();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            this.Remove_Buttons();
            this.Add_Buttons();
        }

        private void Add_Buttons()
        {
            var LightList = Lights.GetLightList();

            foreach (var i in LightList)
            {
                var lightLabel = new Label();
                lightLabel.Content = i.Name;

                var turnOnLight = new Button();
                turnOnLight.Content = "On";
                turnOnLight.Click += (turnOnLight_Action);

                var turnOffLight = new Button();
                turnOffLight.Content = "Off";
                turnOffLight.Click += (turnOffLight_Action);

                mainSubPannel.Children.Add(lightLabel);
                mainSubPannel.Children.Add(turnOnLight);
                mainSubPannel.Children.Add(turnOffLight);

            }
        }

        private void Remove_Buttons()
        {
            foreach (System.Windows.UIElement item in mainSubPannel.Children)
            {
                Console.WriteLine("");
                //mainSubPannel.Children.Remove(item);
            }
            
        }
        private void turnOffLight_Action(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void turnOnLight_Action(object sender, EventArgs e)
        {
            MessageBox.Show("My message here");
            
        }
    }
}
