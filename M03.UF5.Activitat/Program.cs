using System;
using ClassLibrary1;


namespace M03.UF5.Activitats
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1. Implementa la classe “Book”
            Console.WriteLine("Exercici 1 \n");
            List<Book> books = new List<Book>();
            books.Add(new Book(1, "El Quijote", 200));
            books.Add(new Book(2, "El Señor de los Anillos", 300));
            books.Add(new Book(3, "El Perfume", 150));
            books.Add(new Book(4, "El Código Da Vinci", 400));
            books.Add(new Book(5, "El Principito", 100));

            Console.WriteLine("Llista de llibres ordenada per nombre de pàgines: ");
            books.Sort();
            foreach (Book b in books)
            {
                Console.WriteLine(b.toString());
            }
            Console.WriteLine("Llista de llibres ordenada per nombre de pàgines descendentment: ");
            books.Reverse();
            foreach (Book b in books)
            {
                Console.WriteLine(b.toString());
            }
            //2. No se on està la solució "Visit"
            Console.WriteLine("\nExercici 2 \n");
            //3. Implementa un mètode que demani una data i aquest retorni quants dies han passat des de la data indicada fins a la data actual. Nota: l’usuari ha d’introduir la data en format enter (dd, mm, yyyy).
            Console.WriteLine("Exercici 3 \n");
            Console.WriteLine("Introdueix la data en format enter (dd, mm, yyyy): ");
            string data = Console.ReadLine();
            DateTime dataIntroduida = DateTime.Parse(data);
            DateTime dataActual = DateTime.Now;
            TimeSpan dies = dataActual - dataIntroduida;
            if (data != "30 4 1945")
            {
                Console.WriteLine("Han passat " + dies.Days + " dies des de la data introduida fins a la data actual.");

            }
            else
            {
                Console.WriteLine("Han passat " + dies.Days + " dies des de la mort de Hitler");
            }
            //4. Implementa un mètode que demani dues dates i aquest retorni si la segona data és posterior a la primera data. Nota: l’usuari ha d’introduir la data en format enter (dd, mm, yyyy).
            Console.WriteLine("\nExercici 4 \n");
            Console.WriteLine("Introdueix la primera data en format enter (dd, mm, yyyy): ");
            string data1 = Console.ReadLine();
            DateTime dataIntroduida1 = DateTime.Parse(data1);
            Console.WriteLine("Introdueix la segona data en format enter (dd, mm, yyyy): ");
            string data2 = Console.ReadLine();
            DateTime dataIntroduida2 = DateTime.Parse(data2);
            if (dataIntroduida2 > dataIntroduida1)
            {
                Console.WriteLine("La segona data és posterior a la primera data.");
            }
            else
            {
                Console.WriteLine("La segona data no és posterior a la primera data.");
            }   
            //5. Implementa un mètode que demani una data i aquest retorni el dia de la setmana que és. Nota: l’usuari ha d’introduir la data en format enter (dd, mm, yyyy).
            Console.WriteLine("\nExercici 5 \n");
            Console.WriteLine("Introdueix la data en format enter (dd, mm, yyyy): ");
            string data3 = Console.ReadLine();
            DateTime dataIntroduida3 = DateTime.Parse(data3);
            Console.WriteLine("El dia de la setmana de la data introduida és: " + dataIntroduida3.DayOfWeek);

            //6. Implementa un mètode i afegeix-lo a la classe Employee que rebi la data de naixement i retorni la seva edat.
            Console.WriteLine("\nExercici 6 \n");
            Console.WriteLine("Introdueix la data de naixement en format enter (dd, mm, yyyy): ");
            DateTime data4 = DateTime.Parse(Console.ReadLine());
            Employee e = new Employee("1", "Pep", "Guardiola", "afaefaef", dataIntroduida3, data4);
            Console.WriteLine($"L'edat de l'empleat {e.FirstName} {e.LastName} és:  + {e.Edad(data4)} anys");
            //7. Defineix la classe SalesEmployee, que extén la classe Employee, i que té com a  atribut “commission (float).
            Console.WriteLine("\nExercici 7 \n");
            SalesEmployee se = new SalesEmployee("2", "Lionel", "Messi", 0.1f);
            //8. Donada una llista de números, escriu un programa que calculi la suma de tots els elements.
            Console.WriteLine("\nExercici 8 \n");
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(3);
                
            numeros.Add(4);
            numeros.Add(5);
            int suma = 0;
            foreach (int n in numeros)
            {
                suma += n;
            }
            Console.WriteLine("La suma de tots els elements de la llista és: " + suma);
            //9. Donada una llista de números, filtra i mostra només els nombres parells.
            Console.WriteLine("\nExercici 9 \n");
            List<int> numeros2 = new List<int>();
            numeros2.Add(1);
            numeros2.Add(2);
            numeros2.Add(3);
            numeros2.Add(4);
            numeros2.Add(5);
            Console.WriteLine("Els nombres parells de la llista són: ");
            foreach (int n in numeros2)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
            }
            //10. Donat un array de strings, converteix-ho en una llista i mostra els elements de la llista.
            Console.WriteLine("\nExercici 10 \n");
            string[] array = { "Hola", "Adéu", "Benvingut", "Fins aviat" };
            List<string> llista = new List<string>(array);
            Console.WriteLine("Els elements de la llista són: ");
            foreach (string s in llista)
            {
                Console.WriteLine(s);
            }
            //11. Crea un diccionari que emmagatzemi informació sobre empleats (nom i salari) i mostri la informació.
            Console.WriteLine("\nExercici 11 \n");
            Dictionary<string, float> empleats = new Dictionary<string, float>();
            empleats.Add("Pep", 2000);
            empleats.Add("Lionel", 3000);
            empleats.Add("Cristiano", 4000);
            empleats.Add("Neymar", 5000);
            Console.WriteLine("La informació dels empleats és: ");
            foreach (KeyValuePair<string, float> g in empleats)
            {
                Console.WriteLine("Nom: " + g.Key + ", Salari: " + g.Value);
            }
            //12. Donada una llista de números, elimina els elements que siguin majors que un valor específic.
            Console.WriteLine("\nExercici 12 \n");
            List<int> numeros3 = new List<int>();
            numeros3.Add(1);
            numeros3.Add(2);
                
            numeros3.Add(3);
            numeros3.Add(4);
                
            numeros3.Add(5);
                Console.WriteLine("Introdueix un valor: ");
            int valor = int.Parse(Console.ReadLine());




        }
    }
}
