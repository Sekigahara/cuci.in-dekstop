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
using Velacro.Chart.LineChart;
using Velacro.Basic;
using Velacro.UIElements.TextBox;
using Velacro.UIElements.TextBlock;
using System.Globalization;
using Cuciin_Dekstop.History;

namespace Cuciin_Dekstop.Dashboard
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DashboardFrame : MyPage
    {
        private IMyLineChart myLineChart;
        private IMyTextBlock earningTextBlock;
        private BuilderLineChart builderChart;
        private BuilderTextBlock builderTextBlock;
        public DashboardFrame()
        {
            InitializeComponent();
            setController(new DashboardController(this));
            initUIBuilders();
            getController().callMethod("generateTransactionData");
        }

        private void initUIBuilders()
        {
            builderChart = new BuilderLineChart();
            builderTextBlock = new BuilderTextBlock();
        }

        public void generateChart()
        {
            MyList<double> income = new MyList<double>();
            for(int i = 0; i < UtilProvider.getDataTransaction().getData().Count; i++)
            {
                income.Add(UtilProvider.getDataTransaction().getData().ElementAt(i).getAmount().GetValueOrDefault());
            }

            myLineChart = builderChart.activate(this, "monthly_chart")
                .addSeries("Income", income)
                .changeSeriesFillColor("Income", "#80bfff");

            generateEarnings(income);
        }

        private void generateEarnings(MyList<double> income)
        {
            double sum = 0.0;
            for (int i = 0; i < income.Count; i++)
                sum = sum + income.ElementAt(i);

            earningTextBlock = builderTextBlock.activate(this, "earning_text")
                .setText(ToRupiah(sum) + ".-");
        }

        private string ToRupiah(double data)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", data);
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
