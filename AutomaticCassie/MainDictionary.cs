using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using CommandSystem;
using Exiled.API.Features;


namespace AutomaticCassie
{
    static class CassieDeathsies
    {
     
        public static Dictionary<int, Tuple<string, string>> translations = new Dictionary<int, Tuple<string, string>>
        {
            // Secured CASSIES
            {1, new Tuple<string, string>(".g4 .g4 {0} jam_030_2 contained successfully by .g6 MTFunits .g5", "<color=#FF0000>{0}</color> został skutecznie zabezpieczony przez jednostki <color=#ADD8E6>MFO</color>") },
            {2, new Tuple<string, string>("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . {0} Breach Detected jam_027_4 .g5 in Pitch_0.9 {1} pitch_0.6 .g4", "Uwaga, wyłom <color=#FF0000>{0}</color> został wykryty w {1}") },
            {3, new Tuple<string, string>("pitch_0.7 .g4 .g6 pitch_1 jam_042_4 Warning . . {0} Detected jam_027_4 .g5 in Pitch_0.9 {1} pitch_0.6 .g4", "Uwaga, <color=#FF0000>{0}</color> został wykryty w {1}") },
            {4, new Tuple<string, string>("MTFunits central to ninetailedfox  .g3 go to .g2 {0} jam_044_2 .g4", "<color=#ADD8E6>MFO</color> udajcie się do {0}") },
            {5, new Tuple<string, string>(".g2 jam_042_4 .g2 Danger . Unauthorized jam_055_4 Intruders at .g1 {0} pitch_0.9 jam_022_2 .g4", "<color=#FF0000>Niebezpieczeństwo</color>, Wykryto nieautoryzowaną intruzję w {0}") },
            {6, new Tuple<string, string>("MTFunits terminate {0}", "<color=#ADD8E6>MFO</color>, terminujcie <color=#FF00000>{0}</color>" ) }
        };

        #region Validators/Converters

        #region validSCP
        private static string validSCP;
        public static string ValidSCP
        {
            get { return validSCP; }
            set
            {
                if (value == "SCP049" || value == "SCP106" || value == "SCP096" || value == "SCP939" || value == "SCP173" || value == "SCP079" || value == "SCP082")
                {
                    validSCP = value;
                }
                else
                {
                    validSCP = "SCPNR";
                }

                ///<summary>
                /// Validuje czy SCP wpisany jako parametr jest poprawnym podmiotem. Jeżeli tak, to value jest zwracane do validSCP, jeżeli nie to zwracane jest SCPNR.
                /// </summary>

            }
        }
        #endregion

        #region ConvertedLocPL
        private static string convertedLoc_pl;
        public static string ConvertedLoc_PL 
        {
            get { return convertedLoc_pl; }
            set 
            {
                convertedLoc_pl = (value == "Entrance Zone") ? "<color=#FF8000>Strefa Wejściowa</color>" :
                (value == "Heavy Containment Zone") ? "<color=#9C0000>Strefa Ciężkiego Nadzoru</color>" :
                (value == "Light Containment Zone") ? "<color=#019472>Strefa Niższego Nadzoru</color>" :
                "InvalidLocalization";


                ///<summary>
                /// Konwertuje lokalizację z Angielskiego na Polską do podtekstów.
                /// </summary>
            }
        }
        #endregion

        #region ConvertedLocPL
        private static string convertedLoc;
        public static string ConvertedLoc
        {
            get { return convertedLoc; }
            set
            {
                convertedLoc = (value == "EZ") ? "Entrance Zone" :
                (value == "HCZ") ? "Heavy Containment Zone" :
                (value == "LCZ") ? "Light Containment Zone" :
                "InvalidLocalization";


                ///<summary>
                /// Konwertuję parametr na Lokalizację do CASSIE. 
                /// </summary>
            }
        }
        #endregion

        #region validLoc
        private static string validLoc;
        public static string ValidLoc 
        {
            get { return validLoc; }
            set 
            {
                if (value.Equals("LCZ", StringComparison.OrdinalIgnoreCase) ||
                    value.Equals("HCZ", StringComparison.OrdinalIgnoreCase) ||
                    value.Equals("EZ", StringComparison.OrdinalIgnoreCase))
                {
                    validLoc = value;
                }
                else 
                {
                    validLoc = "LOCNR";
                }


                ///<summary>
                ///
                /// </summary>
            }
        }
        #endregion

        #region SCPConverter
        private static string convertedSCP;
        public static string ConvertedSCP 
        {
            get { return convertedSCP; }
            set 
            {
               convertedSCP = (value == "SCP049") ? "SCP 0 4 9" :
               (value == "SCP106") ? "SCP 1 0 6" :
               (value == "SCP939") ? "SCP 9 3 9" :
               (value == "SCP173") ? "SCP 1 7 3" :
               (value == "SCP096") ? "SCP 0 9 6" :
               (value == "SCP079") ? "SCP 0 7 9" :
               (value == "SCP082") ? "SCP 0 8 2" :
               "InvalidSCP";


                ///<summary>
                /// Konwertuje parametr podmiotu na słowo validowe do CASSIE. Np SCP049 nie przejdzie, z tego powodu jest konwertowane na SCP 0 4 9.
                /// </summary>

            }
        }
        #endregion

