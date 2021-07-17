using startWithThreeLayers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startWithThreeLayers.DAL.Interfaces
{
    public interface IUsersDAO
    {
        void AddUser(User user);
        void RemoveUser(Guid id);
        void AddAward(Guid id, Award award);

        void ViewAll();
    }
}
