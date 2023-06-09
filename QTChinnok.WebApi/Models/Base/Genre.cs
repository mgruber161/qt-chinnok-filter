﻿//@GeneratedCode
namespace QTChinnok.WebApi.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    
    public partial class Genre
    {
        ///
        /// Generated by the generator
        ///
        static Genre()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Genre()
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
        public static QTChinnok.WebApi.Models.Base.Genre Create()
        {
            BeforeCreate();
            var result = new QTChinnok.WebApi.Models.Base.Genre();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.WebApi.Models.Base.Genre Create(object other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.WebApi.Models.Base.Genre();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTChinnok.WebApi.Models.Base.Genre instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTChinnok.WebApi.Models.Base.Genre instance, object other);
        ///
        /// Generated by the generator
        ///
        public static QTChinnok.WebApi.Models.Base.Genre Create(QTChinnok.Logic.Models.Base.Genre other)
        {
            BeforeCreate(other);
            var result = new QTChinnok.WebApi.Models.Base.Genre();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate(QTChinnok.Logic.Models.Base.Genre other);
        static partial void AfterCreate(QTChinnok.WebApi.Models.Base.Genre instance, QTChinnok.Logic.Models.Base.Genre other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTChinnok.Logic.Models.Base.Genre other)
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
        partial void BeforeCopyProperties(QTChinnok.Logic.Models.Base.Genre other, ref bool handled);
        partial void AfterCopyProperties(QTChinnok.Logic.Models.Base.Genre other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTChinnok.WebApi.Models.Base.Genre other)
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
        partial void BeforeCopyProperties(QTChinnok.WebApi.Models.Base.Genre other, ref bool handled);
        partial void AfterCopyProperties(QTChinnok.WebApi.Models.Base.Genre other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.Genre other)
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
            return this.CalculateHashCode(Id, Name);
        }
    }
}
