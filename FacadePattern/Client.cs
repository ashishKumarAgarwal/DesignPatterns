using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportFacade
{
    class Client
    {
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant { Name = "Ashish" };

            ApplicationFacade applicationFacade = new ApplicationFacade(applicant);

            Console.WriteLine(applicant.Name +"'s application is " + (applicationFacade.IsValidationDone()? "excepted":"rejected"));
        }
    }
}
