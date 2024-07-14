using Atm.Api.Data.DTOs;
using FluentValidation;

namespace Atm.Api.Data.Validations
{
    public class UpdateAtmMachineDtoValidator:AbstractValidator<UpdateAtmMachineDto>
    {
        public UpdateAtmMachineDtoValidator()
        {
            //RuleFor(x => x.Name)
            //   .NotNull().NotEmpty().WithMessage("Name boş olamaz")
            //   .MaximumLength(100).WithMessage("Name 50 karakterden uzun olamaz");

            //RuleFor(x => x.Longitude)
            //    .InclusiveBetween(-180.0, 180.0).WithMessage("Longitude -180 ile 180 derece arasında olmalıdır");

            //RuleFor(x => x.Latitude)
            //    .InclusiveBetween(-90.0, 90.0).WithMessage("Latitude -90 ile 90 derece arasında olmalıdır");

            //RuleFor(x => x.Adress)
            //    .NotEmpty().WithMessage("Address boş olamaz")
            //    .MaximumLength(200).WithMessage("Address 200 karakterden uzun olamaz");

            ////RuleFor(x => x.DistrictId)
            ////    .GreaterThan(0).WithMessage("DistrictId 0'dan büyük olmalıdır");

            ////RuleFor(x => x.CityId)
            ////    .GreaterThan(0).WithMessage("CityId 0'dan büyük olmalıdır");

            //RuleFor(x => x.IsActive)
            //    .NotNull().WithMessage("IsActive boş olamaz");
            //RuleFor(x => x.IsActive)
            //    .Must(value => value == true || value == false).WithMessage("isActive True ya da false alabilir.");
            //RuleFor(x => x.Name)
            //  .NotNull().NotEmpty().WithMessage("Name boş olamaz")
            //  .MaximumLength(100).WithMessage("Name 50 karakterden uzun olamaz");

            //RuleFor(x => x.Longitude)
            //    .InclusiveBetween(-180.0, 180.0).WithMessage("Longitude -180 ile 180 derece arasında olmalıdır");

            //RuleFor(x => x.Latitude)
            //    .InclusiveBetween(-90.0, 90.0).WithMessage("Latitude -90 ile 90 derece arasında olmalıdır");

            //RuleFor(x => x.Adress)
            //    .NotEmpty().WithMessage("Address boş olamaz")
            //    .MaximumLength(200).WithMessage("Address 200 karakterden uzun olamaz");

            ////RuleFor(x => x.DistrictId)
            ////    .GreaterThan(0).WithMessage("DistrictId 0'dan büyük olmalıdır");

            ////RuleFor(x => x.CityId)
            ////    .GreaterThan(0).WithMessage("CityId 0'dan büyük olmalıdır");

            //RuleFor(x => x.IsActive)
            //    .NotNull().WithMessage("IsActive boş olamaz");
            //RuleFor(x => x.IsActive)
            //    .Must(value => value == true || value == false).WithMessage("isActive True ya da false alabilir.");

        }

    }
}
