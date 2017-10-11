using System.Collections.Generic;

namespace FastInfoInput.Model
{
    class Data
    {
        private List<Member> _members = new List<Member>();
        private List<Communication> _communications = new List<Communication>();

        public Data()
        {
            
        }

        public void AddMember(Member m)
        {
            _members.Add(m);
        }

        public void AddCommunication(Communication c)
        {
            _communications.Add(c);
        }
    }
}
