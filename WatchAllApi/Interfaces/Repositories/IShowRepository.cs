﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WatchAllApi.Models;

namespace WatchAllApi.Interfaces.Repositories
{
    /// <summary>
    /// Manages shows in the database
    /// </summary>
    public interface IShowRepository: IRepositoryBase<ShowModel>
    {
        /// <summary>
        /// Returns top shows by rating
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="countOfEnt">Count of top</param>
        /// <returns></returns>
        Task<List<ShowModel>> GetFiltered(string name, int countOfEnt);
    }
}
