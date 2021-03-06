using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FootballApplicationForm.Models
{
	public class PlayerInfo
	{
		[Required(ErrorMessage = "Please insert your name.")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please insert your surname.")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Please insert your e-mail address..")]
		[RegularExpression(".+\\@.+\\..+",
				ErrorMessage = "Please insert appropriate e-mail address.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Please insert your phone number.")]
		public string Phone { get; set; }
		[Required(ErrorMessage = "Please insert your age.")]
		public string Age { get; set; }
		[Required(ErrorMessage = "Please specify your gender.")]
		public string Gender { get; set; }
		[Required(ErrorMessage = "Please specify your club affiliation.")]
		public bool? CurrentlyPlaying { get; set; }
	}
}