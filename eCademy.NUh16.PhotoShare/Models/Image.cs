﻿using System;

namespace eCademy.NUh16.PhotoShare.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Timestamp { get; set; }

        public byte[] ImageData { get; set; }
    }
}