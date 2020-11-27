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
using Cuciin_Dekstop.Util;

namespace Cuciin_Dekstop.Login
{
    class LoginController : MyController
    {
        private string SUCCESS_MESSAGE = "Login Success";
        private string FAILED_MESSAGE = "Wrong Email or Password";

        public LoginController(IMyView _myView) : base(_myView)
        {
            
        }

        public async void OnLogin(string username, string password)
        {
            //MessageBox.Show(password);

            ApiClient client = new ApiClient("http://127.0.0.1:8000/api/auth/");
            var request = new ApiRequestBuilder();

            var req = request
                .buildHttpRequest()
                .addParameters("username", username)
                .addParameters("password", password)
                .setEndpoint("login")
                .setRequestMethod(HttpMethod.Post);
            
            var response = await client.sendRequest(request.getApiRequestBundle());

            if (response.getHttpResponseMessage().ReasonPhrase.Equals("OK"))
            {
                getView().callMethod("setLoginStatus", SUCCESS_MESSAGE);

                User user = response.getParsedObject<User>();
                client.setAuthorizationToken(user.getData().getToken());

                UtilProvider.initSession(user, client);
                getView().callMethod("redirectToDashboard");
            }
            else if(response.getHttpResponseMessage().ReasonPhrase.Equals("Unauthorized"))
            {
                getView().callMethod("setLoginStatus", FAILED_MESSAGE);
            }
            else
            {
                getView().callMethod("setLoginStatus", response.getHttpResponseMessage().ReasonPhrase);
            }
        }
    }
}
