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
using Velacro.UIElements.Basic;
using Velacro.UIElements.Button;
using Velacro.UIElements.TextBlock;
using Velacro.UIElements.TextBox;
using Cuciin_Dekstop.Dashboard;
using Cuciin_Dekstop.Util;

namespace Cuciin_Dekstop.Login
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginFrame : MyPage
    {
        private BuilderButton buttonBuilder;
        private BuilderTextBox textBoxBuilder;
        private BuilderTextBlock textBlockBuilder;
        private IMyButton loginbutton;
        private IMyTextBox usernameTextBox;
        private IMyTextBox passwordTextBox;
        private IMyTextBlock statusTextBlock;

        public LoginFrame()
        {
            InitializeComponent();
            setController(new LoginController(this));
            initUIBuilders();
            initUIElements();
        }

        private void initUIBuilders()
        {
            buttonBuilder = new BuilderButton();
            textBoxBuilder = new BuilderTextBox();
            textBlockBuilder = new BuilderTextBlock();
        }

        private void initUIElements()
        {
            loginbutton = buttonBuilder
                            .activate(this, "login_button")
                            .addOnClick(this, "onLoginButtonClick");
            usernameTextBox = textBoxBuilder.activate(this, "username_field");
            passwordTextBox = textBoxBuilder.activate(this, "password_field");
            statusTextBlock = textBlockBuilder.activate(this, "status_field");
        }

        public void onLoginButtonClick()
        {
            getController().callMethod("OnLogin", username_field.Text, password_field.Text);
        }

        public void setLoginStatus(string status)
        {
            this.Dispatcher.Invoke(() =>
            {
                statusTextBlock.setText(status);
                
            });
        }

        public void redirectToDashboard()
        {
            UtilProvider.getMainFrame().Navigate(new DashboardFrame());
        }
    }
}
