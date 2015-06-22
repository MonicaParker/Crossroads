using Crossroads.Data;
using Crossroads.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Crossroads.Controllers
{
    public class CharactersController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext(); //Consider using generic repository

        public CharactersController()
        {
            if (_db.Characters.Count() == 0)
            {
                var characters = new List<Character>{
                    new Character { Id = 1, Name = "Aser", Image = "http://orig09.deviantart.net/b2d1/f/2015/147/8/0/aser_pelt_test_by_azho-d8uyvpb.jpg", Description = "First", Published = false, AcceptingQuestions = false },
                    new Character { Id = 2, Name = "Eo", Image = "http://orig02.deviantart.net/951a/f/2015/056/9/6/eo_by_azho-d8jihze.jpg", Description = "Second", Published = false, AcceptingQuestions = false },
                    new Character { Id = 3, Name = "Sarkany", Image = "http://orig06.deviantart.net/c1ca/f/2015/093/3/2/sarkany_by_azho-d8oagly.jpg", Description = "Third", Published = false, AcceptingQuestions = false },
                    new Character { Id = 4, Name = "Raghan", Image = "http://orig00.deviantart.net/f31d/f/2015/141/c/f/raghan_by_azho-d8u99p2.jpg", Description = "Fourth", Published = false, AcceptingQuestions = false },
                    new Character { Id = 5, Name = "Sohl", Image = "http://orig01.deviantart.net/1a08/f/2015/099/8/1/sohlvatar_by_azho-d8p4jvb.jpg", Description = "Fifth", Published = true, AcceptingQuestions = true },
                    new Character { Id = 6, Name = "Taurce", Image = "http://orig12.deviantart.net/dc4b/f/2015/136/f/a/taurce_ref_by_azho-d8tn9o4.jpg", Description = "Third", Published = false, AcceptingQuestions = false }

                };
                characters.ForEach(c => _db.Characters.Add(c));
                _db.SaveChanges();
            }
        }


        // GET: api/Characters
        public IEnumerable<Character> Get()
        {
            return _db.Characters.ToList();
        }

        // GET: api/Characters/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Characters
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Characters/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Characters/5
        public void Delete(int id)
        {
        }

        public void SaveChar(int id)
        {

        }
    }
}
