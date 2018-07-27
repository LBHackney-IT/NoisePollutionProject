using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NoisePollutionDashboard.DTOs;
using NoisePollutionDashboard.Models;
using PagedList;

namespace NoisePollutionDashboard.ViewModels
{
    public class NoisePollutionModel
    {
        public IPagedList<NoisePollutionDTO> lNoisePollutionDtos { get; set; }

        public NoisePollutionModel(List<NOISE_LIGHT_ODOUR_DB> lApplications, int? page)
        {

            List<NoisePollutionDTO> tempList = new List<NoisePollutionDTO>();
            if (lApplications != null)
            {
                foreach (NOISE_LIGHT_ODOUR_DB application in lApplications)
                {
                    NoisePollutionDTO applicationDTO = new NoisePollutionDTO()
                    {
                        BestContactTime = application.BEST_TIME_TO_CONTACT,
                        ReferenceNumber = application.REFERENCE_NUMBER,
                        Diagnostics = application.DIAGNOSTICS,
                        FoodPremiseName = application.FOOD_PREMISE_NAME,
                        Impact = application.IMPACT,
                        IsFoodPremise = application.IS_FOOD_PREMISE,
                        IsNewIssue = application.IS_NEW_ISSUE,
                        NoiseType = application.NOISE_TYPE,
                        DayDetails = application.DAYTIME_EVENING,
                        WeekDetails = application.WEEKEND_WEEKDAY,
                        ResidentialCommercial = application.RESIDENTIAL_COMMERCIAL,
                        ReportType = application.REPORT_TYPE,
                        Other = application.OTHER,
                        PreferredCommunication = application.PREFERRED_COMMUNICATION,
                        UserAddress = application.C_USER_ADDRESS_ONLY__FULL_ADDRESS,
                        UserUPRN = application.C_USER_ADDRESS_ONLY__UPRN
                    };

                    string formDateTime = Convert.ToDateTime(application.FORM_DATE).ToShortDateString() + "\n" +
                                          Convert.ToDateTime(application.FORM_TIME).ToShortTimeString();
                    applicationDTO.FormDateTime = formDateTime;

                    //There are two ways address details are captured. This code finds the empty one and uses the other to ensure as many fields are populated as possible
                    if (application.C_MANUAL_ADDRESS_ONLY_LLPG__POST_CODE != null)
                    {
                        string problemAddress = application.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_1 + "\n" +
                                                application.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_2 + "\n" +
                                                application.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_3 + "\n" +
                                                application.C_MANUAL_ADDRESS_ONLY_LLPG__ADDRESS_LINE_4 + "\n" + 
                                                application.C_MANUAL_ADDRESS_ONLY_LLPG__POST_CODE;
                        applicationDTO.ProblemAddress = problemAddress;

                    }
                    else if (application.C_POSTCODE_SEARCH_LLPG__POSTCODE != null)
                    {
                        string problemAddress = application.C_POSTCODE_SEARCH_LLPG__ADDRESS_NAME + "\n" +
                                                application.C_POSTCODE_SEARCH_LLPG__LINE1 + "\n" +
                                                application.C_POSTCODE_SEARCH_LLPG__LINE2 + "\n" +
                                                application.C_POSTCODE_SEARCH_LLPG__LINE3 + "\n" +
                                                application.C_POSTCODE_SEARCH_LLPG__POSTCODE;
                        applicationDTO.ProblemAddress = problemAddress;
                    }

                    //To make the GUI more user-friendly I am manipulating the data here to be shown as yes or no on the dashboard as they are stored as bits in the database.
                    if (Convert.ToInt32(application.SENT_TO_CIVICA) == 0)
                    {
                        string sentToCivica = "No";
                        applicationDTO.SentToCivica = sentToCivica;
                    }
                    else
                    {
                        string sentToCivica = "Yes";
                        applicationDTO.SentToCivica = sentToCivica;
                    }

                    tempList.Add(applicationDTO);
                }

                lNoisePollutionDtos = tempList.ToPagedList(page ?? 1, 25);
            }
        }
    }
}