﻿//@GeneratedCode
namespace QTChinnok.MvvMApp.Models.App
{
    using System;
    ///
    /// Generated by the generator
    ///
    
    public partial class MusicCollection
    {
        ///
        /// Generated by the generator
        ///
        static MusicCollection()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public MusicCollection()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        
        public System.String Name { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        
        public System.Collections.Generic.List<QTChinnok.MvvMApp.Models.App.Album> Albums { get; set; } = new();
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.MvvMApp.Models.App.MusicCollection Create()
        {
            BeforeCreate();
            var result = new QTChinnok.MvvMApp.Models.App.MusicCollection();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.MvvMApp.Models.App.MusicCollection Create(object other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.MvvMApp.Models.App.MusicCollection();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTChinnok.MvvMApp.Models.App.MusicCollection instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTChinnok.MvvMApp.Models.App.MusicCollection instance, object other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.App.MusicCollection other)
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
