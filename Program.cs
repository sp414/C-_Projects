// Program Name : Speeding Ticket Application
// Program Purpose : determine the fine on campus 
// Program Author : Sanketkumar Arvindbhai Patel
// Program start Date :  2021-03-26 
// Program End Date : 2021-03-31

using System;

namespace ParkingTicket
{
    class Program
    { 
        static void Main(string[] args)
        {
            // declare the variable 
            int speedreported,speedlimit;
            char yrInSchool;
            string studentnum;
            
            // Get the input from the user 
            Console.WriteLine("Enter Student Number: ");
            studentnum = Console.ReadLine();
            Console.WriteLine("Enter the Speed Limit: ");
            speedlimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ticketed Speed: ");
            speedreported = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Classification: \n\tFreshmen <enter 1>\n\tSophomore <enter 2>\n\tJunior <enter 3>\n\tSenior <enter 4> ");
            yrInSchool = Convert.ToChar(Console.ReadLine());

            //call to class
         
            var classification =new ReturnClassification(yrInSchool); 
            var setfine = new SetFine (speedlimit,speedreported,classification.stclass); 
           
           // Ticket APP Get the data from user input and Show final Fine price
         
            Console.WriteLine("\t Ticket App \n");
            Console.WriteLine("Student Number:" + studentnum);
            Console.WriteLine("Classification:"+ classification.stclass);
            Console.WriteLine("Speed:" + speedlimit);
            Console.WriteLine("Reported Speed:" + speedreported);


            Console.WriteLine($"\n\n Fine: {setfine.fine1}"); 
         
              
        }
        
         // Create a class with get set method 
        public class ReturnClassification
    {
        
        public String stclass { get; set;} 
        
          //call the method 
        public ReturnClassification(char yrinschool){

            // Logical calculation of classification
             if(yrinschool.Equals('4'))
             {
                this.stclass = "Seniors";
            }
            else
            {
                if(yrinschool.Equals('3'))
                {
                    this.stclass= "Juniors";
          
                }
                else
                    {
                    if(yrinschool.Equals('2'))
                    {
                        this.stclass = "Sophomores";
                    }
                    else{
                        this.stclass = "Freshmen"; 
                    }
                }
            }
            
        }
    }
 
        // create a class for setfine 
        
        public class SetFine
    {
        //Declare Variables
        public double fine1 { get; set;}
        
        // Fine logical calculation 
        public SetFine(int slimit, int sreported, String classification)
        {
            int speed; //Variable Declaraition 
            speed = sreported - slimit; //Calculation Based on Question
      
            double fine = speed/5*87.50 +75; //Calculation Based on Question
            
            //if else logical calculation for student fine 
            if(classification=="Seniors"){
                if(speed>20)
                {
                    fine=fine+200;
                }
                else
                {
                    fine=fine+50;
                }
            }
            else{
                if(classification=="Freshmen"){
                    if(speed<20)
                    {
                        fine=fine-50;
                      
                    }
                    else
                    {
                        fine=fine+100;
                    }

                }
                else{
                    if(speed>19)
                    {
                        fine=fine+100;
                    }
                }
            }
            
            this.fine1 = fine;
            
        }
    }
        

        
    }
}

