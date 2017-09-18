using System;
using System.ComponentModel.DataAnnotations;
namespace Database.Models
{
	public class User
    {
        [Key]
        public int Id { get; set; }

        public string First { get; set; }

        public string Last { get; set; }

        public string Email { get; set; }

        public string PictureUrl { get; set; }
    }
}
