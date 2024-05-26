using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _context;

        public PostRepository(SocialMediaContext context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<Post>> GetPosts() 
        {            
            var result = await _context.Posts.ToListAsync();            
            return (IEnumerable<Post>)result;
        }
        public async Task<Post> GetPosts(int id)
        {
            var result = await _context.Posts.FirstOrDefaultAsync(x => x.PostId == id);            
            return result;
        }
        public async Task InsertPost(Post post) 
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }
    }
}
