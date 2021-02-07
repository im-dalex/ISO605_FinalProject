using System.Text.RegularExpressions;

namespace TeteoRentCar.Utilities
{
    public class Identification
    {
        public static bool Validate(string id)
        {

            //var regex = new Regex(@"^\d{3}-\d{7}-\d$");

            //var match = Regex.Match(id, regex);

            //if (!match.Success)
            //{
            //    // does not match
            //}

            int vnTotal = 0;
            string vcCedula = id.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = int.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += int.Parse(vCalculo.ToString().Substring(0, 1)) + int.Parse(vCalculo.ToString().Substring(1, 1));
            }

            return (vnTotal % 10 == 0);
        }
    }
}
