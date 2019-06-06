using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gabrielli.gianmarco._5i.Corsi.Controllers
{
    [Route("api/[controller]")]
    public class CorsoController : Controller
    {
        CorsiContex db{get;}
        public CorsoController(){
        //   db = new CorsiContex();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Corso> Get()
        {
          /*  if(db.ambiti.Count() == 0){
                db.ambiti.Add(new Ambito{NomeAmbito = "Lettere" });
                db.SaveChanges();
            }*/
            return db.corsi.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Corso Get(int id)
        {
            return db.corsi.Find(id);
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody]Ambito value)
        {
            if(value != null){
                db.corsi.Add(value);
                //db.utenti.Add(new Utente{Nome="Gianmarco", Cognome="Gabrielli"});
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Corso value)
        {
            if(value!=null){
                Corso c=db.corsi.Find(id);
                if(c!=null){
                    c.Descrizione=value.Descrizione;
                    c.GiornoSettimana=value.GiornoSettimana;
                    c.OraInizio=value.OraInizio;
                    c.OraFine=value.OraFine;
                    c.Prezzo=value.Prezzo;
                    c.NumeroMaxPartecipanti=value.NumeroMaxPartecipanti;
                    c.IdAmbito=value.IdAmbito;
                    c.IdDocente=value.IdDocente;
                    db.SaveChanges();
                }
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Corso c = db.corsi.Find(id);
            if(c != null)
            {
                db.corsi.Remove(c);
                db.SaveChanges();
            }
        }
    }
}