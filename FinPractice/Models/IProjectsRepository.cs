using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinPractice.Models
{
    public interface IProjectsRepository
    {
        IQueryable<Project> Projects { get;}

        public void SaveProject(Project p);

        public void UpdateProject(Project p);

        public void RemoveProject(Project p);
    }
}
