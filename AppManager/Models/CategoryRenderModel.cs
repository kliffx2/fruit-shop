﻿namespace AppManager.Models
{
    public class CategoryRenderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int FileId { get; set; }
        public string FilePath { get; set; }
    }
}
