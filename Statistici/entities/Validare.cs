using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistici.entities
{
    class Validare
    {
        public enum TITLU_CALATORIE
        {
            BILET_HARTIE,
            ABONAMENT,
            PORTOFEL_ELECTRONIC,
            CALATORIE
        }

        public enum AUTOBUZ
        {
            BV_18_DKZ = 843,
            BV_18_EWH = 844,
            BV_18_DKY = 845,
            BV_18_DKX = 846,
            BV_18_EHX = 847,
            BV_18_EIC = 864,
            BV_18_EID = 865,
            BV_18_EIF = 867,
            BV_18_EIH = 869,
            BV_18_EIK = 871,
            BV_18_EIL = 874
        }

        public Validare(TITLU_CALATORIE tipTitlu,AUTOBUZ numarAutobuz,DateTime Data)
        {
            m_tipTitlu = tipTitlu;
            m_numarAutobuz = numarAutobuz;
            m_dataValidarii = Data;
        }

        private TITLU_CALATORIE m_tipTitlu { get; }
        private AUTOBUZ m_numarAutobuz { get; }
        private DateTime m_dataValidarii { get; }

    }
}
