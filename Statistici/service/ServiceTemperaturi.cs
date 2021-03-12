using Statistici.entities;
using Statistici.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistici.service
{
    class ServiceTemperaturi
    {
        private RepoTemperaturi repoTemperaturi;

        public ServiceTemperaturi(RepoTemperaturi repoTemperaturi)
        {
            this.repoTemperaturi = repoTemperaturi;
        }

        public List<Temperatura> get_all()
        {
            return repoTemperaturi.get_all();
        }

        public double get_temp_min(int day, int month, int year)
        {
            List<Temperatura> temperaturi = repoTemperaturi.get_all();
            foreach(Temperatura t in temperaturi)
            {
                if (t.data.Day == day && t.data.Month == month && t.data.Year == year)
                    return (t.minim+t.maxim)/2;
            }
            return -1;
        }

        internal List<DateTime> get_data(int min, int max)
        {
            List<DateTime> dates = new List<DateTime>();
            int med = (min + max) / 2;
            List<Temperatura> temperaturi = repoTemperaturi.get_all();
            foreach (Temperatura t in temperaturi)
            {
                if((t.minim+t.maxim)/2 == med)
                        dates.Add(t.data);
            }
            return dates;
        }
    }
}
