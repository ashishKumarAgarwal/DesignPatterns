using PassportFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentFacade
{
    class FeeValidation
    {
        Applicant _applicant;
        public FeeValidation(Applicant applicant)
        {

            _applicant = applicant;
        }

       public bool IsFeeReceived()
        {
            // Logic for Fee validation
            Console.WriteLine("Fee validation succesfull");
            return true;
        }
    }
}
