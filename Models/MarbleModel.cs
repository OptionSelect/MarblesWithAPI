using System;
using System.Collections.Generic;

namespace MarblesWithAPI.Models
{
    public class MarbleModel
    {
        public int ID { get; set; }
        public string MarbleColor { get; set; }
        public MarbleModel(){}
        public List<MarbleModel> MarbleBagGetter()
        {
            var MarbleList = new List<MarbleModel>();
            var Marble1 = new MarbleModel{
                ID = 1,
                MarbleColor = "Blue"
            };
            var Marble2 = new MarbleModel{
                ID = 2,
                MarbleColor = "Red"
            };
            var Marble3 = new MarbleModel{
                ID = 3,
                MarbleColor = "Green"
            };
            var Marble4 = new MarbleModel{
                ID = 4,
                MarbleColor = "Yellow"
            };
            MarbleList.Add(Marble1);
            MarbleList.Add(Marble2);
            MarbleList.Add(Marble3);
            MarbleList.Add(Marble4);
            return MarbleList;
        }

        public override string ToString()
        {
            return $"Marble: {ID} is of the color {MarbleColor}";
        }
    }
}