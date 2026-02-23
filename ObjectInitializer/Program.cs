using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    //create a class called "Student" with 3 data members called "studentid", "studentname" and "marks"
    class Student
    {
        //data members or instance variables or non static variables or Fileds 
        public int studentid;
        public string studentname;
        public int marks;
        public Student()//This is the constructor.it is used to assign the data to instance variables. 
        {
            //This is the userdefined default constructor.it doesnot contain parameteres.
        }
        public void DisplayData()
        {
            Console.WriteLine("I am displaying Data");
        }

    }
//***To see the project path (goto project name in solution explorer window=>RightClick=>OpenInFileExplorer.
//Second way is open the file hover on the mouse on Filename(it will show the where the project is located.)
    internal class Program
    {
        static void Main(string[] args)
        {
            //****normal way of accessing the class variables and methods*****
            Student studentObj=new Student();
            studentObj.DisplayData();//calling the student method here.
            studentObj.studentid = 1;//assign the data to the varibales
            studentObj.studentname = "JNTU";
            studentObj.marks = 100;

            //********************second way of passing the data to class while creating the object*****
            //create 3 objects of "Student" type
            //syntax of creating object initializer.
//Syntax:classname obj=new classname(){datamember1=value,datamember2=value,datamember3=value}
//========================================================================================================
            Student s1 = new Student() { studentid = 101, studentname = "Scott", marks = 70 };
            Student s2 = new Student() { studentid = 102, studentname = "Allen", marks = 80 };
            Student s3 = new Student() { studentid = 103 };//i want to pass data to only one variable for that purpose you can pass this way.
            Student s4=new Student() { studentid=105,studentname="raju",marks=100};
            Console.WriteLine("=======================All Details Printing Here====================");
            //get data from first object
            System.Console.WriteLine("First student:");
            System.Console.WriteLine("Student ID: " + s1.studentid);
            System.Console.WriteLine("Student Name: " + s1.studentname);
            System.Console.WriteLine("Marks: " + s1.marks);
            System.Console.WriteLine("---------------------------------------");

            //get data from second object
            System.Console.WriteLine("Second student:");
            System.Console.WriteLine("Student ID: " + s2.studentid);
            System.Console.WriteLine("Student Name: " + s2.studentname);
            System.Console.WriteLine("Marks: " + s2.marks);
            System.Console.WriteLine("---------------------------------------");

            //get data from third object
            System.Console.WriteLine("Third student:");
            System.Console.WriteLine("Student ID: " + s3.studentid);
            System.Console.WriteLine("Student Name: " + s3.studentname);
            System.Console.WriteLine("Marks: " + s3.marks);
            System.Console.WriteLine("---------------------------------------");

            //get data from Fourth object
            System.Console.WriteLine("Fourth student:");
            System.Console.WriteLine("Student ID: " + s4.studentid);
            System.Console.WriteLine("Student Name: " + s4.studentname);
            System.Console.WriteLine("Marks: " + s4.marks);
            System.Console.WriteLine("---------------------------------------");



            System.Console.ReadKey();
        }
    }
}
