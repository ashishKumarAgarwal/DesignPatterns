using PassportFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentFacade
{
    class BackgroundValidation
    {
        Applicant _applicant;
        public BackgroundValidation(Applicant applicant)
        {

            _applicant = applicant;
        }

        public bool IsApplictionEligible()
        {
            // Logic for data validation
            Console.WriteLine("Background validation succesfull");
            return true;
        }
    }
}
