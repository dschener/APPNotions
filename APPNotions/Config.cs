#define MUN_LAPAZ
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
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MOVPARK
        public static string urlLogin = "https://desarrollo.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://esperanza.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_GUALEGUAY && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://gualeguay.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_CDELURUGUAY && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://cdeluruguay.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://concepcion.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_NOGOYA && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://nogoya.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_VICTORIA && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://victoria.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_TRESARROYOS && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://tresarroyos.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_MERLO && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://merlo.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_TAFIVIEJO && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://tafiviejo.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_LAPAZ && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://lapaz.movilparking.com/vecino/app/login?appVersion=" + appVersion;
#endif
        #endregion

        #region oneSignalKey
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_COMPRAS
        //public static string oneSignalKey = "9aef9f9d-396e-424b-96e3-63d57596b3d6";
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "f8a0c2c3-1256-4bf3-91b8-bec7e20f058f";
#endif
#if MUN_GUALEGUAY && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "1ccf7a59-4b8a-4c22-afd8-d77098e9c9b5";
#endif
#if MUN_CDELURUGUAY && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "8f857fa3-0943-4c57-aa73-95858b4f828c";
#endif
#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "f58e4242-2bfa-48a0-b9fa-4327ec9e7b4c";
#endif
#if MUN_NOGOYA && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "ac98676c-9a61-4823-b7b5-c2f59ed3716e";
#endif
#if MUN_VICTORIA && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "09fd2971-8a32-4422-aa2a-15193536d24b";
#endif
#if MUN_TRESARROYOS && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "b95aa083-934b-4f6e-8420-379e65f5525c";
#endif
#if MUN_MERLO && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "78a6c668-d29a-4a67-b51f-d09961456d74";
#endif
#if MUN_TAFIVIEJO && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "754e513f-4c10-4a56-840f-a25e77f87002";
#endif
#if MUN_LAPAZ && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "35bb0d49-af4a-415c-845b-a2c494270d22";
#endif
        
#if AMB_PRODUCCION
        public static string ambiente = "Produccion";
#endif
#if AMB_DESARROLLO
        public static string ambiente = "Desarrollo";
#endif
        #endregion

    }
}
