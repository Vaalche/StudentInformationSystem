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
                    
                    listBox.Items.Add(stud);
                }
            }
            else
            {
                foreach (Student stud in StudentData.TestStudents)
                {
                    if (stud.FacNumber.StartsWith(facNumber))
                    {
                        
                        listBox.Items.Add(stud);
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
