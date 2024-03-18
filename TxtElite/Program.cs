namespace TxtElite;

class Program
{
    public static int boolean;
    public static char uint8;
    public static short uint16;
    public static short int16;
    public static long int32;
    public static uint uint0;
    public static int planetNum;
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
    public const string Base0Hex= "0x5A4A"; /* Base seed for galaxy 1 */
    public const string Base1Hex = "0x0248"; /* Base seed for galaxy 1 */
    public const string Base2Hex = "0xB753"; /* Base seed for galaxy 1 */


    private SeedType seed;
    private FastSeedType rndSeed;
    private bool nativeRand;

    public class FastSeedType /* four byte random number used for planet description */
    {
        public byte a;
        public byte b;
        public byte c;
        public byte d;
    }

    private class SeedType /* six byte random number used as seed for planets */
    {
        public int w0;
        public int w1;
        public int w2;
    }

    public class PlanSys
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
    }

    public class TradeGood
    {
        public uint basePrice;
        public uint gradient;
        public uint baseQuant;
        public uint maskByte;
        public uint units;
        public string name;
    }

    public class MarketType
    {
        private uint quantity = LastTrade + 1;
        private uint price = LastTrade + 1;
    }

    public class PlayerWorkspace
    {
        private uint shipsHold = LastTrade + 1;
        private int currentPlanet; // planetNum currentplanet;
        private uint galaxyNum; // 1-8
        private int cash;
        private uint fuel;
        private MarketType localMarket;
        private uint holdSpace;

        private int fuelCost = 2;
        private int maxFuel = 70;
    }

    public class Names
    {
        private string pairs0 = "ABOUSEITILETSTONLONUTHNOALLEXEGEZACEBISOUSESARMAINDIREA.ERATENBERALAVETIEDORQUANTEISRION";
        private string pairs = "..LEXEGEZACEBISO" + "USESARMAINDIREA." + "ERATENBERALAVETI" + "EDORQUANTEISRION"; /* Dots should be nullprint characters ?? */
        private List<string> govNames = new List<string> {"Anarchy","Feudal","Multi-gov","Dictatorship", "Communist","Confederacy","Democracy","Corporate State"};
        private List<string> econNames = new List<string>() {"Rich Ind","Average Ind","Poor Ind","Mainly Ind", "Mainly Agri","Rich Agri","Average Agri","Poor Agri"};
        private List<string> unitNames = new List<string>() {"t","kg","g"};
    }
    
    public class CommodityAttributes
    {

        
    }

    static void Main(string[] args)
    {
        var base0Converted = Convert.ToInt32(Base0Hex);
        // var base0Test = int.TryParse(Base0Hex);
        //var base0Test1 = int.Parse(Base0Hex.ToString(),System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(base0Converted);
        Console.ReadLine();
    }
}