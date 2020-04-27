using System;
using System.Collections.Generic;
using System.Text;

namespace Answers.SecondExercise
{
    public class Knife : ISharp
    {
        private double length;
        public double Length { get { return length; } set {if(value>0) length = value; } }
        private string material;
        public string Material { get { return material; } set { if (!string.IsNullOrEmpty(value)) material = value; } }
        public bool IsSharp { get; set; }
    }
}
