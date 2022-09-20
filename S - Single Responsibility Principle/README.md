# SRP
Single responsibility principle.

Here are two console projects that output the same result when run.
A book gets its content printed to the console.

### ViolatingSingleResponsibilityPrinciple
The book class in this project is violating the single responsibility principle by providing a "print to console" method.
Printing is not a feature of a book, so the responsibility should not be on the book class itself., but on a separate class
that can either accept the book or its contents as an argument.

### RespectingSingleResponsibilityPrinciple
The book class in this project is respecting the single responsibility principle by only containing properties and methods
that are relateable. The printing is handled by a seperate class and method which takes in the books content as an argument.
Both the book and the printer class has but only one clear responsibility. 
