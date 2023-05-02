using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using VillaAPIDemo_Web.Models.Dto;

namespace VillaAPIDemo_Web.Models.VM
{
	public class VillaNumberDeleteVM
	{
		public VillaNumberDeleteVM()
		{
			VillaNumber = new VillaNumberDTO();
		}
		public VillaNumberDTO VillaNumber { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> VillaList { get; set; }
	}
}
