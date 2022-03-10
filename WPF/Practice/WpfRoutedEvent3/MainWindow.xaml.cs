using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Practice03.Ex03.WpfRoutedEvent3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameFile = "username.txt";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void setText_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetBut.IsEnabled = true;
            RetBut.IsEnabled = true;
        }

        bool isDataDirty = false;
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.isDataDirty)
            {
                string msg = "Данные были изменены, но не сохранены!\n Закрыть окно без сохранения?";
                MessageBoxResult result = MessageBox.Show(msg, "Контроль данных", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void New_Win_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            try
            {            
            switch (feSource.Name)
                {
                    case "SetBut":
                        SetButClick();
                        break;
                    case "RetBut":
                        RetButClick();
                        break;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetButClick()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(nameFile))
            {
                sw.WriteLine(SetText.Text);               
                RetBut.IsEnabled = true;
                isDataDirty = false;
            }
        }
        private void RetButClick()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(nameFile))
            {
                sw.WriteLine(RetLabel.Content);               
                RetBut.IsEnabled = true;
                isDataDirty = false;
            }
        }
    }
}
