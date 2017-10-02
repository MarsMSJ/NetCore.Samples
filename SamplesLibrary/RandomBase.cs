using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SamplesLibrary
{    
    public class RandomBase
    {
        //RNG Provider
        static RNGCryptoServiceProvider RNGCSP;
                
        public RandomBase()
        {
            if( RNGCSP == null )
            {
                RNGCSP = new RNGCryptoServiceProvider();
            }
        }
        
        //Call this at the end of your program.
        //All classes share this static crypto generator.
        public void Dispose()
        {
            if( RNGCSP != null )
            {
                RNGCSP = new RNGCryptoServiceProvider();
            }
        }
        

        /*************************************************************************
            Random Numbers    
        
            public int32 GetInt32()  // *Can return negative values
            public int32 GetPosInt32()
            public int32 GetNegInt32()
        */
        
        //Note* Can be Negative
        public int GetInt()
        {
            var randomBytes = new byte[4];
            RNGCSP.GetBytes( randomBytes );
            return BitConverter.ToInt32( randomBytes, 0 );
        }
        
        public int GetPosInt()
        {
            int randomNumber = GetInt();
            return ( randomNumber < 0 ) ? randomNumber * -1 : randomNumber;
        }
        
        public int GetNegInt()
        {
            int randomNumber = GetInt();
            return ( randomNumber > 0 ) ? randomNumber * -1 : randomNumber;
        }
       
       //Returns a random number that may be negative
       public List<int> GetNumberSequence(int count = 10 )
       {
           if( count < 1 )
           {
               throw new ArgumentException($"Bad Parameter ( < 1 ):{count}");
           }
           
           var list = new List<int>();
           
           while( list.Count < count )
           {
               list.Add( GetInt() );
           }
           
           return list;
           
       }
       
       //Returns either a positive or negative number sequence depending on 
       //the positive parameter
       public List<int> GetSignedNumberSequence(int count = 10, bool positive = true )
       {
           if( count < 1 )
           {
               throw new ArgumentException($"Bad Parameter ( < 1 ):{count}");
           }
           
           var list = new List<int>();
           
           while( list.Count < count )
           {
                list.Add( ( positive ) ? GetPosInt() : GetNegInt() );
           }
           
           return list;          
       }
        
        /*************************************************************************
            Random Characters
            
            public char GetRandomChar()
            public char GetRandomCharUpper() 
            public char GetRandomCharLower() 
        */ 
        
        //ASCII
        public char GetRandomChar()
        {
            //Random number between 1 and 10
            int randomNumber = GetPosInt() % 10 + 1;
            
            //Should this be and upper char?
           return ( YesOrNo() ) ? GetRandomCharUpper() : GetRandomCharLower();
            
        }
        
        public char GetRandomCharUpper()
        {
            return (char)(GetPosInt() % 25 + 65);
        }
        
        public char GetRandomCharLower()
        {
            return (char)(GetPosInt() % 25 + 97);
        }
        
        /*************************************************************************
            Random Yes or No
            
            // Probability: True 1/2, Odd 1/2
            public bool YesOrNo()   
        */   
            
        // Random bool
        public bool YesOrNo()
        {
            //Random number between 1 and 10
            int randomNumber =  GetPosInt() % 10 + 1;
            //Return true if number is even
            //otherwise return odd.
            // Probability: True 1/2, Odd 1/2
            return randomNumber % 2 == 0;  
        }
        
    }
} 