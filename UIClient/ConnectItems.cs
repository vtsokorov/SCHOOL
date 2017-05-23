using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UIClient
{
   public static class ConnectItems
    {
        private static string libPath;
        private static string serverName;
        private static string dbPath;
        private static string[] usersName;
        private static string roleName;
        private static string charsetName;
        private static int portNumper;

        public static string library
         {
             get { return libPath; }
             set { libPath = value; }
         }

        public static string server
         {
             get { return serverName; }
             set { serverName = value; }
         }

        public static string database
         {
             get { return dbPath; }
             set { dbPath = value; }
         }

        public static string[] users
         {
             get { return usersName; }
             set { usersName = value; }
         }

        public static string role
         {
             get { return roleName; }
             set { roleName = value; }
         }

        public static string charset
         {
             get { return charsetName; }
             set { charsetName = value; }
         }

        public static int port
         {
             get { return portNumper; }
             set { portNumper = value; }
         }


    }
}
