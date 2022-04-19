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
    public class NewLetterManager : INewLetterService
    {
        INewLetterDal _newletterDal;

        public NewLetterManager(INewLetterDal newletterDal)
        {
            _newletterDal = newletterDal;   
        }

        public void LetterAdd(NewsLetter newsLetter)
        {
           _newletterDal.Insert(newsLetter);

        }
    }
}
