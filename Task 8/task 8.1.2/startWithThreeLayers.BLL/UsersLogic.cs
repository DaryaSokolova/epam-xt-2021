using startWithThreeLayers.BLL.Interfaces;
using startWithThreeLayers.DAL.Interfaces;
using startWithThreeLayers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startWithThreeLayers.BLL
{
    public class UsersLogic : IUsersInterfaces
    {
        private IUsersDAO _usersDAO;

        public UsersLogic(IUsersDAO usersDAO)
        {
            _usersDAO = usersDAO;
        }

        public void AddUser(User user) => _usersDAO.AddUser(user);
        public void RemoveUser(Guid id) => _usersDAO.RemoveUser(id);
        public void RemoveUser(User user) => _usersDAO.RemoveUser(user.ID);
        public void AddAward(Guid id, Award award) => _usersDAO.AddAward(id, award);
        public void ViewAll() => _usersDAO.ViewAll();
    }
}
