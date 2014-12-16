using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ClassInvariants
{
    public class Student
    {
        public string _name { get; set; }
        public int _age { get; set; }

        public Student(string name, int age)
        {
            Contract.Requires<ArgumentException>(!String.IsNullOrEmpty(name));
            Contract.Requires<ArgumentException>(age >= 0);
            _name = name;
            _age = age;
        }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrEmpty(_name));
            Contract.Invariant(_age >= 0);
        }

        
    }
}
