using System;
using System.Collections.Generic;

namespace CsGoRadar
{
    public class Radar
    {
        private readonly MemoryReader memoryReader;
        private readonly int rdarcenterX;
        private readonly int rdarcenterY;
        private readonly int baseClient;
        private readonly bool showTeam;
        private readonly bool showEnemies;
        private readonly bool isStreched;

        public Radar(MemoryReader rp, int rdarcenterX, int rdarcenterY, int baseClient, bool showTeam, bool showEnemies, bool isStreched)
        {
            this.memoryReader = rp;
            this.rdarcenterX = rdarcenterX;
            this.rdarcenterY = rdarcenterY;
            this.baseClient = baseClient;
            this.showTeam = showTeam;
            this.showEnemies = showEnemies;
            this.isStreched = isStreched;
        }

        public PlayerPosition getMe()
        {
            int meId = memoryReader.readInt(baseClient + Offsets.dwLocalPlayer);
            float x = memoryReader.readFloat(meId + Offsets.offsetXPosition + sizeof(float) * 0);
            float y = memoryReader.readFloat(meId + Offsets.offsetXPosition + sizeof(float) * 1);
            int team = memoryReader.readInt(meId + Offsets.offsetTeams);

            return new PlayerPosition() { Id = meId, X = x, Y = y, Team = team };
        }

        public List<PlayerPosition> getOtherPlayers(PlayerPosition me)
        {
            var otherPlayers = new List<PlayerPosition>();
            for (var i = 1; i < 35; i++)
            {
                int otherPlayerId = memoryReader.readInt(baseClient + Offsets.dwEntityList + i * Offsets.PlayerLoopDistance);
                int otherPlayerTeam = memoryReader.readInt(otherPlayerId + Offsets.offsetTeams);
                bool isEnemy = (me.Team > 0 && otherPlayerTeam > 0 && me.Team != otherPlayerTeam);

                if (isEnemy && showEnemies || !isEnemy && showTeam)
                {
                    int otherPlayerHealth = memoryReader.readInt(otherPlayerId + Offsets.offsetHealth);
                    int dormant = memoryReader.readInt(otherPlayerId + Offsets.oDormant);

                    bool hasToShowPlayer = otherPlayerHealth > 0 && (dormant == 0 || dormant == 1);
                    if (hasToShowPlayer)
                    {
                        float otherPlayerX = memoryReader.readFloat(otherPlayerId + Offsets.offsetXPosition + sizeof(float) * 0);
                        float otherPlayerY = memoryReader.readFloat(otherPlayerId + Offsets.offsetXPosition + sizeof(float) * 1);

                        otherPlayers.Add(new PlayerPosition() { Id = otherPlayerId, X = otherPlayerX, Y = otherPlayerY, Team = otherPlayerTeam });
                    }
                }
            }

            return otherPlayers;
        }

        public PlayerPosition getPlayerPositionOnRadar(PlayerPosition me, PlayerPosition otherPlayer, float yaw, int rdardist)
        {
            double angle = (yaw * Math.PI / 180) + 80;
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);

            double XNiceRise = rdarcenterX + ((otherPlayer.X - me.X) / rdardist);
            double YNiceRun = rdarcenterY - ((otherPlayer.Y - me.Y) / rdardist);
            double dx = XNiceRise - rdarcenterX;
            double dy = YNiceRun - rdarcenterY;

            double y = sin * dx + cos * dy + rdarcenterY;

            if (isStreched)
            {
                double stretchedX = (cos * dx - sin * dy) * 1.33 + rdarcenterX;
                return new PlayerPosition() { X = stretchedX, Y = y };
            } else {
                double x = cos * dx - sin * dy + rdarcenterX;
                return new PlayerPosition() { X = x, Y = y };
            }
        }
    }
}
