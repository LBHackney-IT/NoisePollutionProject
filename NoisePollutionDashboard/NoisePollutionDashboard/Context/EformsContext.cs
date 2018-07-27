using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using NoisePollutionDashboard.Models;

namespace NoisePollutionDashboard.EformsContext
{
    public class EformsContext
    {
        public string sqlSelect = $"SELECT TOP (500) * FROM {ConfigurationManager.AppSettings["liveNoiseDB"]}";
        public string dbConnection = ConfigurationManager.ConnectionStrings["liveEbaseSqlConnection"].ToString();

        public List<NOISE_LIGHT_ODOUR_DB> SelectAll()
        {
            var lApplications = new List<NOISE_LIGHT_ODOUR_DB>();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    var sql = $"{sqlSelect} ORDER BY FORM_DATE DESC";
                    lApplications = conn.Query<NOISE_LIGHT_ODOUR_DB>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"ERROR: " + ex.Message);
                return lApplications;
            }
            return lApplications;
        }

        public List<NOISE_LIGHT_ODOUR_DB> SelectAllFailedRecords()
        {
            var lApplications = new List<NOISE_LIGHT_ODOUR_DB>();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    var sql = $"{sqlSelect} WHERE SENT_TO_CIVICA = 0";
                    lApplications = conn.Query<NOISE_LIGHT_ODOUR_DB>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"ERROR: " + ex.Message);
                return lApplications;
            }
            return lApplications;
        }

        public List<NOISE_LIGHT_ODOUR_DB> SearchByEformReference(string reference)
        {
            var lApplications = new List<NOISE_LIGHT_ODOUR_DB>();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    var sql = $"{sqlSelect} WHERE REFERENCE_NUMBER = '{reference}'";
                    lApplications = conn.Query<NOISE_LIGHT_ODOUR_DB>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"ERROR: " + ex.Message);
                return lApplications;
            }
            return lApplications;
        }

        public List<NOISE_LIGHT_ODOUR_DB> SearchByCivicaReference(string reference)
        {
            var lApplications = new List<NOISE_LIGHT_ODOUR_DB>();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    var sql = $"{sqlSelect} WHERE DIAGNOSTICS = '{reference}'";
                    lApplications = conn.Query<NOISE_LIGHT_ODOUR_DB>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"ERROR: " + ex.Message);
                return lApplications;
            }
            return lApplications;
        }

        public List<NOISE_LIGHT_ODOUR_DB> SearchByUPRN(string uprn)
        {
            var lApplications = new List<NOISE_LIGHT_ODOUR_DB>();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbConnection))
                {
                    var sql = $"{sqlSelect} WHERE C_USER_ADDRESS_ONLY__UPRN = '{uprn}'";
                    lApplications = conn.Query<NOISE_LIGHT_ODOUR_DB>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"ERROR: " + ex.Message);
                return lApplications;
            }
            return lApplications;
        }
    }
}