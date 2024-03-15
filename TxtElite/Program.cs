namespace TxtElite;

class Program
{
    public static int boolean;
    public static char uint8;
    public static short uint16;
    public static short int16;
    public static long int32;
    public static uint uint0;
    public static int planetnum;
    public PlanSys[] galaxy =  new PlanSys[GalSize];
 
    public const int True = -1;
    public const int False = 0;
    public const int Tonnes = 0;
    public const int MaxLen = 20;
    public const int GalSize = 256;
    public const int AlienItems = 16;
    public const int LastTrade = AlienItems;
    public const int NumForLave = 7;
    public const int NumForZaonce = 129;
    public const int NumForDiso = 147;
    public const int NumForRied = 46;

    private SeedType seed;
    private FastSeedType rndSeed;
    private bool nativeRand;

    public struct FastSeedType /* four byte random number used for planet description */
    {
        public byte a;
        public byte b;
        public byte c;
        public byte d;

        public FastSeedType(byte a, byte b, byte c, byte d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }

    private struct SeedType /* six byte random number used as seed for planets */
    {
        public int w0;
        public int w1;
        public int w2;

        public SeedType(int w0, int w1, int w2)
        {
            this.w0 = w0;
            this.w1 = w1;
            this.w2 = w2;
        }
    }

    public struct PlanSys
    {
        public uint x;
        public uint y;
        public uint economy;
        public uint govType;
        public uint techLev;
        public uint population;
        public uint productivity;
        public uint radius;
        public string name;
        public FastSeedType goatSoupSeed;

        public PlanSys(uint x, uint y, uint economy, uint govType, uint techLev, uint population, uint productivity, uint radius, string name, FastSeedType goatSoupSeed)
        {
            this.x = x;
            this.y = y;
            this.economy = economy;
            this.govType = govType;
            this.techLev = techLev;
            this.population = population;
            this.productivity = productivity;
            this.radius = radius;
            this.name = name;
            this.goatSoupSeed = goatSoupSeed;
        }
    }

    public struct TradeGood
    {
        public uint basePrice;
        public uint gradient;
        public uint baseQuant;
        public uint maskByte;
        public uint units;
        public string name;

        public TradeGood(uint basePrice, uint gradient, uint baseQuant, uint maskByte, uint units, string name)
        {
            this.basePrice = basePrice;
            this.gradient = gradient;
            this.baseQuant = baseQuant;
            this.maskByte = maskByte;
            this.units = units;
            this.name = name;
        }
    }

    public struct MarketType
    {
        private uint quantity = LastTrade + 1;
        private uint price = LastTrade + 1;
        
        public MarketType(uint quantity, uint price)
        {
            this.quantity = quantity;
            this.price = price;
        }
    }

    static void Main(string[] args)
    {
        SeedType seed;
        FastSeedType rndSeed;
        
    }
}