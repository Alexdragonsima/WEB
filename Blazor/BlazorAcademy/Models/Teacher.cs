using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
	public class Teacher:Human
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column()]
		public int teacher_id { get; set; }
		//[Required]
		//public string last_name { get; set; }
		//[Required]
		//public string first_name { get; set; }
		//[Required]
		//public string middle_name { get; set; }
		//[Required]
		//public DateOnly birth_date { get; set; }
		[Required]
		public DateOnly work_since { get; set; }
	}
}
