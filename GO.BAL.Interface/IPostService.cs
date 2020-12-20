using GO.Domain.Request.Posts;
using GO.Domain.Response.Posts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GO.BAL.Interface
{
    public interface IPostService
    {
        Task<IEnumerable<Posts>> Gets();

        Task<CreatePostResult> CreatePost(CreatePostRequest request);

        Task<UpdatePostResult> UpdatePost(UpdatePostRequest request);

        Task<DeletePostResult> DeletePost(DeletePostRequest request);
    }
}
