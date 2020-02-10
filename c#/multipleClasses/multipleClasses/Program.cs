using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleClasses
{
    /* public class Program
      {
          public int id;
          public string name;
      }
      public class ProgramA
      {
          public int id;
          public string name;
      }
      public class programB
      {
          public int id;
          public string name;
      }
      class mainProgram
      {
          public static void Main(string[] args)
          {
              ProgramA pa = new ProgramA();
              programB pb = new programB();
              Program p = new Program();
              pa.id = 10;
              pa.name = "rohith";
              pb.id = 100;
              pa.name = "bandirohith";
              p.id = 1000;
              p.name = "rohithabndi";
              Console.WriteLine(pa.id);
              Console.WriteLine(pa.name);
              Console.ReadKey();
          }
      }
      public  partial class C
      {
          public int id;
          public string name;
          public int i;
          public string n;
          public C(int id, string name)
          {
              this.id = id;
              this.name = name;

          }
      }
      public partial class C
      {
          public C(int i)
          {
              this.i = i;
              this.n = "rohith";
          }

      }
      public class myProgram
      {
          public static void Main(String[] args)

          {
              C c1 = new C(10,"bandi");
              C c2 = new C(2);

              Console.WriteLine(c1.id);
              Console.WriteLine(c1.name);
              Console.WriteLine(c2.i);
              Console.WriteLine(c2.n);
              Console.ReadKey();

          }

      }*/
    public class InternalClass
    {
        int age;
        string name;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

    }
    class Getset
    {
        public static void Main(string[] args)
        {
            InternalClass  ic= new InternalClass();
            ic.Name = "rohith";
            ic.Age = 22;
            Console.WriteLine(ic.Name);
            Console.WriteLine(ic.Age);



        }
    }
}
