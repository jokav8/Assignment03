using Assignmet_3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.Repository
{
    public class Context
    {
        private Context()
        {
            Players = new List<Player>();
            var DenverNuggets = new Team { Name = "Denver Nuggets", Color = "Blue", Id = 1 };
            var BostonCeltics = new Team { Name = "Boston Celtics", Color = "Green", Id = 2 };
            var MilwaukeeBucks = new Team { Name = "Milwaukee Bucks", Color = "Red", Id = 3 };

            Teams.Add(DenverNuggets);
            Teams.Add(BostonCeltics);
            Teams.Add(MilwaukeeBucks);

            Players.Add(new Player
            {
                Name = "Giannis Antetokounmpo", Age = 29, AveragePoints = 31.1m, FoulsPerGame = 3.0m, Height = 7m,
                Id = 1, Team = MilwaukeeBucks, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Damian Lillard", Age = 33, AveragePoints = 28.7m, Height = 6.2m, FoulsPerGame = 2m, Id = 2,
                Team = MilwaukeeBucks, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Khris Middleton", Age = 32, AveragePoints = 15.1m, Height = 6.7m, FoulsPerGame = 2.3m, Id = 3,
                Team = MilwaukeeBucks, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Brook Lopez", Age = 35, AveragePoints = 15.9m, Height = 7m, FoulsPerGame = 2.1m, Id = 4,
                Team = MilwaukeeBucks, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Nikola Jokić", Age = 28, AveragePoints = 24.5m, Height = 6.11m, FoulsPerGame = 2.4m, Id = 5,
                Team = DenverNuggets, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Jamal Murray", Age = 26, AveragePoints = 20.0m, Height = 6.4m, FoulsPerGame = 1.8m, Id = 6,
                Team = DenverNuggets, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Aaron Gordon", Age = 28, AveragePoints = 16.3m, Height = 6.8m, FoulsPerGame = 2.1m, Id = 7,
                Team = DenverNuggets, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Michael Porter Jr.", Age = 25, AveragePoints = 17.4m, Height = 6.10m, FoulsPerGame = 1.7m,
                Id = 8, Team = DenverNuggets, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Jayson Tatum", Age = 25, AveragePoints = 30.1m, Height = 6.8m, FoulsPerGame = 2.2m, Id = 9,
                Team = BostonCeltics, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Jaylen Brown", Age = 27, AveragePoints = 26.6m, Height = 6.6m, FoulsPerGame = 2.5m, Id = 10,
                Team = BostonCeltics, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Kristaps Porzingis", Age = 28, AveragePoints = 20.5m, Height = 7.3m, FoulsPerGame = 2.3m,
                Id = 11, Team = BostonCeltics, Image = ""
            });
            Players.Add(new Player
            {
                Name = "Derrick White", Age = 29, AveragePoints = 13.4m, Height = 6.4m, FoulsPerGame = 1.5m, Id = 12,
                Team = BostonCeltics, Image = "null"
            });
        }

        private static Context instance;

        public static Context Instance
        {
            get
            {
                if (instance is null)
                    instance = new Context();
                return instance;
            }
        }

        public List<Player> Players { get; private set; }
        public List<Team> Teams { get; private set; } = new List<Team>();

        public void AddTeam(Team team)
        {
            if (Teams.Any(x => x.Id == team.Id))
                return;
            Teams.Add(team);
        }

        public List<Player> GetPlayersByTeam(int teamId)
        {
            return Players.Where(player => player.Team.Id == teamId).ToList();
        }

        public Player? AddNewPlayer(string? name, int? age)
        {
            if (age is null)
                return null;
            if (string.IsNullOrEmpty(name))
                return null;
            return null;
            //do it the test unit for this
        }

        public List<Player> GetAllPlayers()
        {
            return Players.ToList();
        }

        public List<Team> GetAllTeams()
        {
            return Teams.ToList();
        }
    }
}