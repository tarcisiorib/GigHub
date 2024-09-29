using GigHub.Core;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    [Authorize]
    public class FolloweesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FolloweesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: Followers
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var followees = _unitOfWork.Followings
                .GetFollowees(userId);

            return View(followees);
        }
    }
}