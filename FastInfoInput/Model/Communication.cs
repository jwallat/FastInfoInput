using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastInfoInput.Model
{
    class Communication
    {
        private Member _fromMember;
        private Member _toMember;

        public Communication(Member from, Member to)
        {
            FromMember = from;
            ToMember = to;
        }

        internal Member FromMember { get => _fromMember; set => _fromMember = value; }
        internal Member ToMember { get => _toMember; set => _toMember = value; }
    }
}
