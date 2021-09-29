using System;

namespace FootballPlayerLib
{
    public class FootballPlayer
    {
        private string _name;
        private int _price;
        private int _shirtno;

        public FootballPlayer(int id, string name, int price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }


        public int Id { get; set;}


        public string Name { get => _name;

            set
            {
                if (value == null) throw new ArgumentNullException("name", "Name is null");
                if (value.Length < 4) throw new ArgumentException("Name length must be at least 4 characters");
                _name = value;
            }

        }

        public int Price { get => _price;
            set 
            {
                if (value == 0) throw new ArgumentNullException(" Price is not allowed to be 0");
                _price = value;
            }
        }


        public int ShirtNumber { get=> _shirtno;
            set 
            {
                if (1 <= value && value <= 100) _shirtno = value;
                else throw new ArgumentOutOfRangeException("Shirtno:",value, "Not allowed. Only 1-100");
            } 
        }

    }
}
