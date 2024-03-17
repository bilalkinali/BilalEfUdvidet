using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UiModels;

namespace BusinessLogic.Validation
{
    public class VareValidator
    {
        Regex vText;
        //Regex vDigit;

        public VareValidator()
        {
            // Name + digits (0-9) + comma (,) + period (.)
            vText = new Regex("^[A-Za-zÆØÅæøå0-9\\s-,.]+$");
            // Allows digits
            //vDigit = new Regex("^[0-9]+$");
        }

        public bool ValidName(string name)                      // Name     --*
        {
            return !string.IsNullOrWhiteSpace(name) &&
                name.Length >= 2 && name.Length <= 30 &&       // Length
                vText.IsMatch(name);                         // Pattern
        }

        public bool ValidDescription(string text)               // Name     --*
        {
            return !string.IsNullOrWhiteSpace(text) &&
                text.Length >= 2 && text.Length <= 500 &&      // Length
                vText.IsMatch(text);                         // Pattern
        }


        public bool ValidPrice(string price)                    // Price    --*
        {
            double x = 0;
            bool vPrice = double.TryParse(price, out x);
            if (vPrice)
                return x > 0;
            return vPrice;
        }

        public bool ValidVare(VareUI v)
        {
            return ValidName(v.Name) &&
                ValidPrice(v.Price.ToString()) &&
                ValidDescription(v.Description);
        }
    }
}
