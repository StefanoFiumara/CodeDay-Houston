using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssaultCubeAimbot
{
    public class PlayerDataAddresses
    {
        public int xMouse;
        public int yMouse;
        public int xPos;
        public int yPos;
        public int zPos;
        public int health;
        public int primaryAmmo;
        public int secondaryAmmo;

        public PlayerDataAddresses(int _xMouse, int _yMouse, int _xPos, int _yPos, int _zPos, int _health, int _primaryAmmo, int _secondaryAmmo)
        {
            xMouse = _xMouse;
            yMouse = _yMouse;

            xPos = _xPos;
            yPos = _yPos;
            zPos = _zPos;

            health = _health;

            primaryAmmo = _primaryAmmo;
            secondaryAmmo = _secondaryAmmo;
        }
    }

    public class PlayerData
    {
        public int baseAddress;
        public int[] multilevel;
        public PlayerDataAddresses offsets;
    }

    public class PlayerDataValues
    {
        public float xMouse;
        public float yMouse;
        public float xPos;
        public float yPos;
        public float zPos;
        public int health;
        public int primaryAmmo;
        public int secondaryAmmo;
    }
}
