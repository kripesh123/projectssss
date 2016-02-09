using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Consultancy.Application.Models
{
    public class Consultancies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType (DataType.Text) ]
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double lng { get; set; }
        public double lat { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Status { get; set; }
    }
}