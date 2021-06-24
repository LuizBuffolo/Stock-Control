using ControleDeEstoque.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Models
{
    public class Cliente : IModel
    {
        public int Id { get; set; }
    }
}