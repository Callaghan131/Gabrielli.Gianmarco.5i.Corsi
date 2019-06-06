using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gabrielli.gianmarco._5i.Corsi.Controllers
{
    [Route("api/[controller]")]
    public class AmbitiController : Controller
    {
        CorsiContex db{get;}
        public AmbitiController(){
        //   db = new CorsiContex();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Ambito> Get()
        {
          /*  if(db.ambiti.Count() == 0){
                db.ambiti.Add(new Ambito{NomeAmbito = "Lettere" });
                db.SaveChanges();
            }*/
            return db.ambiti.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Ambito Get(int id)
        {
            return db.ambiti.Find(id);
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody]Ambito value)
        {
            if(value != null){
                db.ambiti.Add(value);
                //db.utenti.Add(new Utente{Nome="Gianmarco", Cognome="Gabrielli"});
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Ambito value)
        {
            if(value!=null){
                Ambito a=db.ambiti.Find(id);
                if(a!=null){
                    a.NomeAmbito=value.NomeAmbito;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Ambito a = db.ambiti.Find(id);
            if(a != null)
            {
                db.ambiti.Remove(a);
                db.SaveChanges();
            }
        }
    }
}