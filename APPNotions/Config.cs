#define MUN_ALEM
#define AMB_PRODUCCION
#define MOD_GDA_CIUDADANO
namespace APPNotions
{
    static class Config
    {
        private static string appVersion = "20";
        // Version 16 (Version Name 1.3.1): Si no tiene activo GPS o no da permisos, mando coordenadas 0,0
        // Version 15 (Version Name 1.3): Corregido OneSignal (app cerraba en notificationreceived), y mejoras en notificaciones y lectura posición GPS entre otras
        // Version 13 (Version Name 1.2): Soporte android 12
        // Version 11 (Version Name 1.1): Primera Version Xamarin
        // Version  8 (Version Name 1.0): Primera Version React Native
        // Cómo decidir códigos de versión: https://ed.team/blog/como-se-deciden-las-versiones-del-software
        #region urlLogin
#if  MUN_ALEM && AMB_PRODUCCION && MOD_GDA_CIUDADANO
        public static string urlLogin = "https://alem.gobdigital.com.ar/CiudadanoApp/index?app=true&appVersion=" + appVersion;
#endif
#if  MUN_TAFIVIEJO && AMB_PRODUCCION && MOD_MOVPARK_CONTROLADOR
        public static string urlLogin = "https://tafiviejo.movilparking.com/controladorAPP/login?app=true&appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MOVPARK_CIUDADANO
        public static string urlLogin = "https://app.movilparking.com/CiudadanoAPP/login?app=true&appVersion=" + appVersion;
#endif
#if MUN_TAFIVIEJO && AMB_PRODUCCION && MOD_MOVPARK_CIUDADANO
        public static string urlLogin = "https://tafiviejo.movilparking.com/CiudadanoAPP/login?app=true&appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MOVPARK_CONTROLADOR
        public static string urlLogin = "https://app.movilparking.com/ControladorApp/login?app=true&appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_GDA_CIUDADANO
            public static string urlLogin = "https://gda.gobdigital.com.ar/CiudadanoApp/index?app=true&appVersion=" + appVersion;
#endif
#if MUN_TRANSPORTEROMERO && AMB_PRODUCCION && MOD_TRANSPORTE
        public static string urlLogin = "https://transporteromero.boleteriadigital.com.ar/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_COMPRASFUNCIONARIOS
        public static string urlLogin = "https://esperanza.gobdigital.com.ar/compras/login?appVersion=" + appVersion;
#endif

#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_FUNCIONARIOS
        public static string urlLogin = "https://esperanza.gobdigital.com.ar/_gda/login?appVersion=" + appVersion;
#endif

#if MUN_LAPAZ && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string urlLogin = "https://lapaz.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif

#if MUN_TRESARROYOS && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string urlLogin = "https://tresarroyos.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif

#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string urlLogin = "https://concepcion.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif

#if MUN_NOGOYA && AMB_PRODUCCION && MOD_SEGURIDAD
            public static string urlLogin = "https://nogoya.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif
#if MUN_VICTORIA && AMB_PRODUCCION && MOD_SEGURIDAD
            public static string urlLogin = "https://victoria.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif
#if MUN_VILLAGUAY && AMB_PRODUCCION && MOD_SEGURIDAD
            public static string urlLogin = "https://villaguay.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif
#if MUN_GUALEGUAY && AMB_PRODUCCION && MOD_SEGURIDAD
            public static string urlLogin = "https://gualeguay.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif
#if MUN_CDELURUGUAY && AMB_PRODUCCION && MOD_SEGURIDAD
            public static string urlLogin = "https://cdeluruguay.gobdigital.com.ar/seguridad/login?appVersion=" + appVersion;
#endif
#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_GESTIONCOCHERAS
        public static string urlLogin = "http://desarrollo-esperanza.gobdigital.com.ar/web/vecino/app_establecimientos/login?appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_VECINODIGITAL
        public static string urlLogin = "http://desarrollo-esperanza.gobdigital.com.ar/web/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_VECINODIGITAL
        public static string urlLogin = "http://esperanza.gobdigital.com.ar/web/vecino/app/login?appVersion=" + appVersion;
#endif
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
#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_VECINODIGITAL
        public static string urlLogin = "http://concepcion.gobdigital.com.ar/web/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_CONTROLADOR
        public static string urlLogin = "http://desarrollo.movilparking.com/controlador/login?appVersion=" + appVersion;
#endif
#if MUN_NOGOYA && AMB_PRODUCCION && MOD_VECINODIGITAL
        public static string urlLogin = "https://nogoya.gobdigital.com.ar/web/vecino/app/login?appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MULTAS
        public static string urlLogin = "http://desarrollo-jujuy.gobdigital.com.ar/juzgadofaltas/app-multas/login?appVersion=" + appVersion;
#endif
#if MUN_VENADOTUERTO && AMB_DESARROLLO && MOD_MOVPARK
        public static string urlLogin = "https://venadotuerto-desarrollo.movilparking.com/vecino/app-new/login?appVersion=" + appVersion;
#endif
#if MUN_VENADOTUERTO && AMB_DESARROLLO && MOD_CONTROLADOR
        public static string urlLogin = "http://desa.movilparking.com/controlador/login?appVersion=" + appVersion;
#endif
#if MUN_VENADOTUERTO && AMB_PRODUCCION && MOD_MOVPARK
        public static string urlLogin = "https://venadotuerto.movilparking.com/vecino/app-new/login?appVersion=" + appVersion;
#endif
#if MUN_VENADOTUERTO && AMB_PRODUCCION && MOD_CONTROLADOR
        public static string urlLogin = "http://venadotuerto.movilparking.com/controlador/login?appVersion=" + appVersion;
#endif
#if MUN_MERLO && AMB_PRODUCCION && MOD_CONTROLADOR
        public static string urlLogin = "http://merlo.movilparking.com/controlador/login?appVersion=" + appVersion;
#endif
#if MUN_LAMARQUE && AMB_PRODUCCION && MOD_MULTAS
        public static string urlLogin = "http://lamarque.gobdigital.com.ar/juzgadofaltas/app-multas/login?appVersion=" + appVersion;
#endif
#if MUN_POSADAS && AMB_PRODUCCION && MOD_MULTAS
        public static string urlLogin = "http://posadas.gobdigital.com.ar/juzgadofaltas/app-multas/login?appVersion=" + appVersion;
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_BOLETERIA
        public static string urlLogin = "https://victoria-desarrollo.boleteriadigital.com.ar/validar/default?app=true" + appVersion;
#endif
#if MUN_DESAMULTAS && AMB_DESARROLLO && MOD_MULTAS
        public static string urlLogin = "https://desarrollo.gobdigital.com.ar/juzgadofaltas/app-multas/login?app=true" + appVersion;
#endif
#if MUN_DESAMULTAS && AMB_DESARROLLO && MOD_UROVO
        public static string urlLogin = "http://desa.gobdigital.com.ar/juzgadofaltas/app_multas/causa-print/login?app=true" + appVersion;
#endif
#if MUN_LUJAN && AMB_DESARROLLO && MOD_CONTROLADOR
        public static string urlLogin = "https://desa-lujan.movilparking.com/controlador/login?app=true" + appVersion;
#endif
#if MUN_RADATILLY && AMB_PRODUCCION && MOD_MULTAS
        public static string urlLogin = "https://radatilly.gobdigital.com.ar/juzgadofaltas/app-multas/login?app=true" + appVersion;
#endif
#if MUN_GDA && AMB_PRODUCCION && MOD_GDA
            public static string urlLogin = "https://gda.gobdigital.com.ar/CiudadanoApp/index?app=true" + appVersion;
#endif
        #endregion

