using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
	public class Student:Human
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int student_id { get; set; }
		//[Required]
		//public string last_name { get; set; }
		//[Required]
		//public string first_name { get; set; }
		//[Required]
		//public string middle_name { get; set; }
		//[Required]
		////[RangeAttribute(typeof(DateOnly), "1888-10-14", "2032-12-31")]
		//public DateTime birth_date { get; set; }
		[Required]
		public int group { get; set; }
	}
}
