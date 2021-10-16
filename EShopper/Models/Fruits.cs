using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopper.Models
{
    public class Fruits
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Type")]
        public string Type { get; set; }


        [Display(Name = "Kg")]
        public string Kg { get; set; }


        [Display(Name = "DeliveryAddress")]
        public string DeliveryAddress { get; set; }

    }
}
