namespace CsGoRadar
{
    public static class Offsets
    {
        /*
         * These offsets can be changed often after each game update
         * You can get the latest values at: https://github.com/frk1/hazedumper
         * 
         * To avoid waiting for them update values, you can use directly
         * the HazeDumper and extract these values by yourself: https://github.com/frk1/hazedumper-rs/releases
         */
        public static int dwClientState = 0x588A2C;
        public static int dwLocalPlayer = 0xC5F89C;
        public static int dwEntityList = 0x4C3C454;

        // Those other values I never had to change, seems to be fixed.
        public static int offsetXPosition = 0x134;
        public static int offsetYPosition = 0x138;
        public static int oDormant = 0x000000E9;
        public static int PlayerLoopDistance = 0x00000010;
        public static int offsetHealth = 0xFC;
        public static int offsetTeams = 0xF0;
        public static int dwClientState_ViewAngles = 0x4d10;
    }
}
