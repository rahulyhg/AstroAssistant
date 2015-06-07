﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astro
{
    /// <summary>
    /// Thème natal
    /// </summary>
    public class NatalChart
    {

        /// <summary>
        /// Définition du thème
        /// </summary>
        public NatalChartDefinition Definition { get; set; }

        /// <summary>
        /// Date Julien
        /// </summary>
        public JulianDay JulianDay { get; set; }

        /// <summary>
        /// Temps universel
        /// </summary>
        public DateTime UniversalTime { get; set; }

        /// <summary>
        /// Temps éphémérides
        /// </summary>
        public EphemerisTime EphemerisTime { get; set; }

        /// <summary>
        /// Temps sidéral
        /// </summary>
        public SideralTime SideralTime { get; set; }

        /// <summary>
        /// Mean ecliptic obliquity
        /// </summary>
        public Double MeanEclipticObliquity { get; set; }

        /// <summary>
        /// True ecliptic obliquity
        /// </summary>
        public Double TrueEclipticObliquity { get; set; }

        /// <summary>
        /// Nutation in longitude
        /// </summary>
        public Double NutationLongitude { get; set; }

        /// <summary>
        /// Nutation in obliquity
        /// </summary>
        public Double NutationObliquity { get; set; }

    }
}
