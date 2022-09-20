# OCP
Open closed principle.

Here are two console projects that output the same result when run.
A list of cars is being filterd and the result is printed to the console.

### ViolatingOpenClosedPrinciple
This project is structured in a way that makes it hard not to violate 
the open closed principle if the filter behvior were to be extended in the future.
Modifications are likly to be made to the existing classes.

### RespectingOpenClosedPrinciple
This projects filter behavior is structured in a way that makes it easy 
to extend without making modifications to existing classes.
This is achived using interfaces.
