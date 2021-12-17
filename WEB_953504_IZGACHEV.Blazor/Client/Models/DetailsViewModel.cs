using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json.Serialization;

namespace WEB_953504_IZGACHEV.Blazor.Client.Models
{
	public class DetailsViewModel
	{
		[JsonPropertyName("softwareName")]
		public string SoftwareName { get; set; }
		[JsonPropertyName("description")]
		public string Description { get; set; }
		[JsonPropertyName("price")]
		public int Price { get; set; }
		[JsonPropertyName("image")]
		public string Image { get; set; }
	}
}
