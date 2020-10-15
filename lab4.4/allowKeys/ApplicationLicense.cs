using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace allowKeys
{
    class ApplicationLicense
    {
        private const string trialKey = "qwe123";
        private const string commonKey = "q12qwe";
        private const string proKey = "reqw12344";
        public string typeVersion { get; private set; }
        public ApplicationLicense(string key)
        {
            typeVersion = "free";
            switch (key)
            {
                case trialKey:
                    AllowTrial();
                    break;
                case commonKey:
                    AllowCommon();
                    break;
                case proKey:
                    AllowPro();
                    break;
                    
            }

        }
        public void AllowTrial()
        {
            Debug.WriteLine("TrialVersion");
            typeVersion = "trial";
        }
        public void AllowCommon()
        {
            Debug.WriteLine("CommonVersion");
            typeVersion = "common";

        }
        public void AllowPro()
        {
            Debug.WriteLine("ProVersion");
            typeVersion = "pro";
        }
    }
}
