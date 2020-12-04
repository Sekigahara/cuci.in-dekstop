using Cuciin_Dekstop.Model;
using Cuciin_Dekstop.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Velacro.Api;
using Velacro.Basic;

namespace Cuciin_Dekstop.Dashboard
{
    class DashboardController : MyController
    {
        public DashboardController(IMyView _myView) : base(_myView)
        {

        }

        public async void generateTransactionData()
        {
            ApiClient client = UtilProvider.getSession().getClient();
            var request = new ApiRequestBuilder();

            String URL = "transaction/owner/" + UtilProvider.getSession().getUser().getData().getId();
            var req = request
                      .buildHttpRequest()
                      .setEndpoint(URL)
                      .setRequestMethod(HttpMethod.Get);
            client.setAuthorizationToken(UtilProvider.getSession().getUser().getData().getToken());
            var response = await client.sendRequest(request.getApiRequestBundle());

            if (response.getHttpResponseMessage().ReasonPhrase.Equals("OK"))
            {
                Transaction transaction = response.getParsedObject<Transaction>();
                cleanData(transaction);
            }
            else
            {
                MessageBox.Show(response.getHttpResponseMessage().ReasonPhrase);
            }
        }

        public async void OnLogout()
        {
            ApiClient client = UtilProvider.getSession().getClient();
            var request = new ApiRequestBuilder();

            var req= request
                      .buildHttpRequest()
                      .setEndpoint("logout")
                      .setRequestMethod(HttpMethod.Get);
            client.setAuthorizationToken(UtilProvider.getSession().getUser().getData().getToken());

            var response = await client.sendRequest(request.getApiRequestBundle());
        }

        private void cleanData(Transaction transaction)
        {
            for(int i = 0; i < transaction.getData().Count; i++)
            {
                if(transaction.getData().ElementAt(i).getStatus() == null)
                {
                    transaction.getData().ElementAt(i).setStatus("Calculating");
                }

                Double? amount = transaction.getData().ElementAt(i).getAmount();
                Double? price = transaction.getData().ElementAt(i).getPrice();
                if (amount == null)
                {
                    transaction.getData().ElementAt(i).setAmount(0);
                }
                if(price == null)
                {
                    transaction.getData().ElementAt(i).setPrice(0.0);
                }
            }

            UtilProvider.initDataTransaction(transaction); UtilProvider.initDataTransaction(transaction);
            getView().callMethod("generateChart");
        }
    }
}
