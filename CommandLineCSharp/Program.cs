using System;
using System.Collections;

namespace CommandLineCSharp
{
    /* class Array{

        int sum = 0;
        public void countAvg(){
            
            Console.WriteLine("Enter no of elements :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + " : ");
                Array[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int j = 0; j < n; j++)
            {
                sum += Array[j];

            }
            Console.WriteLine("Array is :" );
            for (int i = 0; i < n ;i++ ){
                
                Console.Write(Array[i]);
                Console.Write("\t");
            }

            double avg = Convert.ToDouble(sum) / n;
            Console.WriteLine("\nAverage of all the elements is : " + avg);
        }

    }

    class Array2
    {
        public void Avg(int[,] arr1, int n, int m)
        {
            int sum = 0, avg = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += arr1[i, j];
                }

            }
            avg = sum / (m * n);
            Console.WriteLine("\nAverage of the array elements is : " + avg);

        }

        public void showArray(int[,] arr1 , int n , int m){
            Console.WriteLine("Array is : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < m; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
        }

    }

    class ArrayMain{

        public static void Main(String[] args){

            Array arrayObject = new Array();
            Array2 arrayObject2 = new Array2();
            
            Console.WriteLine("What is the type of array ?");
            Console.WriteLine("Type 1 for 1D Array or 2 for 2D array");

            int arrayType = Convert.ToInt32(Console.ReadLine());
            
            if( arrayType == 1 ){


                arrayObject.countAvg();
            }

            else if ( arrayType == 2 ) {

                Console.Write("\nEnter No of Rows : ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Number of columns : ");
                int m = Convert.ToInt32(Console.ReadLine());
                int[,] arr1 = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("Enter - [{0},{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                arrayObject2.showArray(arr1, n, m);
                arrayObject2.Avg(arr1 , n , m);


            }

         }

    } */

    /*class StackDemo2{

        public static void Main(string[] args){
            Stack stack = new Stack();


            stack.Push("Delzad");
            stack.Push("Devansh");
            stack.Push("Dalwadi");

            Console.WriteLine("Current Stack : ");
            foreach (string c in stack){
                Console.WriteLine(c + " ");
            }

            Console.WriteLine("\nPushing Aayush to stack");
            stack.Push("Aayush");
            Console.WriteLine("Top of stack : " + stack.Peek());
            Console.WriteLine("\nTherefore current stack becomes : ");
            foreach (string c in stack){
                Console.WriteLine(c);
            }

            Console.WriteLine("\nIs Dalwadi present in stack ? " + stack.Contains("Dalwadi") );
            Console.WriteLine("\nRemoving Values");
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine("\nNew stack : ");
            foreach (string c in stack){
                Console.WriteLine(c);
            }

            Console.WriteLine("Clearing Stack :");
            stack.Clear();
            Console.Write("\nCount of stack is : ");
            Console.WriteLine(stack.Count);

        }


    } */

    class Override
    {
        public virtual void show(){
            Console.WriteLine("Inside Parent");
        }
    }

    class Override2 : Override
    {
        public override void show(){
            Console.WriteLine("Inside child");
        }
    }

    class Override3 : Override2{

        public override void show(){
            Console.WriteLine("Inside superchild");
        }
    }

    class MainOvr{
        public static void Main(string[] args){

            Override obj1 = new Override();
            Override2 obj2 = new Override2();
            Override obj3 = new Override3();

            obj3 = obj1;

            obj1.show();
            obj2.show();
            obj3.show();



        }
    }

}


