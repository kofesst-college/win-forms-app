﻿namespace WinFormsApp1.Models
{
    public class Passport
    {
        public int Number { get; set; }
        public int Series { get; set; }

        public override string ToString()
        {
            return $"{Number} {Series}";
        }
    }
}