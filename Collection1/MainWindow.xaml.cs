using System;
using System.Collections;
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

namespace Collection1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList1;
        public MainWindow()
        {
            InitializeComponent();
            arrayList1 = new ArrayList();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            arrayList1.Sort();

            foreach (string data in arrayList1)
            {
                MessageBox.Show(data.ToString());
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string dataInput = txtInput.Text;
            if (dataInput != null)
            {
                arrayList1.Add(dataInput);
                txtInput.Clear();
            } else
            {
                MessageBox.Show("Plase input valuse !!");
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            string dataInput = txtInput.Text;
            if (dataInput != null)
            {
                MessageBoxResult result =  MessageBox.Show("Do you want to remove data "+dataInput+ " ?" ,"Confirm" , MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    arrayList1.Remove(dataInput);//object
                    MessageBox.Show("Already Remove");
                    txtInput.Clear();
                }
            }
            else
            {
                MessageBox.Show("Plase input valuse !!");
            }
        }
    }
}
