﻿using ControleFinanceiroNetCore.Models;
using ControleFinanceiroNetCore.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ControleFinanceiroNetCore.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IMongoCollection<Pedido> _collection;

        public PedidoService(IControleFinanceiroDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Pedido>(nameof(Pedido));
        }

        public List<Pedido> Get() =>
                    _collection.Find(Model => true).ToList();

        public Pedido Get(Guid id) =>
            _collection.Find(model => model.Id == id).FirstOrDefault();

        public Pedido Create(Pedido model)
        {
            _collection.InsertOne(model);
            return model;
        }

        public void Update(Guid id, Pedido model) =>
            _collection.ReplaceOne(Model => Model.Id == id, model);

        public void Remove(Pedido modelIn) =>
            _collection.DeleteOne(Model => Model.Id == modelIn.Id);

        public void Remove(Guid id) =>
            _collection.DeleteOne(Model => Model.Id == id);

    }
}
