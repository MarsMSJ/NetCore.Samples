using System;
using System.Collections.Generic;
using SamplesLibrary;

namespace TourApp
{
	class Program
	{
		const int NumberOfSamples = 10;
		const int RangeMax = 10;
		static void Main(string[] args)
		{
			Intro();
			
			//Generate integer sequence, may be negative
			Console.WriteLine($"\n\nGenerating {NumberOfSamples} random integers ( -{RangeMax} to {RangeMax} ):");	
			var randomBase = new RandomBase();
			var randomNumbers = randomBase.GetNumberSequence( NumberOfSamples, RangeMax );
			PrintSequence<int>( randomNumbers );
			
			//Generate positive number sequence
			Console.WriteLine($"\n\nGenerating {NumberOfSamples} random integers ( 0 to {RangeMax} ):");	
			randomNumbers = randomBase.GetSignedNumberSequence( NumberOfSamples, 100, true );
			PrintSequence<int>( randomNumbers );
			
			//Generate negative number sequence
			Console.WriteLine($"\n\nGenerating {NumberOfSamples} random integers ( -1{RangeMax} to 0 ):");
			randomNumbers = randomBase.GetSignedNumberSequence( NumberOfSamples, 100, false);
			PrintSequence<int>( randomNumbers );
			
			//Get random strings of random length
			Console.WriteLine($"\n\nGenerating {NumberOfSamples} random strings:");			
			var strSample = new StringSample();
			var randomStrings = strSample.GetRandomStrings( 5 );
			PrintSequence<string>( randomStrings );
			
			Console.WriteLine($"\nDone...\n");
			Signature();
			
		}
		
		/*
		Region works on Visual Studio Code editors only. 
		It's nice for having stuff out of the way.
		*/
#region Console Fancy Section
		/*************************************************************************
				Don't mind me, I'm just here to make the console fancy looking. 
				
				Mars :)
		*/
		
		static Program()
        {
            DefaultForegroundConsoleColor = Console.ForegroundColor;
            DefaultBackgroundConsoleColor = Console.BackgroundColor;  
        }
        
        static void ResetConsole()
        {
            Console.ForegroundColor = DefaultForegroundConsoleColor;
            Console.BackgroundColor = DefaultBackgroundConsoleColor;
        }
        
        static void Intro()
        { 	
					Console.WriteLine(string.Empty);
					WriteCenter(fDiv);				
					ResetConsole();
					Console.WriteLine(string.Empty);					
					WriteCenter("Hello C#/GitHub World");
					WriteCenter(fHeading);
					Console.WriteLine(string.Empty);			
					WriteCenter(fDiv);					
					Console.WriteLine(string.Empty);
				}    
				
			
				
				static void Signature()
				{
					WriteCenter("Github.com/MarsMSJ");
					PrintHorizontalRainbow();	
					Console.WriteLine(string.Empty);
					
				}
       
			 static void WriteCenter(string str)
			 {
				 Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);					
				 Console.WriteLine( str );
			 }
			 
			 static void SetCursorCenter( int length )
			 {
				 Console.SetCursorPosition((Console.WindowWidth - length) / 2, Console.CursorTop);
			 }
			 
			 static void PrintHorizontalRainbow( )
			 {
				  string space = "          ";														
					SetCursorCenter( space.Length * 4 );
					BgColor = ConsoleColor.Red;
					Console.Write(space);
					BgColor = ConsoleColor.Yellow;
					Console.Write(space);
					BgColor = ConsoleColor.Green;		
					Console.Write(space);
					BgColor = ConsoleColor.Blue;
					Console.Write(space);
					
					ResetConsole();
						
			 }
        
        //Printing our sequence
        static void PrintSequence<T>( List<T> list )
        {
            int len = list.Count;
            FontColor = ConsoleColor.White;
            
            for( int i = 0; i < len; i++ )
            {
                 Console.Write($"{list[i].ToString()}");
                 
                 if( i < len - 1 )
                 {
                     Console.Write($", ");
                 }
             } 
             
            Console.Write($"\n");
            ResetConsole();
                       
        }
        static ConsoleColor FontColor { set => Console.ForegroundColor = value; }
        static ConsoleColor BgColor { set => Console.BackgroundColor = value; }
        
				static readonly string fHeading= "This is the Samples Library";
        static readonly string fDiv = "*******************************";
				//static readonly string fSpace = "                              ";
        static ConsoleColor DefaultForegroundConsoleColor;
        static ConsoleColor DefaultBackgroundConsoleColor;
        
#endregion //Console Fancy Section
	}
}