        #endregion

        public static void BreachCassie(string whobreached, string wherebreached)
        {
            string breacher; 
            string convertedbreacher; 
            string loc; 
            string convertedloc_PLL; 

            ValidSCP = whobreached;
            convertedbreacher = validSCP;
            breacher = convertedbreacher;
            ConvertedSCP = convertedbreacher;
            convertedbreacher = convertedSCP;

            loc = wherebreached;

            ConvertedLoc = loc;
            loc = convertedLoc;
            convertedloc_PLL = loc;
            ConvertedLoc_PL = convertedloc_PLL;
            convertedloc_PLL = convertedLoc_pl;


            Cassie.MessageTranslated(
                    string.Format(translations[2].Item1, convertedbreacher, loc),
                    string.Format(translations[2].Item2, breacher, convertedloc_PLL),
                    isNoisy: true);

            ///<summary>
            /// Metoda Funkcji parametru breach.
            /// </summary>

        }

        public static void SecureSCP(string whosecured) 
        {

            string convertedsecured; 

            if (string.IsNullOrEmpty(whosecured))
            {
                whosecured = "Around";
            }

                ValidSCP = whosecured;
                convertedsecured = validSCP;
                whosecured = convertedsecured;
                ConvertedSCP = convertedsecured;
                convertedsecured = convertedSCP;


            // Cassie.Message(string.Format(translations[1].Item1, convertedsecured), isSubtitles: true); // To do debugu tylko

            Cassie.MessageTranslated(
                    string.Format(translations[1].Item1, convertedsecured),
                    string.Format(translations[1].Item2, whosecured),
                    isNoisy: true);

            ///<summary>
            /// Metoda funkcji parametru Secure. 
            /// </summary>

        }

        public static void TerminationCassie(string terminateWho) 
        {
            string SCP;
            string SCPPL;

            ValidSCP = terminateWho;
            SCPPL = validSCP;

            SCP = SCPPL;
            ConvertedSCP = SCP;
            SCP = convertedSCP;


            Cassie.MessageTranslated(
                    string.Format(translations[6].Item1, SCP),
                    string.Format(translations[6].Item2, SCPPL),
                    isNoisy: true);

            /// <summary>
            /// Metoda funkcji parametru termination.
            /// </summary>

        }

        public static void LocalizationCassie(string who, string where) 
        {
            string SCPToLoc; 
            string WhereLoc; 
            string SCPConverted; 
            string LocPL; 

            ValidSCP = who;
            SCPConverted = validSCP;
            SCPToLoc = SCPConverted;
            ConvertedSCP = SCPConverted;
            SCPConverted = convertedSCP;

            WhereLoc = where;

            ConvertedLoc = WhereLoc;
            WhereLoc = convertedLoc;
            LocPL = WhereLoc;
            ConvertedLoc_PL = LocPL;
            LocPL = convertedLoc_pl;

            Cassie.MessageTranslated(
                    string.Format(translations[3].Item1, SCPConverted, WhereLoc),
                    string.Format(translations[3].Item2, SCPToLoc, LocPL),
                    isNoisy: true);

        }

        public static void MTFGoTo(string towhere) 
        {
            string Destination;
            string DestinationPL;

            ConvertedLoc = towhere;

            Destination = convertedLoc;
            DestinationPL = Destination;

            ConvertedLoc_PL = DestinationPL;
            DestinationPL = convertedLoc_pl;


            Cassie.MessageTranslated(
                    string.Format(translations[4].Item1, Destination),
                    string.Format(translations[4].Item2, DestinationPL),
                    isNoisy: true);


            /// <summary>
            /// Metoda funkcji parametru MTFGoTo.
            /// </summary>

        }

        public static void MTFIntruders(string intruderLocation) 
        {
            string Location;
            string LocationPL;

            ConvertedLoc = intruderLocation;
            Location = convertedLoc;
            LocationPL = Location;
            ConvertedLoc_PL = LocationPL;
            LocationPL = convertedLoc_pl;

            Cassie.MessageTranslated(
                    string.Format(translations[5].Item1, Location),
                    string.Format(translations[5].Item2, LocationPL),
                    isNoisy: true);

            /// <summary>
            /// Metoda funkcji parametru MTFIntruders.
            /// </summary>
        }

