using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP_Project
{
    public class Patients
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        public Patients(int id, string fullName)
        {
            ID = id;
            FullName = fullName;
        }
        public override bool Equals(object obj)
        {
            if (obj is Patients other)
            {
                return this.ID == other.ID;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        public override string ToString()
        {
            return FullName;
        }
    }


}
