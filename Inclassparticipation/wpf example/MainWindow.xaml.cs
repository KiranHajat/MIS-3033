//kiran hajat
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

namespace wpf_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //when application load we want empty text box (delete the text frm text box:
            txtFirstname.Text = ""; // you just want to change the txt property
            txtLastname.Text = string.Empty;
            txtBirthdate.Text = string.Empty;
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //evertime i click the submit button clear everythibg
            lstLetters.Items.Clear();
            //get the input from user
            string firstName, lastName, birthDate;
            firstName = txtFirstname.Text;  //txtFirstname is whole thing so put txt
            lastName = txtLastname.Text;
            birthDate = txtBirthdate.Text;

            string fullName = firstName + " " + lastName;
            DateTime dob = Convert.ToDateTime(birthDate);


            //output all the letters
            foreach (var letter in fullName)
            {
                lstLetters.Items.Add(letter);

            }
            lstLetters.Items.Add($"you were born on a {dob.DayOfWeek}");
        }
    

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Thank you using the app");
            Close();
        }
    }
}
