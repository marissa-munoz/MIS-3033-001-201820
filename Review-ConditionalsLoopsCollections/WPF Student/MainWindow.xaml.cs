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

namespace WPF_Student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  List<Student> students = new List<Student>(); (moved up for scope to add more to the list)
            string txtIDAsString = txtID.Text; //long way
          
            int studentID = Convert.ToInt16(txtIDAsString);

            string fullName = txtName.Text;
            double studentGPA = Convert.ToDouble(txtGPA.Text);

            Student a = new Student();
            a.SoonerID = Convert.ToInt16(txtIDAsString);
            a.FirstName = txtName.Text;
            a.GPA = Convert.ToDouble(txtGPA.Text);
            students.Add(a);
            var futureDate = Convert.ToDateTime("1/15/2020");
            DateTime studentDOB = Convert.ToDateTime(txtDOB.Text);
            var x = studentDOB.AddDays(50); //add 50 days to the date of birth
            
            DateTime rightNow = DateTime.Now; //get the time/date right now
            var dif = rightNow - studentDOB; //difference between today and date of birth
           // MessageBox.Show($"Hello, {fullName} ({studentID}) with a GPA of {studentGPA}");


            output.Text = $"Hello {a.FirstName} ({a.SoonerID})";
        }
    }
}
