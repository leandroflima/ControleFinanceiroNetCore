using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Models.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMongoCollection<Cliente> _collection;

        public ClienteService(IControleFinanceiroDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Cliente>(nameof(Cliente));
        }

        public List<Cliente> Get() =>
                    _collection.Find(Model => true).ToList();

        public Cliente Get(Guid id) =>
            _collection.Find(model => model.Id == id).FirstOrDefault();

        public Cliente Create(Cliente model)
        {
            _collection.InsertOne(model);
            return model;
        }

        public void Update(Guid id, Cliente model) =>
            _collection.ReplaceOne(Model => Model.Id == id, model);

        public void Remove(Cliente modelIn) =>
            _collection.DeleteOne(Model => Model.Id == modelIn.Id);

        public void Remove(Guid id) =>
            _collection.DeleteOne(Model => Model.Id == id);

    }
}
