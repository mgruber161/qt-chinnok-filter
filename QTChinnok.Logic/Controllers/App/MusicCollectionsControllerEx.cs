#if GENERATEDCODE_ON
namespace QTChinnok.Logic.Controllers.App
{
    partial class MusicCollectionsController
    {
        internal override IEnumerable<string> Includes => new string[] { nameof(Entities.App.MusicCollection.Albums) };

        internal override async Task<Entities.App.MusicCollection> ExecuteInsertAsync(Entities.App.MusicCollection entity)
        {
            var albums = await QueryAlbums(entity).ToArrayAsync().ConfigureAwait(false);

            foreach (var item in entity.Albums.Where(e => e.Id > 0).ToArray())
            {
                entity.Albums.Remove(item);
            }
            entity.Albums.AddRange(albums);

            return await base.ExecuteInsertAsync(entity).ConfigureAwait(false);
        }
        internal override Entities.App.MusicCollection ExecuteUpdate(Entities.App.MusicCollection entity)
        {
            var albums = QueryAlbums(entity).ToArray();

            foreach (var item in entity.Albums.Where(e => e.Id > 0).ToArray())
            {
                entity.Albums.Remove(item);
            }
            entity.Albums.AddRange(albums);

            return base.ExecuteUpdate(entity);
        }
        private IQueryable<Entities.App.Album> QueryAlbums(Entities.App.MusicCollection entity)
        {
            using var albumCtrl = new AlbumsController(this);
            var albumIds = entity.Albums.Where(e => e.Id > 0).Select(a => a.Id);
            var query = albumCtrl.EntitySet.AsQueryable();

            return query.Where(e => albumIds.Contains(e.Id));
        }

        public async Task AddAlbumAsync(int musicCollectionId, int albumId)
        {
            using var albumCtrl = new AlbumsController(this);
            var musicCollection = await ExecuteGetByIdAsync(musicCollectionId).ConfigureAwait(false);
            var album = await albumCtrl.ExecuteGetByIdAsync(albumId).ConfigureAwait(false);

            if (musicCollection != null && album != null && musicCollection.Albums.Contains(album) == false)
            {
                musicCollection.Albums.Add(album);
            }
        }
        public async Task RemoveAlbumAsync(int musicCollectionId, int albumId)
        {
            var musicCollection = await ExecuteGetByIdAsync(musicCollectionId).ConfigureAwait(false);

            if (musicCollection != null)
            {
                var member = musicCollection.Albums.FirstOrDefault(m => m.Id == albumId);

                if (member != null)
                {
                    musicCollection.Albums.Remove(member);
                    await UpdateAsync(musicCollection).ConfigureAwait(false);
                }
            }
        }
    }
}
#endif