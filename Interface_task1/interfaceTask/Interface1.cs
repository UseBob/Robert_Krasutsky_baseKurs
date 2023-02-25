using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask
{
    internal interface IMusInstruments
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public void Play()
        {

        }
        public void Sound()
        {

        }
    }
}
