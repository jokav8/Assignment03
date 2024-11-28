using Assignmet_3.Domain.Models;

namespace Assignment_3.Presentation;

public partial class Details : Form
{
    private readonly Player _player;
    public Details(Player player)
    {
        InitializeComponent();
        _player = player;
        Text = _player.Name;
    }
}