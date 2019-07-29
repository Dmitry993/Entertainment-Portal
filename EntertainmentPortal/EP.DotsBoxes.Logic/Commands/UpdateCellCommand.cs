using CSharpFunctionalExtensions;
using EP.DotsBoxes.Logic.Models;
using MediatR;
using System.Collections.Generic;

namespace EP.DotsBoxes.Logic.Commands
{
    public class UpdateCellCommand : IRequest<Result<IEnumerable<Cell>>>
    {
        public int GameBoardId { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public bool Top { get; set; }

        public bool Bottom { get; set; }

        public bool Left { get; set; }

        public bool Right { get; set; }

        public string Name { get; set; }
    }
}