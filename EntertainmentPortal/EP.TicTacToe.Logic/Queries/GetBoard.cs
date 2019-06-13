﻿using System;
using System.Collections.Generic;
using EP.TicTacToe.Logic.Models;
using MediatR;

namespace EP.TicTacToe.Logic.Queries
{
    public class GetBoard: IRequest<Board>
    {
    }
}
