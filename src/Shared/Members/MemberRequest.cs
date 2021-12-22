namespace Shared.Members
{
    public static class MemberRequest
    {
        public class GetIndex { }

        public class Create
        {
            public MemberDto.Mutate Member { get; set; }
        }
    }
}
