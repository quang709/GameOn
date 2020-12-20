using GO.BAL.Interface;
using GO.DAL.Interface;
using GO.Domain.Request.Posts;
using GO.Domain.Response.Posts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GO.BAL
{
    public class PostService : IPostService
    {
        private readonly IPostRepository postRepository;
        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        public async Task<CreatePostResult> CreatePost(CreatePostRequest request)
        {
            return await postRepository.CreatePost(request);
        }

        public async Task<DeletePostResult> DeletePost(DeletePostRequest request)
        {
            return await postRepository.DeletePost(request);
        }

        public async Task<IEnumerable<Posts>> Gets()
        {
            return await postRepository.Gets();
        }

        public async Task<UpdatePostResult> UpdatePost(UpdatePostRequest request)
        {
            return await postRepository.UpdatePost(request);
        }
    }
}
