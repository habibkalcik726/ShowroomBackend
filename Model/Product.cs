using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShowroomBackend.Model
{
 
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int price { get; set; }
        public int categoryId { get; set; }
        public string description { get; set; }
        public string productname { get; set; }

        public string imageUrl { get; set; }

        public Category category { get; set; }

        //        id:number;
        //productname:string;
        //price:number;
        //categoryId:number;
        //description:string;
        //imageUrl:string;
    }
}
