namespace AspFlex.RepositoryManager_
{
    public interface IRepositoryManager
    {
        void Insert(object model);
        void Update(object model);
        void Remove(object model);
    }
}