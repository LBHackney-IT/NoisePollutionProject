using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;

namespace NoisePollution
{
    class Program
    {
        public static string sqlTable = ConfigurationManager.AppSettings["liveNoiseDB"];
        public static string dbConnection = ConfigurationManager.ConnectionStrings["liveSqlConnection"].ToString();

        public static List<NOISE_LIGHT_ODOUR_DB> SelectAll()
        {
            using (SqlConnection conn = new SqlConnection(dbConnection))
            {
                //conn.Open();
                var sql = $"SELECT * FROM {sqlTable} WHERE SENT_TO_CIVICA = 0";
                List<NOISE_LIGHT_ODOUR_DB> lResult = conn.Query<NOISE_LIGHT_ODOUR_DB>(sql).ToList();
                Console.WriteLine("Query finished with " + lResult.Count + " elements.");
                return lResult;
            }
        }

        public static void UpdateCivicaStatus(string strReferenceId, int iSentToCivica, string strComment)
        {
            string newSQL = $"UPDATE {sqlTable} SET SENT_TO_CIVICA = '{iSentToCivica}', DIAGNOSTICS= '{strComment}' WHERE REFERENCE_NUMBER = '{strReferenceId}'";

            using (SqlConnection conn = new SqlConnection(dbConnection))
            {
                //conn.Open();
                var sql = newSQL;
                conn.Query<NOISE_LIGHT_ODOUR_DB>(sql);
            }
        }

