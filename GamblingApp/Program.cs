class Gambling
{
    int money = 100;
    int betAmount = 1;
    int count = 0;
    int wonCount = 0;
    public void Start()
    {
        while(money!=0 && money !=200)
        {
            Console.WriteLine("The bet start");
            Random rm=new Random();
            int bet=rm.Next(0,1);
            count++;
        }
    }
    public static void Main(string[] args)
    {
        Gambling gambling = new Gambling();
        
    }
}