using System.Data.OleDb;
using System.Data.SqlClient;


namespace FinalExercise
{
    public partial class Program
    {
        static void Main()
        {
            string dbCS = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=FinalCars;Integrated Security=True";
            string excelPath = @"C:\Users\H39J61\Desktop\FinalCarsExcel.xlsx";
            string excelCS = @"Provider =Microsoft.ACE.OLEDB.12.0;Data Source=" + excelPath + ";Extended Properties=Excel 12.0;Persist Security Info=False";
            OleDbConnection excelODB = new OleDbConnection(excelCS);
            OleDbCommand dataTransfer = new OleDbCommand("Select [Make],[Model],[Year] from [Cars$]", excelODB);
            excelODB.Open();
            OleDbDataReader odbReader;
            odbReader = dataTransfer.ExecuteReader();
            SqlBulkCopy sbc = new SqlBulkCopy(dbCS)
            {
                DestinationTableName = "FinalCars"
            };
            sbc.WriteToServer(odbReader);
            excelODB.Close();
        }
    }
}






