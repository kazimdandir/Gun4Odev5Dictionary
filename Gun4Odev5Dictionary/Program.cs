using System;

namespace Gun4Odev5Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(1, "Kazım");
            students.Add(2, "Talha");
            students.Add(3, "Fatih");
            students.Add(4, "Ahmet");
            Console.WriteLine(students.Count);
        }
    }
    class MyDictionary<T1, T2>
    {
        T1[] items1;
        T1[] tempArray1;
        T2[] items2;
        T2[] tempArray2;

        public MyDictionary()
        {
            items1 = new T1[0];
            items2 = new T2[0];
        }

        public void Add(T1 id, T2 name)
        {
            tempArray1 = items1;
            tempArray2 = items2;

            items1 = new T1[items1.Length + 1];
            items2 = new T2[items2.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
            }

            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }

            items1[items1.Length - 1] = id;
            items2[items1.Length - 1] = name;
        }

        public int Count
        {
            get { return items1.Length; }
        }
    }
}