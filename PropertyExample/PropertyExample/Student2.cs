using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Student2
    {
        private int _id;
        private string _Name;
        private int _PassMark=35;

        public int GetPassmark()
        {
            return _PassMark;
        }
        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = Name;
        }

        public string GetName()
        {
          //if (string.IsNullOrEmpty(this._Name) ? "no name" : this._Name) ;
            if (string.IsNullOrEmpty(_Name))
            {
                return "No name";

            }
            return (_Name);

        }
        public void SetId(int id)
        {
            if (id < 0)
            {
                throw new Exception("Id cannot be negative..");
            }
            else
            {
                this._id = id;
            }

        }
        public int GetId()
        {
            return (_id);
        }
    }
}
