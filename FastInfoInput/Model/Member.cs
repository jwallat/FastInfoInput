using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastInfoInput
{
    class Member
    {
        private String _name;
        private int _id;
        private String _type;

        public Member(String name, int id, String type)
        {
            _name = name;
            _id = id;
            _type = type;
        }

        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public string Type { get => _type; set => _type = value; }
    }
}
