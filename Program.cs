using System;

namespace SK_NilaiMahasiswa__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B;
            bool LB, LK, LBS, LKS, SMD, TSM;
            int VAR_A, VAR_B;

            Console.Write("Masukkan Nilai A   : "); A = Console.ReadLine();
            Console.Write("Masukkan Nilai B   : "); B = Console.ReadLine();

            VAR_A = Convert.ToInt32(A);
            VAR_B = Convert.ToInt32(B);

            LB = VAR_A > VAR_B;
            LK = VAR_A < VAR_B;
            LBS = VAR_A >= VAR_B;
            LKS = VAR_A <= VAR_B;
            SMD = VAR_A == VAR_B;
            TSM = VAR_A != VAR_B;

            Console.WriteLine("\nApakah A Lebih Besar dari B ? {0}", LB);
            Console.WriteLine("Apakah A Lebih Kecil dari B? {0}", LK);
            Console.WriteLine("Apakah A lebih besar sama dengan b? {0}", LBS);
            Console.WriteLine("Apakah A lebih kecil sama dengan b? {0}", LKS);
            Console.WriteLine("Apakah A sama dengan b? {0}", SMD);
            Console.WriteLine("Apakah A tidak sama dengan b? {0}", TSM);
            Console.Read();
                
        }
    }
}
