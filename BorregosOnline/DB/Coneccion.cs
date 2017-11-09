using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BorregosOnline.Models;

namespace BorregosOnline.DB
{
    public class Coneccion: DbContext
    {
       public Coneccion()  
            //:base("Server=tcp:borregosserver.database.windows.net,1433;Initial Catalog=BOnline;Persist Security Info=False;User ID={noadmin};Password={unodos34L};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {

        }
       
        public DbSet<BorregosOnline.Models.UserModels> UserModels { get; set; }
    }
}