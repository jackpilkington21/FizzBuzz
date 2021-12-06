# Fizz Buzz Challenge

## Requirements

Write a program that prints the numbers from 1 to 100.
But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
For numbers which are multiples of both three and five print "FizzBuzz".

## Development

To run the solution use the following commands
```
- cd FizzBuzz
- dotnet run
```

To execute the tests use the following commands
```
- cd FizzBuzz.Tests
- dotnet test
```

## Further improvements

1. Add a timer to start at the beginning of the run the output the time the program takes to process.
   This can be used to then compare the performance of future iterations.
2. Investigate the use of dependency injection in dotnet core console apps.
3. The processor could lose an if/else statement and append strings Fizz and Buzz together. This may
   sacrifice readability for performance.
4. Implement processor logic using LINQ.
