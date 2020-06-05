using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
	// Добавить класс Subject с полями Room, Title, List<Student> CourseName (название курса)
	public class Subject
	{
		[Key]
		public int Id { get; set; }

		public int Room { get; set; }

		public string Title { get; set; }

		public List<Student> Students { get; set; }

		public string CourseName { get; set; }
	}
}