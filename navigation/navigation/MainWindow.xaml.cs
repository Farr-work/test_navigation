using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using navigation.Views;

namespace navigation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Tải trang Dashboard làm trang mặc định khi mở ứng dụng
            MainContent.Content = new DashboardView();
        }

        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {
            // Khi nhấn nút, thay đổi thuộc tính Content của ContentControl
            MainContent.Content = new DashboardView();
        }

        private void BtnStudents_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new StudentsView();
        }

        private void BtnCourses_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CoursesView();
        }
    }
}