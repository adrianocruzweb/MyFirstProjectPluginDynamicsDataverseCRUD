using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectPlugin.ProjecISpace
{
    public class Conexao
    {
        private static CrmServiceClient crmServiceClientTreinamento;

        public CrmServiceClient ObterConexao()
        {
            var connectionStringCRM = @"AuthType=OAuth;
            Username = adrianocruzweb@adrianocruzwebhotmail.onmicrosoft.com;
            Password = MSD365CEAlice12Sarah@@@999; 
            SkipDiscovery = True;
            AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
            RedirectUri = app://58145891-0C36-4500-8554-080854F2AC97;
            Url = https://org5fe93c80.crm2.dynamics.com/main.aspx;";
            
            if(crmServiceClientTreinamento == null)
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                crmServiceClientTreinamento = new CrmServiceClient(connectionStringCRM);
            }
            return crmServiceClientTreinamento;
        }
    }
}
