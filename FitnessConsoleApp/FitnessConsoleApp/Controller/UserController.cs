using FitnessConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FitnessConsoleApp.Controller
{
    public class UserController
    {
        public User User { get; }
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);
        }
        public void Serialize()
        {
            var fs = new FileStream("Users.json", FileMode.OpenOrCreate);
            JsonSerializer.Serialize(fs, User);
        }
        public void DeSerialize()
        {
            var fs = new FileStream("Users.json", FileMode.Open);
            string json = null;
            User user = JsonSerializer.Deserialize<User>(json);
        }
    }
}