        #region oneSignalKey
#if MUN_ALEM && AMB_PRODUCCION && MOD_GDA_CIUDADANO
        public static string oneSignalKey = "ffdbce16-8162-4f00-9f30-99eb8af4deba";
#endif
#if MUN_TAFIVIEJO && AMB_PRODUCCION && MOD_MOVPARK_CONTROLADOR
        public static string oneSignalKey = "89762c81-e984-49ff-858b-908a9e60ef8d";
#endif
#if MUN_TAFIVIEJO && AMB_PRODUCCION && MOD_MOVPARK_CIUDADANO
        public static string oneSignalKey = "25c42a2a-5980-43ca-904e-3e1e6aa5c430";
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MOVPARK_CIUDADANO
        public static string oneSignalKey = "8e2febce-dc2d-4c4b-b5fc-71fb2229673b";
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MOVPARK_CONTROLADOR
        public static string oneSignalKey = "a4d4e88c-e519-47d7-a1dc-61108b72aa22";
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_GDA_CIUDADANO
            public static string oneSignalKey = "129ec209-9f8c-465a-a8f1-12d5d052b4d5";
#endif
#if MUN_TRANSPORTEROMERO && AMB_PRODUCCION && MOD_TRANSPORTE
        public static string oneSignalKey = "2158f7f7-7d26-4234-9ad7-f074b77844c5";
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_COMPRASFUNCIONARIOS
        public static string oneSignalKey = "2158f7f7-7d26-4234-9ad7-f074b77844c5";
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_FUNCIONARIOS
        public static string oneSignalKey = "8e80e930-5556-4ddd-8e1f-e76ad171075c";
#endif
#if MUN_LAPAZ && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string oneSignalKey = "036d0be0-bcd8-4915-8214-3fea1e9c1de4";
#endif
#if MUN_TRESARROYOS && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string oneSignalKey = "cd451176-3450-4a68-bd53-73ff587d3d34";
#endif
#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string oneSignalKey = "f851a053-e70f-4318-a469-9073bfc41509";
#endif
#if MUN_NOGOYA && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string oneSignalKey = "f978ec06-0fff-4c9e-971c-3db62b52ebf8";
#endif
#if MUN_VICTORIA && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string oneSignalKey = "838cec95-033a-4771-9a50-d4e2d5159d94";
#endif
#if MUN_VILLAGUAY && AMB_PRODUCCION && MOD_SEGURIDAD
        public static string oneSignalKey = "634e79c2-53f8-431b-b2f6-264934a09e26";
#endif
#if MUN_GUALEGUAY && AMB_PRODUCCION && MOD_SEGURIDAD
            public static string oneSignalKey = "5b5043f8-1325-43b7-a857-68401916d55e";
#endif
#if MUN_CDELURUGUAY && AMB_PRODUCCION && MOD_SEGURIDAD
            public static string oneSignalKey = "da566331-0776-4289-ad9f-df098e5e5944";
#endif
#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_GESTIONCOCHERAS
        public static string oneSignalKey = "ca11db27-be18-4bbe-ad35-9b418a425aca";
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_VECINODIGITAL
        public static string oneSignalKey = "b1d5f2d5-29b0-4409-abe2-d0a070f2d1ad";
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_VECINODIGITAL
        public static string oneSignalKey = "b1d5f2d5-29b0-4409-abe2-d0a070f2d1ad";
#endif
#if MUN_ESPERANZA && AMB_PRODUCCION && MOD_COMPRAS
        public static string oneSignalKey = "9aef9f9d-396e-424b-96e3-63d57596b3d6";
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
#if MUN_CONCEPCION && AMB_PRODUCCION && MOD_VECINODIGITAL
        public static string oneSignalKey = "f0725816-e18d-4d25-8e86-5880551e5e7e";
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MOVPARK
        public static string oneSignalKey = "b3e2811a-523e-41d7-bc1c-e70d6a397cfc";
#endif
#if MUN_NOGOYA && AMB_PRODUCCION && MOD_VECINODIGITAL
        public static string oneSignalKey = "3b4d495c-d0d0-4464-b28b-3084a6e6e28b";
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_MULTAS
        public static string oneSignalKey = "";
#endif
#if AMB_PRODUCCION
        public static string ambiente = "Produccion";
#endif
#if MUN_VENADOTUERTO && AMB_DESARROLLO && MOD_MOVPARK
        public static string oneSignalKey = "fa4237ee-9d51-4cfb-a3af-cbd132f8b6a6";
#endif
#if MUN_VENADOTUERTO && AMB_DESARROLLO && MOD_CONTROLADOR
        public static string oneSignalKey = "597a6f2d-11da-4943-8905-5635299276ac";
#endif
#if MUN_VENADOTUERTO && AMB_PRODUCCION && MOD_MOVPARK
        public static string oneSignalKey = "b9e8bd52-1e4c-413f-9036-d88affe0a511";
#endif
#if AMB_DESARROLLO
        public static string ambiente = "Desarrollo";
#endif
#if MUN_VENADOTUERTO && AMB_PRODUCCION && MOD_CONTROLADOR
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_MERLO && AMB_PRODUCCION && MOD_CONTROLADOR
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_LAMARQUE && AMB_PRODUCCION && MOD_MULTAS
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_POSADAS && AMB_PRODUCCION && MOD_MULTAS
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_DESARROLLO && AMB_DESARROLLO && MOD_BOLETERIA
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_DESAMULTAS && AMB_DESARROLLO && MOD_MULTAS
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_DESAMULTAS && AMB_DESARROLLO && MOD_UROVO
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_LUJAN && AMB_DESARROLLO && MOD_CONTROLADOR
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_RADATILLY && AMB_PRODUCCION && MOD_MULTAS
        public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif
#if MUN_GDA && AMB_PRODUCCION && MOD_GDA
            public static string oneSignalKey = "c2917484-05b1-4694-838e-1571dd4b6868";
#endif

