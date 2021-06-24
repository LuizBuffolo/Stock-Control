using ControleDeEstoque.Models.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Venda : IModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonField]
        public Cliente Client { get; set; }

        [BsonField]
        public List<Peca> Pecas { get; set; }
    }
}
