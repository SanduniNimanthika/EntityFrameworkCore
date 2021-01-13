using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entityfarmework
{
    [Table("Employee")]
    internal class Employee
    {
        public int Id { get; set; }
        [Column("first_name")]
        public string FristName { get; set; }
        [Column("last_name" )]
        public string LastName { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("home_address")]
        public string HomeAddress { get; set; }
        [Column("cell_phone")]
        public int Cellphone { get; set; }
    }
}
