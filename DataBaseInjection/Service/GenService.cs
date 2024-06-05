using Models;
using Repository;

namespace Service
{
    public class GenService
    {
        private GenRepository _GenRepository;

        public GenService()
        {
            _GenRepository = new GenRepository();
        }
        public bool Insert(Generic generic)
        {
            return _GenRepository.Insert(generic);
        }
    }
}
