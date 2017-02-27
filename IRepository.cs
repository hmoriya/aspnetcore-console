public interface IRepository<T> where T:IAggregateRoot
{
    T Find (object id);
    void Save(T item);
}