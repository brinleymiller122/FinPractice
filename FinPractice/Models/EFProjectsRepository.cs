using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinPractice.Models
{
    public class EFProjectsRepository : IProjectsRepository
    {
        private ProjectDbContext repo { get; set; }

        public EFProjectsRepository (ProjectDbContext temp)
        {
            repo = temp;
        }

        public IQueryable<Project> Projects => repo.Projects;


        public void SaveProject(Project p)
        {
            repo.Add(p);
            repo.SaveChanges();
        }

        public void UpdateProject(Project p)
        {
            repo.Update(p);
            repo.SaveChanges();
        }

        public void RemoveProject(Project p)
        {
            repo.Projects.Remove(p);
            repo.SaveChanges();
        }

    }
}
