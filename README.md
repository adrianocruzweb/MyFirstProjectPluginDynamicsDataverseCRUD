# Projeto MyFirstProjectPluginDynamicsDataverseCRUD

Esta é uma aplicação backend com um CRUD para interagir com entidades criadas em ambiente grafico do [MS PowerApps](https://make.powerapps.com/) que gera uma estrutura de dados no Dataverse e tem formulários no [MS Dynamics](https://dynamics.microsoft.com/pt-br/crm/) mas por meio de uma Conexão **CrmServiceClient** e um Protocolo de Segurança **Tls12** Posso gerar uma interação com o Código **.NET C#** com essas informações.

## 💻 Resumos das aulas

|Aula|
|----|
|- Fizemos um Fetch(Select) nos dados da table 'account' e buscamos o id (Type GUID key), o name, e o address1_telephone1|
|- Criamos novos registros(Insert) na mesma tabela 'account' |
|- Atualizamos(Update) mesmas informações a acima somente trocamos nos mesmo campos selecionados a partir de um id (Type GUID key) informado como segundo parametro da Entity|
|- Removemos o registro seguindo o mesmo id (Type GUID key) e informações do update |
|- Versionado|

## 🔗 Referências

- [Cursos plataforma Microsoft](https://learn.microsoft.com/pt-br/)
