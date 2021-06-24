using ControleDeEstoque.Models.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Peca : IModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonField]
        public float BuyPrice { get; set; }

        [BsonField]
        public float SalePrice { get; set; }

        [BsonField]
        public float Profit { get; set; }
    }
}
