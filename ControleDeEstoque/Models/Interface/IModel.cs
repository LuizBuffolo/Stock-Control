using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models.Interface
{
    public interface IModel
    {
        ObjectId Id { get; set; }
    }
}

