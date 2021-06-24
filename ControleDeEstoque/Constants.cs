using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    public static class Constants
    {
        public const string PROGRAM_DATA_FOLDER_NAME = "Controle De Estoque";
        public const string PROGRAM_DATA_DATABASES_FOLDER_NAME = "databases";
        public const string DB_EXTENSION = ".db";
        public static readonly string PROGRAM_DATA_DATABASES_FOLDER_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), PROGRAM_DATA_FOLDER_NAME, PROGRAM_DATA_DATABASES_FOLDER_NAME);
    }
}
