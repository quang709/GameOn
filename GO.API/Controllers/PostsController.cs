using GO.BAL.Interface;
using GO.Domain.Request.Posts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GO.API.Controllers
{
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }
        [HttpGet]
        [Route("/api/post/gets")]
        public async Task<OkObjectResult> Gets()
        {
            return Ok(await postService.Gets());
        }

        [HttpPost]
        [Route("/api/post/create")]
        public async Task<OkObjectResult> Create(CreatePostRequest request)
        {
            return Ok(await postService.CreatePost(request));
        }

        [HttpPost]
        [Route("/api/post/update")]
        public async Task<OkObjectResult> Update(UpdatePostRequest request)
        {
            return Ok(await postService.UpdatePost(request));
        }
        [HttpDelete]
        [Route("/api/post/delete")]
        public async Task<OkObjectResult> Delete(DeletePostRequest request)
        {
            return Ok(await postService.DeletePost(request));
        }
    }
}
