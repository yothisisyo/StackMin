using System;

namespace StackMin
{//InTestBranch
    class Program
    {
       static int[] Xlist = new int[100];
        static int top = -1;
        static int min=0,minPrev;

        static void Main(string[] args)
        {//This is Master !! 
            int X;
            while(true)
            {//Test
                Console.WriteLine("Select");
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Min");
                Console.WriteLine("Enter a number");
                X =Int32.Parse( Console.ReadLine());
                switch(X)
                {
                    case 1:
                        Console.WriteLine("Enter value to push");
                       int  Z = Int32.Parse(Console.ReadLine());
                        Push(Z);
                        break;
                    case 2: Pop();
                        break;
                    case 3: Min();
                        break;
                    default: Console.WriteLine("Enter Valid Output");
                        break;
                        
                }
            }
        }


        private static void Min()
        {

            Console.WriteLine("MINIMUM at this moment :{0}",min+Xlist[top]);
         //   throw new NotImplementedException();
        }

        private static void Pop()
        {

            //if(min==0)
            min = minPrev;
            top--;
            //throw new NotImplementedException();
        }

        private static void Push(int y)
        {
           
            if (top>-1)
            {
                if (y <= Xlist[top] + min) //reset Min if less
                {
                    minPrev = min;
                    min = 0; 
                }
                else //Setting Min if great 
                {
                    minPrev = min;
                    min = Xlist[top] + min - y;
                }
            }
            Xlist[++top] = y;
      
          
        }
    }
}
