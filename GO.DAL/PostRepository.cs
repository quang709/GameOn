using Dapper;
using GO.DAL.Interface;
using GO.Domain.Request.Posts;
using GO.Domain.Response.Posts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace GO.DAL
{
    public class PostRepository : BaseRepository, IPostRepository
    {
        public async Task<CreatePostResult> CreatePost(CreatePostRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Title", request.Title);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Image", request.Image);
                parameters.Add("@IdCategory", request.IdCategory);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreatePostResult>(cnn: connect,
                                                    sql: "sp_CreatePost",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeletePostResult> DeletePost(DeletePostRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IdPosts", request.IdPosts);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeletePostResult>(cnn: connect,
                                                    sql: "sp_DeletePost",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Posts>> Gets()
        {
            return await SqlMapper.QueryAsync<Posts>(cnn: connect,
                                                sql: "sp_GetPosts",
                                                commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdatePostResult> UpdatePost(UpdatePostRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IdPosts", request.IdPosts);
                parameters.Add("@Title", request.Title);
                parameters.Add("@Description", request.Description);
                parameters.Add("@Image", request.Image);
                parameters.Add("@IdCategory", request.IdCategory);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdatePostResult>(cnn: connect,
                                                    sql: "sp_UpdatePost",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;

            }
        }
    }
}
