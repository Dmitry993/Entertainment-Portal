﻿using EP.Balda.Logic.Models;
using MediatR;

namespace EP.Balda.Logic.Queries
{
    public class GetPlayer : IRequest<Player>
    {
        public long Id { get; set; }
    }
}