using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentManager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public List<Comment> TGetDestinationById(int id)   //Destination Id sine ait yorumlar getirilir.
        {
            return _commentDAL.GetListByFilter(x=>x.DestinationID == id);
        }

        public void TAdd(Comment t)
        {
           _commentDAL.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            return _commentDAL.GetList();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDAL.GetListCommentWithDestination();
        }
    }
}
