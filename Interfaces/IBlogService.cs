using Entities.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpitafioTattoo.Interfaces
{
    public interface IBlogService
    {
        Task <IEnumerable<BlogItemDto>> GetBlogItems();

        Task<BlogPostDto> GetBlogPost(Guid id);

        Task<bool> InsertBlogPost(BlogPostToInsertDto post);

        Task<bool> UpdateBlogPost(BlogPostToUpdateDto id);            

        Task<bool> DeleteBlogPost(Guid id);
    }
}