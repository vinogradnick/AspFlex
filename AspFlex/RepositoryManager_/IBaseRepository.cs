namespace AspFlex.RepositoryManager_
{
    public interface IBaseRepository
    {
        void Add(object model);
        void Remove(object model);
        void Update(object model);
    }
}