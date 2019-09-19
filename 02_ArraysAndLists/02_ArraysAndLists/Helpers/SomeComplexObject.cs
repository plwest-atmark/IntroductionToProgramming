using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ArraysAndLists
{
    class SomeComplexObject
    {

        public string SomeComplexObjectProperty { get; set; }

        private SomeComplexObject() { }
        public SomeComplexObject(string prop)
        {
            this.SomeComplexObjectProperty = prop;
        }
    }
}
