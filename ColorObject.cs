using UnityEngine;
using System.Collections;
using OpenCVForUnity.CoreModule;

namespace OpenCVForUnityExample
{
    public class ColorObject
    {
        int xPos, yPos;
        string type;
        Scalar HSVmin, HSVmax;
        Scalar Color;

        public ColorObject ()
        {
            //set values for default constructor
            setType ("Object");
            setColor (new Scalar (0, 0, 0));
        }

        public ColorObject (string name)
        {
            setType (name);
            if (name == "red") {
                setHSVmin (new Scalar (160, 120, 67));
                setHSVmax (new Scalar (200, 255, 255));
            }
            if (name == "green")
            {
                //baby BLUE DAY
                setHSVmin(new Scalar(95, 157, 65));
                setHSVmax(new Scalar(118, 255, 255));

                //baby blue living room day
                setHSVmin(new Scalar(90, 93, 18));
                setHSVmax(new Scalar(107, 255, 255));
            }
        }

        //OpenCV for Unity Asset Helper Methods
        public int getXPos () { return xPos;}

        public void setXPos (int x) {xPos = x; }

        public int getYPos (){return yPos;}

        public void setYPos (int y) {yPos = y;}

        public Scalar getHSVmin () {return HSVmin;}

        public Scalar getHSVmax (){return HSVmax;}

        public void setHSVmin (Scalar min){ HSVmin = min;}

        public void setHSVmax (Scalar max) {HSVmax = max;}

        public string getType () {return type;}

        public void setType (string t) {type = t; }

        public Scalar getColor (){ return Color; }

        public void setColor (Scalar c){ Color = c; }
    }
}