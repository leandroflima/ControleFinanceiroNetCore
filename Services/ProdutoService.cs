using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMongoCollection<Produto> _collection;

        public ProdutoService(IControleFinanceiroDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Produto>(nameof(Produto));
        }

        public List<Produto> Get() =>
                    _collection.Find(Model => true).ToList();

        public Produto Get(Guid id) =>
            _collection.Find(model => model.Id == id).FirstOrDefault();

        public Produto Create(Produto model)
        {
            _collection.InsertOne(model);
            return model;
        }

        public void Update(Guid id, Produto model) =>
            _collection.ReplaceOne(Model => Model.Id == id, model);

        public void Remove(Produto modelIn) =>
            _collection.DeleteOne(Model => Model.Id == modelIn.Id);

        public void Remove(Guid id) =>
            _collection.DeleteOne(Model => Model.Id == id);

    }
}
