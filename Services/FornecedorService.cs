using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Models.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IMongoCollection<Fornecedor> _collection;

        public FornecedorService(IControleFinanceiroDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Fornecedor>(nameof(Fornecedor));
        }

        public List<Fornecedor> Get() =>
                    _collection.Find(Model => true).ToList();

        public Fornecedor Get(Guid id) =>
            _collection.Find(model => model.Id == id).FirstOrDefault();

        public Fornecedor Create(Fornecedor model)
        {
            _collection.InsertOne(model);
            return model;
        }

        public void Update(Guid id, Fornecedor model) =>
            _collection.ReplaceOne(Model => Model.Id == id, model);

        public void Remove(Fornecedor modelIn) =>
            _collection.DeleteOne(Model => Model.Id == modelIn.Id);

        public void Remove(Guid id) =>
            _collection.DeleteOne(Model => Model.Id == id);

    }
}
