using ControleDeEstoque.DataBase.Interface;
using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DataBase
{
    public class VendaDataBaseManager : IVendaDataBaseManager
    {
        public bool Insert(Venda item)
        {
            return true;
        }

        public bool Update(Venda item)
        {
            return true;
        }

        public bool Delete(int Id)
        {
            return true;
        }

        public Venda GetItemById(int Id)
        {
            return null;
        }

        public List<Venda> GetAll()
        {
            return null;
        }        
    }
}
