//Assignment #6

//Copy this block into your Visual Studio.

// Review and Redo this code line by line at home.  

// Place comments on each line and describe what the code is doing


// program of struct
// array. 
// let user add, delete and list.
using System;

namespace ConsoleApplication1
{
    public struct Pet                       // structure looks like a mini class. Use to collect & keep of a series of information, item or data.
                                            // create an array of strcut of (pet)
    {                                       // define the struct components here using Public which is common in struct.
        public string Name;                 // these components/struct elements provides direct access, without instantiation, or creating an object.
        public string TypeOfPet;            // it is value based with direct access in the memory, uses less memories, easy to access, debug.
    }

    class Program                           // This is the class for the User/Client/Tester.
    {
        static void Main()                  //1. complier starts here.
                                            // Method: returns something. (this case it returns voild, nothing)

        {
            var numberOfPets = 0;           //2.
                                            // outside of the loop acess
                                            // declare & initialize the fields.
                                            // assigning 0 to the numberOfPets.
                                            // implicit type var, declared at method scope.
                                            // var is used for storing a reference to an object of an anonymous type, because the name cannot be known in advance.
                                            // C# has a built in function to determine automatically the type of hte variable based on teh expression it is assigned to.
                                            // beaware, the variable is stor in static, so you can't simply use "new" to reasign it to another type of variable afterwards.
                                            // a local type.

            var pets = new Pet[10];         //3.
                                            // declaration of the array.
                                            // creates a space in the memory with 10 spots reserved, 10 is max.
                                            // complier will determine the explicit type of the variable based on usage.
                                            // this gives the variable of type Pet.
                                            // the keyword new is to call on its constructor.
                                            // new = allocate an inititialize.


            while (true)                    //4.    //J.from case A & a.    //X. from case D & d.   //O. from case L & l.     //.default break will take you here also.
                                            // looping.
                                            // while loop must have: while, if statements, breaks, continue & incrementor.
                                            // (true) is the condition, while the condition is true.
                                            // the following will run and keep going and looping.
            {
                Console.Write("A)dd D)elete L)ist pets:");
                //5.
                // ask the user to enter A for add, D for delete, L for list pets.
                var choice = Console.ReadLine();
                //6.
                // read and store the input from the user to choice.

                switch (choice)             //7.
                                            // nested switch inside a while loop.
                                            // switch statment: a C# exclusive tool.
                                            // switch is a type, must be an integer, string or 1 char type.
                                            // exclusive statement of (choice).
                                            // (choice) must match with case type.
                                            // each case must have a break and a default.
                                            // takes you into the choices/cases the user has selected.

                {                           // list all cases within brackets.
                    case "A":
                    case "a":               // the choice A or a are combined with only 1 brackets and break.
                                            // both will lead complier to generate the items within the brackets below.
                        {
                            Console.Write("Name :");                //A.
                                                                    // ask user to enter a Name.
                            var name = Console.ReadLine();          //B.
                                                                    // read and store the input of Name entered as name.

                            Console.Write("Type of pet :");         //C.
                                                                    // ask the user to enter the Type of pet.
                            var typeOfPet = Console.ReadLine();     //D.
                                                                    // read and store the input of Type of pet as typeOfPet

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;         //E. associate pet's number [0]/[1]/[5]/[9]/anything less than 9, with the pet's name. (
                            pets[numberOfPets].TypeOfPet = typeOfPet;
                                                                    //F. associate pet's number [0]/[1]/[5]/[9]/anything less than 9, with the pet's type.

                            numberOfPets++;                         //G. incrementor of numberOfPets, so if the last pet number was 0, the next one will be 1.
                            break;                                  //H. each case must have a break to exit.
                                                                    // 
                        }       // end of case A/a array.

                    case "D":
                    case "d":               // the choice D or d, both will lead complier to generate the items within the brackets below.
                        {
                            if (numberOfPets == 0)                  // A.
                                                                    // boolean statment: result in true/false result.
                                                                    // if numberOfPets is same as 0 = true, then the following will run.
                                                                    // if false, then it will skip the brackets below, and jump to the next statment.
                            {
                                Console.WriteLine("No pets");       // this will only execute if the above if statement is true.
                                                                    // console will write on the screen, "No pets".                                break;
                            }   // end of if loop

                            for (var index = 0; index < numberOfPets; index++)  // this for loop makes a list of all the pets & their info.
                            
                            // this for statement will only execute if the above if statement is false. 
                            // statements: (initialize; condition; incrementor)
                            // do not skip incrementer in for loop, unlike while loop.
                            // B. initializer: var index = 0;
                            // C. condition: check boolean condition: index < numberOfPets;
                            //      execute statements below:
                            // E. iterator: incremeter: index++; 0+1        //H.
                            // F. check condition: index < numberOfPets;    //I. If conditin is not met, do not execute statement below.
                            //       execute statements below:

                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                                // this prints the pets info.
                                // D.   //G.
                                // Console reports the information onto the screen.
                                // {0}: to show index number of pets. (index +1)
                                // {1, -10}: show pets[index].Name with 1 empty space on the left, followed by 10 spaces for the pet's name or type, left justify.
                                // {2}: show pets[index].TypeOfPet.
                            }   // end of for loop 1.

                            Console.Write("Which pet to remove (1-{0})", numberOfPets);
                            // console ask "Which pet to remove", with the (1-{however many pet index number per pet has been entered}).
                            // J. if condition was not met. This execute.

                            var petNumberToDelete = Console.ReadLine();         // console read the input number and store it to petNumberToDelete
                                                                                // K.
                            var indexToDelete = int.Parse(petNumberToDelete);   // convert the string input number to an integer and store it to indexToDelete.
                                                                                // L.

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)  // this for loop runs through the array to delete.
                            // M. Initializer: indexToDelete - 1 is assigned to index.
                            // N. Condition: index < numberOfPets   //Q.    //.T
                            //      execute the statement below     //  if condition does not met requirement, do not execute statement in brackets.
                            // P. Iterator: index++                 //S.
                            
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];      // O. //R.  keep going until the above conditions are not true.
                            }   // end of for loop 2.

