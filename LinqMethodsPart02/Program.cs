using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqMethodsPart02
{
    public class Program
    {
        private static IList<Student> _students;
        public static int Option { get; set; }
        static void Main(string[] args)
        {
            AddStudents();
            GetOptions();
        }

        // Pega a lista de students e cria uma nova lista de StudentViewModel;
        private static void SelectMethodExample()
        {
            var viewModelStudents = _students
               .Select(s => new StudentViewModel(
                    $"{s.Name} {s.LastName}",
                    s.Documento)
               ).ToList();

            GetOptions();
        }

        // Pega os emails de cada estudante e adiciona em uma lista de emails.
        private static void SelectManyMethodExample()
        {
            var emails = _students.SelectMany(s => s.Emails).ToList();

            GetOptions();
        }

        private static void WhereMethodExample()
        {
            List<int> numbers = new() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Exemplo 01
            // Deve retornar apenas o número 1;
            var example01 = numbers.Where(x => x == 1);

            // Exemplo 02
            // Deve retornar apenas o número menores que 6;
            var example02 = numbers.Where(x => x <= 5);

            // Exemplo 01
            // Deve retornar apenas os números que estão entre 5 e 8;
            var example03 = numbers.Where(x => x > 5 && x < 8);

            GetOptions();
        }



        // Retorna apenas os itens do tipo string (One, Two, Three);
        private static void OfTypeMethodExample()
        {
            var _mixedList = new ArrayList();
            _mixedList.Add(0);
            _mixedList.Add("One");
            _mixedList.Add(2);
            _mixedList.Add("Two");
            _mixedList.Add(3);
            _mixedList.Add("Three");


            var result = _mixedList.OfType<string>();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


        private static void AddStudents()
        {
            _students = new List<Student>
            {
                new Student(1,"Jõao","Souza","304930494933",new List<string>{"joao@gmail.com"},"123"),
                new Student(2,"Maria","Olinda","2344343545",new List<string>{"olinda@gmail.com" },"123"),
                new Student(3,"Marcos","Lima","45436555",new List<string>{"lima@gmail.com" },"123")
            };
        }

        private static void GetOptions()
        {
            Console.WriteLine("Aqui vamos ver alguns exempos de métodos LINQ:");
            Console.WriteLine("Insira um breakpoint Em cada método e veja sua execução!:");
            Console.WriteLine("Informe uma das opções abaixo para ver um exemplo: \n");
            Console.WriteLine("\t1: Método Select");
            Console.WriteLine("\t2: Método SelectMany");
            Console.WriteLine("\t3: Método Where");
            Console.WriteLine("\t4: Método OfType");
            Console.WriteLine("\t5: Aperte para sair");

            Option = int.Parse(Console.ReadLine());

            switch (Option)
            {
                case 1:
                    SelectMethodExample();
                    break;

                case 2:
                    SelectManyMethodExample();
                    break;

                case 3:
                    WhereMethodExample();
                    break;

                case 4:
                    OfTypeMethodExample();
                    break;


                default:
                    Environment.Exit(0);
                    break;
            }
        }

    }
}
