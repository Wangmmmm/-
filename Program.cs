class Program
    {
        static void Main(string[] args)
        {
           
        }
      public static int Mod(int mInput, int eInput, int nInput)
        {
            //a*m^e
            if (mInput == 0 && eInput == 0) return -1;


            int level = 1;
             while(Math.Pow(mInput, level)<int.MaxValue)
             {
               
                if (level == eInput)
                {
                    return (int)Math.Pow(mInput, level) % nInput;
                }
                level++;
            }

            int a = 1;
            int m = mInput;
            int e = eInput;

            while (true)
            {
                for (int i = 1; ; i++)
                {
                 
                    int temp = ((int)Math.Pow(mInput, i) * a);
                    if (temp < nInput) continue;
                    else if (temp == nInput) return 0;
                    a = ((int)Math.Pow(mInput, i) * a) % nInput;
                    e = e - i ;
                    if (a == 1) { a = mInput; e = e - 1; }
              
                    break;
                }
                if (Math.Pow(mInput, e)*a < int.MaxValue)
                {
                    if (a * (int)Math.Pow(m, e) < nInput) break;
                }
            }

            return a * (int)Math.Pow(m, e);

       }