        #endregion

        #region Dominio y Modulo
#if MOD_MOVPARK_CIUDADANO
        public static string modulo = "MovilPark Ciudadano";
        public static string dominio = "movilparking.com";
#endif
#if MOD_MOVPARK_CONTROLADOR
        public static string modulo = "MovilPark Controlador";
        public static string dominio = "movilparking.com";
#endif
#if MOD_GDA_CIUDADANO
        public static string modulo = "MOD_GDA_CIUDADANO";
        public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_TRANSPORTE
        public static string modulo = "Transporte Digital";
        public static string dominio = "boleteriadigital.com.ar";
#endif
#if MOD_COMPRASFUNCIONARIOS
            public static string modulo = "Compras Funcionarios";
            public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_FUNCIONARIOS
        public static string modulo = "Funcionarios";
            public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_SEGURIDAD
            public static string modulo = "Seguridad";
            public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_MOVPARK
        public static string modulo = "Movil Parking";
        public static string dominio = "movilparking.com";
#endif
#if MOD_COMPRAS
        public static string modulo = "COMPRAS";
        public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_VECINODIGITAL
        public static string modulo = "Vecino Digital";
        public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_GESTIONCOCHERAS
        public static string modulo = "Gestión Cocheras";
        public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_CONTROLADOR
        public static string modulo = "Controlador";
        public static string dominio = "movilparking.com.ar";
#endif
#if MOD_MULTAS
        public static string modulo = "Multas";
        public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_BOLETERIA
        public static string modulo = "Boleteria Digital";
        public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_UROVO
        public static string modulo = "Urovo";
        public static string dominio = "gobdigital.com.ar";
#endif
#if MOD_GDA
            public static string modulo = "Gobierno Digital Abierto";
            public static string dominio = "gobdigital.com.ar";
#endif
        #endregion

    }
}
