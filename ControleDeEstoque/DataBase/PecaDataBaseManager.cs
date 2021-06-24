using ControleDeEstoque.DataBase.Interface;
using ControleDeEstoque.Models;
using ControleDeEstoque.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DataBase
{
    public class PecaDataBaseManager : IPecaDataBaseManager
    {
        public bool Insert(Peca item)
        {
            return true;
        }

        public bool Update(Peca item)
        {
            return true;
        }

        public bool Delete(int Id)
        {
            return true;
        }

        public Peca GetItemById(int Id)
        {
            return null;
        }

        public List<Peca> GetAll()
        {
            return null;
        }        
    }
}
