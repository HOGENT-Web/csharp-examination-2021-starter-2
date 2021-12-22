using Microsoft.AspNetCore.Components;
using Shared.Members;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Members
{
    public partial class Index
    {
        [Inject] public IMemberService MemberService { get; set; }

        private List<MemberDto.Index> members;

        protected override async Task OnInitializedAsync()
        {
            await GetMembersAsync();
        }

        private async Task GetMembersAsync()
        {
            MemberRequest.GetIndex request = new();
            var response = await MemberService.GetIndexAsync(request);
            members = response.Members;
        }
    }
}
