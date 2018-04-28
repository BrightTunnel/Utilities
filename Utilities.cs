     /// <summary>
        /// Method accepts any number and returns number rounded to 0.1, 0.2, 0.5, 1, 2, 5, etc...
        /// </summary>
        /// <remarks>
        /// Author Valeri Tikhonov, 2018
        /// </remarks>
        /// <param name="aDbl"></param>
        /// <returns></returns>
        public static double RoundForGraphScale(double aDbl) {
            int scaleBtm = (int)Math.Floor(Math.Log10(Math.Abs(aDbl)));
            double dRaw = Math.Round(aDbl, Math.Abs(scaleBtm));
            double dNorm = dRaw * Math.Pow(10, -scaleBtm);
            if (dNorm <= 1) {
                return Math.Pow(10, scaleBtm);
            } else if (dNorm <= 2) {
                return 2 * Math.Pow(10, scaleBtm);
            } else if (dNorm <= 5) {
                return 5 * Math.Pow(10, scaleBtm);
            } else {
                return 10 * Math.Pow(10, scaleBtm);
            }
        }