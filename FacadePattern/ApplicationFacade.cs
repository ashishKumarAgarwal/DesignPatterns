using RecruitmentFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportFacade
{
    class ApplicationFacade
    {
        Applicant _applicant;
        FormValidation _formValidation;
        BackgroundValidation _backgroundValidation;
        FeeValidation _feeValidation;
        public ApplicationFacade(Applicant applicant)
        {
            _applicant = applicant;
            _formValidation = new FormValidation(applicant);
            _backgroundValidation = new BackgroundValidation(applicant);
            _feeValidation = new FeeValidation(applicant);
        }

        public bool IsValidationDone()
        {
            if (_formValidation.IsFormDataValid() && _backgroundValidation.IsApplictionEligible() && _feeValidation.IsFeeReceived())
                return true;
            return false;
        }
    }
}
