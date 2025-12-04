using ivosWebsite.Models;
using System.Linq.Expressions;

namespace ivosWebsite.Service
{
    public class MemberService
    {
        public List<Member> GetMembers()
        {
            return new List<Member>
            {
                new Member
                {
                    Name = "Zild Benitez",
                    Position = new List<string>{ "Vocalist", "Bassist", "Keyboardist" },
                    Photo = "/images/member/zild.jpg"
                },
                new Member
                {
                    Name = "Blaster Silonga",
                    Position = new List<string>{ "Vocalist", "Lead Guitarist" },
                    Photo = "/images/member/blaster.jpg"
                },
                new Member
                {
                    Name = "Badjao De Castro",
                    Position = new List<string>{ "Drummer" },
                    Photo = "/images/member/badjao.jpg"
                },
                new Member
                {
                    Name = "Unique Salonga",
                    Position = new List<string>{ "Vocalist", "Rhythm Guitarist" },
                    Photo = "/images/member/unique.jpg"
                },
            };
        }
    }
}
