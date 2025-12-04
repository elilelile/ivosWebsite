using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ivosWebsite.Models
{
    public class Music
    {
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {  get; set; }
        public string Photo {  get; set; }
        public string Type { get; set; }
    }
}