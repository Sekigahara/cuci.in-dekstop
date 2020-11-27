using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Velacro.Api;
using Velacro.Basic;
using Cuciin_Dekstop.Model;

namespace Cuciin_Dekstop.Login
{
    class LoginController : MyController
    {
        public LoginController(IMyView _myView) : base(_myView)
        {
            
        }

        public async void OnLogin(string username, string password)
        {
            //MessageBox.Show(password);

            var client = new ApiClient("http://127.0.0.1:8000/api/auth/");
            var request = new ApiRequestBuilder();

            string token = "";
            var req = request
                .buildHttpRequest()
                .addParameters("username", username)
                .addParameters("password", password)
                .setEndpoint("login")
                .setRequestMethod(HttpMethod.Post);
            client.setOnSuccessRequest(setViewLoginStatus);
            client.setOnFailedRequest(viewFailStatus);
            
            var response = await client.sendRequest(request.getApiRequestBundle());
            User user = response.getParsedObject<User>();

            client.setAuthorizationToken(user.getData().getToken());
        }

        private void setViewLoginStatus(HttpResponseBundle response)
        {
            string SUCCESS_MESSAGE = "Login Success";

            if (response.getHttpResponseMessage().Content != null)
            {
                getView().callMethod("setLoginStatus", SUCCESS_MESSAGE);
            }
        }

        private void viewFailStatus(HttpResponseBundle response)
        {
            string FAILED_MESSAGE = "Wrong Email or Password";

            if (response.getHttpResponseMessage().ReasonPhrase == "Unauthorized")
                getView().callMethod("setLoginStatus", FAILED_MESSAGE);
            else
                getView().callMethod("setLoginStatus", response.getHttpResponseMessage().ReasonPhrase);
        }
    }
}
