using ControleDeEstoque.DataBase.Interface;
using ControleDeEstoque.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DataBase
{
    public class VendaDataBaseManager : IVendaDataBaseManager
    {
        private const string DB_NAME = "VendaDataBase";
        public readonly string VENDA_DATABASE_CONNECTION_STRING = "Filename=" + Path.Combine(Constants.PROGRAM_DATA_DATABASES_FOLDER_PATH, DB_NAME) + Constants.DB_EXTENSION + ";Password=1234";
        private static VendaDataBaseManager instance = null;

        private VendaDataBaseManager()
        {

        }

        public static VendaDataBaseManager GetInstance()
        {
            if (instance == null)
            {
                instance = new VendaDataBaseManager();
            }

            return instance;
        }

        public bool Insert(Venda item)
        {
            ObjectId Id = ObjectId.Empty;

            using (LiteDatabase db = new LiteDatabase(this.VENDA_DATABASE_CONNECTION_STRING))
            {
                Id = db.GetCollection<Venda>().Insert(item);
            }

            if (Id != ObjectId.Empty)
            {
                return true;
            }

            return false;
        }

        public bool Update(Venda item)
        {
            bool flag = false;

            if (item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.VENDA_DATABASE_CONNECTION_STRING))
                {
                    flag = db.GetCollection<Venda>().Update(item);
                }
            }

            return flag;
        }

        public bool Delete(Venda item)
        {
            bool flag = false;

            if (item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.VENDA_DATABASE_CONNECTION_STRING))
                {
                    flag = db.GetCollection<Venda>().Delete(item.Id);
                }

            }

            return flag;
        }

        public Venda GetItemById(Venda item)
        {
            Venda venda = null;

            if (item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.VENDA_DATABASE_CONNECTION_STRING))
                {
                    venda = db.GetCollection<Venda>().FindById(item.Id);
                }
            }

            return venda;
        }

        public List<Venda> GetAll()
        {
            IEnumerable<Venda> vendasCollection;

            using (LiteDatabase db = new LiteDatabase(this.VENDA_DATABASE_CONNECTION_STRING))
            {
                vendasCollection = db.GetCollection<Venda>().FindAll();

                if (vendasCollection != null)
                {
                    if (vendasCollection.ToList().Count > 0)
                    {
                        return vendasCollection.ToList();
                    }
                }

                return null;
            }
        }        
    }
}
