﻿using Astro;
using AstroAssistant.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroAssistant.DesignTime
{
#if DEBUG
    public class DtNatalChartDefinitionViewModel : INatalChartDefinitionViewModel
    {
        public DtNatalChartDefinitionViewModel()
        {
            var dt = DateTime.Now;
            this.BirthDateYear = dt.Year;
            this.BirthDateMonth = dt.Month;
            this.BirthDateDay = dt.Day;
            this.BirthDateHour = dt.Hour;
            this.BirthDateMinute = dt.Minute;
            this.BirthDateSecond = dt.Second;
            this.BirthDateMilliSecond = dt.Millisecond;
            this.BirthDateDayLight = DayLightDefinition.FromDotNet;
            this.BirthDateTimeZone = TimeZoneInfo.Local;

            this.BirthPlaceName = "Besançon";
            this.BirthPlacePosition = new Astro.GeoPosition(new Longitude(6, 1, 19, LongitudePolarity.East), new Latitude(47, 14, 35, LatitudePolarity.North), 400);
            this.Gender = Gender.Male;
            this.HouseSystem = HouseSystem.Placidus;
            this.Name = "Test";
            this.PositionCenter = PositionCenter.Topocentric;

            ListGenders = new List<KeyValuePair<Gender, string>>();
            ListGenders.Add(new KeyValuePair<Gender, string>(Gender.Female, "Femme"));
            ListGenders.Add(new KeyValuePair<Gender, string>(Gender.Male, "Homme"));

            ListTimeZoneInfos = new List<TimeZoneInfo>();
            ListTimeZoneInfos.AddRange(TimeZoneInfo.GetSystemTimeZones());
        }

        public int BirthDateDay { get; set; }

        public Astro.DayLightDefinition BirthDateDayLight { get; set; }

        public int BirthDateHour { get; set; }

        public int BirthDateMilliSecond { get; set; }

        public int BirthDateMinute { get; set; }

        public int BirthDateMonth { get; set; }

        public int BirthDateSecond { get; set; }

        public TimeZoneInfo BirthDateTimeZone { get; set; }

        public List<TimeZoneInfo> ListTimeZoneInfos { get; set; }

        public double BirthDateUtcOffset { get; set; }

        public int BirthDateYear { get; set; }

        public string BirthPlaceName { get; set; }

        public Astro.GeoPosition BirthPlacePosition { get; set; }

        public Astro.Gender Gender { get; set; }

        public Astro.HouseSystem HouseSystem { get; set; }

        public string Name { get; set; }

        public Astro.PositionCenter PositionCenter { get; set; }

        public Longitude BirthPlaceLongitude { get; set; }

        public Latitude BirthPlaceLatitude { get; set; }

        public double BirthPlaceAltitude { get; set; }


        public List<KeyValuePair<Gender, string>> ListGenders { get; set; }
    }
#endif
}
