for (int i = 1; i<=100; i++){
    bool divisibleByThree = i%3 == 0;
    bool divisibleByFive = i%5 == 0;
    if (divisibleByThree && divisibleByFive) {
        Console.WriteLine("fizzbuzz");
    } else if (divisibleByFive) {
        Console.WriteLine("buzz");
    } else if (divisibleByThree) {
        Console.WriteLine("fizz");
    } else {
        Console.WriteLine(i);
    }
}

// int i = 1;
// while (i < 255) {
//     i++;
//     Console.WriteLine(i);
// }