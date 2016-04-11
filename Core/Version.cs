﻿namespace Core
{
    public class Version
    {
        public static string Core = "1.1." + CoreInformation.Build;

        #region WEB
        public static string Vtnorton = "1.0.0";
        public static string OpenSearch = "4.0.0 _discontinued_";
        #endregion
        
        #region WINDOWS 10
        public static string Win10LasVegas = "2.1.0" + CoreInformation.Target;
        public static string Win10Pasadena = "2.1.7" + CoreInformation.Target;
        public static string Win10Lyon = "2.3.0" + CoreInformation.Target;
        public static string Win10Douai = "2.1.0" + CoreInformation.Target;
        public static string Win10Nice = "2.1.0" + CoreInformation.Target;
        public static string Win10Miame = "1.0.0" + CoreInformation.Target;
        public static string Win10Rio = "1.1.5" + CoreInformation.Target;
        public static string Win10Teresopolis = "2.0.0" + CoreInformation.Target;
        #endregion

        #region WINDOWS 8.1
        public static string Win8LasVegas = "1.1.0" + CoreInformation.Target;
        public static string Win8Pasadena = "1.1.0" + CoreInformation.Target;
        public static string Win8Lyon = "2.2.0" + CoreInformation.Target;
        public static string Win8Douai = "1.1.0" + CoreInformation.Target;
        public static string Win8Nice = "1.1.0" + CoreInformation.Target;
        public static string Win8Miame = "0.0.0" + CoreInformation.Target;
        public static string Win8Rio = "1.1.0" + CoreInformation.Target;
        public static string Win8Teresopolis = "2.0.0" + CoreInformation.Target;
        #endregion

        #region WEB
        public static string WebLasVegas = "0.0.0" + CoreInformation.Target;
        public static string WebPasadena = "0.0.0" + CoreInformation.Target;
        public static string WebLyon = "0.0.0" + CoreInformation.Target;
        public static string WebDouai = "0.0.0" + CoreInformation.Target;
        public static string WebNice = "0.0.0" + CoreInformation.Target;
        public static string WebMiame = "0.0.0" + CoreInformation.Target;
        #endregion

        #region IOS
        public static string iOSLasVegas = "0.0.0" + CoreInformation.Target;
        public static string iOSPasadena = "0.0.0" + CoreInformation.Target;
        public static string iOSLyon = "0.0.0" + CoreInformation.Target;
        public static string iOSDouai = "0.0.0" + CoreInformation.Target;
        public static string iOSNice = "0.0.0" + CoreInformation.Target;
        public static string iOSMiame = "0.0.0" + CoreInformation.Target;
        #endregion

        #region ANDROID
        public static string AndroidLasVegas = "0.0.0" + CoreInformation.Target;
        public static string AndroidPasadena = "0.0.0" + CoreInformation.Target;
        public static string AndroidLyon = "0.0.0" + CoreInformation.Target;
        public static string AndroidDouai = "0.0.0" + CoreInformation.Target;
        public static string AndroidNice = "0.0.0" + CoreInformation.Target;
        public static string AndroidMiame = "0.0.0" + CoreInformation.Target;
        #endregion
    }
}