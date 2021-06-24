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
    public class ClienteDataBaseManager : IClienteDataBaseManager
    {
        private const string DB_NAME = "ClienteDataBase";
        public readonly string CLIENTE_DATABASE_CONNECTION_STRING = "Filename=" + Path.Combine(Constants.PROGRAM_DATA_DATABASES_FOLDER_PATH, DB_NAME) + Constants.DB_EXTENSION + ";Password=1234";
        private static ClienteDataBaseManager instance = null;

        private ClienteDataBaseManager()
        {

        }

        public static ClienteDataBaseManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ClienteDataBaseManager();
            }

            return instance;
        }

        public bool Insert(Cliente item)
        {
            ObjectId Id = ObjectId.Empty;

            using (LiteDatabase db = new LiteDatabase(this.CLIENTE_DATABASE_CONNECTION_STRING))
            {
                Id = db.GetCollection<Cliente>().Insert(item);
            }

            if (Id != ObjectId.Empty)
            {
                return true;
            }

            return false;
        }

        public bool Update(Cliente item)
        {
            bool flag = false;

            if(item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.CLIENTE_DATABASE_CONNECTION_STRING))
                {
                    flag = db.GetCollection<Cliente>().Update(item);
                }
            }

            return flag;
        }

        public bool Delete(Cliente item)
        {
            bool flag = false;

            if(item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.CLIENTE_DATABASE_CONNECTION_STRING))
                {
                    flag = db.GetCollection<Cliente>().Delete(item.Id);
                }
                
            }

            return flag;
        }

        public Cliente GetItemById(Cliente item)
        {
            Cliente cliente = null;

            if (item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.CLIENTE_DATABASE_CONNECTION_STRING))
                {
                    cliente = db.GetCollection<Cliente>().FindById(item.Id);
                }
            }

            return cliente;
        }

        public List<Cliente> GetAll()
        {
            IEnumerable<Cliente> clientesCollection;

            using (LiteDatabase db = new LiteDatabase(this.CLIENTE_DATABASE_CONNECTION_STRING))
            {
                clientesCollection = db.GetCollection<Cliente>().FindAll();

                if (clientesCollection != null)
                {
                    if (clientesCollection.ToList().Count > 0)
                    {
                        return clientesCollection.ToList();
                    }
                }

                return null;
            }
        }
    }
}
