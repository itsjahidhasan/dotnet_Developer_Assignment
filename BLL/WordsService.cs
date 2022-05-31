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
    public class WordsService
    {
        public static List<WordsModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<wordsTable, WordsModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.WordsDataAccess();
            var data = mapper.Map<List<WordsModel>>(da.Get());
            return data;
        }
        public static void Add(WordsModel words)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<wordsTable, WordsModel>();
                c.CreateMap<WordsModel, wordsTable>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.WordsDataAccess();
            var upload = mapper.Map<WordsModel, wordsTable>(words);
            da.Add(upload);
        }
    }
}
