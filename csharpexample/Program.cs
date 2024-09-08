using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;

namespace csharpexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var my-var="" //this var name is illegal in Python too
            var x = 10;//just x=10 in Python
            var X = 20;//variables are case-sensitive just like c#
            var dummy = 0;
           
            Console.WriteLine("Case-sensitive vars similar to Python - x: " +  x + " X: " + X);
            //Console.Write(x);multiline comment in c#, """ in Python
            /*
             * multi-line comment
             */

            Console.WriteLine("Usual division in Python/C#: " + 10 / 2);
            //Console.WriteLine(X//x)//  // used for floor or int division in Python
            x = X =dummy= 100;//this is possible in Python too
            var y = "this is multiline text\n" +
                "for my variable" +
                "this is good for testing" +
                "for now";

            var (k,j,m)=(20,40,"dfsdf");//this is possible in Python but var is not needed understandably
            (k, j) = (j, k);

            Console.WriteLine("THis is multiline var: "+ y);//multiline var //Python uses """
            //Console.WriteLine("Python accommodates the following line using print(x, y) since it can't concatenate string with int or other datatype with +");
            Console.WriteLine("Variable x:" + x);//Python accommodates this using print(x,y) since it can't concatenate string with int or other datatype with +
            //Console.WriteLine("Testing Python bool() cast with C# Convert.ToBoolean: "+ (Convert.ToBoolean("abc")));//throws error here but bool("abc") will return true in Python

            //Console.WriteLine("Variable x:" *3);//this throws error in c# but Python will accommodate and print the string 3 times

            Console.WriteLine("Convert to string:" + Convert.ToString(x));//Python has str()

            var n = " navan";//both single and double quotes accommodated in Python

            Console.WriteLine("Get second element using index from a string similar to Python:"+ n[1]);
            Console.WriteLine("Trimmed name:"+ n.Trim());//Python has strip(),lstrip(),rstrip()
            Console.WriteLine(n.Replace('a', 'b'));//Python has replace()
            Console.WriteLine("String length: " + n.Length);//Python has len(n)
            if (n.Contains("na")) Console.WriteLine("Contains Substring: " + n.Contains("na"));//single quote used for single char in c# but not the case with python

            Console.WriteLine("First string char: " + n[0]);//index accessed same way in Python
            Console.WriteLine("Sub string: "+ n.Substring(0, 4));//slice or [:] is used instead in Python

            Console.WriteLine("Uppercase: "+ n.ToUpper());//upper() and lower() in Python

            Console.WriteLine("Split" + n.Split('v')[0]);//split('v') in Python

            Console.WriteLine("Concat and output as one string: ",x.ToString(), n);//concatenate and output multiple strings in one-go like print in  Python
            Console.WriteLine("Concat and output as one string: " +  x +  n);//this is possible in  Python but note that x is int and auto-concatenates with other strings, this is not possible in Python since it needs an explicit conv to string

            //Console.WriteLine("Negative Sub string: " + n.Substring(-2,-3));//negative index right binding not available in c#
            Console.WriteLine($"This is extrapoldated string - {n}");//f or F instead of dollar in python and n could be integer or any data type in python unlike string concatenation 
            Console.WriteLine($"Calculated value - {x*10}");//Python can also invoke calculations or functions
            Console.WriteLine($"Function call in string interpolation - {returnInt()}");//Python can also invoke calculations or functions
            Console.WriteLine($"Convert to decimal - {Convert.ToDecimal(x)}");//Python can also invoke calculations or functions

            Console.WriteLine("Escape char similar to Python:" + "My \'name\' is... \n \"navan\"");//same in Python

            foreach(var l in n) Console.WriteLine("foreach: " + l);//for used instead of foreach in Python

            Console.WriteLine("for loop: ");
            for (var i = 0; i < 10; i++) 
                if (i % 2 == 0) { Console.WriteLine(" even " + i); } else { Console.WriteLine(" odd " + i); }//indentation is part of syntax in Python but not so in c#

            //no equivalent for Python - for in range

            Console.WriteLine("list ");
            List<string> languages = new List<string>() { "Python", "Java", "C" };

            var age = 20;
            Console.WriteLine("if elif and else in Python: ");
            if (age < 18) Console.WriteLine("teen");
            else if (age > 18 && age <30) Console.WriteLine("youth");
            else if (age > 30 && age < 60) Console.WriteLine("man"); //elif
            else if (age > 60) Console.WriteLine("gentleman");
            else Console.WriteLine("baby");

            //this is possible in Python: print("hi") if a==b else print("bye")
            //var a = 10;
            //var b = 20;

            //Console.WriteLine("hi") if (a == b) else Console.WriteLine("bye");//this is not possible in C#

            Console.WriteLine("type() in Python instead of GetType(): " + languages.GetType().Name);

            languages.Insert(2, "JavaScript");// insert "JavaScript" at index 2
            languages.Add("xxx");
            for(int i=0;i<=languages.Count-1;i++) { Console.WriteLine(languages[i]); }

            languages.Sort();//same sort() in list - python

            languages.RemoveAt(1);//use of del in Python and pop for last item removal

            languages[0] = "C#";//same as Python

            //languages.Clear();//same as clear() in Python

            if (languages.Contains("Python")) Console.WriteLine("Python present");//in operator in Python vs contains

            //|| = or, && = and operator in Python

            Console.WriteLine("Function invocation (MyFunction)...");

            Console.WriteLine("if else ");

            if (MyFunction()) Console.WriteLine("Hi"); else Console.WriteLine("bye");

            bool loop = true;

            while (loop) {
                Console.WriteLine("while loop ");//Python has else for while loop, C# doesn't support the same
                loop = false;
            }
            
            var list2 = languages;//byref same as Python

            var list3 = new List<string>(languages);//byval copy, python has copy() function / list(languages) or slice[:] instead

            languages[0] = "blah blah";

            var newlist = new List<string>
            {
                "dfdfd",
                "kkkk",
                "kkkk"
            };

            //(string var1, string var2,string var3) = newlist;//concept of unpacking present in Python for list - c# doesn't support list deconstruct

            newlist.AddRange(languages);//+ or extend can be used in Python to add two or more list elements into one list

            int ind=newlist.IndexOf("kkkk");//Python has index() instead, unsure what is the equivalent for LastIndexOf in Python

            Console.WriteLine("Accessing last index using count but not negatives: " + languages[languages.Count- 1]);//no -1 or minuses as in Python to access elements from last

            var slice = languages.GetRange(1, 2);//slice or : used in case of Python

            //Python also has tuples similar to c# and they are unchangeable after creation although elements are accessible similar to list and you can convert tuple to list and modify elements and convert back to tuple
            var tup = new Tuple<int,int,string>(1, 2, "navan");
            var (tvar1,tvar2,tvar3) = tup;
            Console.WriteLine("tuple deconstructed:" + tvar1 + " " + tvar2 + " " + tvar3);//deconstruct as equivalent to unpacking in Python
            
            //most importantly asterisk * is not present for deconstruct in c# but Python supports *

            //tup.Item1 = "dfsdf";tuple is readonly similar to Python
            //var mytuplist = new List<string>(tup);//this is not possible in c# but Python will accommodate it with just a list() method!

            //also note that if there is tuple1 and you want to duplicate the elements into a new tuple, you can use *2 similar to string duplication in Python            
            
            HashSet<string> names = new HashSet<string>
            {
                "nanana",
                "boooobbooo",
                "herere",
                "dfsdf"
            };//equivalent for Set in Python

            HashSet<string> names2 = new HashSet<string>
            {
                "nanana2",
                "boooobbooo2",
                "herere2",
                "dfsdf2"
            };//equivalent for Set in Python

            names2.UnionWith(names);//union or | in Python
            names2.IntersectWith(names);//intersection() or & in Python
            
            foreach (var name in names)
            {
                Console.WriteLine("Hashset" + name);
            }

            //names[0]="safsdfs" //cannot apply indexing to hashset similar to set in Python
            names.Add("dfsdfs");//can add and remove items in Set
            names.Add("dfsdfs");//cannot have dupes in Set similar to Python
            names.Remove("boooobbooo");//hashset can remove an item as in Python

            //discard vs remove in Python: former doesnt throw error is element not exists but latter does throw error

            if (names.Contains("nanana")) Console.WriteLine("Hashset supports contains and Python has in instead");

            Dictionary<string,string> dict= new Dictionary<string, string>
            {
                { "1", "navan" },
                { "2", "dff" },
                { "3", "sdfsfs" }
            };
            //dict.Add("1", "ddfsfs");//not possible since key must be unique

            dict.Remove("3");//remove in Python

            string d = string.Empty;
            dict.TryGetValue("1", out d);//get() in Python
            var keys=dict.Keys;//list of keys

            //IMPORTANT: Python - list:square brackets, tuple: simple brackets, dictionary: flower braces
            //Python doesn't support arrays instead offers lists
            //Python Nested dictionary accessing key/value via items()
            //pop() in Python to remove a specific key

            myFunc(xx: "hi", y: "z");//named or aka keyword arg in Python but = used instead of : btw arg and value

            Console.WriteLine("Lambda expression:" + myFunc("hi",""));
            Console.WriteLine("Lambda expression:" + myFunc("bye",""));

            Console.WriteLine("My Lambda func:" + lambdafunc(10,20));
            Console.WriteLine("type() in Python instead of GetType(): " + lambdafunc.GetType().FullName);

            MyClass myc = new MyClass("navan", 49); //myc = MyClass("navan", 49) in Python
            Console.WriteLine("Name and age from class:" + myc.Name + myc.Age);

            int[] marklist = new int[5];
            marklist[0]=(97);
            marklist[1] = 92;
            marklist[2]=81;
            marklist[3] = 8;
            marklist[4] = 50;

            // Define the query expression.
            IEnumerable<int> scoreQuery = from mark in marklist where mark > 80 select mark;

            Console.ReadLine();
        }

        //        def myFunction() :
        //  return True

        //if myFunction() :
        //  print("YES!")
        //else:
        //  print("NO!")
        static bool MyFunction()
        { return true; }

        //function is reusable code but method is data-bound or manipulates data in Python
        //* can be specified in param to denote any number of args can be handled by the function in case of Python but not in C#

        static string myFunc(string xx,string y)
        {
            //global keyword can make a variable of global scope although within a function in Python
            //in case of Python, a blank function must have pass
            return arrowfunc(xx);
        }

        static int returnInt()
        {
            return 200;
        }

        //lambda keyword is used in Python to create a lambda function
        static Func<string, string> arrowfunc = (x =>
        {
            return "anonymous " + x;
        });

        static Func<int, int, string> lambdafunc = (a, b) => { return (a + b + 10).ToString() + "lambda"; };
    }
}
