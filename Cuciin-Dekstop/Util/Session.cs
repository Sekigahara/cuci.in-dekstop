using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velacro.Api;
using Cuciin_Dekstop.Model;

namespace Cuciin_Dekstop.Util
{
    class Session
    {
        private User user;
        private ApiClient client;
        
        public Session(User user, ApiClient client)
        {
            this.user = user;
            this.client = client;
        }

        public void setUser(User user)
        {
            this.user = user;
        }

        public User getUser()
        {
            return user;
        }

        public void setClient(ApiClient client)
        {
            this.client = client;
        }

        public ApiClient getClient()
        {
            return client;
        }

        public void setSession(String token)
        {
            client.setAuthorizationToken(token);
        }

        public void logout()
        {
            client.clearAuthorizationToken();
        }
    }
}
