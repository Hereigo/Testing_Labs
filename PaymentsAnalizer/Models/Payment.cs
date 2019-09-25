using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentsAnalizer.Models
{
	public class Payment
	{
		[Key]
		public int ID { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yy HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime PayDate { get; set; }

		[Required]
		[RegularExpression("^-?[0-9]{1,}", ErrorMessage = "Numbers only!")]
		public int Amount { get; set; }

		[Required]
		[MinLength(3)]
		public string Description { get; set; }

		[ForeignKey("Category")]
		public int CatogoryId { get; set; }

		public Category Category { get; set; }
	}
}