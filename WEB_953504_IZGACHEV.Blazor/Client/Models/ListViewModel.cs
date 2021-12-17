using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text.Json.Serialization;

namespace WEB_953504_IZGACHEV.Blazor.Client.Models
{
	public class ListViewModel
	{
		[JsonPropertyName("softwareId")]
		public int SoftwareId { get; set; }
		[JsonPropertyName("softwareName")]
		public string SoftwareName { get; set; }
	}
}
