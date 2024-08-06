using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TakeAwayNight.Comment.DAL.Context;
using TakeAwayNight.Comment.DAL.Entities;
using TakeAwayNight.Comment.Dtos;

namespace TakeAwayNight.Comment.Services
{
    public class CommentService : ICommentService
    {
        private readonly CommentContext _commentContext;
        private readonly IMapper _mapper;

        public CommentService(CommentContext commentContext, IMapper mapper)
        {
            _commentContext = commentContext;
            _mapper = mapper;
        }

        public async Task CreateUserCommentAsync(CreateUserCommentDto createUserCommentDto)
        {
            var value = _mapper.Map<UserComment>(createUserCommentDto);
            await _commentContext.UserComments.AddAsync(value);
            await _commentContext.SaveChangesAsync();
        }

        public async Task DeleteUserCommentAsync(int id)
        {
            var values = await _commentContext.UserComments.FindAsync(id);
            _commentContext.UserComments.Remove(values);
            await _commentContext.SaveChangesAsync();
        }

        public async Task<List<ResultUserCommentDto>> GetAllUserCommentAsync()
        {
            var values = await _commentContext.UserComments.ToListAsync();
            return _mapper.Map<List<ResultUserCommentDto>>(values);
        }

        public Task<GetByIdUserCommentDto> GetByIdUserCommentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetByProductIdUserCommentDto>> GetByProductIdUserCommentAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserCommentAsync(UpdateUserCommentDto updateUserCommentDto)
        {
            throw new NotImplementedException();
        }
    }
}
