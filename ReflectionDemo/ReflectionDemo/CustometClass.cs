using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class CustometClass
    {
        public  int a , b ;
        public int id { get; set; }
        public string name { get; set; }
        public CustometClass()
        {
            id = 1;
            name = "Uday";
        }
        public CustometClass(int id ,string name)
        {
            this.id = id ;
            this.name = name ;
        }
        public void CustomerCLassOne()
        {

        }
        public void CustomerClassTwo( int id)
        {

        }
    }
}
