using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using MyFirstProjectPlugin.ProjecISpace;
using MyFirstProjectPlugin.ProjecISpace.Model;

namespace MyFirstProjectPlugin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var crmService = new ConexaoModel().ObterConexao();
            //FetchXML(crmService);
            //Create(crmService);
            //UpdateEntity(crmService, Guid.Parse("88cea450-cb0c-ea11-a813-000d3a1b1223"));
            EntityDataverse entityDataverse = new EntityDataverse();
            entityDataverse.RemoveEntity(crmService, new Guid("88cea450-cb0c-ea11-a813-000d3a1b1223"));


            //88cea450-cb0c-ea11-a813-000d3a1b1223
        }
    }
}
