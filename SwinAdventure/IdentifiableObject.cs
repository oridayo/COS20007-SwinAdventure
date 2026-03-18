using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        //construct list
        public IdentifiableObject(string[] idents) 
        {
            _identifiers = new List<string>(idents);
        }

        //are you method to check whether the list contains certain object in lowercase
        public bool AreYou(string id)
        {
            return Identifiers.Contains(id.ToLower());
        }

        //check the first id of the list
        public string FirstId()
        {
            if (Identifiers.Count == 0)
            {
                return "";
            } else
            {
                return Identifiers[0];
            }
        }

        //add new identifier
        public void AddIdentifier(string id)
        {
            Identifiers.Add(id.ToLower());
        }

        //properties
        List<string> Identifiers
        {
            get { return _identifiers; }
            set { _identifiers = value; }
        }
    }
}
