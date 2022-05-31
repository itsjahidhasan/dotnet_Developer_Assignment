using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WordsRepo : IRepository<wordsTable, int>
    {
        SentenceMakingAPIEntities db;
        public WordsRepo(SentenceMakingAPIEntities db)
        {
            this.db = db;
        }
        public void Add(wordsTable e)
        {
            db.wordsTables.Add(e);
            db.SaveChanges();
        }

        public List<wordsTable> Get()
        {
            return db.wordsTables.ToList();
        }
    }
}
