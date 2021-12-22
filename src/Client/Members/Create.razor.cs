using System;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Shared.Groups;
using Shared.Members;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client.Members
{
    public partial class Create
    {
        [Inject] public IGroupService GroupService { get; set; }
        
        private List<GroupDto.Index> groups = new();

        protected override async Task OnInitializedAsync()
        {
            await GetGroupsAsync();
        }

        private async Task CreateMemberAsync()
        {
            throw new NotImplementedException();
        }

        private async Task GetGroupsAsync()
        {
            GroupRequest.GetIndex request = new();
            var response = await GroupService.GetIndexAsync(request);
            groups = response.Groups;
        }
    }
}
