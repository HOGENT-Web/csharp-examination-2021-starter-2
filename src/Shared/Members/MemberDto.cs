using FluentValidation;

namespace Shared.Members
{
    public static class MemberDto
    {
        public class Index
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string TwitterHandle { get; set; }
        }

        public class Mutate
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string TwitterHandle { get; set; }
            public int GroupId { get; set; }
        }
    }
}
