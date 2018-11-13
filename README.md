# StringRandomizer
A simple .NET Random String Generator library. Greate for generating OTP.

[![Build Status](https://dev.azure.com/sarthak-github/StringRandomizer/_apis/build/status/sarthakmahapatra.StringRandomizer)](https://dev.azure.com/sarthak-github/StringRandomizer/_build/latest?definitionId=1) [![NuGet Badge](https://buildstats.info/nuget/StringRandomizer?includePreReleases=true)](https://www.nuget.org/packages/StringRandomizer/)

# Samples

Randomizer by default creates a string with numbers and upper characters of length 10

Basic use,

```C#
var randomizer = new Randomizer();
var result = randomizer.Next();
Console.WriteLine(result);  
```
```Console
Output
----------
KI1677784H
```


Generating strings with lower and upper characters of length 6.


```C#
var randomizer = new Randomizer(6, new DefaultRandomizerOptions(hasNumbers: false, hasLowerAlphabets: true, hasUpperAlphabets: true));
var result = randomizer.Next();
Console.WriteLine(result);  
```
```Console
Output
------
meAoQH
```


Generate 10000 unique non-repeating string of length 5. All the strings will be stored locally. You can use  `DefaultRandomizerStore` or create your own store by implementing `IRandomizerStore`.


```C#
var randomizer = new Randomizer(5, store: new DefaultRandomizerStore());
int i = 0;

while (i < 10000)
{
    Console.WriteLine(randomizer.Next());  
    i++;
}
```


Generate 10000 unique non-repeating string of length 4 with numbers and lower characters.


```C#
var randomizer = new Randomizer(4, new DefaultRandomizerOptions(hasNumbers: true, hasLowerAlphabets: true, hasUpperAlphabets: false),  new DefaultRandomizerStore());

int i = 0;

while (i < 10000)
{
    Console.WriteLine(randomizer.Next());  
    i++;
}
```