        public static void ClassDShit(string whatEvent) 
        {
            if (whatEvent == "riot")
            {
                Cassie.MessageTranslated("pitch_0.70 .g4 .g4 .g4 pitch_1 . Class D personnel . has escaped class d cells . pitch_0.70 .g4 .g4 g4", "Personel <color=#FF7700>Klasy D</color> wyłamał się z cel.", isNoisy: false);
            }
            else if (whatEvent == "termination") 
            {
                Cassie.MessageTranslated("jam_077_4 MtfUnits All jam_042_3 ClassD . Personnel Designated pitch_1.1 For pitch_1 .g3 jam_067_3 Termination .g4", "Cały personel <color=#FF7700>Klasy D</color> został wyznaczony do <color=#FF0000>terminacji</color>.", isNoisy: true);
            }
            else if(whatEvent == "terminated") 
            {
                Cassie.MessageTranslated("All .g4 Class 0 jam_044_2 Personnel .g5 Has. pitch_0.8 been jam_055_8 Terminated .g2", "Cały personel 0 został zlikwidowany.", isNoisy: false);
            }
            else if(whatEvent == "termcancel") 
            {
                Cassie.MessageTranslated("pitch_0.4 .g2 .g1 .g5 .g2 .g3 pitch_0.7 jam_022_4 Warning pitch_0.85 class D termination jam_060_7 cancel . MTFunits .g5 secure all jam_036_5 class D personnel pitch_0.3 .g1 .g5 .g3 .g1", "<color=#FF0000>Ostrzeżenie</color>: Terminacja <color=#FF7700>klasy D</color> zostało anulowane. Zabezpieczyć cały personel <color=#FF7700>klasy D</color>.", isNoisy: false);
            }
            else 
            {
                whatEvent = "CASSIE error";
            }

            /// <summary>
            /// Metoda funkcji parametru classd.
            /// </summary>

        }

    }

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class PlayCassie : ICommand
    {
        public string Command { get; } = "pcassie";

        public string[] Aliases { get; } = {};

        public string Description { get; } = "System Komend 'pcassie'";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            if (arguments.Count == 0) 
            {
                response = "No arguments!";
                return false;
            }

            string category = arguments.At(0).ToLower();

            switch (category) 
            {
                case "breach":
                    if (arguments.Count < 3) 
                    {
                        response = "No arguments!";
                        return false;
                    }
                    else if(arguments.Count > 3) 
                    {
                        response = "Too many arguments!";
                        return false;
                    }
                    else 
                    {
                        string breacher;
                        string loc;
                        breacher = arguments.At(1).ToUpper();
                        loc = arguments.At(2).ToUpper();
                        CassieDeathsies.BreachCassie(whobreached: breacher, wherebreached: loc);
                    }

                    break;
                    // -- 
                case "secure":
                    if (arguments.Count < 2) 
                    {
                        response = "No arguments!";
                        return false;
                    }
                    else if (arguments.Count > 2)
                    {
                        response = "Too many arguments!";
                        return false;
                    }
                    else 
                    {
                        string securesubject;
                        securesubject = arguments.At(1).ToUpper();
                        CassieDeathsies.SecureSCP(securesubject);
                    }
                    break;
                    // --
                case "termination":
                   if (arguments.Count < 2) 
                    {
                        response = "No arguments!";
                        return false;
                    }
                   else if (arguments.Count > 2)
                    {
                        response = "Too many arguments!";
                        return false;
                    }
                   else 
                    {
                        string whoterminate;
                        whoterminate = arguments.At(1).ToUpper();
                        CassieDeathsies.TerminationCassie(whoterminate);
                    }
                    break;
                    // --
                case "localization":
                    if (arguments.Count < 3)
                    {
                        response = "No arguments!";
                        return false;
                    }
                    else if (arguments.Count > 3)
                    {
                        response = "Too many arguments!";
                        return false;
                    }
                    else 
                    {
                        string localizewho;
                        string localizewhere;

                        localizewho = arguments.At(1).ToUpper();
                        localizewhere = arguments.At(2).ToUpper();
                        CassieDeathsies.LocalizationCassie(localizewho, localizewhere);
                    }
                        break;
                case "mtfgoto":
                    if (arguments.Count > 2) 
                    {
                        response = "Too many arguments!";
                        return false ;
                    }
                    else if (arguments.Count < 2) 
                    {
                        response = "No arguments!";
                        return false ;
                    }
                    else 
                    {
                        string gotowhere;
                        gotowhere = arguments.At(1).ToUpper();

                        CassieDeathsies.MTFGoTo(gotowhere);

                    }
                    break;
                //--
                case "mtfintruders":
                    if (arguments.Count > 2)
                    {
                        response = "Too many arguments!";
                        return false;
                    }
                    else if (arguments.Count < 2)
                    {
                        response = "No arguments!";
                        return false;
                    }
                    else
                    {
                        string where;
                        where = arguments.At(1).ToUpper();

                        CassieDeathsies.MTFIntruders(where);

                    }
                    break;
                //--
                case "classd":
                    if (arguments.Count > 2)
                    {
                        response = "Too many arguments!";
                        return false;
                    }
                    else if (arguments.Count < 2)
                    {
                        response = "No arguments!";
                        return false;
                    }
                    else
                    {
                        string codeword;
                        codeword = arguments.At(1).ToLower();

                        CassieDeathsies.ClassDShit(codeword);
                    }
                    break;
                default:
                    response = "Invalid Category";
                    return false;
            }
            response = string.Empty;
            return true;

        }
    }



}
