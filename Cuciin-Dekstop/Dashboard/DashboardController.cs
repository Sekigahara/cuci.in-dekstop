using Cuciin_Dekstop.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Velacro.Api;
using Velacro.Basic;

namespace Cuciin_Dekstop.Dashboard
{
    class DashboardController : MyController
    {
        public DashboardController(IMyView _myView) : base(_myView)
        {

        }

        public async void OnLogout()
        {
            ApiClient client = new ApiClient("http://127.0.0.1:8000/api/auth/");
            var request = new ApiRequestBuilder();

            var req= request
                      .buildHttpRequest()
                      .setEndpoint("logout")
                      .setRequestMethod(HttpMethod.Get);
            client.setAuthorizationToken(UtilProvider.getSession().getUser().getData().getToken());

            var response = await client.sendRequest(request.getApiRequestBundle());
        }
    }
}
