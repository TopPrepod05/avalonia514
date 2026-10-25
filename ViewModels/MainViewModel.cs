using AvaloniaApplication12.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AvaloniaApplication12.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string login = "";
    [ObservableProperty] private string email = "";
    ObservableCollection<User> Users { get; set; } = [];
    public MainViewModel()
    {
        _ = LoadUsersAsync();
    }

    private async Task LoadUsersAsync()
    {
        using var db = new AppDbContext();
        var urs = await db.Users.ToListAsync();
        Users.Clear();
        foreach (var u in urs) Users.Add(u);
    }

    [RelayCommand] private async Task AddUser()
    {
        using var db = new AppDbContext();
        var nU = new User { Login = this.Login, Email = this.Email };
        await db.AddAsync(nU);
        await db.SaveChangesAsync();
    }

    [RelayCommand] private async Task DeleteUser()
    {

    }
}
