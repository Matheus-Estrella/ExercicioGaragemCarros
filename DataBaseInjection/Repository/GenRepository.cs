using Dapper;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Repository
{
    public class GenRepository
    {
        private string Conn { get; set; }

        public GenRepository()
        {
            //Conn = "Data Source = 127.0.0.1; Initial Catalog = x;User Id=sa; Password=SqlServer2019!";  , onde, x é o nome do banco de dados
            Conn = ConfigurationManager.ConnectionStrings["StringConnection_SQLServer"].ConnectionString; // --> Substitui o método da linha acima
        }
        public bool Insert(Generic generic)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                string _inforRestrained = generic.GetRestrained();
                string _tableName = generic.GetTableName();
                string _sqlCommand = Generic.GenerateInsertCommand(generic, _tableName,_inforRestrained);
                var _parameters = Generic.GetParameters(generic);
                db.Execute(_sqlCommand, _parameters);
                status = true;
                db.Close();
            }
            return status;
        }
        #region INSERÇÃO GENÉRICA NUM BD EM FUNÇÃO DE UM OBJETO X
        /*
        using (var db = new SqlConnection(Conn))
        {
            db.Open();
            db.Execute("INSERT INTO TB_X (Descricao, Mesa, IdItem) values (@Descricao, @Mesa,@IdItem)",
                new { Descricao = x.Descricao, Mesa = x.Mesa, IdItem = x.Item.Id}); 
            // new para customizar entradas
            //db.Execute("INSERT INTO TB_X (Id, Descricao, Mesa) values (@pera, @uva, @abacate)", new { pera = "", uva = "", abacate = "" });
            status = true;
            db.Close();
        }
        */
        #endregion
    }
}
