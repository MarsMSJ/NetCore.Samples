
#.NET Core 2.0 Samples Library

This is a library containing code to help with generating samples for input into your algorithms and data structures.  The library was written in C# using the .Net core 2.0 framework. The RNG crypto service provider is used as the base generator. Use this library to generate random numbers, number sequences, characters, and strings. Tests (xUnit) are included. This is still a work in progress.

## Getting Started

### Prerequisities

In order to build and run this code you'll need the .NET core CLI tools. Head over to Microsoft's .Net core web site and install on your OS of choice.

* [Microsoft .NET and C#] (https://www.microsoft.com/net/core#macos) Required to build and run this code.

### Installing

First we need to clone the project directory to your workstation

```
git clone https://github.com/MarsMSJ/NetCore.Samples.git
```

Second, we need to restore the packages needed to build this project.
```
dotnet restore
```

Lastly, lets build and run the code with the provided driver program.
```
dotnet run
```

## Unit Test

The following test are include:

#### RandomBase 
- Test for all functions

To run the unit tests simply type the following in the terminal:
```
dotnet test SamplesLibrary-test/*.csproj
```


## Deployment

Use the following command to publish.
```
dotnet publish
```

Located dll file in the publish directory in the bin/debug folder. To add the library as a dependency to another project simple type the following in the terminal from your app's directory:
```
dotnet add YourApp/Project.csproj reference SamplesLibrary/*.csproj
```

Then in add the following line to the top of your code:
```
using SamplesLibrary
```

Code away!
```
//Get 100 random strings of random length
var strSample = new StringSample();
var randomStrings = strSample.GetRandomStrings( 100 );

foreach( var str in randomStrings )
{
	Console.WriteLine( $"\nRandom string: {str}" );
	
	//Pick random character
	Console.WriteLine( $"Has character { strSample.GetRandomCharFromString( str ) }" );
	
	
}
```



## Contributing
Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

### To Do:
* Matrix Samples
* Random char Strings
* Random words,
* Word Shifts 
* Palindromes
* Much more unit test


## Versioning

I use [SemVer](http://semver.org/) for versioning. 

