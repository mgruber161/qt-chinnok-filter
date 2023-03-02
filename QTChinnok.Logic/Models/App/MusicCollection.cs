﻿//@GeneratedCode
namespace QTChinnok.Logic.Models.App
{
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
            _source = new Entities.App.MusicCollection();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        internal MusicCollection(Entities.App.MusicCollection source)
        {
            Constructing();
            _source = source;
            Constructed();
        }
        
        new internal Entities.App.MusicCollection Source
        {
            get => (Entities.App.MusicCollection)(_source ??= new Entities.App.MusicCollection());
            set => _source = value;
        }
        
        public System.String Name
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
        internal void CopyProperties(Entities.App.MusicCollection other)
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
        partial void BeforeCopyProperties(Entities.App.MusicCollection other, ref bool handled);
        partial void AfterCopyProperties(Entities.App.MusicCollection other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTChinnok.Logic.Models.App.MusicCollection other)
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
        partial void BeforeCopyProperties(QTChinnok.Logic.Models.App.MusicCollection other, ref bool handled);
        partial void AfterCopyProperties(QTChinnok.Logic.Models.App.MusicCollection other);
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
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.MusicCollection Create()
        {
            BeforeCreate();
            var result = new QTChinnok.Logic.Models.App.MusicCollection();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.MusicCollection Create(object other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.App.MusicCollection();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.MusicCollection Create(QTChinnok.Logic.Models.App.MusicCollection other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.App.MusicCollection();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.Logic.Models.App.MusicCollection Create(Entities.App.MusicCollection other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.Logic.Models.App.MusicCollection();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTChinnok.Logic.Models.App.MusicCollection instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTChinnok.Logic.Models.App.MusicCollection instance, object other);
        static partial void BeforeCreate(QTChinnok.Logic.Models.App.MusicCollection other);
        static partial void AfterCreate(QTChinnok.Logic.Models.App.MusicCollection instance, QTChinnok.Logic.Models.App.MusicCollection other);
        static partial void BeforeCreate(Entities.App.MusicCollection other);
        static partial void AfterCreate(QTChinnok.Logic.Models.App.MusicCollection instance, Entities.App.MusicCollection other);
    }
}
