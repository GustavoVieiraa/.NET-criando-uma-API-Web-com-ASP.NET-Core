using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopuplarTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
             "Michael Jackson", "Michael Joseph Jackson foi um cantor, compositor, dançarino e filantropo estadunidense.", 
                "https://mjbeats.com.br/wp-content/uploads/2023/06/Bart-Simpson-e-Michael-Jackson-thriller-MJ-Beats.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
{
            "Freddie Mercury", "Freddie Mercury foi um cantor, pianista e compositor britânico, vocalista da icônica banda Queen.",
            "https://upload.wikimedia.org/wikipedia/commons/0/0d/Freddie_Mercury_performing_in_New_Haven%2C_CT%2C_November_1977.jpg"
});

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Beyoncé", "Beyoncé Knowles é uma cantora, compositora e atriz norte-americana, ex-integrante do Destiny’s Child.",
            "https://upload.wikimedia.org/wikipedia/commons/6/64/Beyonce_-_The_Formati%C3%B3n_World_Tour%2C_2016.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Elvis Presley", "Elvis Aaron Presley foi um cantor e ator norte-americano, considerado o Rei do Rock.",
            "https://upload.wikimedia.org/wikipedia/commons/d/d4/Elvis_Presley_1970.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Lady Gaga", "Lady Gaga é uma cantora, compositora e atriz americana, conhecida por seu estilo excêntrico e voz poderosa.",
            "https://upload.wikimedia.org/wikipedia/commons/8/8c/Lady_Gaga_2019.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Kurt Cobain", "Kurt Cobain foi um músico americano, vocalista e guitarrista da banda Nirvana.",
            "https://upload.wikimedia.org/wikipedia/commons/3/36/Kurt_Cobain_1993.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Rihanna", "Rihanna é uma cantora, atriz e empresária barbadiana, conhecida por hits como Umbrella e Diamonds.",
            "https://upload.wikimedia.org/wikipedia/commons/3/32/Rihanna_2018.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "David Bowie", "David Bowie foi um cantor, compositor e ator britânico, um dos artistas mais inovadores do século XX.",
            "https://upload.wikimedia.org/wikipedia/commons/a/a5/David-Bowie_Chicago_2002-08-08_photoby_Adam-Bielawski-cropped.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Adele", "Adele é uma cantora e compositora britânica conhecida por sua poderosa voz e baladas emocionantes.",
            "https://upload.wikimedia.org/wikipedia/commons/4/4f/Adele_2016.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Bob Marley", "Bob Marley foi um cantor, compositor e guitarrista jamaicano, o mais famoso expoente do reggae.",
            "https://upload.wikimedia.org/wikipedia/commons/c/cd/Bob-Marley.jpg"
            });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[]
            {
            "Whitney Houston", "Whitney Houston foi uma cantora e atriz norte-americana, uma das vozes mais icônicas da música pop.",
            "https://upload.wikimedia.org/wikipedia/commons/a/a6/Whitney_Houston_Welcome_Home_Heroes_1_cropped.jpg"
            });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
