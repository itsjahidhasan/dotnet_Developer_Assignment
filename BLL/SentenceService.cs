using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using AutoMapper;

namespace BLL
{
    public class SentenceService
    {
        public static List<SentenceModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<sentenceTable, SentenceModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.SentenceDataAccess();
            var data = mapper.Map<List<SentenceModel>>(da.Get());
            return data;
        }
        public static void Add(SentenceModel sentence)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<sentenceTable, SentenceModel>();
                c.CreateMap<SentenceModel, sentenceTable>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.SentenceDataAccess();
            var upload = mapper.Map<SentenceModel, sentenceTable>(sentence);
            da.Add(upload);
        }
    }
}
