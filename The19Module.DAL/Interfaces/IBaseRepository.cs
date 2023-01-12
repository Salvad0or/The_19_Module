namespace The19Module.DAL.Interfaces
{
    /// <summary>
    /// Главный интерфейс для любого репозитория
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T>
    {
        T GetById(int id);

        bool Delete(int id);

    }
}
