namespace TxtElite;

public class Program
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
    public const int NoComms = 14;
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

    public class TradeGoods
    {
        public int BasePrice { get; set; }
        public int Gradient { get; set; }
        public int BaseQuantity { get; set; }
        public int MaskByte { get; set; }
        public int Units { get; set; }
        public string Name { get; set; }
        
        public TradeGoods(int basePrice, int gradient, int baseQuantity, int maskByte, int units, string name)
        {
            BasePrice = basePrice;
            Gradient = gradient;
            BaseQuantity = baseQuantity;
            MaskByte = maskByte;
            Units = units;
            Name = name;
        }
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
        private List<string> govNames = new List<string> {"Anarchy","Feudal","Multi-gov","Dictatorship", "Communist","Confederacy","Democracy","Corporate State"}; // MaxLen
        private List<string> econNames = new List<string>() {"Rich Ind","Average Ind","Poor Ind","Mainly Ind", "Mainly Agri","Rich Agri","Average Agri","Poor Agri"}; // MaxLen
        private List<string> unitNames = new List<string>() {"t","kg","g"}; // MaxLen = 5
    }
    
    public class CommodityAttributes
    {
        
    }

    public void GoatSoup(string source, PlanSys psy)
    {
        
    }

    public class TradeCommands
    {
        public bool DoBuy(string buy)
        {
            return true;
        }
        
        public bool DoSell(string sell)
        {
            return true;
        }
        
        public bool DoFuel(string fuel)
        {
            return true;
        }
        
        public bool DoJump(string jump)
        {
            return true;
        }
        
        public bool DoCash(string cash)
        {
            return true;
        }
        
        public bool DoMkt(string mkt)
        {
            return true;
        }

        public bool DoHelp(string help)
        {
            return true;
        }
        
        public bool DoHold(string hold)
        {
            return true;
        }
        
        public bool DoSneak(string sneak)
        {
            return true;
        }

        public bool DoLocal(string local)
        {
            return true;
        }
        
        public bool DoInfo(string info)
        {
            return true;
        }
        
        public bool DoGalHyp(string galHyp)
        {
            return true;
        }
        
        public bool DoQuit(string quit)
        {
            return true;
        }
        
        public bool DoTweakRand(string tweakRand)
        {
            return true;
        }
    }

    static void Main()
    {
        int[,] tradNames = { { LastTrade }, { MaxLen } }; //char tradnames[lasttrade][maxlen]; -- 2D array -- https://www.w3schools.com/cs/cs_arrays_multi.php
        var politicallyCorrect = true;
        TradeGoods[] commodities;
        
        if (politicallyCorrect)
        {
            commodities = new TradeGoods[]
            {
                new TradeGoods(0x13, -0x02, 0x06, 0x01, 0, "Food"),
                new TradeGoods(0x14, -0x01, 0x0A, 0x03, 0, "Textiles"),
                new TradeGoods(0x41, -0x03, 0x02, 0x07, 0, "Radioactives"),
                new TradeGoods(0xC4, +0x08, 0x36, 0x03, 0, "Luxuries"),
                new TradeGoods(0x9A, +0x0E, 0x38, 0x03, 0, "Computers"),
                new TradeGoods(0x75, +0x06, 0x28, 0x07, 0, "Machinery"),
                new TradeGoods(0x4E, +0x01, 0x11, 0x1F, 0, "Alloys"),
                new TradeGoods(0x7C, +0x0d, 0x1D, 0x07, 0, "Firearms"),
                new TradeGoods(0xB0, -0x09, 0xDC, 0x3F, 0, "Furs"),
                new TradeGoods(0x20, -0x01, 0x35, 0x03, 0, "Minerals"),
                new TradeGoods(0x61, -0x01, 0x42, 0x07, 1, "Gold"),
                new TradeGoods(0xAB, -0x02, 0x37, 0x1F, 1, "Platinum"),
                new TradeGoods(0x2D, -0x01, 0xFA, 0x0F, 2, "Gem Stones"),
                new TradeGoods(0x35, +0x0F, 0xC0, 0x07, 0, "Alien Items"),
                new TradeGoods(0x28, -0x05, 0xE2, 0x1F, 0, "Robot Slaves"),
                new TradeGoods(0x53, -0x05, 0xFB, 0x0F, 0, "Beverages"),
                new TradeGoods(0xEB, +0x1D, 0x08, 0x78, 0, "Rare Species"),
            };
        }
        else
        {
            commodities = new TradeGoods[]
            {
                new TradeGoods(0x13, -0x02, 0x06, 0x01, 0, "Food"),
                new TradeGoods(0x14, -0x01, 0x0A, 0x03, 0, "Textiles"),
                new TradeGoods(0x41, -0x03, 0x02, 0x07, 0, "Radioactives"),
                new TradeGoods(0xC4, +0x08, 0x36, 0x03, 0, "Luxuries"),
                new TradeGoods(0x9A, +0x0E, 0x38, 0x03, 0, "Computers"),
                new TradeGoods(0x75, +0x06, 0x28, 0x07, 0, "Machinery"),
                new TradeGoods(0x4E, +0x01, 0x11, 0x1F, 0, "Alloys"),
                new TradeGoods(0x7C, +0x0d, 0x1D, 0x07, 0, "Firearms"),
                new TradeGoods(0xB0, -0x09, 0xDC, 0x3F, 0, "Furs"),
                new TradeGoods(0x20, -0x01, 0x35, 0x03, 0, "Minerals"),
                new TradeGoods(0x61, -0x01, 0x42, 0x07, 1, "Gold"),
                new TradeGoods(0xAB, -0x02, 0x37, 0x1F, 1, "Platinum"),
                new TradeGoods(0x2D, -0x01, 0xFA, 0x0F, 2, "Gem Stones"),
                new TradeGoods(0x35, +0x0F, 0xC0, 0x07, 0, "Alien Items"),
                new TradeGoods(0x28, -0x05, 0xE2, 0x1F, 0, "Slaves"),
                new TradeGoods(0xEB, +0x1D, 0x08, 0x78, 0, "Narcotics"),
                new TradeGoods(0x53, -0x05, 0xFB, 0x0F, 0, "Liquor/Wines"),
            };
        }

        string[] commands = new string[NoComms]
        {
            "buy", "sell", "fuel", "jump",
            "cash", "mkt", "help", "hold",
            "sneak", "local", "info", "galhyp",
            "quit", "rand"
        };

        CommandFunction[] comfuncs = new CommandFunction[NoComms];
        TradeCommands tradeCommands = new TradeCommands();
        comfuncs[0] = tradeCommands.DoBuy;
        comfuncs[1] = tradeCommands.DoSell;
        comfuncs[2] = tradeCommands.DoFuel;
        comfuncs[3] = tradeCommands.DoJump;
        comfuncs[4] = tradeCommands.DoCash;
        comfuncs[5] = tradeCommands.DoMkt;
        comfuncs[6] = tradeCommands.DoHelp;
        comfuncs[7] = tradeCommands.DoHold;
        comfuncs[8] = tradeCommands.DoSneak;
        comfuncs[9] = tradeCommands.DoLocal;
        comfuncs[10] = tradeCommands.DoInfo;
        comfuncs[11] = tradeCommands.DoGalHyp;
        comfuncs[12] = tradeCommands.DoQuit;
        comfuncs[13] = tradeCommands.DoTweakRand;
        
        // continue from /**- General functions **/
        
        /*var base0Converted = Convert.ToInt32(Base0Hex);
        // var base0Test = int.TryParse(Base0Hex);
        //var base0Test1 = int.Parse(Base0Hex.ToString(),System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(base0Converted);
        Console.ReadLine();*/
    }
}