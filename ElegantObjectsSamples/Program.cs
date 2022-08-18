// See https://aka.ms/new-console-template for more information
using ElegantObjectsSamples._2_6_be_immutable;

RunBeImmutableExperimentWithDictionary261();


static void RunBeImmutableExperimentWithDictionary261()
{
    Console.WriteLine("2.6.1 Identity mutability");

    Cash five = new(5);
    Cash ten = new(10);

    Dictionary<Cash, string> map = new(new CashEqualityComparer());

    Console.WriteLine("Now I will try to add Cash five 2 times");
    try
    {
        map.Add(five, "five");
        map.Add(five, "five");
    }
    catch
    {
        map.Remove(five);
        Console.WriteLine("Exception: Adding 2 times five doesn't work");
    }

    Console.WriteLine("Now I am adding five and ten");

    map.Add(five, "five");
    map.Add(ten, "ten");

    Console.WriteLine(string.Empty);
    Console.WriteLine("Following are added: ");

    map.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);

    Console.WriteLine(string.Empty);
    Console.WriteLine("Now I am going to change the state of five and make it equal to 10");
    five.Multiply(2);

    Console.WriteLine(string.Empty);
    Console.WriteLine("I have the following states now in dictionary: ");
    map.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);


    Console.WriteLine(string.Empty);
    Console.WriteLine("Now I will try to get five from the dictionary, lets see what it returns:");
    map.TryGetValue(five, out string value);
    Console.WriteLine(value);

    Console.WriteLine(string.Empty);
    Console.WriteLine("Now I ended pup having 2 equal key objects in dictionary. This is because my class is mutable and Dictionary can't control it after it is added.");
}