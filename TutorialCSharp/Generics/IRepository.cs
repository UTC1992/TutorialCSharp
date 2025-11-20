namespace TutorialCSharp.Generics;

public interface IRepository<T> where T : BaseEntity
{
    T GetById( int id);
    void Save(T entity);
}