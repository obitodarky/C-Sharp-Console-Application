using System;
using System.Collections.Generic;
using System.Linq;


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


    /*abstract class BaseStudent
    {
        protected string Name;
        protected string ID;
        protected string Class;
        protected string Address;
        public abstract string stuName { get; set; }
        public abstract string stuID { get; set; }
        public abstract string stuClass { get; set; }
        public abstract string stuAddress { get; set; }
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
        public void displayInfo()
        {
            displayDetails(stuName, stuID, stuClass, stuAddress);
            doDance();
            Sing();
            feesPayment();
            modeOfTransport();
        }
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
            Console.WriteLine("Dance is a talent");
            
        }
        public void Sing(){
            Console.WriteLine("Singing is a talent");
            
        }
        public override void feesPayment()
        {
            Console.WriteLine("Fees have been paid");
        }
        public override void modeOfTransport()
        {
            Console.WriteLine("Mode of transport is Bus");
        }
    }
    class Student2 : BaseStudent , IYoga {
        public void displayInfo(){
            displayDetails(stuName, stuID, stuClass, stuAddress);
            doYoga();
            feesPayment();
            modeOfTransport();
        }
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
            Console.WriteLine("Talented in Yoga");
            
        }
        public override void feesPayment()
        {
            Console.WriteLine("Fees Pending");
        }
        public override void modeOfTransport()
        {
            Console.WriteLine("Mode of transport is Car");
        }
    }
    class AbstractMain{
        public static void Main(string[] args){
            Student1 obj1 = new Student1();
            Console.WriteLine("Write Name , ID , Class and Address  of Student 1");
            obj1.stuName = Convert.ToString(Console.ReadLine());
            obj1.stuID = Convert.ToString(Console.ReadLine());
            obj1.stuClass = Convert.ToString(Console.ReadLine());
            obj1.stuAddress = Convert.ToString(Console.ReadLine());
            obj1.displayInfo();
            Student2 obj2 = new Student2();
            Console.WriteLine("----------------");
            Console.WriteLine("Write Name , ID , Class and Address  of Student 2");
            obj2.stuName = Convert.ToString(Console.ReadLine());
            obj2.stuID = Convert.ToString(Console.ReadLine());
            obj2.stuClass = Convert.ToString(Console.ReadLine());
            obj2.stuAddress = Convert.ToString(Console.ReadLine());
            obj2.displayInfo();
        }
    } */

    /* abstract class Person{
        protected string ID;
        protected string NAME;
        public abstract string _ID { get; set; }
        public abstract string _NAME { get; set; }
        public abstract void displayDetails();
    }
    class Faculty : Person {
        public override string _ID { get { return ID; } set { ID = value; } }
        public override string _NAME { get { return NAME; } set { NAME = value; } }
        public string course;
        public override void displayDetails()
        {
            Console.WriteLine("Faculty Name : " + this._ID);
            Console.WriteLine("Faculty ID : " + this._NAME);
            Console.WriteLine("Course taught : " + this.course);
        }
    }
    class Student : Person
    {
        public override string _ID { get { return ID; } set { ID = value; } }
        public override string _NAME { get { return NAME; } set { NAME = value; } }
        public string grade;
        public override void displayDetails()
        {
            Console.WriteLine("Student Name : " + this._ID);
            Console.WriteLine("Student ID : " + this._NAME);
            Console.WriteLine("Grade is : " + this.grade);
        }
    }
    class AbsMain{
        public static void Main(string[] args){
            Console.WriteLine("Are you a faculty or a student ?");
            Console.WriteLine("1.Faculty");
            Console.WriteLine("2.Student");
            int r = Convert.ToInt32(Console.ReadLine());
            switch(r){
                case 1:
                    Faculty fobj = new Faculty();
                    Console.WriteLine("---------------");
                    Console.WriteLine("Enter Faculty 1 ID And Name and Course");
                    fobj._ID = Convert.ToString(Console.ReadLine());
                    fobj._NAME = Convert.ToString(Console.ReadLine());
                    fobj.course = Convert.ToString(Console.ReadLine());
                    Faculty fobj2 = new Faculty();
                    Console.WriteLine("---------------");
                    Console.WriteLine("Enter Faculty 2 ID And Name and Course");
                    fobj2._ID = Convert.ToString(Console.ReadLine());
                    fobj2._NAME = Convert.ToString(Console.ReadLine());
                    fobj2.course = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Faculty 1 info is :");
                    fobj.displayDetails();
                    Console.WriteLine("------------");
                    Console.WriteLine("Faculty 2 info is :");
                    fobj2.displayDetails();
                    break;
                case 2:
                    Student sobj = new Student();
                    Console.WriteLine("---------------");
                    Console.WriteLine("Enter Student 1 ID And Name and Grade");
                    sobj._ID = Convert.ToString(Console.ReadLine());
                    sobj._NAME = Convert.ToString(Console.ReadLine());
                    sobj.grade = Convert.ToString(Console.ReadLine());
                    Student sobj2 = new Student();
                    Console.WriteLine("---------------");
                    Console.WriteLine("Enter Student 2 ID And Name and Grade");
                    sobj2._ID = Convert.ToString(Console.ReadLine());
                    sobj2._NAME = Convert.ToString(Console.ReadLine());
                    sobj2.grade = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Student 1 info is : ");
                    sobj.displayDetails();
                    Console.WriteLine("------------");
                    Console.WriteLine("Student 2 info is : ");
                    sobj2.displayDetails();
                    break;
            }
        }
    } */

    /* 
     * class Queue{
        public int front = 0;
        public int rear = 0;
        public static int size;
        public void setSize(int n){
            size = n;
        }
        int[] queue = new int[size];
        public void Enqueue(int x){
            if (this.rear == size){
                    Console.WriteLine("queue is full!");
            } else {
                if(this.front == 0 && this.rear == 0){
                    this.front = 1;
                }
                Console.WriteLine(queue);
                Console.WriteLine(rear);
                rear = rear + 1;
                Console.WriteLine(rear);
                this.queue[this.rear] = x;
            }
        }
        public void Dequeue(int x){
            if(this.front ==0){
                Console.WriteLine("Queue is empty");
            } else {
                x = this.queue[this.front];
                this.front = this.front + 1;
            }
        }
        public void showQueue(){
            for (int j = 0; j < size; j++ ){
                Console.WriteLine(queue[j]);
            }
        }
    }
    class QueueMain{
        public static void Main(string[] args){
            Queue obj = new Queue();
            Console.WriteLine("Enter no of elements");
            int size = Convert.ToInt32(Console.ReadLine());
            obj.setSize(size);
            Console.WriteLine("Menu : ");
            Console.WriteLine("1.Add to queue");
            Console.WriteLine("2. Remove from queue");
            Console.WriteLine("3. Peek queue");
            int q = Convert.ToInt32(Console.ReadLine());
            switch(q){
                
                case 1:
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.Enqueue(x);
                    break;
                
                case 2:
                    
                    break;
                
                case 3:
                    break;
            }
            obj.showQueue();
        }
    } */

    /*public abstract class Employee{
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
    }
    class Teacher : Employee {
        private string _Code;
        private string _Name;
        private int _Age;
        public string Code { get { return _Code; } set{ _Code = value; }}
        public override string Name
        {
            get
            {
                
                //return _Name;
                if (string.IsNullOrEmpty(this._Name))
                    return "no name";
                else
                    return this._Name;
                //ternary operator
                //return string.IsNullOrEmpty(this._Name) ? "no name" : this._Name;
            }
            set
            {
                if (value == "")
                    Console.WriteLine("No value for name");
                else
                    _Name = value;
            }
        }
            public override int Age { 
                get {
                    return _Age;
                } set {
                if (value < 25)
                    Console.WriteLine("Age cant be less than 25");
                else
                    _Age = value;
            } 
          }
        public override string ToString()
        {
            return " Code = " + Code + "\n Name = " + Name + "\n Age = " + Age; 
        }
    }
        class MainProg{
            public static void Main(string[] args){
            /*Teacher t1 = new Teacher();
            Console.WriteLine("Enter age : ");
            t1.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teacher info : " + t1.ToString());
            t1.Age +=2;
            Console.WriteLine("Age is now : " +t1.ToString()); 
                
            Teacher[] t2 = new Teacher[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter properties for Teacher : " + (i + 1));
                t2[i].Name = Convert.ToString(Console.ReadLine());
                t2[i].Age = Convert.ToInt32(Console.ReadLine());
                t2[i].Code = Convert.ToString(Console.ReadLine());
                
                    Console.WriteLine("Teacher " + (i+1) + "info is \n");
                    Console.WriteLine(t2[i].ToString());
                }
            }
        } */

    //INDEXER EXAMPLE

    /* class Employee
     {
         int Eno;
         double Salary;
         string Ename, Location, Dname;
         public Employee(int Eno , double Salary , string Ename , string Location , String Dname){
             this.Eno = Eno;
             this.Salary = Salary;
             this.Ename = Ename;
             this.Location = Location;
             this.Dname = Dname;

         }
         public object this[int index]{
             get{
                 if (index == 0)
                     return Eno;
                 else if (index == 1)
                     return Salary;
                 else if (index == 2)
                     return Ename;
                 else if (index == 3)
                     return Location;
                 else if (index == 4)
                     return Dname;
                 else
                     return null;
             }
             set{
                 if (index == 1)
                     Salary = (double)value;
                 else if (index == 3)
                     Location = (string)value;
                 else if (index == 4)
                     Dname = (string)value;
             }
         }
     }
     class EmployeeMain{
         public static void Main(String[] args){
             Employee employee = new Employee(1,85000.00,"Dhruvil","Nuv","Marketing");
             Console.WriteLine("eno - " + employee[0].ToString());
             Console.WriteLine("esalaray - " + employee[1].ToString());
             Console.WriteLine("ename - " + employee[2].ToString());
             Console.WriteLine("elocation - " + employee[3].ToString());
             Console.WriteLine("edept - " + employee[4].ToString());
             employee[3] = "Navrachana University";
             employee[4] = "IT";
             Console.WriteLine("eno - " + employee[0].ToString());
             Console.WriteLine("esalaray - " + employee[1].ToString());
             Console.WriteLine("ename - " + employee[2].ToString());
             Console.WriteLine("elocation - " + employee[3].ToString());
             Console.WriteLine("edept - " + employee[4].ToString());
         }
     } */


    //GENERIC LIST EXAMPLE

    /*class Address {
        public string City { get; set; }
        public int Pincode { get; set; }
        public string CellNo { get; set; }
    }
    class Customer{
        //create generic addresses List
        public Address getAddress(int pin){
            foreach(Address o in addresses){
                if(o.Pincode == pin){
                    return o;
                }
            }
            return null;
        }
        public Address getAddress(string city){
            foreach(Address o in addresses){
                
                if(o.City == city){
                    return o;
                }
            }
            return null;
        }
        public Address getAddress(string cellNo , string nullstring)
        {
            foreach (Address o in addresses)
            {
                if (o.CellNo == cellNo)
                {
                    return o;
                }
            }
            return null;
        }
    }
    class AddressMain{
        public static void Main(string[] args){
            Customer c1 = new Customer();
            Console.WriteLine("customer data: " + c1.getAddress("baroda" , "nullstring").Pincode);
            foreach(Address a in c1["baroda"]){
                Console.WriteLine("\t pincode: " + a.Pincode + "\t cell no " + a.CellNo + "\t city" + a.City);
            }
        }
    } */

    /*class ExceptionTest {
        private string _Email;
        private string _Phone;
        private DateTime _Date;
        public string Email{ 
        
            get{
                return _Email;
            }
            set{
                string email = value;
                int atpos = email.IndexOf('@');
                var dotpos = email.LastIndexOf('.');
                if (atpos < 1 || dotpos < atpos + 2 || dotpos + 2 >= email.Length){
                    Console.WriteLine("wrong email");
                } else {
                    _Email = value;
                }
            }
        }
        public string Phone{
            get{
                return _Phone;
            }
            set{
                
                if(!value.All(char.IsDigit) || value.Length != 10){
                    //throw new FormatException("Exception found");
                    Console.WriteLine("Wrong phone no");
                } else {
                    _Phone = value;
                }
            }
        }
        public DateTime Date{
            get{
                return _Date;   
            }
            set{
                if(value != DateTime.Now.Date){
                    Console.WriteLine("invalid date");
                } else {
                    _Date = value;
                }
            }
        }
    }
    class ExceptionMain{
        public static void Main(string[] args){
            ExceptionTest e = new ExceptionTest();
            try
            {
                e.Date = Convert.ToDateTime(Console.ReadLine()).Date;
                e.Email = Convert.ToString(Console.ReadLine());
                e.Phone = Convert.ToString(Console.ReadLine());
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(1/x);
            }
            catch (DivideByZeroException){
                Console.WriteLine("0 used");
            }
        }
    } 


    /* class StudentIndexer
    {

        public string studentName;
        public double marks1, marks2, marks3;

        public StudentIndexer(string studentName, double marks1, double marks2, double marks3)
        {


            this.studentName = studentName;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;


        }

        public object this[int index]
        {

            get
            {

                if (index == 0)
                    return studentName;
                else if (index == 1)
                    return marks1;
                else if (index == 2)
                    return marks2;
                else if (index == 3)
                    return marks3;
                else
                    return null;

            }

            set
            {

                if (index == 0)
                    studentName = (String)value;
                else if (index == 1)
                    marks1 = (double)value;
                else if (index == 2)
                    marks2 = (double)value;
                else if (index == 3)
                    marks3 = (double)value;

            }



        }
        public void showPercentage()
        {

            double percentage;
            percentage = (marks1 + marks2 + marks3) / 300;

            Console.WriteLine("Percentage for " + studentName + " is  {0}2F", percentage);
        }

    }
    class StudentMain
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Student 1 :");

            StudentIndexer stu1 = new StudentIndexer(
                                                     Convert.ToString(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                                                     Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())
                                                    );

            Console.WriteLine("Student 2 : ");

            StudentIndexer stu2 = new StudentIndexer(
                                         Convert.ToString(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                                         Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())
                                        );

            Console.WriteLine("Student 3 :");

            StudentIndexer stu3 = new StudentIndexer(
                                         Convert.ToString(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                                         Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())
                                        );

            Console.WriteLine("Student 4 : ");

            StudentIndexer stu4 = new StudentIndexer(
                                         Convert.ToString(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                                         Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())
                                        );

            Console.WriteLine("Student 5 : ");
            StudentIndexer stu5 = new StudentIndexer(
                                         Convert.ToString(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()),
                                         Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())
                                        );

            stu1.showPercentage();
            stu2.showPercentage();
            stu3.showPercentage();
        }
    } */

    /*abstract class  Train
    {



        public abstract int Tno { get; set; }
        public  abstract string Tname { get; set; }
        public  abstract string Tsource { get; set; }
        public  abstract string Tdest { get; set; }
        public  abstract string Dtime { get; set; }
        public  abstract string Atime { get; set; }
        public  abstract string Ttype { get; set; }

        public abstract void displayInfo();

        public abstract object this[int index]{
            get;
            set;
        }

    class Express : Train
    {


        public override int Tno{

            get {
                return Tno;
            }

            set{
                Tno = value;
            }
        }

        public override string Tname{

            get{
                return Tname;
                
            }
            set{
                Tname = value;
            }
        }
        public override string Dtime
        {

            get
            {
                return Dtime;

            }
            set
            {
                Dtime = value;
            }
        }

        public override string Ttype
        {

            get
            {
                return Ttype;

            }
            set
            {
                Ttype = value;
            }
        }

        public override string Atime
        {

            get
            {
                return Atime;

            }
            set
            {
                Atime = value;
            }
        }
        public override string Tdest
        {

            get
            {
                return Tdest;

            }
            set
            {
                Tdest = value;
            }
        }

        public override string Tsource
        {

            get
            {
                return Tsource;

            }
            set
            {
                Tsource = value;
            }
        }

        public override object this[int index]{

            get{
                return Tname;

            }

            set{

                if(index == 1){
                    
                    if(Tsource == "New Delhi"){
                        Tname = (string)value;
                    }
                }
                    
            }
        }

        public override void displayInfo(){

            Console.WriteLine(Tsource + Tno + Ttype + Tdest + Atime + Dtime + Tname);
        }


    }


        class Local : Train
        {

            public Local(int Tno, string Tname, string Dtime, string Ttype, string Atime, string Tdest, string Tsource){

                this.Tno = Tno;
                this.Tname = Tname;
                this.Dtime = Dtime;
                this.Ttype = Ttype;
                this.Atime = Atime;
                this.Tdest = Tdest;
                this.Tsource = Tsource;
                
            }

        

        public override int Tno
        {

            get
            {
                return Tno;
            }

            set
            {
                Tno = value;
            }
        }

        public override string Tname
        {

            get
            {
                return Tname;

            }
            set
            {
                Tname = value;
            }
        }
        public override string Dtime
        {

            get
            {
                return Dtime;

            }
            set
            {
                Dtime = value;
            }
        }

        public override string Ttype
        {

            get
            {
                return Ttype;

            }
            set
            {
                Ttype = value;
            }
        }

        public override string Atime
        {

            get
            {
                return Atime;

            }
            set
            {
                Atime = value;
            }
        }
        public override string Tdest
        {

            get
            {
                return Tdest;

            }
            set
            {
                Tdest = value;
            }
        }

        public override string Tsource
        {

            get
            {
                return Tsource;

            }
            set
            {
                Tsource = value;
            }
        } 
            public override object this[int index]
        {

            get
            {
                return Tname;

            }

            set
            {

                if (index == 1)
                {

                    if (Tsource == "New Delhi")
                    {
                        Tname = (string)value;
                    }
                }

            }
        }

        public override void displayInfo()
        {

            Console.WriteLine(Tsource + Tno + Ttype + Tdest + Atime + Dtime + Tname);
        }
        }
        class Superfast : Train
        {
        public override int Tno
        {

            get
            {
                return Tno;
            }

            set
            {
                Tno = value;
            }
        }

        public override string Tname
        {

            get
            {
                return Tname;

            }
            set
            {
                Tname = value;
            }
        }
        public override string Dtime
        {

            get
            {
                return Dtime;

            }
            set
            {
                Dtime = value;
            }
        }

        public override string Ttype
        {

            get
            {
                return Ttype;

            }
            set
            {
                Ttype = value;
            }
        }

        public override string Atime
        {

            get
            {
                return Atime;

            }
            set
            {
                Atime = value;
            }
        }
        public override string Tdest
        {

            get
            {
                return Tdest;

            }
            set
            {
                Tdest = value;
            }
        }

        public override string Tsource
        {

            get
            {
                return Tsource;

            }
            set
            {
                Tsource = value;
            }
        }


         public override object this[int index]
        {

            get
            {
               return Tname;

            }

            set
            {

                if (index == 1)
                {

                    if (Tsource == "New Delhi")
                    {
                        Tname = (string)value;
                    }
                }

            }  
        } 

        public override void displayInfo()
        {

            Console.WriteLine(Tsource + Tno + Ttype + Tdest + Atime + Dtime + Tname);
        }
       } 

        class ProgMain
        {
            public static void Main(string[] args)
            {
            try
            {
                Express[] express = new Express[2];
               
                Superfast[] superfast = new Superfast[1];
                Local[] local = new Local[1];

                express[0].Tno = 12010;
                express[0].Tname = "Shatabdi";
                express[0].Tsource = "New Delhi";
                express[0].Tdest = "Mumbai";
                express[0].Atime = "14:20";
                express[0].Dtime = "14:45";
                express[0].Ttype = "Express";

                express[1].Tno = 12010;
                express[1].Tname = "Rajdhani";
                express[1].Tsource = "New Delhi";
                express[1].Tdest = "Howrah";
                express[1].Atime = "12:55";
                express[1].Dtime = "9:45";
                express[1].Ttype = "Express";

                superfast[0].Tno = 22926;
                superfast[0].Tname = "Paschim";
                superfast[0].Tsource = "Kolkata";
                superfast[0].Tdest = "Bandra";
                superfast[0].Dtime = "5.50";
                superfast[0].Atime = "10.10";
                superfast[0].Ttype = "Superfast";

                local[0].Tno = 55409;
                local[0].Tname = "Viramgam Passenger";
                local[0].Tsource = "Valsad";
                local[0].Tdest = "Viramgam";
                local[0].Atime = "10.30";
                local[0].Dtime = "5.50";
                local[0].Ttype = "Local";

                local[1].Tno = 69110;
                local[1].Tname = "Vadodara- surat";
                local[1].Tsource = "Vadodara ";
                local[1].Tdest = "Surat";
                local[1].Atime = "11.25";
                local[1].Dtime = "14.20";
                local[1].Ttype = "Local";

                string source, dest;
                source = Convert.ToString(Console.ReadLine());
                dest = Convert.ToString(Console.ReadLine());

                if (superfast[0].Tsource == source || superfast[0].Tdest == dest)
                    superfast[0].displayInfo();
                if (express[0].Tsource == source || express[0].Tdest == dest)
                    express[0].displayInfo();
                if (express[1].Tsource == source || express[1].Tdest == dest)
                    express[1].displayInfo();
                if (local[0].Tsource == source || local[0].Tdest == dest)
                    local[0].displayInfo();
                if (local[1].Tsource == source || local[1].Tdest == dest)
                    local[1].displayInfo();

            } catch (Exception e){
                Console.WriteLine( e);
            }
        }
        } 


    /*class SeqentialSearch {

        public static bool flag = false;


        public bool findKey(int[] list , int key , int size){

            Array.Sort(list);

            for (int i = 0; list[i]<=key && i<size; i ++){

                if(list[i] == key){

                    Console.WriteLine("Search found on posititon : " + (i+1));

                    flag = true;
                }
            }

            return flag;
        }

    }


    class SearchMain{


        public static void Main(string[] args){

            SeqentialSearch seqential = new SeqentialSearch();
            Console.WriteLine("Size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[size];

            Console.WriteLine("Enter Elemements");

            for (int i = 0; i < size; i++){
                
                list[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Search Element : ");
            int s = Convert.ToInt32(Console.ReadLine());
            if(seqential.findKey(list , s , size) == true){
                Console.WriteLine("Search complete !");
            }
            else{

                Console.WriteLine("No element form");
            }
        }
    } */

    /*class Lmao {

        public static void Main(string[] args){


            Console.WriteLine("Shatabdi Express  Rajdhani Express ");

            Console.WriteLine("Enter Source Station and Destination Station");
            Console.ReadLine();
            Console.ReadLine();
            Console.Write("12236 ");
            Console.Write("Rajdhani Express ");
            Console.Write(" Express ");
            Console.Write(" 12:55 9:45  New Delhi Howrah");

        }
    } */


    /* class CircularQueue
    {

        private int[] ele;
        private int front;
        private int rear;
        private int max;
        private int count;


        public CircularQueue(int size)
        {

            ele = new int[size];
            front = 0;
            rear = -1;
            max = size;
            count = 0;


        }

        public void insert(int item)
        {

            if (count == max)
            {

                Console.WriteLine("Overflow");
                return;
            }
            else
            {

                rear = (rear + 1) % max;
                ele[rear] = item;
                count++;

            }
        }

        public void delete()
        {

            if (count == 0)
            {

                Console.WriteLine("Undeflow");
                return;
            }

            else
            {

                Console.WriteLine("deleted element is " + ele[front]);

                front = (front + 1) % max;

                count--;
            }
        }

        public void showQueue()
        {

            // foreach(int x in ele){
            //
            //     Console.WriteLine(x);
            // } 

            int j = 0, i = 0;

            if(count == 0){

                Console.WriteLine("Queue is Empty");
                return;

            }
            else {

                for (i = front; j < count;)
                {

                    Console.WriteLine("Item[" + (i + 1) + "]:" + ele[i]);
                    i = (i + 1) % max;
                    j++;
                }
            }



        }

    }

    class CircularMain{

        public static void Main(string[] args){


            Console.WriteLine("Enter size");
            int size = Convert.ToInt32(Console.ReadLine());

            CircularQueue cq = new CircularQueue(size);

            cq.insert(Convert.ToInt32(Console.ReadLine()));
            cq.insert(Convert.ToInt32(Console.ReadLine()));
            cq.insert(Convert.ToInt32(Console.ReadLine()));

            cq.delete();
            cq.delete();


            Console.WriteLine("Final Queue is : ");
            cq.showQueue();


        }
    } */


    class HeapSort
    {

        private int heapSize;

        private void BuildHeap(int[] arr){

            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--){

                Heapify(arr, i);
            }
        }


        private void Heapify(int[] arr , int index){

            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if(left <= heapSize && arr[left] > arr[index]){

                largest = left;

            }

            if(right  <= heapSize && arr[right] > arr[largest]){

                largest = right;

            }

            if(largest != index){

                Swap(arr, index, largest);
                Heapify(arr, largest);

            }
        }

        private void Swap(int[] arr, int x, int y)
        {

            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;

        }

        public void performHeapSort(int[] arr)
        {

            BuildHeap(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {

                Swap(arr, 0, i);
                heapSize--;
                Heapify(arr, 0);
            }

            DisplayArray(arr);


        }

        private void DisplayArray(int[] arr){
            
            for (int i = 0; i < arr.Length; i++){

                Console.WriteLine(arr[i]);
            }
        } 

    }


    class HeapMain{

        public static void Main(string[] args){

            HeapSort heap = new HeapSort();

            int[] x = { 1, 3, 5, 10, 54, 6 ,8 ,67};

            heap.performHeapSort(x);

        }
    }
}



