using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class Corso
{
    public int CorsoId{get;set;}
    public string Descrizione {get;set;}
    public string GiornoSettimana {get;set;}
    public string OraInizio{get;set;}
    public string OraFine{get;set;}
    public float Prezzo {get;set;}
    public int NumeroMaxPartecipanti{get;set;}
    public int IdDocente{get;}
    public int IdAmbito{get;}

}
public class CorsiContex : DbContext
    {
        public DbSet<Corso> corsi{get;set;}
        public DbSet<Docente> docenti{get;set;}
        public DbSet<Ambito> ambiti{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Corsi.db");
        }
    }
