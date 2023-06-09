﻿//@GeneratedCode
namespace QTChinnok.MvvMApp.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    
    public partial class Artist
    {
        ///
        /// Generated by the generator
        ///
        static Artist()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Artist()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        
        public System.String? Name { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public System.Collections.Generic.List<QTChinnok.MvvMApp.Models.App.Album> Albums { get; set; } = new();
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.MvvMApp.Models.Base.Artist Create()
        {
            BeforeCreate();
            var result = new QTChinnok.MvvMApp.Models.Base.Artist();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.MvvMApp.Models.Base.Artist Create(object other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.MvvMApp.Models.Base.Artist();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTChinnok.MvvMApp.Models.Base.Artist instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTChinnok.MvvMApp.Models.Base.Artist instance, object other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.Artist other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return this.CalculateHashCode(Id, Name, Albums);
        }
    }
}
