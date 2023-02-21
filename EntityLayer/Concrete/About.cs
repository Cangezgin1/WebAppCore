using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLenght(10)]
        public string Title { get; set; }
        [StringLenght(100)]
        public string Description { get; set; }
        [StringLenght(2)]
        public string Age { get; set; }
        [StringLenght(25)]
        public string Mail { get; set; }
        [StringLenght(11)]
        public string Phone { get; set; }
        [StringLenght(100)]
        public string Address { get; set; }
        [StringLenght(250)]
        public string ImageUrl { get; set; }
    }
}
