using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace week_5_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class seedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Jobs (Id, Company, JobTitle, JobDescription, StartDate, EndDate)
                VALUES('1','Chevron', 'Internship', 'ibhwiiiiiiiivihvfebvqv ', '12/02/2022' ,'12/02/2023'),
                ('2','Suntrust', 'Internship', 'ibhwiiiiiiiivihvfebvqv ', '12/02/2023' ,'12/02/2024'),
                ('3','Decagon', 'Internship', 'ibhwiiiiiiiivihvfebvqv ', '12/02/2021' ,'12/02/2023'),
                ('4','Nestoil', 'Internship', 'ibhwiiiiiiiivihvfebvqv ', '12/02/2020' ,'12/02/2021'),
                ('5','PWC', 'Internship', 'ibhwiiiiiiiivihvfebvqv ', '12/02/2019' ,'12/02/2020')
                
                ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
