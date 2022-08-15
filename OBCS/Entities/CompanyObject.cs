using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class CompanyObject
    {
        public string CompanyStatus { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyWebsite { get; set; }

        public string LegalName { get; set; }
        public string LegalAddress1 { get; set; }
        public string LegalAddress2 { get; set; }
        public string LegalCity { get; set; }
        public string LegalState { get; set; }
        public string LegalZIP { get; set; }
        public string LegalCountry { get; set; }

        public string FiscalYear { get; set; }
        public string TaxYear { get; set; }
        public string IncomeTaxFormUsed { get; set; }

        public string FEIN { get; set; }
        public string SSN { get; set; }

        public string PayrollContact { get; set; }
        public string PayrollTitle { get; set; }
        public string PayrollPhone { get; set; }
    }
}
