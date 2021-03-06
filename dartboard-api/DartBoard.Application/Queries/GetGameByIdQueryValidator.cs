﻿using FluentValidation;
using System;

namespace DartBoard.Application.Queries
{
    public class GetGameByIdQueryValidator : AbstractValidator<GetGameByIdQuery>
    {
        public GetGameByIdQueryValidator()
        {
            RuleFor(a => a.Id).NotEmpty();
        }
    }
}