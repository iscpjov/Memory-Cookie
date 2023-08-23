using System;
using System.Collections.Generic;
using InCache.Cookie;
using RunCache.animales;

namespace RunCache {
    class Program {

        public static void Main() {
            setvalues();
            List<test> listtest = new List<test>();
            listtest.Add(new test { t1=1, t2="h1"});
            listtest.Add(new test { t1 = 1, t2 = "h1" });
            listtest.Add(new test { t1 = 2, t2 = "h2" });
            listtest.Add(new test { t1 = 3, t2 = "h3" });
            listtest.Add(new test { t1 = 4, t2 = "h4" });
            listtest.Add(new test { t1 = 5, t2 = "h5" });
            //List<int> list = new List<int>() { 0,1,2,3,4,5,6,7,8,9 };
            //Cookie.Set("listtest", listtest);
            var list = Cookie.Get("test");



            test te = new test { t1 = 10, t2 = "prueba" };
            gato g = new gato { Nombre = "misifu", Edad = 5 };
            Cookie.Set("gato", g);
            var test = Cookie.Get("gato" , 70);
            var inta = Cookie.Get("int5", 60);
            Type t = typeof(string);
            string r = t.FullName;
            /*
            List<test> tester = new List<test> { 
                new test{t1 = 1, t2 = "test1"},
                new test{t1 = 2, t2 = "test2"},
                new test{t1 = 3, t2 = "test3"},
                new test{t1 = 4, t2 = "test4"},
                new test{t1 = 5, t2 = "test5"}
            };

            Cookie.Set("tester", tester);
            */
            var tester = Cookie.Get<List<int>>("tester");

            
            Cookie.Set("date", DateTime.Now);
            Cookie.Set("perro", "perro");

            double int2 = (double)Cookie.Get<double>("double");
            var arrayI = Cookie.Get<int[]>("Aint");
            var arrayS = Cookie.Get<string[]>("Astring");
            var condicion = Cookie.Get("bool", true);
            var entero = Cookie.Get("int");
            var flotante = Cookie.Get("float");
            var decima = Cookie.Get("decimal");
            var doble = Cookie.Get("double");
            var obj = Cookie.Get<test>("test");

            
            Console.Read();
        }


        
        static void setvalues() {
            test t = new test { t1 = 10, t2 = "prueba" };
            int[] arrayInt = new int[] { 1, 2, 3, 4, 5, 6 };
            string[] arrayString = new string[] { "1", "2", "3", "4", "5", "6" };
            Cookie.Set("bool", true);
            Cookie.Set("int", 10);
            Cookie.Set("float", 5.2f);
            Cookie.Set("decimal", 5.1321321321m);
            Cookie.Set("double", 5.1321321321);
            Cookie.Set("Astring", arrayString);
            Cookie.Set("Aint", arrayInt);
            Cookie.Set("test", t);
            
        }

    }

    

}
