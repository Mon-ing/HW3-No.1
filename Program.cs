public class Program
{
    public static void Main(string[] args)
    {
        Queue<char> Flower = new Queue<char>();
        char flower = 'a';
        int check1 = 0;
        char rose = 'b';
        int i = 0;
        
            while (flower == 'J' || flower == 'G' || flower == 'O' || flower == 'R' || flower == 'a')
            {
                flower = char.Parse(Console.ReadLine());
            if (flower == 'J')
            {
                if (flower != rose)
                {
                    Flower.Push('J');
                    check1++;
                    rose = 'z';
                }
                else
                {
                    Console.WriteLine("Invalid patten");

                }
            }
            else if(flower == 'G')
            {
             
                    if(flower != rose)
                    {
                        Flower.Push('G');
                        rose = 'z';
                        check1++;
                        i++;
                    }
                
                else if(i>3)
                {
                    Console.WriteLine("invalid patten");
    
                }
                else
                {
                    Console.Write("Invalid patten");
            
                }
            }
            else if (flower == 'O')
            {
                if(flower != rose)
                {
                    Flower.Push('O');
                    rose = 'z';
                    check1++;
                }
                else
                {
                    Console.WriteLine("Invalid patten");
                
                }
            }
            else if(flower == 'R')
            {
                if(check1 == 0)
                {
                    Console.WriteLine("Invalid patten");
                }
                else
                {
                    Flower.Push('R');
                    rose = 'z';
                    rose= Flower.Get(Flower.GetLength()-2);
                    check1++;    
                }
            }
        }
       
        for(int n = 0;n<Flower.GetLength();n++)
            {
                Console.Write("{0}",Flower.Get(n));
            }
            
    }   
}