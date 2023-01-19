﻿//@GeneratedCode
namespace QTChinnok.AspMvc
{
    ///
    /// Generated by the generator
    ///
    partial class Program
    {
        static partial void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<QTChinnok.Logic.Contracts.Base.IArtistsAccess<QTChinnok.Logic.Models.Base.Artist>, QTChinnok.Logic.Controllers.Base.ArtistsController>();
            builder.Services.AddTransient<QTChinnok.Logic.Contracts.Base.IGenresAccess<QTChinnok.Logic.Models.Base.Genre>, QTChinnok.Logic.Controllers.Base.GenresController>();
            builder.Services.AddTransient<QTChinnok.Logic.Contracts.Base.IMediaTypesAccess<QTChinnok.Logic.Models.Base.MediaType>, QTChinnok.Logic.Controllers.Base.MediaTypesController>();
        }
    }
}