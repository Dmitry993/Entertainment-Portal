﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CSharpFunctionalExtensions;
using EP.DotsBoxes.Data.Context;
using EP.DotsBoxes.Data.Models;
using EP.DotsBoxes.Logic.Commands;
using EP.DotsBoxes.Logic.Models;
using FluentValidation;
using JetBrains.Annotations;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EP.DotsBoxes.Logic.Handlers
{
    public class AddPLayerHandler : IRequestHandler<AddPlayerCommand, Result<Player>>
    {
        private readonly GameBoardDbContext _context;
        private readonly IMapper _mapper;
        private readonly IValidator<AddPlayerCommand> _validator;
        private readonly ILogger<AddPLayerHandler> _logger;

        public AddPLayerHandler(GameBoardDbContext context, IMapper mapper, IValidator<AddPlayerCommand> validator, ILogger<AddPLayerHandler> logger)
        {
            _context = context;
            _mapper = mapper;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Result<Player>> Handle([NotNull]AddPlayerCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Adding a new player.");

            //validate
            var result = _validator.Validate(request);

            if (result == null)
            {
                _logger.LogError($"Result: {result.ToString()}!");
                return Result.Fail<Player>(result.Errors.First().ErrorMessage);
            }

            var model = new Player
            {
                Name = request.Name,             
            };

            var context = _context.GameBoard.Include(g => g.Players)
                .FirstOrDefault(b => b.Id == request.GameBoardId);

            context.Players.Add(_mapper.Map<PlayerDb>(model));

            try
            {
                _logger.LogInformation("Updating database with a new player.");
                await _context.SaveChangesAsync(cancellationToken);
                return Result.Ok<Player>(model);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex.Message, "Unsuccessful database update with a new player!");
                return Result.Fail<Player>(ex.Message);
            }
        }
    }
}
