using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SentenceRepo : IRepository<sentenceTable, int>
    {
        SentenceMakingAPIEntities db;
        public SentenceRepo(SentenceMakingAPIEntities db)
        {
            this.db = db;
        }
        public void Add(sentenceTable e)
        {
            db.sentenceTables.Add(e);
            db.SaveChanges();
        }

        public List<sentenceTable> Get()
        {
            return db.sentenceTables.ToList();
        }
    }
}
