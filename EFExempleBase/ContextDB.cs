using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExempleBase
{
    public class ContextDB : DbContext
    {
        public ContextDB()
            : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=ClientDB1;Integrated Security=true")
        {

        }

        //Les DBSet
        //Declarations virtuelle
        public virtual IDbSet<Client> Clients {get;set;}
    }
}
