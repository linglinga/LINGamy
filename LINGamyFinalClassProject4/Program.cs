// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
public struct ItemData
{
    //+ use to collect & keep track of a series of information, item or data.
    //+ like array collecting informaiton into enum.
    //+ useful: can create a struct to keep track of a category (person)
    //+     then create an array of the struct of (person) = create an array of boxes that contain information.
    //+ array of struct of ItemData.
    //+ struct compoents goes here. Using Public which is common. 
    //+ direct access, without instantiation, or creating an object.
    //+ value based with direct access in the memory, uses less memories, easy to access, debug.
    //+ lives inline, where the variable or field is defined.
    //+ including enum & struct. with sublet of value types: boxing (do not inherit).
    //+ intrinsic built-in values: byte 1, char2, int 4, double 8, etc.
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;

    public int NewID;
    public int mstritemID;


}   // End of Public Struct ItemData

// use constructor to hide/inditialize data.
// constructor good start to get the right ingredients.
// recommended.
// constructor does not return anything. unlike method, either void or
// constructor with a name.
// do all initializations inside {}.
//+ all const in struct is assign values.

class MyInventory       //+ close for client/user/test.
                        //+ reference types: contains a pointer
                        //+ it address is returned & the address is assigned to a reference.
                        //+ usually are objects on the heap. Which are destroyed after the stack frame they are declared within ends, as in the function ends.



