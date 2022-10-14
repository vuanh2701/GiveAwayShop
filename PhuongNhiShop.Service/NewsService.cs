using ReuseShop.Data.Infrastructure;
using ReuseShop.Data.Repositories;
using ReuseShop.Model.Models;

namespace ReuseShop.Service
{
    public interface INewsService
    {
        void Add(News news);
        void Update(News news);
        void Delete(int  id);
        IEnumerable<News> GetAll();
        IEnumerable<News> GetAllPaging(int page,int pageSize, out int totalRow);
        IEnumerable<News> GetAllByTagPaging(string tag,int page,int pageSize, out int totalRow);
        IEnumerable<News> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        News GetById(int id);
        void SaveChanges();
        
    }
    public class NewsService : INewsService
    {
        INewsRepository _newsRepository;
        IUnitOfWork _unitOfWork;

        public NewsService(INewsRepository newsRepository, IUnitOfWork unitOfWork)
        {
            this._newsRepository = newsRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(News news)
        {
           _newsRepository.Add(news);
        }

        

        public void Delete(int id)
        {
            _newsRepository.Delete(id);
        }

        public IEnumerable<News> GetAll()
        {
           return _newsRepository.GetAll(new string[] { "CategoryNews" });
        }

        public IEnumerable<News> GetAllByCategoryPaging(int categoryNewsId, int page, int pageSize, out int totalRow)
        {
            return _newsRepository.GetMultiPaging(x => x.Status && x.CategoryNewID == categoryNewsId, out totalRow, page, pageSize, new string[] { "CategoryNews" });
        }

        public IEnumerable<News> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<News> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public News GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(News news)
        {
            throw new NotImplementedException();
        }
    }
}
