using System;
using System.Runtime.ConstrainedExecution;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.ShowDialog();

            if (secondWindow.DialogResult == true)
            {
                var newCar = new Car
                {
                    Jmeno = secondWindow.Jmeno,
                    Prijmeni = secondWindow.Prijmeni,
                    Id = secondWindow.Id,
                    Datum = secondWindow.Datum
                };
                carListBox.Items.Add(newCar);
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (carListBox.SelectedItem != null)
            {
                carListBox.Items.Remove(carListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Prosím vyberte zamestnance ke smazání.");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.ShowDialog();

            if (carListBox.SelectedItem != null)
            {
                carListBox.Items.Remove(carListBox.SelectedItem);
            if (secondWindow.DialogResult == true)
            {
                var newCar = new Car
                {
                    Jmeno = secondWindow.Jmeno,
                    Prijmeni = secondWindow.Prijmeni,
                    Id = secondWindow.Id,
                    Datum = secondWindow.Datum
                };
                carListBox.Items.Add(newCar);
            }
            }
            else
            {
                MessageBox.Show("Prosím vyberte zamestnance k editaci.");
            }

        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            if (carListBox.SelectedItem != null)
            {
                upraveni.Text = carListBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Prosím vyberte zamestnance k zobrazeni.");
            }

        }
    }
}