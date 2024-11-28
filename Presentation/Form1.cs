using Assignment_3.Repository;
using Assignmet_3.Domain.Models;

namespace Assignment_3.Presentation;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitPlayersList();
    }

    private void InitPlayersList()
    {
        PlayerList.DataSource = Context.Instance.GetAllPlayers();
        PlayerList.DisplayMember = "Name";
        PlayerList.ValueMember = "Id";
        PlayerList.SelectedIndex = -1;
        Name.Text = string.Empty;
        TeamName.Text = string.Empty;


        PlayerList.SelectedIndexChanged += (sender, args) =>
        {
            if (sender is not ListBox { SelectedItem: Player selectedPlayer }) return;

            Name.Text = selectedPlayer.Name;
            TeamName.Text = selectedPlayer.Team.Name;
            TeamName.ForeColor = Color.FromName(selectedPlayer.Team.Color);

            DetailsBtn.Click -= DetailsOnClick();
            DetailsBtn.Click += DetailsOnClick();
        };
    }

    EventHandler? DetailsOnClick()
    {
        return (sender, args) =>
        {
            var details = new Details(PlayerList.SelectedItem as Player);
            details.Show();
        };
    }
}