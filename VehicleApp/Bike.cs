using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class Bike
    {
        private string model = string.Empty;
        private int horsePower = 0;
        private double currSpeed = 0.0;
        private Color color = Color.Red;

        public void Accelerate(double speedToReach)
        {
            currSpeed = speedToReach;
        }

        public void Brake()
        {
            currSpeed = 0;
        }

        public void SetModel(string newModel)
        {
            model = newModel;
        }

        public void SetHorsePower(int newHorsePower)
        {
            horsePower = newHorsePower;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            string strOut = model + " Horse power = " + horsePower.ToString() + " Color = " + color.ToString() + " and the current speed is " + currSpeed.ToString();

            return strOut;
        }
    }
}
