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
        private Owner owner;
        
        public Session(User user , Owner owner, ApiClient client)
        {
            this.user = user;
            this.client = client;
            this.owner = owner;
        }

        public void setOwner(Owner owner)
        {
            this.owner = owner;
        }

        public Owner getOwner()
        {
            return owner;
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
