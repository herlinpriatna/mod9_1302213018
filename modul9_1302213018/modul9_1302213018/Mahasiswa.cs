﻿using Microsoft.VisualBasic;

namespace modul9_1302213018
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }
        public List<String> Course { get; set; }
        public int Year { get; set; }
        public Mahasiswa()
        {
            Course = new List<string>();
        }
    }
}
