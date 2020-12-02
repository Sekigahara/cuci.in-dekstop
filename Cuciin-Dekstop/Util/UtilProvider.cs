using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Cuciin_Dekstop.Model;
using Velacro.Api;

namespace Cuciin_Dekstop.Util
{
    class UtilProvider
    {
        private static Session session;
        private static Frame mainFrame;
        private static Transaction dataTransaction;


        public static void initDataTransaction(Transaction transaction)
        {
            dataTransaction = transaction;
        }

        public static void initSession(User user, Owner owner, ApiClient client)
        {
            session = new Session(user, owner, client);
        }

        public static void initMainFrame(Frame frame)
        {
            mainFrame = frame;
        }

        public static Session getSession()
        {
            return session;
        }

        public static Transaction getDataTransaction()
        {
            return dataTransaction;
        }

        public static void destroySession()
        {
            session = null;
            dataTransaction = null;
            mainFrame = null;
        }

        public static Frame getMainFrame()
        {
            return mainFrame;
        }
    }
}
