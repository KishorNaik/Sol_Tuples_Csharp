using System;

namespace Sol_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            (String firstName,String lastName) tuplesUserObj=(
                firstName:"Kishor",
                lastName:"Naik"

            );

            Console.WriteLine(tuplesUserObj.firstName);
            Console.WriteLine(tuplesUserObj.lastName);


            var userCommunicationObj=(emailId : "kishor.naik011.net@gmail.com", mobileNo: "0101010101");
                Console.WriteLine(userCommunicationObj.emailId);
                Console.WriteLine(userCommunicationObj.mobileNo);

            
            // Set Value
            var tuplesDemoObj=new TuplesDemo();
                tuplesDemoObj.SetValues((

                    firstName:"Kishor",
                    lastName:"naik"
                ));

            // Get Values
            var tupleUserObj1=tuplesDemoObj.GetValues();
                Console.WriteLine(tupleUserObj1.firstName);
                Console.WriteLine(tupleUserObj1.lastName);



        }
    }

    public class TuplesDemo{

        // Tuples as Parameter
        public void SetValues((string firstName,string lastName) tuplesUserObj)
        {
            Console.WriteLine(tuplesUserObj.firstName);
            Console.WriteLine(tuplesUserObj.lastName);
        }

        // Tuples as Return Type
        public (String firstName,String lastName) GetValues(){

            var tuplesUserObj=(

                    firstName:"Kishor",
                    lastName:"Naik"
            );

            return tuplesUserObj;

        }

    }
}
