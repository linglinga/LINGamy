// File: VerySimple.cs
using System;

class VerySimple //useful tool or useful object
{
    int simpleValue; //field, inside of a clas, instead of a variable. // declared here.

    public VerySimple() //constructor (as an initializer and tool, get you on the right path). it dont return anything, only access of element and same name as the class.
    // access tool: public or private. by default it is private unless you declare it public.
    {
        simpleValue = 10; // initialize the fields in the constructor. constructor is an option.
    }
    // inside of a class can have: 
    //methods (functions)
    //properties
    //another class
    //enums
}
// developers want to create the tools: above.
// end developers/tester/user that wants to test those tools: below.
// need instantiation, key, lock to access.
class TestVerySimpleClass
{
    static void Main() //entry point. // compiler starts here.
    {
        VerySimple ver; // notice that ver is null
        // ver the variable is a null object with nothing to it.
        // execute the line below.
        ver = new VerySimple(); //instantiation (give me an object of type VerySimple) creating a blue print of what you want to use.
        // after this line, complier goes to :public VerySimple() the constructor. And initialize the fields.
        // This Simple Value 0 int type.
        // initialize the field to 10.
        // must use the keyword "new". and calls on the constructor VerySimple()
    }

}