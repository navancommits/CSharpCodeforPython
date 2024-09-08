using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace csharpexample
{
    //Python syntax, indentation and : is important
    //class MyClass:
    //  def __init__(self, name, age): //constructor
    //      self.name = name   //self for this keyword
    //      self.age = age
    //similar to __init__ there is __str__ and this function is invoked when object must be returned as string
    //__init__  __str__ and other user-defined functions must start with def or in other words, must be defined within the class

    internal class MyClass
    {
        internal MyClass(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //while : is used for inheritance in c# , () is used in Python to enclose the Parent class
    //super() keyword in Python similar to base keyword in C#
    internal class newClass : MyClass
    {
        internal newClass(string name, int age) : base(name, age)
        {
            
        }
    }
}
