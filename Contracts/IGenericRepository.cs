namespace BankClientApi.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// GET all of T objects from the database
        /// </summary>
        /// <returns>A list of T objects</returns>
        Task<List<T>> GetAllAsync();
        /// <summary>
        /// GET a T object by id from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T object</returns>
        Task<T> GetAsync(int? id);
        /// <summary>
        /// Adds a T object to the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>The added T object</returns>
        Task<T> AddAsync(T entity);
        /// <summary>
        /// Update a T object in the database
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task UpdateAsync(T entity);  
        /// <summary>
        /// Deletes a T object from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(int id);
        /// <summary>
        /// Checks if T object exists in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if true, false if false</returns>
        Task<bool> Exists(int id);

    }
}
