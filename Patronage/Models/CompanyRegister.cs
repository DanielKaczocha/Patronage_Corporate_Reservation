using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patronage.Models
{
    public class CompanyRegister
    {
        List<Company> companyList;
        static CompanyRegister compreg = null;
        private CompanyRegister()
        {
            companyList = new List<Company>();
        }
        public static CompanyRegister getInstance()
        {
            if (compreg == null)
            {
                compreg = new CompanyRegister();
                return compreg;
            }
            else
            {
                return compreg;
            }
        }
        public void Add(Company company)
        {
            companyList.Add(company);
        }
        public String RemoveCompany(String registrationNumber)
        {
            for (int i = 0; i < companyList.Count; i++)
            {
                Company comp = companyList.ElementAt(i);
                if (comp.IdCompany.Equals(registrationNumber))
                {
                    companyList.RemoveAt(i);
                    return "Wpis o firmie usunieto.";
                }
            }
            return "Blad";
        }
        public List<Company> getCompanys()
        {
            return companyList;
        }
        public String AddCompany(Company comp)
        {
            for (int i = 0; i < companyList.Count; i++)
            {
                Company _comp = companyList.ElementAt(i);
                if (_comp.IdCompany.Equals(comp.IdCompany))
                {
                    companyList[i] = comp;
                    return "Dodano wpis o firmie.";
                }
            }
            return "Blad";
        }
    }
}
