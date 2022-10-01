using System;

namespace LEAP_YEAR{
    class program{
        static void Main(String[] args){
            int presentDate = DateTime.Now.Year;
            int nextLeap;
            switch(presentDate%4){
                case 1:
                    nextLeap = presentDate +3;
                    break;
                case 2:
                    nextLeap = presentDate + 2;
                    break;
                case 3:
                    nextLeap = presentDate + 1;
                    break;
                default:
                    nextLeap = presentDate;
                    break;
            }
            Console.WriteLine(nextLeap);
            for(int years = 0; years < 19; years++){
                nextLeap+=4;
                Console.WriteLine(nextLeap);
            }
        }
    }
}

