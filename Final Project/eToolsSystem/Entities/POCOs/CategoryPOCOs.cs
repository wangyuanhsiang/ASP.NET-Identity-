using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eToolsSystem.Entities.POCOs
{
    public class CategoryPOCOs
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int ConutItems { get; set; }

        public int AllItems { get; set; }

        [NotMapped]
        public string Description_Items
        {
            get { return Description + "  " + ConutItems; }
        }


    }
}
