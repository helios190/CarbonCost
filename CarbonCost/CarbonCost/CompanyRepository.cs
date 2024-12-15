using CarbonCost;

public class CompanyRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public CompanyRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public void UpdateCompanyEmissions(int companyId, double emissions)
    {
        using (var conn = _connectionFactory.CreateConnection())
        {
            conn.Open();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "UPDATE company SET company_emissions = @average WHERE company_id = @companyId";
                var param1 = cmd.CreateParameter();
                param1.ParameterName = "@average";
                param1.Value = emissions;
                cmd.Parameters.Add(param1);

                var param2 = cmd.CreateParameter();
                param2.ParameterName = "@companyId";
                param2.Value = companyId;
                cmd.Parameters.Add(param2);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    throw new Exception($"No rows updated for Company ID: {companyId}");
            }
        }
    }
}
