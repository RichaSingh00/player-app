using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _age;
        public Player(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public Player(int id, string name, int age) : this(id, name)
        {
            _age = age;
        }
        public int GetId { get { return _id; } }
        public string GetName { get { return _name; } }
        public int GetAge { get { return _age; } }
        public string GetDetails()
        {
            return $"Player Id: {_id}\n Player Name: {_name}\n Player Age: {_age}";
        }
        public static Player WhoIsElder(Player[] players)
        {
            int elderPlayer = players[0]._age;
            Player p= players[0];
            for (int i = 1; i < players.Length; i++)
            {
                if (players[i]._age > elderPlayer)
                {
                    elderPlayer = players[i]._age;
                    p = players[i];
                }
            }
            return p;
        }
    }
}
