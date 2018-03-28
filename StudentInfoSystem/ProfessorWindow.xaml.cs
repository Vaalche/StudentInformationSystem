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
using System.Windows.Shapes;
using StudentRepository;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for ProfessorWindow.xaml
    /// </summary>
    public partial class ProfessorWindow : Window
    {
        public ProfessorWindow()
        {
            InitializeComponent();
            FillListBox(null);
        }

        private void FillListBox(string facNumber)
        {
            if (facNumber == null)
            {
                foreach (Student stud in StudentData.TestStudents)
                {
                    ListBoxItem studentItem = new ListBoxItem();
                    studentItem.Content = stud.firstName + stud.lastName;
                    listBox.Items.Add(studentItem);
                }
            }
            else
            {
                foreach (Student stud in StudentData.TestStudents)
                {
                    if (stud.facNumber.StartsWith(facNumber))
                    {
                        ListBoxItem studentItem = new ListBoxItem();
                        studentItem.Content = stud.firstName + stud.lastName;
                        listBox.Items.Add(studentItem);
                    }
                }
            }
        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            FillListBox(facNumberFilter.Text);
        }
    }
}
