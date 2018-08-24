﻿using System;
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

    /* class Override
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

            //reference to parent class 
            obj3 = obj1;

            obj1.show();
            obj2.show();
            obj3.show();



        }
    } */

    /* class Shape2{

        public const double PI = Math.PI;
        protected double x, y;
        public Shape2(){

            Console.WriteLine("Default constructor");
        }

        public Shape2(double x , double y){

            this.x = x;
            this.y = y;

        }

        public virtual double Area(){

            return x * y;

        }
    }

    class Circle : Shape2 {

        public Circle(double r) : base(r,0){


        }

        public override double Area()
        {
            return PI * x * x;
        }

    }

    class Sphere : Shape2{


        public Sphere(double r) : base(r , 0) {
            
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    class Cylinder : Shape2 {

        public Cylinder(double r , double h) : base( r , h ){


        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }

    class ShapeMain{

        public static void Main(string[] args)
        {

            double r, h;
        menu:

            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Sphere");
            Console.WriteLine("3.Cylinder");
            Console.WriteLine("--------------");
            Console.WriteLine("Select Shape");

            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {

                case 1:

                    Console.WriteLine("Enter Radius value");
                    r = Convert.ToDouble(Console.ReadLine());
                    Shape2 c = new Circle(r);
                    Console.WriteLine("Area is " + c.Area());
                    break;

                case 2:
                    Console.WriteLine("Enter Radius value");
                    r = Convert.ToDouble(Console.ReadLine());
                    Shape2 s = new Sphere(r);
                    Console.WriteLine("Area is " + s.Area());
                    break;

                case 3:
                    Console.WriteLine("Enter Radius value");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Height value");
                    h = Convert.ToDouble(Console.ReadLine());
                    Shape2 cy = new Cylinder(r, h);
                    Console.WriteLine("Area is " + cy.Area());
                    break;
            }

            Console.WriteLine("Press M to go to menu or anything else to exit");

            ConsoleKeyInfo cmd = Console.ReadKey();

            if (cmd.KeyChar == 'M' || cmd.KeyChar == 'm')
            {
                goto menu;
            } else {
                Environment.Exit(0);
            }



        } 
    } */

    /* interface Abc
    {

        void Xyz();


    }

    interface Pqr
    {

        void Def();
    }

    interface A1: Pqr , Abc{

        void display();

    }

    class TestClass: Abc , Pqr{

        public void Xyz(){

            Console.WriteLine("Inside implemented class of interface ABC");
        }

        public void Def(){

            Console.WriteLine("Inside implemented class of interface PQR");
        }

    }

    class SecondTest : A1 {

        public void Xyz()
        {

            Console.WriteLine("Inside Second class of interface A1");
        }

        public void Def()
        {

            Console.WriteLine("Inside Second class of interface A1");
        }

        public void display(){

            Console.WriteLine("Method of interface A1");
        }
    }

    class InterfaceDemo{

        public static void Main(string[] args){

            Abc obj = new TestClass();

            obj.Xyz();

            Pqr obj2 = new TestClass();

            obj2.Def(); 

            SecondTest obj = new SecondTest();

            obj.Xyz();
            obj.Def();
            obj.display();


        }


    } */

    /* interface IDinner{

        void doDinner(double time, string place);

    }

    interface IGym{

        void doWorkout(double time , string place);

    }

    interface IMovie : IDinner
    {

        void doMovie(double time, string place);

    }
    interface IShopping : IMovie{

            void doShopping(double time, string place);

    }

    class Routine : IGym , IDinner{
        
            public void doWorkout(double time, string place){
                Console.WriteLine("Gym is at " + time + " at " + place);
            }

            public void doDinner(double time, string place){
            
                Console.WriteLine("Dinner is at " + time + " at " + place);    
            }

    }

    class Holiday : IShopping{

            public void doMovie(double time , string place){
                    
                Console.WriteLine("Movie is at " + time + " at " + place );

            }

            public void doShopping(double time , string place){
                
                Console.WriteLine("Shopping is at " + time + " at " + place);
            }

            public void doDinner(double time , string place){

            Console.WriteLine("Dinner is at " + time + " at " + place);
            
        }
        
    }

    class Program{

        public static void Main(string[] args){

            Console.WriteLine("What type of day is it ? ");
            Console.WriteLine("1. Routine");
            Console.WriteLine("2. Holiday");

            int q = Convert.ToInt32(Console.ReadLine());

            switch(q){

                case 1:
                    Routine obj = new Routine();
                    Console.WriteLine("Enter time and place of Gym");
                    double Gymtime = Convert.ToDouble(Console.ReadLine());
                    string Gymplace = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter time and place of Dinner");
                    double Dinnertime = Convert.ToDouble(Console.ReadLine());
                    string Dinnerplace = Convert.ToString(Console.ReadLine());

                    obj.doDinner(Dinnertime, Dinnerplace);
                    obj.doWorkout(Gymtime, Gymplace);

                    break;

                case 2:
                    Holiday obj2 = new Holiday();
                    Console.WriteLine("Enter time and place of Shopping");
                    double Shoptime = Convert.ToDouble(Console.ReadLine());
                    string ShopPlace = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter time and place of Dinner");
                    double Dinnertime2 = Convert.ToDouble(Console.ReadLine());
                    string Dinnerplace2 = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter time and place of Movie");
                    double Movietime = Convert.ToDouble(Console.ReadLine());
                    string Movieplace = Convert.ToString(Console.ReadLine());


                    obj2.doDinner(Dinnertime2, Dinnerplace2);
                    obj2.doMovie(Movietime, Movieplace);
                    obj2.doShopping(Shoptime, ShopPlace);

                    break;
            }

        }
    } */


    abstract class BaseStudent
    {

        protected string Name;
        protected string ID;
        protected string Class;
        protected string Address;

        public abstract string stuName { get; set; }
        public abstract string stuID { get; set; }
        public abstract string stuClass { get; set; }
        public abstract string stuAddress { get; set; }


        public void rankCalculator(){
            
        }

        public void displayDetails(string Name , string ID , string Class , string Address){

            Console.WriteLine("Name : " + Name);
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Class : " + Class);
            Console.WriteLine("Address : " + Address);

        }

        public abstract void feesPayment();

        public abstract void modeOfTransport();


    }

    interface IDance
    {

        void doDance();

    }

    interface ISinging
    {
        void Sing();
    }

    interface IYoga
    {
        void doYoga();
    }

    class Student1 : BaseStudent, IDance , ISinging {


        public override string stuName { 

            get
            {
                return Name;
            }
            set
            {
                Name = value;    
            } 
        }
        public override string stuID
        {

            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public override string stuClass
        {

            get
            {
                return Class;
            }
            set
            {
                Class = value;
            }
        }

        public override string stuAddress
        {

            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }

        public void doDance(){
            
        }

        public void Sing(){
            
        }

        public override void feesPayment()
        {
            

        }

        public override void modeOfTransport()
        {
            
        }

    }

    class Student2 : BaseStudent , IYoga {


        public override string stuName
        {

            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public override string stuID
        {

            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        public override string stuClass
        {

            get
            {
                return Class;
            }
            set
            {
                Class = value;
            }
        }

        public override string stuAddress
        {

            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }


        public void doYoga(){
            
        }


        public override void feesPayment()
        {


        }

        public override void modeOfTransport()
        {

        }

    }

    class AbstractMain{

        public static void Main(string[] args){

            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine(arr.Rank);

        }
    }

}


