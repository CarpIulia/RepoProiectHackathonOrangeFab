using Statistici.entities;
using Statistici.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistici.service
{
    class ServiceValidari
    {
        private RepoValidari repoValidari;

        public ServiceValidari(RepoValidari repoValidari)
        {
            this.repoValidari = repoValidari;
        }

        public List<Validare> get_all()
        {
            return repoValidari.get_all();
        }

        public int get_nr_validari(int day, int month, int year)
        {
            return repoValidari.get_nr_validari(day, month, year);
        }

        internal int get_nr_validari_mediu()
        {
            DateTime begin = DateTime.Parse("2020-12-15");
            DateTime end = DateTime.Parse("2021-02-15");
            int s = 0;
            while (begin < end)
            {
                int day = Int32.Parse(begin.Date.Day.ToString());
                int month = Int32.Parse(begin.Date.Month.ToString());
                int year = Int32.Parse(begin.Date.Year.ToString());
                s += get_nr_validari(day, month, year);
                begin = begin.AddDays(1);
            }
            return s / 63;
        }
    }
}
