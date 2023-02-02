#if GENERATEDCODE_ON
namespace QTChinnok.Logic.Contracts.App
{
    partial interface IMusicCollectionsAccess<T>
    {
        Task AddAlbumAsync(int musicCollectionId, int albumId);
        Task RemoveAlbumAsync(int musicCollectionId, int albumId);
    }
}
#endif