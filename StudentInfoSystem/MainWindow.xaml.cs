using System;
using System.Windows;
using StudentRepository;
using System.Collections.Generic;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            StudentData.InitTestStudents();
            UserData.ResetTestUserData();
            DisableForm();
        }



        private void ClearForm()
        {
            firstNameTextBox.Clear();
            secondNameTextBox.Clear();
            lastNameTextBox.Clear();
            SpecialtyTextBox.Clear();
            FacultyTextBox.Clear();
            FNumTextBox.Clear();
            CourseTextBox.Clear();
            StreamTextBox.Clear();
            GroupTextBox.Clear();
        }

        private void FillStudentInfo(Student student)
        {
            firstNameTextBox.Text = student.FirstName;
            secondNameTextBox.Text = student.SecondName;
            lastNameTextBox.Text = student.LastName;
            SpecialtyTextBox.Text = student.Specialty;
            FacultyTextBox.Text = student.Faculty;
            FNumTextBox.Text = student.FacNumber;
            CourseTextBox.Text = student.Year.ToString();
            StreamTextBox.Text = student.Stream.ToString();
            GroupTextBox.Text = student.Group.ToString();
        }

        private void DisableLoginForm()
        {
            usernameTextBox.IsEnabled = false;
            passwordBox.IsEnabled = false;
        }

        private void EnableLoginForm()
        {
            usernameTextBox.IsEnabled = true;
            passwordBox.IsEnabled = true;
        }

        private void ClearLoginForm()
        {
            usernameTextBox.Clear();
            passwordBox.Clear();
        }

        private void DisableForm()
        {
            firstNameTextBox.IsEnabled = false;
            secondNameTextBox.IsEnabled = false;
            lastNameTextBox.IsEnabled = false;
            SpecialtyTextBox.IsEnabled = false;
            FacultyTextBox.IsEnabled = false;
            FNumTextBox.IsEnabled = false;
            CourseTextBox.IsEnabled = false;
            StreamTextBox.IsEnabled = false;
            GroupTextBox.IsEnabled = false;
        }

        private void EnableForm()
        {
            firstNameTextBox.IsEnabled = true;
            secondNameTextBox.IsEnabled = true;
            lastNameTextBox.IsEnabled = true;
            SpecialtyTextBox.IsEnabled = true;
            FacultyTextBox.IsEnabled = true;
            FNumTextBox.IsEnabled = true;
            CourseTextBox.IsEnabled = true;
            StreamTextBox.IsEnabled = true;
            GroupTextBox.IsEnabled = true;
        }

        private void LoginUser()
        {
            LoginValidation validator = new LoginValidation(usernameTextBox.Text, passwordBox.Password, DisplayMessage);
            User user = null;
            if (validator.ValidateUserInput(ref user))
            {
                DisableLoginForm();
                if (user.role == (int)UserRoles.STUDENT)
                {
                    Student stud = StudentData.IsThereStudent(user.facNumber);
                    EnableForm();
                    FillStudentInfo(stud);
                }
                if(user.role == (int)UserRoles.PROFESSOR)
                {
                    //FacNumSearchGrid.Visibility = Visibility.Visible;
                    ProfessorWindow main = new ProfessorWindow();
                    App.Current.MainWindow = main;
                    this.Close();
                    main.Show();
                }
            }
        }
        private void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginUser();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            LogoutUser();
            ClearForm();
            ClearLoginForm();
            EnableLoginForm();
            DisableForm();
            FacNumSearchGrid.Visibility = Visibility.Hidden;
        }

        private void LogoutUser()
        {
            LoginValidation.CurrentUserRole = UserRoles.ANONYMOUS;
            LoginValidation.CurrentUserUsername = null;
        }

        private void facNumSearchButton_Click(object sender, RoutedEventArgs e)
        {
            Student stud = StudentData.IsThereStudent(facNumSearchTextBox.Text);
            if(stud != null)
            {
                EnableForm();
                FillStudentInfo(stud);
            }
        }
    }
}
