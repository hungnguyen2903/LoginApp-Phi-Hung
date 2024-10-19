using System.Windows;

namespace WPFLoginApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            labelMessage.Content = ""; // Ẩn thông báo lỗi khi khởi động
        }

        // Sự kiện khi nhấn nút Login
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Lấy thông tin từ TextBox và PasswordBox
            string username = textBoxUsername.Text;
            string password = passwordBox.Password;

            // Kiểm tra thông tin đăng nhập
            if (username == "admin" && password == "12345")
            {
                // Đăng nhập thành công
                labelMessage.Foreground = System.Windows.Media.Brushes.Green;
                labelMessage.Content = "Login successful!";
            }
            else
            {
                // Đăng nhập thất bại
                labelMessage.Foreground = System.Windows.Media.Brushes.Red;
                labelMessage.Content = "Invalid username or password.";
            }
        }
    }
}