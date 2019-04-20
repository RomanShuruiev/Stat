using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stat_3
{
    class Disp
    {
        string OriginalData;
        char[] CharDat;
        int Count;

        int[] W;

        public double sum;
        public double sum2;
        public double sqSum;
        public double sqSum2;
        public double averageValue;
        public double standardDeviation;
        public double averageValueWPenalties;
        public double standardDeviationWPenalties;
        public double standardDeviationMean;
        public int measurements;
        public double randomError;
        public double ValueOfDivision;
        public double sumError;
        public double Vpn;
        public double Tpn;
        public double MaxY;
        double[] SumDat;

        bool Three;
        bool Four;
        bool Five;
        bool Ten;
        

        List<int> Data = new List<int>();

        public Disp(string OriginalData, bool Three, bool Four, bool Five, bool Ten)
        {
            this.OriginalData = OriginalData;
            this.Three = Three;
            this.Four = Four;
            this.Five = Five;
            this.Ten = Ten;


            Number();
            VPN(Three, Four, Five, Ten);
            AverageValue();
            StandardDeviation();
            CheckForPenalties();
            TPN();
            AverageValueWPenalties();
            StandardDeviationWPenalties();
            StandardDeviationMean();

            RandomError();

            SumError();
        }

        public int Number()
        {
            CharDat = OriginalData.ToCharArray();
            for (int i = 0; i < CharDat.Length; i++)
            {
                Data.Add((int)CharDat[i]);
            }
                Count = Data.Count;
            return Count;
        }

        public double AverageValue()
        {
            sum = 0;
            averageValue = 0;
            for (int i = 0; i < Data.Count; i++)
            {
                sum += Data[i];

            }
            averageValue = sum / Data.Count;
            return averageValue;
        }


        public double StandardDeviation()
        {
            sqSum = 0;
            for (int i = 0; i < Data.Count; i++)
            {
                sqSum += Math.Pow((Data[i] - averageValue), 2);
            }
            standardDeviation = Math.Sqrt(sqSum / ((double)Count - 1));
            return standardDeviation;
        }


        public double VPN(bool Three, bool Four, bool Five, bool Ten)
        {
            if (Three)
            {
                Vpn = 1.4;
            }

            if (Four)
            {
                Vpn = 1.7;
            }

            if (Five)
            {
                Vpn = 1.9;
            }

            if (Ten)
            {
                Vpn = 2.3;
            }
            return Vpn;
        }

        public int CheckForPenalties()
        {
            measurements = Count;
            for (int i = 0; i < Data.Count; i++)
                if ((Math.Abs(Data[i] - averageValue)) / standardDeviation > Vpn)
                {
                    W[i] = 0;
                    measurements--;
                }
                else
                {
                    W[i] = Data[i];
                }

            return measurements;
        }

        public double AverageValueWPenalties()
        {
            sum2 = 0;
            for (int i = 0; i < W.Length; i++)
            {
                sum2 += W[i];
            }
            averageValueWPenalties = sum2 / (double)measurements;
            return averageValueWPenalties;
        }

        public double StandardDeviationWPenalties()
        {
            sqSum2 = 0;
            for (int i = 0; i < W.Length; i++)
            {
                sqSum2 += Math.Pow((W[i] - averageValueWPenalties), 2);
            }
            standardDeviationWPenalties = Math.Sqrt(sqSum2 / ((double)measurements - 1));
            return standardDeviationWPenalties;
        }


        public double StandardDeviationMean()
        {

            standardDeviationMean = standardDeviationWPenalties / (Math.Sqrt((double)measurements));
            return standardDeviationMean;
        }

        public double TPN()
        {

            if (measurements >= 3 && measurements < 4)
            {
                Tpn = 4.3;
            }

            if (measurements >= 4 && measurements < 5)
            {
                Tpn = 3.2;
            }

            if (measurements >= 5 && measurements < 10)
            {
                Tpn = 2.8;
            }

            if (measurements >= 10)
            {
                Tpn = 2.3;
            }
            return Tpn;

        }

        public double RandomError()
        {

            randomError = standardDeviationMean * Tpn;
            return randomError;
        }

        public double SumError()
        {

            sumError = randomError + ValueOfDivision / 2;
            return sumError;
        }

        public double MaximY()
        {
            for (int i = 0; i < Data.Count; i++)
            {
               // SumDat[i] += Math.Abs((double)Data[i] - averageValue);
             
            }

            Array.Sort(SumDat);
            MaxY = SumDat[SumDat.Length - 1];
            return MaxY;
        }


    }
}
