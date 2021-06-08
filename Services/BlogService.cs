using Entities.Data_Transfer_Objects;
using EpitafioTattoo.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EpitafioTattoo.Services
{
    public class BlogService : IBlogService
    {

        #region Members

        private readonly HttpClient Client;

        #endregion

        #region  Constructor

        public BlogService(HttpClient client)
        {
            Client = client;
        }        

        #endregion


        public async Task<IEnumerable<BlogItemDto>> GetBlogItems()
        {
            var response = await Client.GetAsync($"api/blogs");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<BlogItemDto>>(content);
            }
            else
            {
                return null;
            }
        }     

        public async Task<BlogPostDto> GetBlogPost(Guid id)
        {
            var response = await Client.GetAsync($"api/blogs/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<BlogPostDto>(content);
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> InsertBlogPost(BlogPostToInsertDto post)
        {
            var response = await Client.PostAsJsonAsync($"api/blogs/", post);          

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateBlogPost(BlogPostToUpdateDto post)
        {
            var response = await Client.PutAsJsonAsync($"api/blogs/{post.Id}", post);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteBlogPost(Guid id)
        {
            var response = await Client.DeleteAsync($"api/blogs/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
