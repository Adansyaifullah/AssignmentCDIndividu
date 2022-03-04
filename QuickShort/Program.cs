using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShort
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>Pengurutan sorting data</remarks>
    class Program
    {
        /// <summary>
        /// mengurutkan angka dari kecil ke besar
        /// </summary>
        private int[] arr = new int[20];


        private int n;

        /// <summary>
        /// untuk memasukkan elemen ke array dengan batas maximum 20 element
        /// </summary>
        void read()
        {
            while (true)
            {
                Console.Write(" enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 element.\n");
            }

            Console.WriteLine("\n---------------------");
            Console.WriteLine(" enter array elements ");
            Console.WriteLine("--------------------");


            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        /// <summary>
        /// pertukaran element index
        /// </summary>
        /// <param name="x">index pertama pada operasi pertukaran</param>
        /// <param name="y">index kedua pada operasi pertukaran</param>
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        /// <summary>
        /// untuk mengurutkan angka
        /// </summary>
        /// <param name="low">mengurutkan dari terendah</param>
        /// <param name="high">mengurutkan dari tertinggi</param>
        public void q_sort(int low, int high)
        {
            int pivot, i, j;

            if (low > high)
                return;


            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {

                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                }

                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                }

                if (i < j)

                {
                    swap(i, j);
                }
            }
            if (low < j)
            {
                swap(low, j);
            }
            q_sort(low, j - 1);

            q_sort(j + 1, high);
        }

        /// <summary>
        /// untuk menyortir element array
        /// </summary>
        void display()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine(" sorted array elements ");
            Console.WriteLine("------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }

        int getSize()
        {
            return (n);
        }

        /// <summary>
        /// menerima, mengurutkan, menampilkan, dan mengakhiri program
        /// </summary>
        /// <param name="args">untuk menerima argumen dari tipe string</param>
        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.read();
            myList.q_sort(0, myList.getSize() - 1);
            myList.display();
            Console.WriteLine("\n\nPress enter to exit.");
            Console.Read();
        }
    }
}