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
using Cuciin_Dekstop.Util;
using Cuciin_Dekstop.Login;

namespace Cuciin_Dekstop.Dashboard
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DashboardFrame : MyPage
    {
        public DashboardFrame()
        {
            InitializeComponent();
            setController(new DashboardController(this));
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            getController().callMethod("OnLogout");
            UtilProvider.getSession().logout();
            UtilProvider.destroySession();
            UtilProvider.getMainFrame().Navigate(new LoginFrame());
        }
    }
}
