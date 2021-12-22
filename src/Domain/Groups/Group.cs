using Domain.Common;
using Domain.Members;
using Ardalis.GuardClauses;
using System.Collections.Generic;
using System;

namespace Domain.Groups
{
    public class Group : Entity
    {
        private readonly List<Member> _members = new();

        public string Name { get; set; }
        public IReadOnlyList<Member> Members => _members.AsReadOnly();

        private Group() { }

        public Group(string name)
        {
            Name = name;
        }

        public void AddMember(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
