using Newtonsoft.Json;
using startWithThreeLayers.DAL.Interfaces;
using startWithThreeLayers.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startWithThreeLayers.DAL.JsonDAL
{
    public class UsersJsonDAO : IUsersDAO
    {
        public const string JsonFilesPath = @"C:\Users\Darya Sokolova\source\repos\startWithThreeLayers\Files\";

        public void AddUser(User user)
        {
            string json = JsonConvert.SerializeObject(user);

            File.WriteAllText(GetFilePathById(user.ID), json);
        }

        public void RemoveUser(Guid id)
        {
            if (File.Exists(GetFilePathById(id)))
                File.Delete(GetFilePathById(id));

            else throw new FileNotFoundException(
                string.Format("File with name {0} at path {1} isn't created!", id + ".json", JsonFilesPath));

        }

        public void AddAward(Guid id, Award award)
        {
            if (!File.Exists(GetFilePathById(id)))
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!",
                        id, JsonFilesPath));

            User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(GetFilePathById(id)));

            user.AddAward(award);

            File.WriteAllText(GetFilePathById(user.ID), JsonConvert.SerializeObject(user));
        }

        public void ViewAll()
        {
            string[] idOfAllUsers = Directory.GetFiles(JsonFilesPath);
            Console.WriteLine();
            foreach (var item in idOfAllUsers)
            {
                User jsonStringUser = JsonConvert.DeserializeObject<User>(File.ReadAllText(item));
                Console.WriteLine(jsonStringUser);
            }
        }

        private string GetFilePathById(Guid id) => JsonFilesPath + id + ".json";
    }
}
