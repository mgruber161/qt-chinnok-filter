namespace QTChinnok.Logic.Contracts.App
{
    public partial interface IAlbumsAccess : Contracts.IDataAccess<TOutModel>
    {
		Task<Logic.Models.App.Album[]> QueryByAsync(string? albumName, string? artistName);
	}
}
