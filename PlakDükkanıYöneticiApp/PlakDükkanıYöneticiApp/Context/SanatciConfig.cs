using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlakDükkanıYöneticiApp.Entities;

namespace PlakDükkanıYöneticiApp.Context
{
    public class SanatciConfig : IEntityTypeConfiguration<Sanatci>
    {

        public void Configure(EntityTypeBuilder<Sanatci> builder)
        {

            builder.HasData(
                    new Sanatci
                    {
                        Id = 1,
                        AlbumSanatcısı = "Hadise"

                    },
                    new Sanatci
                    {
                        Id = 2,
                        AlbumSanatcısı = "Tarkan"

                    },
                    new Sanatci
                    {
                        Id = 3,
                        AlbumSanatcısı = "Azer Bülbül"

                    },
                    new Sanatci
                    {
                        Id = 4,
                        AlbumSanatcısı = "Rihanna"

                    },
                    new Sanatci
                    {
                        Id = 5,
                        AlbumSanatcısı = "Lady Gaga"

                    }
                    );
        }
    }

}