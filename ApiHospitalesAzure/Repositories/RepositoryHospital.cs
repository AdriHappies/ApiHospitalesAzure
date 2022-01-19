using ApiHospitalesAzure.Data;
using ApiHospitalesAzure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHospitalesAzure.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales select datos;
            return consulta.ToList();
        }

        public Hospital FindHospital(int id)
        {
            return this.context.Hospitales.SingleOrDefault(z => z.IdHospital == id);
        }
    }
}
