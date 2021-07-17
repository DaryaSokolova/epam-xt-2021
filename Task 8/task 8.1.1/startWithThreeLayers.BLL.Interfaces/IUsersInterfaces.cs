using startWithThreeLayers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startWithThreeLayers.BLL.Interfaces
{
    public interface IUsersInterfaces
    {
        void AddUser(User user);

        void RemoveUser(Guid id);

        void RemoveUser(User user);

        void AddAward(Guid id, Award award);

        void ViewAll();
    }
}
