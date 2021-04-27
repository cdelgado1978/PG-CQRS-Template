using FluentValidation;

namespace CQRSTemplate.Commands
{
    public class TemplateCommandValidator : AbstractValidator<TemplateCommand>
    {
        public TemplateCommandValidator()
        {
            //RuleFor(a => a.Nombre)
            //    .MaximumLength(25)
            //    .NotEmpty()
            //    .WithMessage("Nombre requerido")
        }
    }
}