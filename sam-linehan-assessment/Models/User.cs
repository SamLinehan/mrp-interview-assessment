using System;
namespace sam_linehan_assessment.Models
{
	public class User
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string PictureUrl { get; set; }
    }
}
