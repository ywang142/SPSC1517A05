using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPname
{
    public class turn
    {
        Random rnd = new Random();

        private int _player1;
        private int _player2;

        public int player1
        {
            get { return player1; }
            set
            {
                if (value >=0&&value<=6)
                {
                    _player1 = value;
                }
            }
        }
        public int player2
        {
            get { return _player2; }
            set
            {
                if (value >= 0 && value <= 6)
                {
                    _player2 = value;
                }
            }
        }
        public turn()
        {

        }
        public 
    }
}
