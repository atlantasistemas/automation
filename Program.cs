using System.Reflection;
using Atl.Dal.Core;
using Atl.Dto;

namespace automation
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            
            new AutExample().Start();
        }

        private static void Init()
        {
            Session.Connection = new ConnectionDataBase
            {
                Database = "",
                Port = 0,
                Server = "",
                User = "",
                PasswordText = "",
            };
            Session.Version = Assembly.GetExecutingAssembly().GetName().Version;

            SessionLoader.LoadSession();
        }
    }
}