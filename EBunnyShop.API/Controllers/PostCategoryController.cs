using EBunnyShop.API.Infrastructure.Core;
using EBunnyShop.Service;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace EBunnyShop.API.Controllers
{
    [RoutePrefix("api/postcategory")]
    //[Authorize]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) :
            base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var list = _postCategoryService.GetAll().ToList();
            return CreateHttpResponse(request, () =>
            {
                var listCategory = _postCategoryService.GetAll().ToList();

                //var listPostCategoryVm = Mapper.Map<List<PostCategoryViewModel>>(listCategory);

                //HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPostCategoryVm);
                HttpResponseMessage response = null;
                return response;
            });
        }

        //[Route("add")]
        //public HttpResponseMessage Post(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {
        //        HttpResponseMessage response = null;
        //        if (ModelState.IsValid)
        //        {
        //            request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //        }
        //        else
        //        {
        //            PostCategory newPostCategory = new PostCategory();
        //            newPostCategory.UpdatePostCategory(postCategoryVm);

        //            var category = _postCategoryService.Add(newPostCategory);
        //            _postCategoryService.Save();

        //            response = request.CreateResponse(HttpStatusCode.Created, category);

        //        }
        //        return response;
        //    });
        //}

        //[Route("update")]
        //public HttpResponseMessage Put(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {
        //        HttpResponseMessage response = null;
        //        if (ModelState.IsValid)
        //        {
        //            request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //        }
        //        else
        //        {
        //            var postCategoryDb = _postCategoryService.GetById(postCategoryVm.ID);
        //            postCategoryDb.UpdatePostCategory(postCategoryVm);
        //            _postCategoryService.Update(postCategoryDb);
        //            _postCategoryService.Save();

        //            response = request.CreateResponse(HttpStatusCode.OK);

        //        }
        //        return response;
        //    });
        //}

        //public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {
        //        HttpResponseMessage response = null;
        //        if (ModelState.IsValid)
        //        {
        //            request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //        }
        //        else
        //        {
        //            _postCategoryService.Delete(id);
        //            _postCategoryService.Save();

        //            response = request.CreateResponse(HttpStatusCode.OK);

        //        }
        //        return response;
        //    });
        //}
    }
}