using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QTChinnok.Logic.Migrations
{
    /// <inheritdoc />
    public partial class AddedMusicCollection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "musiccollections",
                columns: table => new
                {
                    MusicCollectionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 160, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musiccollections", x => x.MusicCollectionId);
                });


            migrationBuilder.CreateTable(
                name: "AlbumMusicCollection",
                columns: table => new
                {
                    AlbumsId = table.Column<int>(type: "INTEGER", nullable: false),
                    MusicCollectionsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumMusicCollection", x => new { x.AlbumsId, x.MusicCollectionsId });
                    table.ForeignKey(
                        name: "FK_AlbumMusicCollection_albums_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "albums",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlbumMusicCollection_musiccollections_MusicCollectionsId",
                        column: x => x.MusicCollectionsId,
                        principalTable: "musiccollections",
                        principalColumn: "MusicCollectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumMusicCollection_MusicCollectionsId",
                table: "AlbumMusicCollection",
                column: "MusicCollectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_albums_ArtistId",
                table: "albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_musiccollections_Name",
                table: "musiccollections",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumMusicCollection");

            migrationBuilder.DropTable(
                name: "musiccollections");

        }
    }
}
