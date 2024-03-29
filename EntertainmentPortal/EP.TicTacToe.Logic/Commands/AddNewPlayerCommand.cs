﻿using EP.TicTacToe.Logic.Models;
using CSharpFunctionalExtensions;
using MediatR;

namespace EP.TicTacToe.Logic.Commands
{
    public class AddNewPlayerCommand: IRequest<Result<Player>>
    {
        public string NickName { get; set; }
        public string Password { get; set; }
    }
}