        static void Main(string[] args)
        {
            var myTable = SelectAll();
            //            var btc = myTable[2].BEST_TIME_TO_CONTACT;
            //            Console.WriteLine(btc);

            foreach (var value in myTable)
            {

                StringBuilder strXML = new StringBuilder();
                StringBuilder addressXML = new StringBuilder();
                strXML.Append("<xml><noisePollution>");
                strXML.Append("<BEST_TIME_TO_CONTACT>" + value.BEST_TIME_TO_CONTACT + "</BEST_TIME_TO_CONTACT> ");
                if (value.C_MANUAL_ADDRESS_ONLY_LLPG__POST_CODE != null)
                {
                    //Problem Manual Address Details and translates to XML tag (Activity)
                    addressXML.Append("<LINE_1>" + value.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_1 + "</LINE_1>");
                    addressXML.Append("<LINE_2>" + value.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_2 + "</LINE_2>");
                    addressXML.Append("<LINE_3>" + value.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_3 + "</LINE_3>");
                    addressXML.Append("<LINE_4_CITY>" + value.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_4 + "</LINE_4_CITY>");
                    addressXML.Append("<ADDRESS_NAME></ADDRESS_NAME>");
                    addressXML.Append("<POSTCODE>" + value.C_MANUAL_ADDRESS_ONLY_LLPG__POST_CODE + "</POSTCODE>");
                    addressXML.Append("<UPRN></UPRN>");

                }
                else if (value.C_POSTCODE_SEARCH_LLPG__POSTCODE != null)
                {
                    //Problem Address Details and translates to XML tag (Activity)
                    addressXML.Append("<LINE_1>" + value.C_POSTCODE_SEARCH_LLPG__LINE1 + "</LINE_1>");
                    addressXML.Append("<LINE_2>" + value.C_POSTCODE_SEARCH_LLPG__LINE2 + "</LINE_2>");
                    addressXML.Append("<LINE_3>" + value.C_POSTCODE_SEARCH_LLPG__LINE3 + "</LINE_3>");
                    addressXML.Append("<LINE_4_CITY>" + value.C_POSTCODE_SEARCH_LLPG__CITY + "</LINE_4_CITY>");
                    addressXML.Append("<ADDRESS_NAME>" + value.C_POSTCODE_SEARCH_LLPG__ADDRESS_NAME + "</ADDRESS_NAME>");
                    addressXML.Append("<POSTCODE>" + value.C_POSTCODE_SEARCH_LLPG__POSTCODE + "</POSTCODE>");
                    addressXML.Append("<UPRN>" + value.C_POSTCODE_SEARCH_LLPG__UPRN + "</UPRN>");
                }

                strXML.Append(addressXML);
                //Complainer Address Details and translates to XML tag (RequestComp)
                strXML.Append("<C_USER_ADDRESS_ONLY__FULL_ADDRESS>" + value.C_USER_ADDRESS_ONLY__FULL_ADDRESS + "</C_USER_ADDRESS_ONLY__FULL_ADDRESS> ");
                strXML.Append("<C_USER_ADDRESS_ONLY__POST_CODE>" + value.C_USER_ADDRESS_ONLY__POST_CODE + "</C_USER_ADDRESS_ONLY__POST_CODE> ");
                strXML.Append("<C_USER_ADDRESS_ONLY__PREMISES_NO>" + value.C_USER_ADDRESS_ONLY__PREMISES_NO + "</C_USER_ADDRESS_ONLY__PREMISES_NO> ");
                strXML.Append("<C_USER_ADDRESS_ONLY__REFERENCE>" + value.C_USER_ADDRESS_ONLY__REFERENCE + "</C_USER_ADDRESS_ONLY__REFERENCE> ");
                strXML.Append("<C_USER_ADDRESS_ONLY__STREET_NAME>" + value.C_USER_ADDRESS_ONLY__STREET_NAME + "</C_USER_ADDRESS_ONLY__STREET_NAME> ");
                strXML.Append("<C_USER_ADDRESS_ONLY__UPRN>" + value.C_USER_ADDRESS_ONLY__UPRN + "</C_USER_ADDRESS_ONLY__UPRN> ");
                //All other information
                strXML.Append("<DAYTIME_EVENING>" + value.DAYTIME_EVENING + "</DAYTIME_EVENING> ");
                strXML.Append("<FOOD_PREMISE_NAME>" + value.FOOD_PREMISE_NAME + "</FOOD_PREMISE_NAME> ");
                strXML.Append("<IMPACT>" + value.IMPACT + "</IMPACT> ");
                strXML.Append("<IS_FOOD_PREMISE>" + value.IS_FOOD_PREMISE + "</IS_FOOD_PREMISE> ");
                strXML.Append("<IS_NEW_ISSUE>" + value.IS_NEW_ISSUE + "</IS_NEW_ISSUE> ");

                var noiseType = "";
                switch (value.NOISE_TYPE)
                {
                    case "AIRCRAFT":
                        noiseType = "WNA";
                        break;
                    case "BANGING":
                        noiseType = "WNB";
                        break;
                    case "CAR_ALARM":
                        noiseType = "WNC";
                        break;
                    case "CONSTRUCTION":
                        noiseType = "WND";
                        break;
                    case "DIY":
                        noiseType = "WNE";
                        break;
                    case "BARKING":
                        noiseType = "WNF";
                        break;
                    case "ALARM":
                        noiseType = "WNG";
                        break;
                    case "MUSIC":
                        noiseType = "WNH";
                        break;
                    case "Noise on the road":
                        noiseType = "WNI";
                        break;
                    case "Shouting":
                        noiseType = "WNJ";
                        break;
                    case "TV":
                        noiseType = "WNK";
                        break;
                    case "OTHERS":
                        noiseType = "WNL";
                        break;
                }
                strXML.Append("<NOISE_TYPE>" + noiseType + "</NOISE_TYPE> ");
                strXML.Append("<OTHER>" + value.OTHER + "</OTHER> ");
                strXML.Append("<PREFERRED_COMMUNICATION>" + value.PREFERRED_COMMUNICATION + "</PREFERRED_COMMUNICATION> ");

                var reportType = "";
                switch (value.REPORT_TYPE)
                {
                    case "NOISE":
                        reportType = "UNA";
                        break;
                    case "LIGHT":
                        reportType = "ULA";
                        break;
                    case "ODOUR":
                        reportType = "UOA";
                        break;
                }
                strXML.Append("<REPORT_TYPE>" + reportType + "</REPORT_TYPE> ");

                var residential_commercial = "";
                var officer = "";
                switch (value.RESIDENTIAL_COMMERCIAL)
                {
                    case "RESIDENTIAL":
                        residential_commercial = "NOS";
                        officer = "NOR";
                        break;
                    case "COMMERCIAL":
                        residential_commercial = "NOC";
                        officer = "NOC";
                        break;
                }
                strXML.Append("<RESIDENTIAL_COMMERCIAL>" + residential_commercial + "</RESIDENTIAL_COMMERCIAL> ");
                strXML.Append("<OFFICER>" + officer + "</OFFICER> ");
                strXML.Append("<USER_EMAIL>" + value.USER_EMAIL + "</USER_EMAIL> ");
                strXML.Append("<USER_EMAIL_VALIDATION>" + value.USER_EMAIL_VALIDATION + "</USER_EMAIL_VALIDATION> ");
                strXML.Append("<USER_FULLNAME>" + value.USER_FIRSTNAME + " " + value.USER_LASTNAME + "</USER_FULLNAME> ");
                strXML.Append("<USER_MOB_NO>" + value.USER_MOB_NO + "</USER_MOB_NO> ");
                strXML.Append("<USER_TEL_NO>" + value.USER_TEL_NO + "</USER_TEL_NO> ");
                strXML.Append("<USER_TITLE>" + value.USER_TITLE + "</USER_TITLE> ");
                strXML.Append("<WEEKEND_WEEKDAY>" + value.WEEKEND_WEEKDAY + "</WEEKEND_WEEKDAY> ");
                strXML.Append("<REFERENCE_NUMBER>" + value.REFERENCE_NUMBER + "</REFERENCE_NUMBER> ");

                string targetDate = Convert.ToDateTime(value.FORM_DATE).AddDays(5).ToShortDateString();
                string closeDate = Convert.ToDateTime(value.FORM_DATE).AddDays(28).ToShortDateString();

                strXML.Append("<FORM_DATE>" + Convert.ToDateTime(value.FORM_DATE).ToShortDateString() + "</FORM_DATE> ");
                strXML.Append("<FORM_TIME>" + Convert.ToDateTime(value.FORM_TIME).ToShortTimeString() + "</FORM_TIME> ");
                strXML.Append("<C_TARGETDATE>" + targetDate + "</C_TARGETDATE> ");
                strXML.Append("<C_CLOSEDATE>" + closeDate + "</C_CLOSEDATE> ");
                strXML.Append("</noisePollution></xml>");

                Console.WriteLine(strXML);
                try
                {
                    LBHLicensingAPP.Service crmService = new LBHLicensingAPP.Service();
                    LBHLicensingAPP.Response r = new LBHLicensingAPP.Response();
//                    var temp = strXML.ToString();
                    r = crmService.MergeAndSendXMLToAPP("noisePollution", strXML.ToString(), "NoisePollution.xml");

                    if (r.ErrorCode == 0)
                    {
                        UpdateCivicaStatus(value.REFERENCE_NUMBER, 1, r.ReturnValue);
                        Console.WriteLine("DB Updated | 1");
                    }
                    else
                    {
                        UpdateCivicaStatus(value.REFERENCE_NUMBER, 0, r.FailureReason);
                        Console.WriteLine("DB Updated | 0");
                    }
                }
                catch (Exception e)
                {
                    UpdateCivicaStatus(value.REFERENCE_NUMBER, 0, e.Message);
                }

            }
        }

    }
}