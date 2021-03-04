using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApplicationForm.Models
{
	public class PlayerInfo
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Age { get; set; }
		public string Gender { get; set; }
		public bool? CurrentlyPlaying { get; set; }
	}
}