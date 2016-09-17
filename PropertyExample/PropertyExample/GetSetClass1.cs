using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class GetSetClass1
    {
        private int _id;
        private string _Name;
        private int _Passmark = 35;

        public int Id
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Id cannot be negative..");
                }
                else
                {
                    this._id = value;
                }

            }
            get
            {
                return this._id;
            }
        }
        public string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._Name = value;
            }

            get
            {
                //if (string.IsNullOrEmpty(this._Name) ? "no name" : this._Name) ;
                if (string.IsNullOrEmpty(_Name))
                {
                    return "No name";

                }
                return (_Name);
            }

        }
        public int PassMark
        {
            get
            {
                return _Passmark;
            }
        }
    }
}
