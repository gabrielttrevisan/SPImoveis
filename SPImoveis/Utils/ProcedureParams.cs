using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPImoveis.Utils
{
    public class ProcedureParams
    {
        public static ProcedureParams Empty
        {
            get { return new ProcedureParams(); }
        }

        private Dictionary<string, string> dictionary;

        public ProcedureParams()
        {
            this.dictionary = new Dictionary<string, string>();
        }

        public ProcedureParams Add(string key, string value)
        {
            dictionary.Add(key, value);

            return this;
        }

        public override string ToString()
        {
            List<string> list = new List<string>();

            foreach (var key in this.dictionary.Keys)
            {
                list.Add("@" + key + " = " + this.dictionary[key]);
            }

            return String.Join(", ", list);
        }
    }
}