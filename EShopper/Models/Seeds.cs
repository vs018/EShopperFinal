using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopper.Models
{
    public class Seeds
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Kg ")]
        public string Kg { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "NumberOfPacket")]
        public string NumberOfPacket { get; set; }

        [Display(Name = "VegetableId")]
        public int VegetableId { get; set; }
    }
}
