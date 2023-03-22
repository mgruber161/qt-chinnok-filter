﻿//@GeneratedCode
namespace QTChinnok.MvvMApp.Models.App
{
    using System;
    ///
    /// Generated by the generator
    ///
    
    public partial class Album
    {
        ///
        /// Generated by the generator
        ///
        static Album()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Album()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        
        public IdType ArtistId { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public System.String Title { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        
        public QTChinnok.MvvMApp.Models.Base.Artist? Artist { get; set; }
        ///
        /// Generated by the generator
        ///
        
        public System.Collections.Generic.List<QTChinnok.MvvMApp.Models.App.Track> Tracks { get; set; } = new();
        ///
        /// Generated by the generator
        ///
        
        public System.Collections.Generic.List<QTChinnok.MvvMApp.Models.App.MusicCollection> MusicCollections { get; set; } = new();
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.MvvMApp.Models.App.Album Create()
        {
            BeforeCreate();
            var result = new QTChinnok.MvvMApp.Models.App.Album();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.MvvMApp.Models.App.Album Create(object other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.MvvMApp.Models.App.Album();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTChinnok.MvvMApp.Models.App.Album instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTChinnok.MvvMApp.Models.App.Album instance, object other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.App.Album other)
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
            return this.CalculateHashCode(Id, ArtistId, Title, Artist, Tracks, MusicCollections);
        }
    }
}