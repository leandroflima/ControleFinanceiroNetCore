using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Services
{
    public class VendaService : IVendaService
    {
        private readonly IMongoCollection<Venda> _collection;

        public VendaService(IControleFinanceiroDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Venda>(nameof(Venda));
        }

        public List<Venda> Get() =>
                    _collection.Find(Model => true).ToList();

        public Venda Get(Guid id) =>
            _collection.Find(model => model.Id == id).FirstOrDefault();

        public Venda Create(Venda model)
        {
            _collection.InsertOne(model);
            return model;
        }

        public void Update(Guid id, Venda model) =>
            _collection.ReplaceOne(Model => Model.Id == id, model);

        public void Remove(Venda modelIn) =>
            _collection.DeleteOne(Model => Model.Id == modelIn.Id);

        public void Remove(Guid id) =>
            _collection.DeleteOne(Model => Model.Id == id);

    }
}
