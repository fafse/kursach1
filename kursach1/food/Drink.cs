﻿using System;
using System.Drawing;

namespace kursach1.food
{
    public class Drink
    {
        private Image _image;
        private int x, y;
        private int picSizeX, picSizeY;
        private String name;

        public Drink(String path)
        {
            _image = new Bitmap(path);
        }

        public String getName()
        {
            return name;
        }
    }
}