using System;
using System.ComponentModel.DataAnnotations;

namespace Core_MVC_DataTables.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
