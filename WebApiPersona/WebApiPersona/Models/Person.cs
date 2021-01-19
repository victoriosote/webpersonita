using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiPersona.Models
{
    public enum SexType
    {
        Femenino =0,
        Masculino =1
    }
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "Su texto ente 5 y 80 choco", MinimumLength = 5)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }
        public SexType  Sex { get; set; }



    }
}