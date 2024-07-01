using System.IO;

String l;
int aCount = 0;
try
{
    StreamReader reader = new StreamReader("C:/test/test_kon_bal.txt");

    l = reader.ReadLine();
    while( l != null )
    {
        for( int i=0; i<l.Length; i++ )
        {
            if (l[i] == 'a') aCount++;
        }
        l = reader.ReadLine();
    }
    Console.WriteLine(aCount);
}
catch(Exception e)
{
    Console.WriteLine(e);
}