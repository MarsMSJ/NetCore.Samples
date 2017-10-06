using System;
using System.Collections.Generic;
using SamplesLibrary;

namespace TourApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Intro();
			
			//Generate 10 random numbers between -100 and 100
			Console.WriteLine("\n\nGenerating 10 random integers ( -100 to 100 ):");	
			var randomBase = new RandomBase();
			var randomNumbers = randomBase.GetNumberSequence( 10, 100 );
			PrintSequence<int>( randomNumbers );
			
			//Generate 10 random numbers between -100 and 100
			Console.WriteLine("\n\nGenerating 10 random positive integers ( 0 to 100 ):");	
			randomNumbers = randomBase.GetSignedNumberSequence( 10, 100, true );
			PrintSequence<int>( randomNumbers );
			
			//Generate 10 random numbers between -100 and 100
			Console.WriteLine("\n\nGenerating 10 random integers ( -100 to 0 ):");
			randomNumbers = randomBase.GetSignedNumberSequence( 10, 100, false);
			PrintSequence<int>( randomNumbers );
			
			//Get 5 random strings of random length
			Console.WriteLine("\n\nGenerating 5 random strings:");			
			var strSample = new StringSample();
			var randomStrings = strSample.GetRandomStrings( 5 );
			PrintSequence<string>( randomStrings );
			
			Outro();
			
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
					PrintHorizontalRainbow();	
					Console.WriteLine(string.Empty);
					WriteCenter(fDiv);				
					ResetConsole();
					Console.WriteLine(string.Empty);					
					WriteCenter("Hello C#/GitHub World");
					WriteCenter(fHeading);
					Console.WriteLine(string.Empty);			
					WriteCenter(fDiv);	
					PrintHorizontalRainbow();	
					Console.WriteLine(string.Empty);
        }    
				
				static void Outro()
				{
					Console.WriteLine($"\nDone.\n{fDiv}");
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
