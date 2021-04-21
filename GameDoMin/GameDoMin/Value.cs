using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoMin
{
    public class Value
    {
        // ---------------------------- Beginer --------------------------------------
        public static int Board_Beginer_Weight = 10;
        public static int Board_Beginer_Height = 10;

        public static int Beginer_Mines = 10;
        public static int Beginer_Limit_Random = 99;

        //pnlBoradGame size= 313, 315; Location = 326, 86;
        //picReset size = 55, 47; Location = 326, 21;
        //prgCountTime size = 173, 27; Location = 399, 32;
        //btFlagging size = 50, 47; Location = 589, 21;
        //Form size = 679, 465;

        // ---------------------------- Intermediate ----------------------------------

        public static int Board_Intermediate_Weight = 20;
        public static int Board_Intermediate_Height = 20;

        public static int Intermediate_Mines = 70;
        public static int Intermediate_Limit_Random = 399;

        //pnlBoardGame Size(616, 616);
        //picReset.Location (326, 21);
        //prgCountTime.Location (541, 32);
        //btFlagging.Location (892, 21);
        //this.Size (977, 758);

        // ----------------------------- Expert ---------------------------------------

        public static int Board_Expert_Weight = 30;
        public static int Board_Expert_Height = 30;

        public static int Expert_Mines = 250;
        public static int Expert_Limit_Random = 899;


    }
}
