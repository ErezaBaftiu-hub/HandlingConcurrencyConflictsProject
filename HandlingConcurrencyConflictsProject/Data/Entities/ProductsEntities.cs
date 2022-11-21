using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingConcurrencyConflictsProject.Data.Entities
{
    public class ProductsEntities
    {
        public int Id { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }
    }
}
