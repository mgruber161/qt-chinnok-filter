﻿//@GeneratedCode
namespace QTChinnok.Logic.Models.App
{
    ///
    /// Generated by the generator
    ///
    public partial class Track
    {
        ///
        /// Generated by the generator
        ///
        static Track()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Track()
        {
            Constructing();
            _source = new Entities.App.Track();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        internal Track(Entities.App.Track source)
        {
            Constructing();
            _source = source;
            Constructed();
        }
        
        new internal Entities.App.Track Source
        {
            get => (Entities.App.Track)(_source!);
            set => _source = value;
        }
        
        public IdType? AlbumId
        {
            get => Source.AlbumId;
            set => Source.AlbumId = value;
        }
        
        public IdType? GenreId
        {
            get => Source.GenreId;
            set => Source.GenreId = value;
        }
        
        public IdType MediaTypeId
        {
            get => Source.MediaTypeId;
            set => Source.MediaTypeId = value;
        }
        
        public System.String Name
        {
            get => Source.Name;
            set => Source.Name = value;
        }
        
        public System.String? Composer
        {
            get => Source.Composer;
            set => Source.Composer = value;
        }
        
        public System.Int32 Milliseconds
        {
            get => Source.Milliseconds;
            set => Source.Milliseconds = value;
        }
        
        public System.Decimal UnitPrice
        {
            get => Source.UnitPrice;
            set => Source.UnitPrice = value;
        }
        ///
        /// Generated by the generator
        ///
        internal void CopyProperties(Entities.App.Track other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Id = other.Id;
                AlbumId = other.AlbumId;
                GenreId = other.GenreId;
                MediaTypeId = other.MediaTypeId;
                Name = other.Name;
                Composer = other.Composer;
                Milliseconds = other.Milliseconds;
                UnitPrice = other.UnitPrice;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(Entities.App.Track other, ref bool handled);
        partial void AfterCopyProperties(Entities.App.Track other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTChinnok.Logic.Models.App.Track other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Id = other.Id;
                AlbumId = other.AlbumId;
                GenreId = other.GenreId;
                MediaTypeId = other.MediaTypeId;
                Name = other.Name;
                Composer = other.Composer;
                Milliseconds = other.Milliseconds;
                UnitPrice = other.UnitPrice;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTChinnok.Logic.Models.App.Track other, ref bool handled);
        partial void AfterCopyProperties(QTChinnok.Logic.Models.App.Track other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.App.Track other)
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
            return this.CalculateHashCode(Id, AlbumId, GenreId, MediaTypeId, Name, Composer, Milliseconds, UnitPrice);
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.Track Create()
        {
            BeforeCreate();
            var result = new QTChinnok.Logic.Models.App.Track();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.Track Create(object other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.App.Track();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.Track Create(QTChinnok.Logic.Models.App.Track other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.App.Track();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.Track Create(Entities.App.Track other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.App.Track();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTChinnok.Logic.Models.App.Track instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTChinnok.Logic.Models.App.Track instance, object other);
        static partial void BeforeCreate(QTChinnok.Logic.Models.App.Track other);
        static partial void AfterCreate(QTChinnok.Logic.Models.App.Track instance, QTChinnok.Logic.Models.App.Track other);
        static partial void BeforeCreate(Entities.App.Track other);
        static partial void AfterCreate(QTChinnok.Logic.Models.App.Track instance, Entities.App.Track other);
    }
}
