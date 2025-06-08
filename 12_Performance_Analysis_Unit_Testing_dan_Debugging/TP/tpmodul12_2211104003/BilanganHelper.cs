namespace tpmodul12_2211104003ss
{
    public static class BilanganHelper
    {
        public static string CariTandaBilangan(int a)
        {
            if (a < 0) return "Negatif";
            if (a > 0) return "Positif";
            return "Nol";
        }
    }
}