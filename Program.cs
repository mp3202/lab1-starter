// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// CIDM 3312 Lab 1: Review of Lists and Methods
// Read README.md for instructions. IN VS Code, press Ctrl+Shift+V or Cmd+Shift+V to preview the README.md file

// Task 1: Create a new, empty list of strings here.
List<string> list1 = new List<string>();

// Task 2: Add 3 strings to your list - their values can be anything.
list1.Add("first");
list1.Add("second");
list1.Add("third");

// Task 3: Iterate or loop through your list with a foreach loop printing each element to the console.
foreach (string i in list1)
{
    Console.WriteLine(i);
}

// Task 4: Save and run your program with dotnet run.
// Push your changes to github.
// Check github.com and see if your changes are in the repository online

// Task 5: Write code that checks if your list contains a specific string. If it does, remove it from your list.
// Display a message to the console stating that the specific string was removed from the list 
// or it was not removed from the list.
// Test this code with a string that exists in your list and a string that does not exist in your list.
if (list1.Contains("second")) {
    list1.Remove("second");
    Console.WriteLine("You have a 'second' entry. This entry has been removed.");

    } else {
    Console.WriteLine("You don't have a 'second' element, so nothing will be removed.");
}

if (list1.Contains("fourth")) {
    Console.WriteLine("You have a 'fourth' entry");
    list1.Remove("fourth");
    Console.WriteLine("This entry has been removed.");

    } else {
    Console.WriteLine("You don't have a 'fourth' element, so nothing will be removed.");
}

// Task 6: Clear the list and verify that it is cleared by printing out its Count to the console
list1.Clear();
Console.WriteLine($"list1 has {list1.Count()} elements");

// Task 7: Save and run your program. Answer the questions in README.md. You can modify README.md directly
// from inside VS Code. Put your name at the top of the README.md file


// Task 8: Push your changes to GitHub and verify that they are uploaded


// Congratulations. You just completed your first lab exercise and practiced lists and git. Good work.   