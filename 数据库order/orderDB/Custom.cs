using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderDB
{
    class Custom
    {
        public string name_custom;
        public Custom() { }
        public Custom(string c)
        {
            name_custom = c;
        }
        public string Name_cus
        {
            get
            {
                return this.name_custom;
            }
        }
        public override string ToString()
        {
            return "客户名:" + name_custom;
        }
        public override bool Equals(Object obj)
        {
            Custom cu = obj as Custom;
            return cu.name_custom == this.name_custom;
        }
        public override int GetHashCode()
        {
            return this.name_custom.GetHashCode();
        }
    }
}
