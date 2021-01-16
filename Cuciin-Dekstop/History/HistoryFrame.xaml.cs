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
using Velacro.UIElements.Basic;
using Cuciin_Dekstop.Util;
using Cuciin_Dekstop.Login;
using Cuciin_Dekstop.Dashboard;
using Cuciin_Dekstop.HistoryDetail;
using Cuciin_Dekstop.AboutUs;

namespace Cuciin_Dekstop.History
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class HistoryFrame : MyPage
    {
        public HistoryFrame()
        {
            InitializeComponent();
            setController(new HistoryController(this));
            getController().callMethod("generateData", data_grid_transaction);
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            UtilProvider.getMainFrame().Navigate(new LoginFrame());
            getController().callMethod("OnLogout");
            UtilProvider.getSession().logout();
            UtilProvider.destroySession();
        }

        private void history_btn_Click(object sender, RoutedEventArgs e)
        {
            UtilProvider.getMainFrame().Navigate(new HistoryFrame());
        }

        private void dashboard_btn_Click(object sender, RoutedEventArgs e)
        {
            UtilProvider.getMainFrame().Navigate(new DashboardFrame());
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs s)
        {
            int currentIndex = data_grid_transaction.Items.IndexOf(data_grid_transaction.CurrentItem);
            UtilProvider.getMainFrame().Navigate(new HistoryDetailFrame(currentIndex));
        }

        private void about_us_btn_Click(object sender, RoutedEventArgs e)
        {
            UtilProvider.getMainFrame().Navigate(new AboutUsFrame());
        }
    }
}