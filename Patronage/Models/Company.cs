using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patronage.Models
{
    public class Company
    {
        String companyName;

        public String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        int phoneCompany;

        public int PhoneCompany
        {
            get { return phoneCompany; }
            set { phoneCompany = value; }
        }

        int idCompany;
        public int IdCompany
        {
            get { return idCompany; }
            set { idCompany = value; }
        }
    }
}
