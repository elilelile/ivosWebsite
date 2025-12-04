using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ivosWebsite.Models
{
    public class Member
    {
        public string Name { get; set; }
        public List<string> Position {  get; set; }
        public string Photo {  get; set; }
    }
}


