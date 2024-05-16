using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather2
{
	internal class Weather
	{
		public string Varos { get; set; }
		public string Homerseklet { get; set; }
		public int Paratartalom { get; set; }
        public string Szelsebesseg { get; set; }



        public Weather(string sorok) 
		{
			var sor = sorok.Split(';');
			Varos = sor[0];
			Homerseklet	= Convert.ToString(sor[1]);
			Paratartalom = Convert.ToInt32(sor[2]);
            Szelsebesseg = Convert.ToString(sor[3]);

        }
    }
}
