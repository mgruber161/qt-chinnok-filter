﻿//@GeneratedCode
namespace QTChinnok.Logic.Models.Base
{
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
            _source = new Entities.Base.Artist();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        internal Artist(Entities.Base.Artist source)
        {
            Constructing();
            _source = source;
            Constructed();
        }
        
        new internal Entities.Base.Artist Source
        {
            get => (Entities.Base.Artist)(_source ??= new Entities.Base.Artist());
            set => _source = value;
        }
        
        public System.String? Name
        {
            get => Source.Name;
            set => Source.Name = value;
        }
        
        public System.Collections.Generic.IList<QTChinnok.Logic.Models.App.Album> Albums
        {
            get => new CommonBase.Modules.Collection.DelegateList<QTChinnok.Logic.Entities.App.Album, QTChinnok.Logic.Models.App.Album>(Source.Albums, e => QTChinnok.Logic.Models.App.Album.Create(e));
        }
        ///
        /// Generated by the generator
        ///
        internal void CopyProperties(Entities.Base.Artist other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Id = other.Id;
                Name = other.Name;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(Entities.Base.Artist other, ref bool handled);
        partial void AfterCopyProperties(Entities.Base.Artist other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTChinnok.Logic.Models.Base.Artist other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Id = other.Id;
                Name = other.Name;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTChinnok.Logic.Models.Base.Artist other, ref bool handled);
        partial void AfterCopyProperties(QTChinnok.Logic.Models.Base.Artist other);
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
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.Base.Artist Create()
        {
            BeforeCreate();
            var result = new QTChinnok.Logic.Models.Base.Artist();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.Base.Artist Create(object other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.Base.Artist();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.Base.Artist Create(QTChinnok.Logic.Models.Base.Artist other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.Base.Artist();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.Base.Artist Create(Entities.Base.Artist other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.Base.Artist();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTChinnok.Logic.Models.Base.Artist instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTChinnok.Logic.Models.Base.Artist instance, object other);
        static partial void BeforeCreate(QTChinnok.Logic.Models.Base.Artist other);
        static partial void AfterCreate(QTChinnok.Logic.Models.Base.Artist instance, QTChinnok.Logic.Models.Base.Artist other);
        static partial void BeforeCreate(Entities.Base.Artist other);
        static partial void AfterCreate(QTChinnok.Logic.Models.Base.Artist instance, Entities.Base.Artist other);
    }
}