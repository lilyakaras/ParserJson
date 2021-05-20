The task is to develop a utility class on C# that would parse input JSON and present it as a flat list of key-value pairs.


Utility requirements:
+ It is allowed to use any type of JSON-parsing library available in .NET;
+ The code of the utility itself should accept one string instance representing input JSON and return one Dictionary<string, string> instance representing parsed key-value pairs;
+ For the top-level JSON items the key name in the resulting set should be equal to the item name;
+ For nested JSON items the name of the key should be consisted from the name of the parent item key joined with current item name with colon (':');
+ The utility should handle exceptional cases such as having duplicate keys in JSON or malformed JSON file in general;
* The utility should make use of Encapsulation OOP principle: the caller code should not be dependent on the tool implementation in any way;
+ To test the utility class a console application should be developed. The application should accept one argument representing path to file containing JSON to parse. The output of the tool should be presented in the console.


Example of the tool input:
{
   "section1" : {
      "value1" : "x",
     "subsection1" : {
        "value2" : "y"
      }
   }
}


Example of the tool output:
"section1:value1" = "x"
"section1:subsection1:value2" = "y"
