using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections.Generic;

namespace CsGoRadar
{
    public class DisplayRadar
    {
        [DllImport("User32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        private static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);

        private readonly MemoryReader memoryReader;
        private readonly Radar radar;
        private readonly int baseEngine;

        private Graphics graphics;
        private SolidBrush brush;
        private IntPtr desktopPtr;

        public DisplayRadar(MemoryReader memoryReader, Radar radar, int baseEngine)
        {
            this.memoryReader = memoryReader;
            this.radar = radar;
            this.baseEngine = baseEngine;

            desktopPtr = GetDC(IntPtr.Zero);
            graphics = Graphics.FromHdc(desktopPtr);
            brush = new SolidBrush(Color.Green);
        }

        public void render(PlayerPosition me, List<PlayerPosition> otherPlayers, int fanX, int fanY, int spread, int size)
        {
            var rectangles = new List<Rectangle>();
            foreach (PlayerPosition player in otherPlayers)
            {
                var rectangle = getPlayerRectanglePositionOnScreen(me, player, fanX, fanY, spread, size);
                if (rectangle.HasValue)
                {
                    rectangles.Add(rectangle.Value);
                }
            }

            if (rectangles.Count > 0)
            {
                graphics = Graphics.FromHdc(desktopPtr);

                graphics.FillRectangles(brush, rectangles.ToArray());
                graphics.Dispose();
            }
        }

        private Rectangle? getPlayerRectanglePositionOnScreen(PlayerPosition me, PlayerPosition e, int posX, int posY, int spread, int size)
        {
            int facingX = memoryReader.readInt(baseEngine + Offsets.dwClientState);
            int final = facingX + Offsets.dwClientState_ViewAngles;
            float yaw = memoryReader.readFloat(final + 0x4);

            var position = radar.getPlayerPositionOnRadar(me, e, yaw, spread);
            if (position != null)
            {
                var x = position.X - posX;
                var y = position.Y + posY;

                return new Rectangle((int)Math.Round(x) - size / 2, (int)Math.Round(y) - size / 2, size, size);
            }

            return null;
        }
    }
}
