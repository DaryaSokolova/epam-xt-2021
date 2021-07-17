using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace startWithThreeLayers.Entities
{
    public class User
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public int Age { get; private set; }

        public List<Award> Awards => _awards;
        private List<Award> _awards;

        public User(Guid id, string name, DateTime dateOfBirth, int age)
        {
            ID = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = age;

            _awards = new List<Award>();
        }

        public void AddAward(Award award) => _awards?.Add(award);

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
