using PassportFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentFacade
{
    class FormValidation
    {
        Applicant _applicant;
        public FormValidation(Applicant applicant)
        {

            _applicant = applicant;
        }

       public bool IsFormDataValid()
        {
            // Logic for data validation
            Console.WriteLine("Form data validation succesfull");
            return true;
        }
    }
}
