using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SamplesLibrary
{
    
    public class StringSample : RandomBase
    {
        const int MAX_LENGTH = 25;
        const int MIN_LENGTH = 1;
        
        public StringSample() : base(){}
        
        public string GetRandomString(  )
        {
            int randomLength = GetPosInt() % MAX_LENGTH;
						
            //Initialize with 1 random character
            var strBuild = new StringBuilder( GetRandomChar() );
            
            while( strBuild.Length < randomLength )
            {
                strBuild.Append( GetRandomChar() );
            }
            
            return strBuild.ToString();
        }
        
        public string GetRandomString( int length )
        {
            if( length < MIN_LENGTH || length > MAX_LENGTH )
            {
                throw new ArgumentException($"Bad String Length: {length}");
            }
            
            //Initialize with 1 random character
            var strBuild = new StringBuilder( GetRandomChar() );
            
            while( strBuild.Length < length )
            {
                strBuild.Append( GetRandomChar() );
            }
            
            return strBuild.ToString();
        }
				
				public char GetRandomCharFromString( string str )
				{
					if( str == string.Empty )
					{
						return ' ';
					}
					
					if( str.Length == 1 )
					{
						return str[0];
					}
					return str[ GetPosInt() % ( str.Length - 1 ) ];
				}
               
        //Count is 10 by default
        public List<string> GetRandomStrings( int count = 10 )
        {
            var list = new List<string>();
            
            while( list.Count < count )
            {
                list.Add( GetRandomString( ) );
            }
            
            return list;
        }
        
    }
}
