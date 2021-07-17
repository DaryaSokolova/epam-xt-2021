using startWithThreeLayers.BLL;
using startWithThreeLayers.BLL.Interfaces;
using startWithThreeLayers.DAL.Interfaces;
using startWithThreeLayers.DAL.JsonDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startWithThreeLayers.Dependencies
{
    public class DependencyResolver
    {
        #region SINGLETONE

        private static DependencyResolver _instance;
        public static DependencyResolver Instance => _instance ??= new DependencyResolver();

        #endregion

        public IUsersDAO UsersDAO => new UsersJsonDAO();

        public IUsersInterfaces UsersLogic => new UsersLogic(UsersDAO);

    }
}
