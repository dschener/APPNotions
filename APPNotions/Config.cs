#define MUN_ESPERANZA
#define AMB_PRODUCCION
#define MOD_MOVPARK

namespace APPNotions
{
    static class Config
    {
        private static string appVersion = "13";


        #region urlLogin
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_COMPRAS
        public static string urlLogin = "https://desarrollo-esperanza.gobdigital.com.ar/web/compras-blockchain/proveedor_app/login?appVersion=" + appVersion;
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_COMPRAS
        public static string urlLogin = "https://esperanza.gobdigital.com.ar/web/compras-blockchain/proveedor_app/login?appVersion=" + appVersion;
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://esperanza.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MOVPARK
        public static string urlLogin = "https://desarrollo.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
        #endregion

        #region tags para OneSignal
#if MUN_ESPERANZA
        public static string municipio = "Esperanza";
#endif
#if MUN_DESARROLLO
        public static string municipio = "Desarrollo";
#endif

#if AMB_PRODUCCION
        public static string ambiente = "Produccion";
#endif
#if AMB_DESARROLLO
        public static string ambiente = "Desarrollo";
#endif

#if MOD_COMPRAS
        public static string modulo = "Compras";
#endif
#if MOD_MOVPARK
        public static string modulo = "MovPark";
#endif
        #endregion

        #region oneSignalKey
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_COMPRAS
        //public static string oneSignalKey = "9aef9f9d-396e-424b-96e3-63d57596b3d6"; //Proyecto nuevo
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "f8a0c2c3-1256-4bf3-91b8-bec7e20f058f";// Clave original
#endif
        #endregion
    }
}
