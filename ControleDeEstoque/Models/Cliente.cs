using ControleDeEstoque.Models.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Cliente : IModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonField]
        public string Name { get; set; }

        [BsonField]
        public string PhoneNumber { get; set; }

        [BsonField]
        public string Adress { get; set; }

        [BsonField]
        public string Email { get; set; }
    }
}