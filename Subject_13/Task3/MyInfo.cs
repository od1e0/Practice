using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class MyInfo
    {
        public delegate void NameChangedDelegate(string oldName, string newName);
        public event NameChangedDelegate NameChanged;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    string oldName = _name;
                    _name = value;
                    NameChanged?.Invoke(oldName, _name);
                }
            }
        }

        public MyInfo(string name)
        {
            _name = name;
        }
    }
}
