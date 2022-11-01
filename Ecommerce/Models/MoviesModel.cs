using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Data;

namespace Ecommerce.Models
{
    public class MoviesModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Image { get; set; }
        public MovieCategory MovieCategory { get; set; }


        //Relationship

        public List<Actor_Movies> Actor_Movies { get; set; }
        
        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")] 
        public CinemaModel Cinema { get; set; }


        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId ")]
        public ProducersModel Producer { get; set; }





    }
}
