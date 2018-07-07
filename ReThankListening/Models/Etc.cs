using System;
using System.Collections.Generic;
using System.Text;

namespace ReThankListening.Models
{
    public class Location
    {
        private Uri URLField;
        public Uri URL { get => URLField; set => URLField = value; }

        private string ExtraField;
        public string Extra { get => ExtraField; set => ExtraField = value; }

    }
}
