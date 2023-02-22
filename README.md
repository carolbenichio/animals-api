## Animals API 🦁🦓🐵

In this project, we sought the concepts of object orientation, code reuse, clean code and understanding the architecture of a .NET project.

This solution contains two projects:

- Api -> Animals.Api
- Commons -> Animals.Commons

For this challenge, we created a controller that has the purpose of returning a list of 20 different animals, each one with its characteristics.
Let's return the following animals and their particularities:

--------------------------------
Animal *Dog*

Properties:
- Name
- Color
- Age
- Size (small, medium, big)
- Breed

--------------------------------
Animal *Cat*

Properties: 
- Name
- Color
- Age
- Size (small, medium, big)
- HairType

--------------------------------
Animal *Horse*

Properties:
- Name
- Color
- Age
- Size (small, medium, big)

--------------------------------
Animal *Bird*

Properties:
- Color
- Size (small, medium, big)
- WingSize (small, medium, big)
- FlightSpeed
--------------------------------

1. As the project is made in net6, it made sense to understand its nuances and adapt the project to the standards adopted in this version. An example would be namespace encapsulation which is no longer required.

2. The first challenge requested the creation of animals randomly, in your solution you used the class constructor for this construction. As a refactoring point, I believe that implementing a creational-type design pattern would be ideal for creating instances of these animals.

3. Today the solution only contains a GET method that is responsible for creating and returning the animals, I believe we can improve this dynamic, for that I propose the creation of a POST with the following characteristics:

- The endpoint receives as input 1 or N types of animals and the quantity to be generated.
- It must generate the number of animals requested and store it in memory on a map using a UUID as a key.
- With each new request on the endpoint to generate the list of animals, it increments the map, including a new list of animals.

Example:

```
{

   "ID1": [animal1, animal2],
   "ID2": [animal1, animal2, animal3]
   ...
}
```

- "Get all" returns a list containing each previously stored animal list:


```
{
 [
   {
      id: "abc",
      animals: [animal1, animal2],
   },
   {
      id: "xyz",
      animals: [animal1, animal2, animal3],
   }
   {...}
 ]
}
```

- "Get by Id" returns a list of animals filtered by the ID generated in the POST.

<hr>

Hot to use it?

- POST
Feel free to use Postman or Insomnia! Make sure to send your JSON to ```http://localhost:5040/animals```.


```
{
  "types": ["cat", "dog"],
	"quantity": 5	
}
``` 

- GET
Output at ```http://localhost:5040/animals```

![image](https://user-images.githubusercontent.com/78769105/220753905-e33cba7f-b6ae-483c-8ccc-0051c7685034.png)

Any feedback is welcome!
Thanks! 😻
