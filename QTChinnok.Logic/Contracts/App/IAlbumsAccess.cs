﻿//@GeneratedCode
namespace QTChinnok.Logic.Contracts.App
{
    using TOutModel = Models.App.Album;
    ///
    /// Generated by the generator
    ///
    public partial interface IAlbumsAccess : Contracts.IDataAccess<TOutModel>
    {
        Task<Logic.Models.App.Album[]> QueryByAsync(string? albumName, string? artistName);
    }
}
