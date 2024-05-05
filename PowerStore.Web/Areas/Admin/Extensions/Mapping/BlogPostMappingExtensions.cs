using PowerStore.Core.Mapper;
using PowerStore.Domain.Blogs;
using PowerStore.Services.Helpers;
using PowerStore.Web.Areas.Admin.Models.Blogs;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class BlogPostMappingExtensions
    {
        public static BlogPostModel ToModel(this BlogPost entity, IDateTimeHelper dateTimeHelper)
        {
            var blogpost = entity.MapTo<BlogPost, BlogPostModel>();
            blogpost.CreateDate = entity.CreatedOnUtc.ConvertToUserTime(dateTimeHelper);
            blogpost.StartDate = entity.StartDateUtc.ConvertToUserTime(dateTimeHelper);
            blogpost.EndDate = entity.EndDateUtc.ConvertToUserTime(dateTimeHelper);
            return blogpost;
        }

        public static BlogPost ToEntity(this BlogPostModel model, IDateTimeHelper dateTimeHelper)
        {
            var blogpost = model.MapTo<BlogPostModel, BlogPost>();
            blogpost.CreatedOnUtc = model.CreateDate.ConvertToUtcTime(dateTimeHelper);
            blogpost.StartDateUtc = model.StartDate.ConvertToUtcTime(dateTimeHelper);
            blogpost.EndDateUtc = model.EndDate.ConvertToUtcTime(dateTimeHelper);
            return blogpost;
        }

        public static BlogPost ToEntity(this BlogPostModel model, BlogPost destination, IDateTimeHelper dateTimeHelper)
        {
            var blogpost = model.MapTo(destination);
            blogpost.CreatedOnUtc = model.CreateDate.ConvertToUtcTime(dateTimeHelper);
            blogpost.StartDateUtc = model.StartDate.ConvertToUtcTime(dateTimeHelper);
            blogpost.EndDateUtc = model.EndDate.ConvertToUtcTime(dateTimeHelper);
            return blogpost;
        }
    }
}