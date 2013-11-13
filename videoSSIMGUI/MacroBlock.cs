using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace videoSSIMGUI
{
    class MacroBlock
    {
        public ArrayList motionVectors = new ArrayList();
        public ArrayList subMacroBlocks = new ArrayList();



        public Boolean hasSubMacroBlocks() {

            if (subMacroBlocks.Count > 0)
            {
                return true;
            }
            else return false;
        }
        public int posX { get; set; }
        public int posY { get; set; }
        public string typeString { get; set; }
    }
}
