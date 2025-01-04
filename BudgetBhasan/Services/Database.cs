namespace BudgetBhasan.Services;
using SQLite;
using BudgetBhasan.Models;

public class Database
{
    private SQLiteAsyncConnection _database;

    public Database()
    {
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "budgetbhasan.db");
        _database = new SQLiteAsyncConnection(dbPath);

        // Create tables for all models
        _database.CreateTableAsync<User>().Wait();
        _database.CreateTableAsync<Inflow>().Wait();
        _database.CreateTableAsync<Outflow>().Wait();
        _database.CreateTableAsync<Debt>().Wait();
    }

    // User Methods
    public async Task<bool> AddUserAsync(User user)
    {
        try
        {
            await _database.InsertAsync(user);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        try
        {
            return await _database.Table<User>().ToListAsync();
        }
        catch
        {
            return new List<User>();
        }
    }

    public async Task<bool> UpdateUserAsync(User user)
    {
        try
        {
            await _database.UpdateAsync(user);
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Inflow Methods
    public async Task<bool> AddInflowAsync(Inflow inflow)
    {
        try
        {
            await _database.InsertAsync(inflow);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<Inflow>> GetAllInflowsAsync()
    {
        try
        {
            return await _database.Table<Inflow>().ToListAsync();
        }
        catch
        {
            return new List<Inflow>();
        }
    }

    // Outflow Methods
    public async Task<bool> AddOutflowAsync(Outflow outflow)
    {
        try
        {
            await _database.InsertAsync(outflow);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<Outflow>> GetAllOutflowsAsync()
    {
        try
        {
            return await _database.Table<Outflow>().ToListAsync();
        }
        catch
        {
            return new List<Outflow>();
        }
    }

    public async Task<bool> UpdateOutflowAsync(Outflow outflow)
    {
        try
        {
            await _database.UpdateAsync(outflow);
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    // Debt Method
    public async Task<bool> AddDebtAsync(Debt debt)
    {
        try
        {
            await _database.InsertAsync(debt);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding debt: {ex.Message}");
            return false;
        }
    }
    
    public async Task<List<Debt>> GetAllDebtsAsync()
    {
        try
        {
            return await _database.Table<Debt>().ToListAsync();
        }
        catch
        {
            return new List<Debt>();
        }
    }

    public async Task<bool> UpdateDebtAsync(Debt debt)
    {
        try
        {
            await _database.UpdateAsync(debt);
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    public async Task<Debt> GetDebtByIdAsync(Guid debtId)
    {
        try
        {
            return await _database.Table<Debt>().FirstOrDefaultAsync(d => d.debtId == debtId);
        }
        catch
        {
            return null;
        }
    }

}

