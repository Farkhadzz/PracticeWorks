using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.Model
{
    [Serializable]
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime BirthDay { get; }
        public double Weight { get; set; }
        public double Heigth { get; set; }

        public User(string name, Gender gender, DateTime birthDay, double weight, double heigth)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name Cannot Be Empty Or 'Space'", nameof(Name));
            }

            if (gender == null)
            {
                throw new ArgumentException("Gender Cannot Be Empty Or 'Space'", nameof(Gender));
            }

            if (birthDay < DateTime.Parse("01.01.1940") && birthDay > DateTime.Parse("01.01.2008"))
            {
                throw new ArgumentException("Age Must Be Over 14 And Under 83", nameof(BirthDay));
            }

            if (weight < 0 || weight == null)
            {
                throw new ArgumentException("Weight Entered Incorrectly", nameof(Weight));
            }

            if (heigth < 5 || heigth == null )
            {
                throw new ArgumentException("Heigth Entered Incorrectly", nameof(Heigth));
            }

            Name = name;
            Gender = gender;
            BirthDay = birthDay;
            Weight = weight;
            Heigth = heigth;
        }
    }
}
