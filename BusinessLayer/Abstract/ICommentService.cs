using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        List<Comment> TGetDestinationById(int id);
        List<Comment> TGetListCommentWithDestination();
    }
}
