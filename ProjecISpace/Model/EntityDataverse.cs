using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectPlugin.ProjecISpace.Model
{
    public class EntityDataverse
    {
        public void FetchXML(CrmServiceClient crmService)
        {
            string query = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                <entity name='account'>
                                    <attribute name='name'/>
                                    <attribute name='address1_telephone1'/>
                                    <attribute name='accountid'/>
                                    <order attribute='name' descending='false'/>
                                </entity>
                            </fetch>";

            EntityCollection colecao = crmService.RetrieveMultiple(new FetchExpression(query));
            foreach (var item in colecao.Entities)
            {
                Console.WriteLine(item["name"]);
                Console.WriteLine(item["accountid"]);
                if (item.Attributes.Contains("address1_telephone1"))
                {
                    Console.WriteLine(item["address1_telephone1"]);
                }
            }
            Console.ReadLine();
        }

        public void Create(CrmServiceClient crmServiceClient)
        {
            for (int i = 0; i < 2; i++)
            {
                Guid newRecord = new Guid();
                Entity newEntity = new Entity("account");
                newEntity.Attributes.Add("name", "Treinamento " + DateTime.Now.ToString());
                newEntity.Attributes.Add("address1_telephone1", "55679981894046");
                //newEntity.Attributes.Add("emailaddres", "adriano@gmail.com");

                newRecord = crmServiceClient.Create(newEntity);

                if (newRecord != Guid.Empty)
                {
                    Console.WriteLine("Id do Registro Criado" + newRecord);
                }
                else
                {
                    Console.WriteLine("O novo Registro não foi criado");
                }

            }
            Console.ReadLine();
        }

        public void UpdateEntity(CrmServiceClient crmService, Guid id)
        {
            try
            {
                Entity upEntity = new Entity("account", id);
                upEntity["name"] = "Atualização de registro com sucesso";
                upEntity["address1_telephone1"] = "423-555-0000";
                crmService.Update(upEntity);

                Console.WriteLine("Atualizado Com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            Console.ReadLine();
        }

        public void RemoveEntity(CrmServiceClient crmService, Guid guidAccount)
        {
            try
            {
                Entity removeEntity = crmService.Retrieve("account", guidAccount, new ColumnSet("name"));
                if (removeEntity.Attributes.Count > 0)
                {
                    crmService.Delete("account", guidAccount);
                    Console.WriteLine("Conta Excluida");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
