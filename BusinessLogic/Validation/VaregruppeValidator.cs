using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UiModels;

namespace BusinessLogic.Validation
{
    public class VaregruppeValidator
    {
        Regex vName;

        public VaregruppeValidator()
        {
            // Allows upper/lowercase + space (\s) + hyphen (-)
            vName = new Regex("^[A-Za-zÆØÅæøå\\s-]+$");
        }

        public bool ValidName(string name)                      // Name     --*
        {
            return !string.IsNullOrWhiteSpace(name)
                && name.Length >= 2 && name.Length <= 30        // Length
                && vName.IsMatch(name);                         // Pattern
        }

        public bool ValidGroup(VaregruppeUI vgUI)
        {
            return ValidName(vgUI.Name);
        }
    }
}
