using Assignment_3.Repository;
using Assignmet_3.Domain.Models;
using FluentAssertions;
using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3.Test.Unit
{
    public class ContextTests
    {
        [Fact]
        public void AddTeam_ShouldAddNewTeam()
        {
            var Corinthians = new Team { Name = "Corinthians", Color = "Black", Id = 10 };
            Context.Instance.AddTeam(Corinthians);
            Context.Instance.Teams.Should().Contain(Corinthians);
        }

        [Fact]
        public void AddTeam_ShouldNotAddDuplicatedTeam()
        {
            var Corinthians = new Team { Name = "Corinthians", Color = "Black", Id = 10 };
            Context.Instance.AddTeam(Corinthians);
            Context.Instance.AddTeam(Corinthians);
            Context.Instance.Teams.Should().OnlyHaveUniqueItems();
        }

        [Fact]
        public void GetPlayersByTeam_ShouldReturnPlayersFromTheRequiredTime()
        {
            var result = Context.Instance.GetPlayersByTeam(3);
           
            result.Should().HaveCount(4);
        }

        [Fact]

        /*      At least 10 players: You should have data for a minimum of 10 players.
	            At least 3 different teams: The players must be from different teams to showcase variety.
	            Data for each player: The player�s name, team, photo, and at least 4 other relevant statistics for the sport.
         */
        public void ContextInstanceShouldHaveAtLeastTenPlayers()
        {
            var result = Context.Instance.GetAllPlayers();
            result.Count().Should().BeGreaterThanOrEqualTo(10);

        }

        [Fact]
        public void ContextInstanceShouldHaveAtLeastThreeTeams()
        {
            var result = Context.Instance.GetAllTeams();
            result.Count().Should().BeGreaterThanOrEqualTo(3);
        }

        [Fact]
        public void EachPlayerShouldHaveToContainAllAttributes()
        {
            var players = Context.Instance.GetAllPlayers();
            foreach (var player in players)
            {
                player.Id.Should().NotBe(null);
                player.Name.Should().NotBe(null);
                player.Age.Should().NotBe(null);
                player.Team.Should().NotBe(null);
                player.AveragePoints.Should().NotBe(null);
                player.Image.Should().NotBe(null);
                player.Height.Should().NotBe(null);
                player.FoulsPerGame.Should().NotBe(null);
                
            }
            
                
            
        }
    }
    

}