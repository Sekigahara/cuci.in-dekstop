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
        private string FAILED_MESSAGE = "Wrong Email or Password";

        public LoginController(IMyView _myView) : base(_myView)
        {
            
        }

        public async void OnLogin(string username, string password)
        {
            ApiClient client = new ApiClient("https://api.cuci-in.me/api/auth/");
            var request = new ApiRequestBuilder();

            var req = request
                .buildHttpRequest()
                .addParameters("username", username)
                .addParameters("password", password)
                .setEndpoint("login")
                .setRequestMethod(HttpMethod.Post);
            
            var response = await client.sendRequest(request.getApiRequestBundle());

            if(response.getHttpResponseMessage().ReasonPhrase != null)
            {
                if (response.getHttpResponseMessage().ReasonPhrase.Equals("OK"))
                {
                    //assigning json object to User Model
                    User user = response.getParsedObject<User>();

                    //Set Endpoint
                    String ownerEndPoint = "owner/user_id/" + user.getData().getId().ToString();

                    //Request for owner id
                    var reqOwner = request
                          .buildHttpRequest()
                          .setEndpoint(ownerEndPoint)
                          .setRequestMethod(HttpMethod.Get);

                    client.setAuthorizationToken(user.getData().getToken());
                    var responseOnOwner = await client.sendRequest(request.getApiRequestBundle());

                    if (responseOnOwner.getHttpResponseMessage().ReasonPhrase.Equals("OK"))
                    {
                        //assigning owner object to owner model
                        Owner owner = responseOnOwner.getParsedObject<Owner>();

                        UtilProvider.initSession(user, owner, client);
                        getView().callMethod("redirectToDashboard");
                    }
                    else if (responseOnOwner.getHttpResponseMessage().ReasonPhrase.Equals("Not Found"))
                    {
                        MessageBox.Show("Your Account has Not Registered as Owner");
                    }
                    else
                    {
                        MessageBox.Show(responseOnOwner.getHttpResponseMessage().ReasonPhrase);
                    }

                }
                else if (response.getHttpResponseMessage().ReasonPhrase.Equals("Unauthorized"))
                {
                    MessageBox.Show(FAILED_MESSAGE);
                }
                else
                {
                    MessageBox.Show(response.getHttpResponseMessage().ReasonPhrase);
                }
            }
            else
            {
                MessageBox.Show("Check Your Internect Connection");
            }
            
        }
    }
}
