using FluentValidation;
using OrderFlow.Api.ViewModels;
using System;

namespace OrderFlow.Api.Validators
{
    public class InvoiceValidator : AbstractValidator<InvoiceRequestViewModel>
    {
        public InvoiceValidator()
        {
            //RuleFor<>
        }
    }
}
