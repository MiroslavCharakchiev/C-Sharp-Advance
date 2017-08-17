using System;

namespace CardSuit
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string category, string description)
        {
            this.Type = "Enumeration";
            this.Category = category;
            this.Description = description;
        }

        public string Type { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}