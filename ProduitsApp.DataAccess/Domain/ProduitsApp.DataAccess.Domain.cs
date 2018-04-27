using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitsApp.DataAccess.Repository
{
    class Produit
    {
        public string Id { get; set; }
        public string libelle { get; set; }
        public decimal PrixUnitaire { get; set; }
    }
}
