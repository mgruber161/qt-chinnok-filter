﻿//@GeneratedCode
namespace QTChinnok.AspMvc.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class ArtistFilter : Models.View.IFilterModel
    {
        ///
        /// Generated by the generator
        ///
        static ArtistFilter()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public ArtistFilter()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        
        ///
        /// Generated by the generator
        ///
        public System.String? Name
        { get; set; }
        ///
        /// Generated by the generator
        ///
        public bool HasEntityValue => Name != null;
        private bool show = true;
        ///
        /// Generated by the generator
        ///
        public bool Show => show;
        ///
        /// Generated by the generator
        ///
        public string CreateEntityPredicate()
        {
            var result = new System.Text.StringBuilder();
            
            if (Name != null)
            {
                if (result.Length > 0)
                {
                    result.Append(" || ");
                }
                result.Append($"(Name != null && Name.Contains(\"{Name}\"))");
            }
            return result.ToString();
        }
        ///
        /// Generated by the generator
        ///
        public override string ToString()
        {
            System.Text.StringBuilder sb = new();
            if (string.IsNullOrEmpty(Name) == false)
{
sb.Append($"Name: {Name} ");
}
            return sb.ToString();
        }
    }
}
