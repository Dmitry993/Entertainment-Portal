﻿using FluentValidation;
using EP.TicTacToe.Logic.Commands;
using EP.TicTacToe.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace EP.TicTacToe.Logic.Validators
{
    public class PlayerExistsValidator: AbstractValidator<AddNewPlayerCommand>
    {
        public PlayerExistsValidator(PlayerDbContext context)
        {
            RuleSet("PlayerExistingSet", () =>
            {
                RuleFor(x => x.NickName)
                .MustAsync(
                    async (o, s, token) =>
                    await context.Players.AnyAsync(c => c.Password == o.Password && c.NickName == s));
            });
        }
    }
}
