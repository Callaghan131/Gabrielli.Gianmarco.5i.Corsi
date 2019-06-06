using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gabrielli.gianmarco._5i.Corsi.Controllers
{
    [Route("api/[controller]")]
    public class DocentiController : Controller
    {
        CorsiContex db{get;}
        public DocentiController(){
        //   db = new CorsiContex();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Docente> Get()
        {
          /*  if(db.ambiti.Count() == 0){
                db.ambiti.Add(new Ambito{NomeAmbito = "Lettere" });
                db.SaveChanges();
            }*/
            return db.docenti.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Docente Get(int id)
        {
            return db.docenti.Find(id);
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody]Docente value)
        {
            if(value != null){
                db.docenti.Add(value);
                //db.utenti.Add(new Utente{Nome="Gianmarco", Cognome="Gabrielli"});
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Docente value)
        {
            if(value!=null){
                Docente d=db.docenti.Find(id);
                if(d!=null){
                    d.Nome=value.Nome;
                    d.Cognome=value.Cognome;
                    d.DatadiNascita=value.DatadiNascita;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Docente d = db.docenti.Find(id);
            if(d != null)
            {
                db.docenti.Remove(d);
                db.SaveChanges();
            }
        }
    }
}