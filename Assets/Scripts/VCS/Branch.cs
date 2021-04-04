using Assets.Scripts.VCS.Changes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Scripts.VCS
{
    class Branch
    {
        public readonly int Id;

        public IReadOnlyList<Commit> commits => m_commits;
        protected List<Commit> m_commits;

        public Branch(int branchId)
        {
            Id = branchId;
        }

        public void AddCommit(Commit commit)
        {
            m_commits.Add(commit);
        }
    }
}
