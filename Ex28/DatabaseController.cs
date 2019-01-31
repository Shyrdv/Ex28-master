using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ApplicationLayer
{
    public class DatabaseController
    {
        public string s1 = "";
        public string s2 = "";
        public string s3 = "";
        public string s4 = "";
        public string s5 = "";
        public string s6 = "";
        public string s7 = "";
        private static string connectionString =
    "Data Source = EALSQL1.Eal.Local;" +
    "Database = C_DB04_2018;" +
    "User ID = C_STUDENT04;" +
    "Password = C_OPENDB04;";


        public void InsertRow(string name, string type, string breed, string dob, string weight)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PET (PetName, PetType, PetBreed, PetDOB, PetWeight, OwnerID) VALUES " +
                    "(@PetName, @PetType, @PetBreed, @PetDOB, @PetWeight, @OwnerID)";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        command.Parameters.Add(new SqlParameter("@PetName", name));
                        command.Parameters.Add(new SqlParameter("@PetType", type));
                        if (breed == "")
                        {
                            command.Parameters.Add(new SqlParameter("@PetBreed", "Unknown"));
                        }
                        else
                        {
                            command.Parameters.Add(new SqlParameter("@PetBreed", breed));
                        }
                        command.Parameters.Add(new SqlParameter("@PetDOB", dob));
                        command.Parameters.Add(new SqlParameter("@PetWeight", weight));
                        command.Parameters.Add(new SqlParameter("@OwnerID", 1));

                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();

                        Console.WriteLine("Row has been added!");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }
        }

        public string ShowPets()
        {
            string showpetsstring = "";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PET";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int PetID = int.Parse(reader["PetID"].ToString());
                                string PetName = reader["PetName"].ToString();
                                string PetType = reader["PetType"].ToString();
                                string PetBreed = reader["PetBreed"].ToString();
                                string PetDOB = reader["PetDOB"].ToString();
                                string petWeight = reader["petWeight"].ToString();
                                int OwnerID = int.Parse(reader["OwnerID"].ToString());
                                showpetsstring +=(PetID + ", " + PetName + ", " + PetType + ", " + PetBreed + ", " + PetDOB + ", " + petWeight + ", " + OwnerID)+ "\n";
                                s1 += PetID + "\n";
                                s2 += PetName + "\n";
                                s3 += PetType + "\n";
                                s4 += PetBreed + "\n";
                                s5 += PetDOB + "\n";
                                s6 += petWeight + "\n";
                                s7 += OwnerID + "\n";
                            }
                        }

                        con.Close();

                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    return showpetsstring;
                }
            }
        }
    }
}
