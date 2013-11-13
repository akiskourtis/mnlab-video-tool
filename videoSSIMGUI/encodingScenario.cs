using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace videoSSIMGUI
{
    class encodingScenario
    {
        public string encoderFile { get; set; }
        public string inputFile { get; set; }
        public string reconFile { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string outputFile { get; set; }
        public string profileIDC { get; set; }
        public string path { get; set; }
        public int framesToBeEncoded { get; set; }
        public int frameRate { get; set; }
        public int QPISlice { get; set; }
        public int QPPSlice { get; set; }
        public int QPBSlice { get; set; }
        public int ID { get; set; }
        public double bitrate { get; set; }

    }

}
