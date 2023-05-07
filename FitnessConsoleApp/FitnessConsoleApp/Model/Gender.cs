using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConsoleApp.Model
{
    [Serializable]
    public class Gender
    {
        public string Name { get; }

        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentException("Name Cannot Be Empty Or 'Space'", nameof(Name));
            }

            this.Name = name;
        }
    }
}