{
    public static bool exitLoop;
    public static int choice;
    public static int i;
    public static int newid;
    public static int mstritemID;



    public static void Main()                                                   // method Main returns nothing.
                                                                                // compiler always starts here.
    {

        int count = 0;                                                          // use an interger to keep track of the count of items in your inventory.
                                                                                // declare & initialize the fields, assigning 0 to the field count.                                            

        ItemData[] itemData = new ItemData[10];                                 // create an array of your ItemData struct & initialize here.
                                                                                //      new = allocate & initialize.
                                                                                //      objects of the struct by using the new operator
                                                                                // [10] is the max length of the array.
                                                                                // able to reference information of struct components.


        while (exitLoop == false && choice >= 0)                                // While a never ending loop that shows the user what options they can select
                                                                                // exitLoop == false, this helps quitting when the program when user choice 5, then y.
                                                                                // if the exitLoop is same as false and Choice is greater than or equal to 0.
                                                                                // Compound Boolean Expression: && -conditional logical operators, 
                                                                                //      requires both conditions be true in order to execute the statements inside { }.
        {

            bool exitLoop = false;                                              // as long as no one Quits, continue the inventory update
                                                                                //      exitLoop is assigned to false.

            Console.Write("--- 1. ADD an item   2. CHANGE an item   3. DELETE an item   4. LIST an item     5. QUIT the program ---");
            Console.Write("\n--- Please enter a number between (1-5):   ");           // in that loop, show what user can select from the list

            bool isNumber = false;                                                      // to catch input that is not a number/int.
            int number;                                                                 // set bool isNumber to false, declare number as an int.
            while (!isNumber)                                                           // while isNumber is NOT true, the statement inside the { } will execute.
            {
                string strx = Console.ReadLine();                                       // read and store the input strx.
                if (!int.TryParse(strx, out number))                                    // TryParse method does not through an exeption if the conversion fails, wont need exception handling. 
                                                                                        //      (I'm using this method, not because I'm trying to convert anything, I can declare and assign char to values matching the switch statements, but I thought this is more error proof method.)
                                                                                        //       attempt to convert input into an int, unsucessful, then execute statements in { } below.
                {
                    Console.WriteLine();                                                // Print an empty row (for visual improvement)
                    Console.WriteLine("!!! UH-OH! Error! Input is not a number !!!");   // error message for user.
                    Console.WriteLine();                                                // Print an empty row (for visual improvement)
                    Console.WriteLine();                                                // Print an empty row (for visual improvement)
                    goto Outer;                                                         // goto statement, not a preferable way, but good for exiting very deeply nested loops.
                                                                                        // this takes you to End of while (exitLoop == false && choice >= 0) loop,
                                                                                        //      instead of if (!isNumber), which the choice selection won't prompt.
                }
                else
                {
                    int choice = int.Parse(strx);                                       // convert, parsing the strx to an int.
                    Console.WriteLine();                                                // provide an extra blank line on screen

                    switch (choice)                                                     // this is a nested switch method, based on the input, it takes you to the case it is associated with.
                    {                                                                   // exclusive statement of (choice).
                                                                                        // (choice) must match with case type.
                                                                                        // each case must have a break and a default.
                        case 1:                                                         // add an item to the list if this option is selected
                            {                                                           // begining of the case 1 statements.
                                Console.Write("Item ID number (3-digits)---------------------------------------------------#");            
                                string stritemID = Console.ReadLine();                  // ask user to enter an item ID number.
                                                                                        // read & store the input of item ID number entered as stritemID.

                                int stid;
                                while (stritemID.Length > 3 || !int.TryParse(stritemID, out stid))
                                {                                                       // if the input is more than 3 digits or to catch what is not convertable from a string to an int. (similar reason as line 91 comments.)
                                    Console.WriteLine();                                // execute these statements within { }.
                                    Console.Write("!!! UH-OH! Error! Please re-enter max of (3-digits) Item ID number----------#");
                                    stritemID = Console.ReadLine();
                                }
                                var itemID = int.Parse(stritemID);                      // convert string stritemID to Int itemID.


                                Console.Write("Item description (20 letters)------------------------------------------------");          
                                string stritemDescription = Console.ReadLine();         // ask user to enter an Item description within 20 letters, read and store input as stritemDescription.
                                                                                        // this can be 20 characters or 20 numbers. Program doesn't limit it.
                                while (stritemDescription.Length > 20)                  // if the input is longer than 20 in length.
                                {
                                    Console.WriteLine();                                // execute these statments within { }.
                                    Console.Write("!!! UH-OH! Error! Please re-enter max of 20 letters for Item description-----");
                                    stritemDescription = Console.ReadLine();
                                }
                                string itemDescription = stritemDescription;            // read & store the input of string stritemDescription entered as itemDescription.


                                Console.Write("Price per item ($)----------------------------------------------------------$");                   
                                string strpricePerItem = Console.ReadLine();            // ask user to enter an Price per item.
                                                                                        // read & store the input of Price per item entered as strpricePerItem.
                                double ppi;
                                while (!double.TryParse(strpricePerItem, out ppi))      // to catch what is not convertable from a string to an int. (similar reason as line 91 comments.)             
                                {
                                    Console.WriteLine();                                // execute these statments within { }.
                                    Console.Write("!!! UH-OH! Error! Please enter Price per Item ($)---------------------------$");
                                    strpricePerItem = Console.ReadLine();
                                }
                                Double pricePerItem = double.Parse(strpricePerItem);    // convert string strpricePerItem to doulbe pricePerItem.

                                
                                Console.Write("Quantity on hand-------------------------------------------------------------");                     
                                string strquantityOnHand = Console.ReadLine();          // ask user to enter an Quantity on hand.
                                                                                        // read & store the input of Quantity on hand entered as strquantityOnHand.
                                int qoh;
                                while (!int.TryParse(strquantityOnHand, out qoh))       // to catch what is not convertable from a string to an int. (similar reason as line 91 comments.)
                                {
                                    Console.WriteLine();                                // execute these statments within { }.
                                    Console.Write("!!! UH-OH! Error! Please enter Quantity on hand------------------------------");
                                    strquantityOnHand = Console.ReadLine();
                                }
                                int quantityOnHand = int.Parse(strquantityOnHand);      // convert string strquanityOnHand to Int quanityOnHand.


                                Console.Write("Our cost per item ($)-------------------------------------------------------$");                
                                string strourCostPerItem = Console.ReadLine();          // ask user to enter an Our cost per item.
                                
                                double ocpi;                                            // read & store the input of Price per item entered as strourCostPerItem.
                                while (!double.TryParse(strourCostPerItem, out ocpi))   // to catch what is not convertable from a string to an int. (similar reason as line 91 comments.)
                                {
                                    Console.WriteLine();                                // execute these statments within { }.
                                    Console.Write("!!! UH-OH! Error! Please enter Our cost per Item ($)------------------------$");
                                    strourCostPerItem = Console.ReadLine();         
                                }
                                Double ourCostPerItem = double.Parse(strourCostPerItem);// convert string stroutCostPerItem to Int ourCostPerItem.


                                double dblValueOfItem = pricePerItem * quantityOnHand;  // formula ValueOfItem = price * quanity on hand, print to screen.
                                Console.Write("Value of item ($)-----------------------------------------------------------${0}", dblValueOfItem);

                                Console.WriteLine();                                    // add 2 empty rows for better visual seperation.
                                Console.WriteLine();

                                                                                        // Always Add the item to the end of the array.
                                itemData[count].itemIDNo = itemID;                      // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the itemID.
                                itemData[count].sDescription = itemDescription;         // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the itemDescription.
                                itemData[count].dblPricePerItem = pricePerItem;         // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the pricePerItem.
                                itemData[count].iQuantityOnHand = quantityOnHand;       // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the quantityOnHand.
                                itemData[count].dblOurCostPerItem = ourCostPerItem;     // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the ourCostPerItem.
                                itemData[count].dblValueOfItem = dblValueOfItem;        // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the valueOfItem.

                                count++;                                                // increment the numberOfItem, so the index number will grow from 0 to 1 and 1 to 2, etc.
                                break;                                                  // switch method requires each case to have a break for exiting.
                            }   // end of case 1 array.

                        case 2: //change items in the list if this option is selected
                            {
                                while (count != 0)                                         // while there's more than 1 item in the program.                        
                                {
                                    Console.Write("Please enter an item ID No associated with the CHANGE (3-digits):-----#");
                                    string strchgid = Console.ReadLine();                  // read & store the input of item ID number entered as strchgid.
                                                                                           .
                                    int idNo;
                                    if (strchgid.Length > 3 || !int.TryParse(strchgid, out idNo))
                                    {                                                    

                                        Console.WriteLine();                                // same concept as case 1 and line 91 comments.
                                        Console.Write("!!! UH-OH! Error! Please re-enter max of (3-digits) Item ID number---#");
                                        strchgid = Console.ReadLine();
                                    }

                                    Console.WriteLine();
                                    var chgid = int.Parse(strchgid);                        // convert string stritemID to Int itemID.


                                    bool fFound = false;

                                    for (int x = 0; x < count; x++)
                                    {
                                        if (itemData[x].itemIDNo == chgid)                  // if chgid is same as itemData.itemIDNo
                                        {
                                            fFound = true;                                  // if found, then delete it.

                                            int indexToChange = 2;
                                            for (var index = indexToChange - 1; index < count; index++)
                                            {                                               // code to show what has to happen if the item in the list is found
                                                itemData[index] = itemData[index + 1];      // reset the count to show a new count for your list
                                            }
                                            count--;

                                            // all these are similar to case 1, except it the string has a different name at the beginning, 
                                            // but has the same name as the struct fields when it enters an array.

                                            Console.Write("Modify Item ID number (3-digits) to ----------------------------------------------#");            // ask user to enter an item ID number.
                                            string mstritemID = Console.ReadLine();                  // read & store the input of item ID number entered as stritemID.

                                            int mstid;
                                            while (mstritemID.Length > 3 || !int.TryParse(mstritemID, out mstid))
                                            {
                                                Console.WriteLine();
                                                Console.Write("!!! UH-OH! Error! Please re-enter max of (3-digits) Modify Item ID number to-----#");
                                                mstritemID = Console.ReadLine();
                                            }
                                            var itemID = int.Parse(mstritemID);                      // convert string stritemID to Int itemID.


                                            Console.Write("Modify Item description (20 letters) to--------------------------------------------");          // ask user to enter an Item description.
                                            string mstritemDescription = Console.ReadLine();

                                            while (mstritemDescription.Length > 20)
                                            {
                                                Console.WriteLine();
                                                Console.Write("!!! UH-OH! Error! Please re-enter max of 20 letters for Modify Item description to--");
                                                mstritemDescription = Console.ReadLine();
                                            }
                                            string itemDescription = mstritemDescription;               // read & store the input of Item description entered as itemDescription.


                                            Console.Write("Modify Price per item ($) to------------------------------------------------------$");                   // ask user to enter an Price per item.
                                            string mstrpricePerItem = Console.ReadLine();            // read & store the input of Price per item entered as strpricePerItem.

                                            double mppi;
                                            while (!double.TryParse(mstrpricePerItem, out mppi))
                                            {
                                                Console.WriteLine();
                                                Console.Write("!!! UH-OH! Error! Please enter Modify Price per Item ($) to----------------------$");
                                                mstrpricePerItem = Console.ReadLine();
                                            }
                                            Double pricePerItem = double.Parse(mstrpricePerItem);    // convert string strpricePerItem to Int pricePerItem.


                                            Console.Write("Modify Quantity on hand to---------------------------------------------------------");                     // ask user to enter an Quantity on hand.
                                            string mstrquantityOnHand = Console.ReadLine();          // read & store the input of Quantity on hand entered as strquantityOnHand.

                                            int mqoh;
                                            while (!int.TryParse(mstrquantityOnHand, out mqoh))
                                            {
                                                Console.WriteLine();
                                                Console.Write("!!! UH-OH! Error! Please enter Modify Quantity on hand to--------------------------");
                                                mstrquantityOnHand = Console.ReadLine();
                                            }
                                            int quantityOnHand = int.Parse(mstrquantityOnHand);      // convert string strquanityOnHand to Int quanityOnHand.


                                            Console.Write("Modify Our cost per item ($) to---------------------------------------------------$");                // ask user to enter an Our cost per item.
                                            string mstrourCostPerItem = Console.ReadLine();          // read & store the input of Price per item entered as strourCostPerItem.

                                            double mocpi;
                                            while (!double.TryParse(mstrourCostPerItem, out mocpi))
                                            {
                                                // not a number, handle it
                                                Console.WriteLine();
                                                Console.Write("!!! UH-OH! Error! Please enter Modify Our cost per Item ($) to--------------------$");
                                                mstrourCostPerItem = Console.ReadLine();
                                            }
                                            Double ourCostPerItem = double.Parse(mstrourCostPerItem);// convert string stroutCostPerItem to Int ourCostPerItem.


                                            double dblValueOfItem = pricePerItem * quantityOnHand;  // formula ValueOfItem = price * quanity on hand.
                                            Console.Write("Modify Value of item ($) to-------------------------------------------------------${0}", dblValueOfItem);

                                            Console.WriteLine();                                    // add 2 empty rows for better visual seperation.
                                            Console.WriteLine();

                                            // Always Add the item to the end of the array.
                                            itemData[count].itemIDNo = itemID;                      // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the itemID.
                                            itemData[count].sDescription = itemDescription;         // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the itemDescription.
                                            itemData[count].dblPricePerItem = pricePerItem;         // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the pricePerItem.
                                            itemData[count].iQuantityOnHand = quantityOnHand;       // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the quantityOnHand.
                                            itemData[count].dblOurCostPerItem = ourCostPerItem;     // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the ourCostPerItem.
                                            itemData[count].dblValueOfItem = dblValueOfItem;        // associate item's number with index number of [0]/[1]/[2]/[9]/anything less than 99, with the valueOfItem.

                                            count++;                                                // increment the numberOfItem, so the index number will grow from 0 to 1 and 1 to 2, etc.
                                        }
                                    }
                                    if (fFound)                                                     // hint the user that you deleted the requested item
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("----- Item ID {0} has been update -----", chgid);
                                        Console.WriteLine();
                                    }

                                    else                                                            // if did not find it, hint the user that you did not find it in your list
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("!!! Item {0} not found !!!", chgid);
                                        Console.WriteLine();
                                    }
                                    break;

                                }
                                if (count == 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("!!! UH-OH! You've NO inventory, it's shopping time !!!");
                                    Console.WriteLine();
                                }
                                break;
                            }

                        case 3:                                                                     //delete items in the list if this option is selected
                            {
                                while (count != 0)
                                {
                                    Console.Write("Please enter an item ID No to be deleted (3-digits):-----------------#");
                                    string strnewid = Console.ReadLine();                           // prompt user to enter the item ID to be deleted.
                                                                                                    // read & store the input of item ID number entered as stritemID.
                                    int idNo;
                                    if (strnewid.Length > 3 || !int.TryParse(strnewid, out idNo))   // if the input is more than 3 digits or to catch what is not convertable from a string to an int. (similar reason as line 91 comments.)
                                    {

                                        Console.WriteLine();                                        // execute these statments within { }.
                                        Console.Write("!!! UH-OH! Error! Please re-enter max of (3-digits) Item ID number---#");
                                        strnewid = Console.ReadLine();
                                    }

                                    Console.WriteLine();                                            // Print an empty row (for visual improvement)
                                    var newid = int.Parse(strnewid);                                // convert string stritemID to Int itemID.

                                    bool fDeleted = false;                                          // 
                                    for (int x = 0; x < count; x++)
                                    {
                                        if (itemData[x].itemIDNo == newid)                          // if the input (newid) is same as itemIDNo.
                                        {
                                            fDeleted = true;                                        // fDeleted is set to true.

                                            int indexToDelete = 2;                                  
                                            for (var index = indexToDelete - 1; index < count; index++)
                                            {
                                                itemData[index] = itemData[index + 1];              // copy the next structure into the current struct
                                            }                                                       // reset the count to show a new count for your list
                                            count--;                                                // now it had been reduced by one item
                                        }
                                    }                                                               
                                    if (fDeleted)                                                   // hint the user that you deleted the requested item
                                    {
                                        Console.WriteLine();                                        // Print an empty row (for visual improvement)
                                        Console.WriteLine("----- Item {0} deleted -----", newid);   // execute statemnets in { }.
                                        Console.WriteLine();
                                    }

                                    else // if did not find it, hint the user that you did not find it in your list
                                    {
                                        Console.WriteLine();                                         // Print an empty row(for visual improvement)
                                        Console.WriteLine("!!! Item {0} not found !!!", newid);      // Error message for user.
                                        Console.WriteLine();
                                    }
                                    break;                                                           // break from if else statements.

                                }
                                if (count == 0)                                                       // if there are no items in the program
                                {
                                    Console.WriteLine();                                             // Print an empty row(for visual improvement)
                                    Console.WriteLine("!!! UH-OH! You've NO inventory, it's shopping time !!!");
                                    Console.WriteLine();                                             
                                }
                                break;                                                              // breaks from case 3. back to top of while (exitLoop == false && choice >= 0) loop.
                            }

                        case 4:                                                                     //list all items in current database if this option is selected
                            {                      
                                if (count == 0)                                                     // if there are no items in the program
                                {
                                    Console.WriteLine();                                            // Print an empty row(for visual improvement)
                                    Console.WriteLine("!!! UH-OH! You've NO inventory, it's shopping time !!!");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine(" Item#    ItemID  Description           Price  QOH  Cost  Value");
                                    Console.WriteLine("------  --------  --------------------  -----  ---  ----  -----");

                                    for (int index = 0; index < count; index++)
                                    {
                                        Console.WriteLine(" {0,5}     {1,5}  {2,-20}  {3,-4}  {4,-3}  {5,-4}  {6,-4}", index + 1, itemData[index].itemIDNo, itemData[index].sDescription, itemData[index].dblPricePerItem, itemData[index].iQuantityOnHand, itemData[index].dblOurCostPerItem, itemData[index].dblValueOfItem);
                                    }                                                                // print using this format.
                                }
                                break;                                                               // breaks from case 4. back to top of while (exitLoop == false && choice >= 0) loop.
                            }




                        case 5:                                                                         //quit the program if this option is selected
                            {
                                Console.Write("??? Really? Are you sure that you want to QUIT (y/n) ???     ");
                                                                                                        // prompt user for verification of the quit command.
                                if (Console.ReadLine().ToLower().Equals("y") == false)                  // convert all uppercasses to lower casses and if the input is not y, execute the {}.
                                {
                                    choice = 0;                                                         // 0 is assigned to choice.
                                }
                                else
                                {
                                    Console.WriteLine("! OKAY! Program exiting, GOODBYE !");            // if the above statement is true, then print exit message.
                                    exitLoop = true;                                                    // assign exitLoop as true, to exit both the switch & while loop.
                                }
                                break;                                                                  // exit out of case 5's if, else options.
                            }

                        default:                                                                        // required for switch statement, for input that does not match any of the above cases.
                            {
                                Console.WriteLine();                                                     // Print an empty row.
                                Console.Write("!!! UH-OH! Invalid Option, try again !!!");              // display error message.
                                Console.WriteLine();                                                    // Print an empty row.
                                Console.WriteLine();
                                break;                                                                  // exit this default case, return to top of while loop.
                            }

                    }   // End of Switch (choice)

                    if (exitLoop == true)                                                               // if the exitLoop is equal to true
                    {
                        break;                                                                          // then break outside of this if loop.
                    }
                    else
                    {
                        Console.WriteLine();                                                            // print an empty row.
                        continue;                                                                       // if the exitLoop condition is false, then continue, will take you back to beginning of while loop.
                    }   // End of if, else (exitLoop == true) statements.


                }   // End of if, else (!int.TryParse(strx, out number)) statement.

            }   // End of if (!isNumber) statment
            Outer:
            continue;




        } // End of while (exitLoop == false && choice >= 0) loop


    }   // End of Public Static Void Main

}   // End of class MyInventory