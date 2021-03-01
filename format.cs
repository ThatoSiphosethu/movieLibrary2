using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace movieLibrary2
{
    public abstract class mediaType
    {
        public string ID { get; set; }
        public string Title { get; set; }
        
        public abstract void Read();
        public abstract void Add();
        public abstract string getLastID();
           
    }
}