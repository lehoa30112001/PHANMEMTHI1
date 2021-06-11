using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHANMEMTHI.Source.Objects {
    class Subject {

        public readonly string ID;
        public readonly string Name;
        public readonly int Credits;

        public Subject(string id, string name, int credits) {
            ID = id;
            Name = name;
            Credits = credits;
        }
    }
}
