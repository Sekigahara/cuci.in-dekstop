using Cuciin_Dekstop.Dashboard;
using Cuciin_Dekstop.History;
using Cuciin_Dekstop.Login;
using Cuciin_Dekstop.Util;
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
using Velacro.UIElements.TextBlock;

namespace Cuciin_Dekstop.HistoryDetail
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class HistoryDetailFrame : MyPage
    {
        private IMyTextBlock poNumberTextBlock;
        private BuilderTextBlock builderTextBlock;

        public HistoryDetailFrame(int id)
        {
            InitializeComponent();
            setController(new HistoryDetailController(this));
            getController().callMethod("setData", id, id_transaksi, alamat_pembeli, nama_pembeli, totalPrice);
            getController().callMethod("setDataGrid", dataGridTransaksi);
        }

        private void enterEventTrigger(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                getController().callMethod("editData", id_transaksi, alamat_pembeli, nama_pembeli, totalPrice);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getController().callMethod("editData", id_transaksi, alamat_pembeli, nama_pembeli, totalPrice);
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
    }
}
