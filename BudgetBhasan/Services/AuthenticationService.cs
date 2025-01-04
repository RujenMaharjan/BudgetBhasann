namespace BudgetBhasan.Services
{ using BudgetBhasan.Models;
    

    public class AuthenticationService
    {
        private readonly Database _database;

        public AuthenticationService(Database database)
        {
            _database = database;
        }

        // Authenticate user using the database
        public async Task<bool> AuthenticateAsync(User user)
        {
            // Fetch users from the database and check if any user matches the username and password
            var users = await _database.GetAllUsersAsync();
            return users.Any(u => u.Username == user.Username && u.Password == user.Password);
        }
    }
}