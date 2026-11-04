// See https://aka.ms/new-console-template for more information

/*
Variable types are as follows:
byte
short 
int
long
sbyte
ushort
uint
ulong
char
string
float
double
decimal
bool
*/
byte thisIsAByte = 255;
short thisIsAShort = 32_767;
int thisIsAInt = 2_147_483_647;
long thisIsALong = 9_223_372_036_854_775_807L;
sbyte thisIsAnSByte = 127;
ushort thisIsAUShort = 65_535;
uint thisIsAnUInt = 4_294_967_295U;
ulong thisIsAnULong = 18_446_744_073_709_551_615U;
char thisIsAChar = 'f';
string thisIsAString = "default";
float thisIsAFloat = 6.7F;
double thisIsADouble = 0.0005; 
decimal thisIsADecimal = 0.005M;
bool thisIsABool= true;
Console.WriteLine("My name is Doug Dimmadome, owner of the Dimmsdale Dimmadome Variable Shop!");
Console.WriteLine("We have many variables on sale such as!" +
                  $"\n{thisIsAByte.GetType()}" +
                  $"\n{thisIsAShort.GetType()}" +
                  $"\n{thisIsAInt.GetType()}" +
                  $"\n{thisIsALong.GetType()}" +
                  $"\n{thisIsAnSByte.GetType()}" +
                  $"\n{thisIsAUShort.GetType()}" +
                  $"\n{thisIsAnUInt.GetType()}" +
                  $"\n{thisIsAnULong.GetType()}" +
                  $"\n{thisIsAChar.GetType()}" +
                  $"\n{thisIsAString.GetType()}" +
                  $"\n{thisIsAFloat.GetType()}" +
                  $"\n{thisIsADouble.GetType()}" +
                  $"\n{thisIsADecimal.GetType()}" +
                  $"\n{thisIsABool.GetType()}");