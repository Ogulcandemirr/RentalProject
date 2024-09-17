using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RentOdevProje.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount=context.Comments.Where(x=>x.CarId==id).Count();
            var values = commentManager.TGetListCommentWithCarAndUser(id);
            return View(values);
        }
    }
}
