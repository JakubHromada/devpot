using System.ComponentModel.DataAnnotations;

namespace DevPot.Core.Models.ViewModels
{
    public class SearchFormModel
    {
        [Display(Name = "Search")]
        public string SearchTerm { get; set; }
    }
}