                            // We have one less pet
                            numberOfPets--;                         //U.

                            break;                                  //V. back to top of while loop.
                        }       // end of case D/d nested for loop/.

                    case "L":
                    case "l":           // the choice L or l, both will lead complier to generate the items within the brackets below.
                        {
                            if (numberOfPets == 0)              //A. is the numberOfPets same as 0? boolean type.
                            {
                                Console.WriteLine("No pets");   // if it is then No Pets will be printed on the screen.
                            }   // end of if statement

                            for (int index = 0; index < numberOfPets; index++)      // this for loop makes the index list of the pets with their info.
                                                                                    // if it is not, then these conditions will be checked.
                                                                                    // B. initializer: int index = 0;
                                                                                    // C. condition: index < numberOfPets;      //F.    //I.    //L. if condition is not met, do not execute statement in brackets.
                                                                                    //      statements below in brackets.
                                                                                    // E. Iterator: index++ incrementor.        //H.    //K.
                                                                                    

                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                                // D. run this if above 1 & 2 conditions are okay.      //G.    //J.
                                // print to the screen 
                                // {0}: pet's index number. (index +1)
                                // {1, -10}: show pets[index].Name with 1 empty space on the left, followed by 10 spaces for the pet's name or type, left justify.
                                // {2}: the type of pet from index.

                            }   // end of for loop (L/l)

                            break;                                                  // M.   
                        }       // end of case L/l.
                    default:        // switch statements must have a default. 
                                    // for cases that does not match the above conditions/statments.
                                    // default must happen and the following Line will be generated on the screen.
                        {
                            // it will say "Invalid option {whatever the user entered (choice) goes within these brackets}"
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;  // to exit, back to top of while loop.

                        }       // end of default
                }   // end of switch statment
            }       // end of while loop   //will return to top of while loop.     //I.     //W.    //N.
        }           // end of main
    }               // end of class
}                   // end of console app.
