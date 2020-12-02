using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velacro.Basic;
using Cuciin_Dekstop.Model;
using Cuciin_Dekstop.Util;
using Velacro.Api;
using System.Windows;
using System.Net.Http;
using System.Windows.Controls;

namespace Cuciin_Dekstop.History
{
    class HistoryController : MyController
    {
        public HistoryController(IMyView _myView) : base(_myView)
        {

        }

        public async void generateData(DataGrid data_grid_transaction)
        {

            List<DataTransaction> data = UtilProvider.getDataTransaction().getData();
            List<HistoryData> dataHistory = new List<HistoryData>();

            for (int i = 0; i < data.Count(); i++)
            {
                String po_number = data.ElementAt(i).getPoNumber();
                String date = data.ElementAt(i).getCreatedAt();
                Double amount = data.ElementAt(i).getAmount().GetValueOrDefault();

                ApiClient client = UtilProvider.getSession().getClient();
                var request = new ApiRequestBuilder();

                String URL = "user/id/" + data.ElementAt(i).getCustomerId().ToString();
                
                var req = request
                          .buildHttpRequest()
                          .setEndpoint(URL)
                          .setRequestMethod(HttpMethod.Get);
                client.setAuthorizationToken(UtilProvider.getSession().getUser().getData().getToken());
                var response = await client.sendRequest(request.getApiRequestBundle());

                String name;
                String phone;
                
                if (response.getHttpResponseMessage().ReasonPhrase.Equals("OK"))
                {
                    UserCredential userCredential = response.getParsedObject<UserCredential>();
                    name = userCredential.getData().getFullName();
                    phone = userCredential.getData().getPhone();
                }
                else
                {
                    //MessageBox.Show(response.getHttpResponseMessage().ReasonPhrase);
                    phone = name = "unknown";
                }

                dataHistory.Add(new HistoryData(po_number, date, name, phone, amount));
            }

            data_grid_transaction.ItemsSource = dataHistory;
        }

        public async void OnLogout()
        {
            ApiClient client = UtilProvider.getSession().getClient();
            var request = new ApiRequestBuilder();

            var req = request
                      .buildHttpRequest()
                      .setEndpoint("logout")
                      .setRequestMethod(HttpMethod.Get);
            client.setAuthorizationToken(UtilProvider.getSession().getUser().getData().getToken());

            var response = await client.sendRequest(request.getApiRequestBundle());
        }
    }
}
