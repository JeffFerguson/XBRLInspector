using System.ComponentModel.DataAnnotations;

namespace XBRLInspector.Blazor.Models
{
    public class IndexModel
    {
        [Required]
        public string Url { get; set; }
        public string Status { get; set; }

        public IndexModel()
        {
            Status = string.Empty;
        }
    }
}
