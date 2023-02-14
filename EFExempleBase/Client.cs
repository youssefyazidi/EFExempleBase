using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFExempleBase
{
    
 
    [Table("ClientTable")] 
     public class Client
    {
        [Column("CodeClient")]
        public int ClientID { get; set; }
        public string Nom { get; set; }
        public string adresse { get; set; }
    }
}
