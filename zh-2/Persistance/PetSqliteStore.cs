using hazi2.Models;
using System.Data.SQLite;

namespace hazi2.Persistance;

internal class PetSqliteStore : IPetStore
{
    private readonly string _connectionString;

    public PetSqliteStore(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<PetEntity> Pets
    {
        get
        {
            var pets = new List<PetEntity>();

            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();

            using var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Pets;";

            try
            {
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PetEntity pet = new()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Gender = reader.GetString(reader.GetOrdinal("Gender")),
                        OwnerName = reader.GetString(reader.GetOrdinal("OwnerName")),
                        Age = reader.GetInt32(reader.GetOrdinal("Age")),
                        Weight = reader.GetDecimal(reader.GetOrdinal("Weight")),
                        Category = reader.GetString(reader.GetOrdinal("Category")),
                    };
                    pets.Add(pet);
                }
            }
            catch
            {
            }

            return pets;
        }
    }

    public bool AddPet(PetEntity pet)
    {
        if (pet is null)
        {
            return false;
        }

        using var connection = new SQLiteConnection(_connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Pets (Name, Gender, OwnerName, Age, Weight, Category) " +
            "VALUES(@name, @gender, @owner, @age, @weight, @category);";

        command.Parameters.Add("name", System.Data.DbType.String).Value = pet.Name;
        command.Parameters.Add("gender", System.Data.DbType.String).Value = pet.Gender;
        command.Parameters.Add("owner", System.Data.DbType.String).Value = pet.OwnerName;
        command.Parameters.Add("age", System.Data.DbType.Int32).Value = pet.Age;
        command.Parameters.Add("weight", System.Data.DbType.Double).Value = pet.Weight;
        command.Parameters.Add("category", System.Data.DbType.String).Value = pet.Category;

        try
        {
            var rowsModified = command.ExecuteNonQuery();

            if (rowsModified > 0)
            {
                return true;
            }
        }
        catch
        {
        }

        return false;
    }

    public bool UpdatePet(PetEntity pet)
    {
        if (pet is null)
        {
            return false;
        }

        using var connection = new SQLiteConnection(_connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "UPDATE Pets " +
            "SET Name=@name, Gender=@gender, OwnerName=@owner, Age=@age, Weight=@weight, Category=@category " +
            "WHERE Id=@id;";

        command.Parameters.Add("id", System.Data.DbType.Int32).Value = pet.Id;
        command.Parameters.Add("name", System.Data.DbType.String).Value = pet.Name;
        command.Parameters.Add("gender", System.Data.DbType.String).Value = pet.Gender;
        command.Parameters.Add("owner", System.Data.DbType.String).Value = pet.OwnerName;
        command.Parameters.Add("age", System.Data.DbType.Int32).Value = pet.Age;
        command.Parameters.Add("weight", System.Data.DbType.Double).Value = pet.Weight;
        command.Parameters.Add("category", System.Data.DbType.String).Value = pet.Category;

        try
        {
            var rowsModified = command.ExecuteNonQuery();

            if (rowsModified > 0)
            {
                return true;
            }
        }
        catch
        {
        }

        return false;
    }

    public bool RemovePet(PetEntity pet)
    {
        if (pet is null)
        {
            return false;
        }

        using var connection = new SQLiteConnection(_connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Pets " +
            "WHERE id=@id";

        command.Parameters.Add("id", System.Data.DbType.Int32).Value = pet.Id;

        try
        {
            var rowsModified = command.ExecuteNonQuery();

            if (rowsModified > 0)
            {
                return true;
            }
        }
        catch
        {
        }

        return false;
    }
}

