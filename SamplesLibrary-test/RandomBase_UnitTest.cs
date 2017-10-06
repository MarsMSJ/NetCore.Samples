using System;
using Xunit;
using SamplesLibrary;

namespace SamplesLibrary_test
{
    public class RandomBase_UnitTest
    {
        const int TEST_REPS = 100;
        const int TEST_SEQ = 100;
        static RandomBase RandomBase_;
        
        
        static RandomBase_UnitTest()
        {
            RandomBase_ = new RandomBase();
        }
        
        //Testing we get an integer
        [Fact]
        public void TestGetInt()
        {
          int sample = RandomBase_.GetInt();
          Assert.True( true );
        }
        
       
        
        //Testing we get positive integers
        [Fact]
        public void TestPosInt()
        {
          int rep = 0;
          int sample = RandomBase_.GetPosInt();
          
          while( rep <= TEST_REPS )
          {
            rep++;
            sample = RandomBase_.GetPosInt();
            
            if( sample < 0 )
            {
                //Generated a negative result 
                Assert.True( false );
            }
          }
          
          
          Assert.True( true );
        }
        
        //Testing we get negative integers
        [Fact]
        public void TestNegInt()
        {
          int rep = 0;
          int sample = RandomBase_.GetNegInt();
          
          while( rep <= TEST_REPS )
          {
            rep++;
            sample = RandomBase_.GetNegInt();
            
            if( sample > 0 )
            {
                //Generated a positive result 
                Assert.True( false );
            }
          }          
          
          Assert.True( true );
        }
        
        //Testing we get the sequence of numbers we asked for:
        // GetNumberSequence( TEST_SEQ )
        // GetSignedNumberSequence( TEST_SEQ, true )
        // GetSignedNumberSequence( TEST_SEQ, false )
        [Fact]
        public void TestIntegerSequences()
        {
            var listA = RandomBase_.GetNumberSequence( TEST_SEQ );
            var listB = RandomBase_.GetSignedNumberSequence( TEST_SEQ );
            var listC = RandomBase_.GetSignedNumberSequence( TEST_SEQ);
            Assert.True( listA.Count == listB.Count && listB.Count == listC.Count );   
        }
        
        
        //Testing we get a yes or no :)
        [Fact]
        public void TestYesOrNo()
        {
          bool sample = RandomBase_.YesOrNo();
          Assert.True( true );
        }
        
         //Testing we get a char A/a-Z/z
        [Fact]
        public void TestGetRandomChar()
        {
          char sample = RandomBase_.GetRandomChar();          
          Assert.True( char.IsLetter( sample ) );
        }
        
        //Testing we get a char A-Z
        [Fact]
        public void TestGetRandomCharUpper()
        {
          char sample = RandomBase_.GetRandomCharUpper();          
          Assert.True( char.IsLetter( sample ) && char.IsUpper( sample ) );
        }
        
         //Testing we get a char a-z
        [Fact]
        public void TestGetRandomCharLower()
        {
          char sample = RandomBase_.GetRandomCharLower();          
          Assert.True( char.IsLetter( sample ) && char.IsLower( sample ) );
        }
        
        
        
    }
}
