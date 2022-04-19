using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
      //  void CommentDelete(Comment comment);
      //  void Commentpdate(Comment comment);
        List<Comment> GetAllCommenties(int id);
       // Comment GetCommentById(int id);
    }
}
