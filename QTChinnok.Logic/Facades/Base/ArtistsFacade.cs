﻿//@GeneratedCode
namespace QTChinnok.Logic.Facades.Base
{
    using TOutModel = Models.Base.Artist;
    ///
    /// Generated by the generator
    ///
    public sealed partial class ArtistsFacade : ControllerFacade<TOutModel>, Contracts.Base.IArtistsAccess<TOutModel>
    {
        ///
        /// Generated by the generator
        ///
        static ArtistsFacade()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public ArtistsFacade()
        : base(new QTChinnok.Logic.Controllers.Base.ArtistsController())
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public ArtistsFacade(FacadeObject facadeObject)
        : base(new QTChinnok.Logic.Controllers.Base.ArtistsController(facadeObject.ControllerObject))
        {
            Constructing();
            
            Constructed();
        }
    }
}
