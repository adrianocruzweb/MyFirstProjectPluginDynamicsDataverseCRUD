using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace MyFirstProjectPlugin.ProjecISpace
{
    public class ConexaoModel
    {
        private static CrmServiceClient crmServiceClientTreinamento;

        public CrmServiceClient ObterConexao()
        {
            DotNetEnv.Env.Load();

            string username = Environment.GetEnvironmentVariable("USERNAME");
            string password = Environment.GetEnvironmentVariable("PASSWORD");
            string url = Environment.GetEnvironmentVariable("URL");

            var connectionStringCRM = $@"AuthType=OAuth;
            Username = {username};
            Password = {password}; 
            SkipDiscovery = True;
            AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
            RedirectUri = app://58145891-0C36-4500-8554-080854F2AC97;
            Url = {url};";
            
            if(crmServiceClientTreinamento == null)
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                crmServiceClientTreinamento = new CrmServiceClient(connectionStringCRM);
            }
            return crmServiceClientTreinamento;
        }
    }
}
