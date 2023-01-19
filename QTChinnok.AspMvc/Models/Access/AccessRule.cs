﻿//@CodeCopy
//MdStart
#if ACCOUNT_ON && ACCESSRULES_ON
namespace QTChinnok.AspMvc.Models.Access
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class AccessRule : VersionModel
    {
        ///
        /// Generated by the generator
        ///
        static AccessRule()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Generated by the generator
        ///
        public AccessRule()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public Logic.Modules.Access.RuleType Type
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.String EntityType
        {
            get;
            set;
        }
        = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String? RelationshipEntityType
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.String? PropertyName
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.String? EntityValue
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public Logic.Modules.Access.AccessType AccessType
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.String? AccessValue
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Boolean Creatable
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Boolean Readable
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Boolean Updatable
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Boolean Deletable
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.Boolean Viewable
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.DateTime CreatedOn
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public System.DateTime? ModifiedOn
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public IdType? IdentityId_CreatedBy
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public IdType? IdentityId_ModifiedBy
        {
            get;
            set;
        }
        ///
        /// Generated by the generator
        ///
        public static AspMvc.Models.Access.AccessRule Create()
        {
            BeforeCreate();
            var result = new AspMvc.Models.Access.AccessRule();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static AspMvc.Models.Access.AccessRule Create(object other)
        {
            BeforeCreate(other);
            var result = new AspMvc.Models.Access.AccessRule();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(AspMvc.Models.Access.AccessRule instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(AspMvc.Models.Access.AccessRule instance, object other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(AspMvc.Models.Access.AccessRule other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Type = other.Type;
                EntityType = other.EntityType;
                RelationshipEntityType = other.RelationshipEntityType;
                PropertyName = other.PropertyName;
                EntityValue = other.EntityValue;
                AccessType = other.AccessType;
                AccessValue = other.AccessValue;
                Creatable = other.Creatable;
                Readable = other.Readable;
                Updatable = other.Updatable;
                Deletable = other.Deletable;
                Viewable = other.Viewable;
                Id = other.Id;
#if ROWVERSION_ON
                RowVersion = other.RowVersion;
#endif
#if CREATED_ON
                CreatedOn = other.CreatedOn;
#endif
#if CREATEDBY_ON
                IdentityId_CreatedBy = other.IdentityId_CreatedBy;
#endif
#if MODIFIED_ON
                ModifiedOn = other.ModifiedOn;
#endif
#if MODIFIEDBY_ON
                IdentityId_ModifiedBy = other.IdentityId_ModifiedBy;
#endif
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(AspMvc.Models.Access.AccessRule other, ref bool handled);
        partial void AfterCopyProperties(AspMvc.Models.Access.AccessRule other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Access.AccessRule other)
            {
#if ROWVERSION_ON
                result = IsEqualsWith(RowVersion, other.RowVersion) && Id == other.Id;
#else
                result = Id == other.Id;
#endif
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return HashCode.Combine(Type, EntityType, RelationshipEntityType, PropertyName, EntityValue, AccessType, HashCode.Combine(AccessValue, Creatable, Readable, Updatable, Deletable, Viewable, Id));
        }
    }
}
#endif
//MdEnd
