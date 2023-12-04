using Tarea3.Data;

namespace Tarea3.Models {
  public class LoginManager {

    private readonly LoginContext _context;

    public LoginManager(LoginContext context) {
      _context = context;
    }

    public bool CheckCredentials(string username, string password) {
      var logins = from l in _context.Logins
                   where l.Username == username && l.Password == password
                   select l;

      return logins.Count() > 0;
    }

  }
}
