using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        static SentenceMakingAPIEntities db;
        static DataAccess()
        {
            db = new SentenceMakingAPIEntities();
        }

        public static IRepository<wordsTable, int> WordsDataAccess()
        {
            return new WordsRepo(db);
        }
        public static IRepository<sentenceTable, int> SentenceDataAccess()
        {
            return new SentenceRepo(db);
        }
    }
}
