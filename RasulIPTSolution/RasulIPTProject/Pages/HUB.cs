using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace RasulIPTProject.Pages
{
    public class HUB
    {
        public string Search { get; set; } = "";
        public string db = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RasulDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Account Account_Class { get; set; }
        public class Account
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
        public IEnumerable<Account> Account_List { get; set; }

        public void Dis()
        {
            Account_Class = new Account();
            var conn = new SqlConnection(db);
            Account_List = conn.Query<Account>("[dbo].[Find]",new { @Search="%" }, commandType: CommandType.StoredProcedure);

        }

        public void Add(string Name, string Username,string Password)
        {
            var conn = new SqlConnection(db);
            conn.Query<Account>("[dbo].[Create]",
            new {
                    @Name= Name,
                    @Username =Username,
                    @Password=Password
                }
            , commandType: CommandType.StoredProcedure);

        }
        public void Del(int Id)
        {
            var conn = new SqlConnection(db);
            conn.Query<Account>("[dbo].[Delete]",
            new {
                    @Id = Id
                }
            , commandType: CommandType.StoredProcedure);

        }
        public void Upd(int Id,string Name, string Username, string Password)
        {
            var conn = new SqlConnection(db);
            conn.Query<Account>("[dbo].[Edit]",
            new {
                    @Id = Id,
                    @Name = Name,
                    @Username = Username,
                    @Password = Password

            }
            , commandType: CommandType.StoredProcedure);

        }
        public void Sea(string Search)
        {
            Account_Class = new Account();
            var conn = new SqlConnection(db);
            Account_List = conn.Query<Account>("[dbo].[Find]", new { @Search = $"{Search}%" }, commandType: CommandType.StoredProcedure);

        }
        public void Login(string Username,string Password)
        {
            Account_Class = new Account();

            var conn = new SqlConnection(db);
            Account_List = conn.Query<Account>("[dbo].[Login]", new {
                @Username= Username,
                @Password =Password,
            }
            , commandType: CommandType.StoredProcedure);

        }
        public void LoginPass()
        {
            Account_Class = new Account();
            var conn = new SqlConnection(db);
            Account_List = conn.Query<Account>("[dbo].[Login]", new {
                @Username= "",
                @Password ="",
            }
            , commandType: CommandType.StoredProcedure);

        }
    }
}
