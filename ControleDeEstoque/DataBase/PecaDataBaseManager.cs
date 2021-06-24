using ControleDeEstoque.DataBase.Interface;
using ControleDeEstoque.Models;
using ControleDeEstoque.Models.Interface;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.DataBase
{
    public class PecaDataBaseManager : IPecaDataBaseManager
    {
        private const string DB_NAME = "PecaDataBase";
        public readonly string PECA_DATABASE_CONNECTION_STRING = "Filename=" + Path.Combine(Constants.PROGRAM_DATA_DATABASES_FOLDER_PATH, DB_NAME) + Constants.DB_EXTENSION + ";Password=1234";
        private static PecaDataBaseManager instance = null;

        private PecaDataBaseManager()
        {

        }

        public static PecaDataBaseManager GetInstance()
        {
            if (instance == null)
            {
                instance = new PecaDataBaseManager();
            }

            return instance;
        }

        public bool Insert(Peca item)
        {
            ObjectId Id = ObjectId.Empty;

            using (LiteDatabase db = new LiteDatabase(this.PECA_DATABASE_CONNECTION_STRING))
            {
                Id = db.GetCollection<Peca>().Insert(item);
            }

            if (Id != ObjectId.Empty)
            {
                return true;
            }

            return false;
        }

        public bool Update(Peca item)
        {
            bool flag = false;

            if (item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.PECA_DATABASE_CONNECTION_STRING))
                {
                    flag = db.GetCollection<Peca>().Update(item);
                }
            }

            return flag;
        }

        public bool Delete(Peca item)
        {
            bool flag = false;

            if (item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.PECA_DATABASE_CONNECTION_STRING))
                {
                    flag = db.GetCollection<Peca>().Delete(item.Id);
                }

            }

            return flag;
        }

        public Peca GetItemById(Peca item)
        {
            Peca peca = null;

            if (item != null)
            {
                using (LiteDatabase db = new LiteDatabase(this.PECA_DATABASE_CONNECTION_STRING))
                {
                    peca = db.GetCollection<Peca>().FindById(item.Id);
                }
            }

            return peca;
        }

        public List<Peca> GetAll()
        {
            IEnumerable<Peca> pecasCollection;

            using (LiteDatabase db = new LiteDatabase(this.PECA_DATABASE_CONNECTION_STRING))
            {
                pecasCollection = db.GetCollection<Peca>().FindAll();

                if (pecasCollection != null)
                {
                    if (pecasCollection.ToList().Count > 0)
                    {
                        return pecasCollection.ToList();
                    }
                }

                return null;
            }
        }        
    }
}
