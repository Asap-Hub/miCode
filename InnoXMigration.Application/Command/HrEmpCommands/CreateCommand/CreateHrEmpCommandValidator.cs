using FluentValidation;
using InnoXMigration.Application.Dtos.HrEmpDto;
using InnoXMigration.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoXMigration.Application.Command.HrEmpCommands.CreateCommand
{
    public class CreateHrEmpCommandValidator : AbstractValidator<TblHrEmpDto>
    {


        public CreateHrEmpCommandValidator()
        {

            var dto = new TblHrEmpDto();
            DateTime dateTime = DateTime.Now;
            var GetYear = DateTime.Now.Year;



            RuleFor(rf => rf.EmpStaffNo).NotEmpty().WithMessage("Please enter Staff Number, Invalid Entry");
            RuleFor(rf => rf.EmpTitleIdfk).GreaterThan(0);
            RuleFor(rf => rf.EmpFirstName).NotEmpty().WithMessage("Please enter employee's FirstName, Invalid FirstName");
            RuleFor(rf => rf.EmpDoB).NotNull().WithMessage("Your date of Birth is required");
            RuleFor(rf => rf.EmpLastName).NotEmpty().WithMessage("Please enter employee's LastName, Invalid LastName");
        }



    }
}
