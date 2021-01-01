using Cuciin_Dekstop.Model;
using Cuciin_Dekstop.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Velacro.Api;
using Velacro.Basic;
using Velacro.UIElements.Basic;
using Velacro.UIElements.TextBlock;
using Newtonsoft.Json;

namespace Cuciin_Dekstop.HistoryDetail
{
    class HistoryDetailController:MyController
    {
        private DataTransaction transaction;
        private LaundryType allTransaction;
        private int id;
        private int idTemp;
        public String poNumber;
        public String namaPembeli;
        public String alamatPembeli;

        public HistoryDetailController(IMyView _myView) : base(_myView) 
        {

        }

        public async void setData(int id, TextBox id_transaksi, TextBox alamat_pembeli, TextBox namaPembeli, TextBox totalHarga)
        {
            this.id = id;
            transaction = UtilProvider.getDataTransaction().getData()[id];
            this.id = transaction.getId();
            id_transaksi.Text = transaction.getPoNumber();
            alamat_pembeli.Text = transaction.getAddress();
            namaPembeli.Text = transaction.getCustomerId().ToString();
            totalHarga.Text = transaction.price.ToString();
        }

        public async void editData(TextBox id_transaksi, TextBox alamat_pembeli, TextBox namaPembeli, TextBox totalHarga)
        {
            ApiClient client = UtilProvider.getSession().getClient();
            var request = new ApiRequestBuilder();

            MessageBox.Show(id.ToString());

            String URL = "transaction/" + id;

            var req = request
                      .buildHttpRequest()
                      .setEndpoint(URL)
                      .addParameters("price", totalHarga.Text)
                      .addParameters("amount", transaction.getAmount().ToString())
                      .setRequestMethod(HttpMethod.Put);
            
            client.setAuthorizationToken(UtilProvider.getSession().getUser().getData().getToken());
            var response = await client.sendRequest(request.getApiRequestBundle());

            Console.WriteLine(response.getHttpResponseMessage().ToString());

            if (response.getHttpResponseMessage().ReasonPhrase.Equals("Created"))
            {
                MessageBox.Show("Edited");
                UserCredential userCredential = response.getParsedObject<UserCredential>();
            }
            else
            {
                MessageBox.Show(response.getHttpResponseMessage().ReasonPhrase);
            }
        }

        public async void setDataGrid(DataGrid transaction_value)
        {
            DataLaundryType laundryType;
            List<DataLaundryType> listLaundryType = new List<DataLaundryType>();

            MessageBox.Show(transaction.getLaundryType());

            laundryType = JsonConvert.DeserializeObject<DataLaundryType>(transaction.getLaundryType());
            listLaundryType.Add(laundryType);
            transaction_value.ItemsSource = listLaundryType;
        }
    }
}
