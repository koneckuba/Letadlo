using System;
using System.Windows;

namespace WpfApp1
{
    public partial class SecondWindow : Window
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Id { get; set; }
        public DateTime Datum { get; set; }

        public SecondWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Jmeno = spzTextBox.Text;
            Prijmeni = brandTextBox.Text;
            Id = modelTextBox.Text;
            Datum = datePicker.SelectedDate ?? DateTime.Now;
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}