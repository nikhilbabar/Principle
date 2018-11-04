using Principle.Models.ReadModels;
using System.Collections.Generic;

namespace Principle.Repository
{
    public class MockEntityRepository
    {
        #region Declaration(s)
        private List<WildSearchModel> masterEntities;
        private List<WildSearchModel> newEntities;

        #endregion

        #region Properties
        public List<WildSearchModel> MasterEntities
        {
            get
            {
                return masterEntities;
            }
        }

        public List<WildSearchModel> NewEntities
        {
            get
            {
                return newEntities;
            }
        }
        #endregion

        #region Constructor(s)
        public MockEntityRepository()
        {
            CreateMockData();
        }

        #endregion

        #region Method(s)
        #endregion

        #region Function(s)
        public void CreateMockData()
        {
            masterEntities = new List<WildSearchModel>();
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GEELY" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HYUNDAI+SUZUKI" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "CADILLAC" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "CHANGHE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "AUTOVAZ" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MASERATI" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "YUEJIN" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BIKA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "ROVER" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HONDA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ROEWE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "DACIA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "AIXAM" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "LAND ROVER" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "CHRYSLER+DODGE+JEEP" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "VOLKSWAGEN GROUP" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "FISKER" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "ZOTYE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "LUXGEN" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "JCBL" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "JEEP" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "WEIZHI" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "TOWN LIFE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "SUBARU" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "VOLVO" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "JAGUAR LAND ROVER" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "DAIHATSU+TOYOTA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "SSANGYONG" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "ALPINA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HIGER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SUZUKI" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HAWTAI" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "KARRY" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "UNIMOG" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "CHERY" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "JIANGHUAI" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "SOUEAST" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "FERRARI" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "KUNCHENG" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "DR." });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SAAB" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "SYM." });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "PONTIAC" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "YEMA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "GREAT WALL" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "ZAZ" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "TATA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "GAZ" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "UTV." });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "FORD+LINCOLN" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RENAULT" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HUMMER" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "TIANJIN" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "TESLA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "JIANGNAN" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "FOTON" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MUNDI AUTO" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "SCION" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "GMC TRUCK" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "AGRALE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "INFINITI" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "DODGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "ZHONGXING" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "RUILING" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "ASTON MARTIN" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "ZHONGHUA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "GEELY+GLEAGLE" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HYUNDAI" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "XIYATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "XIALI" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BEIJING" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "RADICAL SPORTCARS" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "DODGE+JEEP" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "ABARTH" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "SEAT" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "SOKON" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "JMC" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MITSUBISHI" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "VOLKSWAGEN" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "ZAP" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "YUSHENG" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "DONGFENG" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "LITTLE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "ENGLON" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BUICK+CHEVROLET" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BYD" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "ACURA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "XARRINA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "CHANA+HAFEI" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MITSUBISHI+SOUEAST" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ISUZU" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "CARBON" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "OLDSMOBILE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "PROTON" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "DONGFENG+JBC" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MORGAN" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "GOUPIL" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BMW" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "KARSAN" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "XINKAI" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "JAGUAR" });

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ABARTH SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "ALFA ROMEO SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "ALFACAR SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "AUTOCOM SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BMW DE ARGENTINA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "CHANGAN SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "CHERY SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "CHERY SOCMA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "CHRYSLER ARGENTINA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "CHRYSLER DLR GRP SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CINASCAR SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "CITROEN SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "COAFI ARGENTINA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "COLITALIA AUTOS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "COLWAGEN SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "DAIMLER COLOMBIA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "DERCO SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "DERCO SA+PLANAUTOS" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "DITECAR SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "DONGFENG HONDA AUTO CO.L" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "FIAT SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "FORD DEALERS (SA)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "FORTALEZA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "GAC HONDA MOTOR CO.?LTD" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "GAC HONDA MOTOR CO.|LTD" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "GENERAL MOTORS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "GNC SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "GRUPO AUTOLIDER SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "GUANGZHOU HONDA AUTOMOTI" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HOLDEN DEALERS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HONDA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HONDA AUSTRALIA-MOTOR VE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "HONDA AUTO CO.?LTD." });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "HONDA AUTOMOBILE(THAILAN" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "HONDA AUTOMOBILI IT.SPA " });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "HONDA AUTOMOTIVE DIVISIO" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "HONDA AUTOMOVEIS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HONDA AUTOMOVILES ESPA?A" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "HONDA BRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HONDA CORPORATION" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HONDA DE MEXICO" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HONDA DEALERS ASSOCIATIO" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "HONDA DEALERS NAT" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "HONDA DEALERS NSW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "HONDA DEALERS QLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "HONDA DEALERS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "HONDA DEALERS VIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HONDA DEALERS WA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "HONDA DT.| OFFENBACH" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HONDA INT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HONDA KOREA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HONDA MAGNO" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "HONDA MOTOR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "HONDA MOTORS" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "HONDA SA PTY LTD" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "HONDA SIEL CARS INDIA LT" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "HONDA TEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HONDA TECHNOLOGY&RESEARC" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "HONDA TURKIYE A.S" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HONDA UK LTD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HONDA USA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HONDA VIETNAM CO. LTD." });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "HYUNDAI DEALERS (SA)" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "HYUNDAI SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "INDUMOTORA ARGENTINA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "KIA ARGENTINA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "KIA DEALERS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "KIA MOTORS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "KIA PLAZA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MAHINDRA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MAZDA DEALERS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MERCEDES BENZ ARG SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MERCEDES BENZ DEALERS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MONTESA-HONDA| S.A." });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "NISSAN ARGENTINA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "NISSAN DEALER GROUP SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "NISSAN SA PTY LTD" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "NORDENWAGEN SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "PEUGEOT DEALERS SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "PEUGEOT SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "PORSCHE SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "SUZUKI DEALERS (SA)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "SUZUKI SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "TOYOTA COLOMBIA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "TOYOTA DEALER GROUP SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "VAS COLOMBIA SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "VOLKSWAGEN DEALERS SA" });

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ACURA DEALERS ASSOCIATION M L LEASE TACT(0029080)" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "ACURA DEALERS ASSOCIATION M L TACTICAL (0029080)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "ACURA NSX COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "APPLE IPAD INDIRECT ADVERTISING; LIFAN AUTOMOBILE DEALERSHIPS; LIFAN PASSENGER M" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "ASTON MARTIN - V8 VANTAGE COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "AUDI - A5 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "AUDI A 4 + A 6 AUTOMOVIL / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "AUDI A 6 AUTOMOVIL / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "AUDI A 6 AUTOMOVIL INT" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "AUDI A 6 AUTOMOVIL + Q 5 / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI A5 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "AUDI A5 COUPE LEASE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "AUDI A5 COUPE LEASE DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "AUDI A5 COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "AUDI A5 COUPE ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "AUDI A-6 PASSENGER CARS" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "AUDI A-6 PASSENGER CARS; AUDI Q3 FWD; GOLDEN PEGAS INDIRECT ADVERTISING" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "AUDI A7 SPORTBACK / AUTO CUPE IMP AUDI" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "AUDI R8 COUPE -CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "AUDI RS5 COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI S5 COUPE LEASE AUDI DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "AUDI S7 COUPE'" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "AUDI TT COUPE AUTOMOV / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "AUDI TT COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "AUDI / A5 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "B.M.W. 6 SERIES COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "B.M.W. 6 SERIES GRAN CO" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "B.M.W. 7 SERIES M" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "B.M.W.SERIES_ 6" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BENTLEY / CONTINENTAL GT COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW - 3 SERIES COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "BMW - 6 SERIES" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "BMW - 6 SERIES GRAN COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "BMW - M COUPE CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BMW - MINI COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BMW 1 SERIES M DOUBLE DOOR ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BMW 118 D COUPE M SP.ED" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BMW 120I COUPE-RETAIL" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BMW 128I COUPE LEASE TACTICAL DLRS(0169371)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BMW 5 SERIES & 6 SERIES CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW 5 SERIES & 6 SERIES GRAN COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "BMW 6 SERIES" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "BMW 6 SERIES CABRIOLET ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "BMW 6 SERIES CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BMW 6 SERIES COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BMW 6 SERIES GRAN COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BMW 6 SERISE GRAN COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BMW 6 SERISI" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BMW 640 COUPE DIESEL PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BMW 640 DIESEL GRAN COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW 640D GRAN COUPE OTO" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "BMW 650 COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "BMW 6ER COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "BMW 6ER GRAN COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BMW 6 - SERIES" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BMW 6SERIES GRAN COUPE - CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BMW ALPINA B3 GT3 COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BMW BANK CREDIT SERVICES FOR SALE OF TRANSPORT; BMW X3 XDRIVE20D M SPORT EDITION" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BMW EFFICIENT DYNAMICS / AUTO CUPE IMP BMW" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BMW M CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW M COUPE / M ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "  BMW M KFZ-IMAGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "BMW M PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "BMW M SERIES" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BMW M SERIES CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BMW M SERIES NAMEPLATE (0020560)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BMW M6 COUPE NAMEPLATE(0020560)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BMW MINI COUPE & ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BMW MINI COUPE ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BMW MINI ROADSTER & COUPE CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW SERIE 2 GRAN COUPE' (@)" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "BMW SERIE 6 AUTO N." });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "BMW SERIE 6 AUTOMOVIL" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "BMW SERIE 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BMW SERIE 6 GRAN COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BMW SERIE 6 GRAN COUPE'" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BMW SERIE 6 GRAN COUPE / C." });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BMW SERIE 6 GRAN CP" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BMW SERIES 6 CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BMW SERIES 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW SERIES 6 GRAN COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "BMW X1 M CAMIONETA / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "BMW X1 M P 4 DRIVE PR / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "BMW X1 M PLAN 4 DRIVE / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BMW X1 M SPORT ED./ C." });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BMW X1 M SPORT EDITION" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BMW X3 M FWDS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BMW - 6 SERIES(MID - SIZE LUXURY CAR)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BYD F 6 AUTOMOVIL / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "CADILLAC CTS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC CTS COUPE & CTS - V COUPE ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "CADILLAC CTS COUPE NAMEPLATE(009279C)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "CADILLAC CTS COUPE ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "CADILLAC CTS - V COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "CADILLAC CTS - V COUPE SPEEDSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "CADILLAC / CTS COUPE 2012" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "CADILLAC / CTS COUPE 2012 + DIST" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "CADILLAC / CTS V SERIES COUPE 2012" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "CADILLAC / ESCALADE + SRX + CTS COUP 2012" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "CAMARO / AUTO CUPE IMP GM" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CESAR SATELLITE INDIRECT ADVERTISING; MAZDA 6 PASSENGER CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "CHERY - ASSISTANCE ON THE ROAD!ADDITIONAL SERVICES FOR SALE OF TRANSPORT; CHERY M" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "CHEVROLET CAMARO COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "CHEVROLET DEALER ASSOCIATION M L LEASE T" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "CHEVROLET DEALERS ASSOCIATION M L LEASE (0260710)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "CHEVROLET DEALERS ASSOCIATION M L TACTIC(0260710)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "CHEVROLET DIVISION M L LEASE TACTICAL(009279D)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "CHEVROLET DIVISION M L TACTICAL(009279D)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "CHRYSLER DODGE JEEP RAM DLRS ASSOC M L T(0053101)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "CITROEN C4 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CLASSE C 180 TURBO / AUTO CUPE IMP MERC BENZ" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "CLASSE C 180 TURBO / AUTO CUPE IMP MERC BENZ(VJ)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "FAW MAZDA 6 & RUIYI CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "FAW MAZDA 6 CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "FIAT 500 COUPE NAMEPLATE(1033568)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "FIAT 500 COUPE TACTICAL(1033568)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "FIAT 500 COUPE TACTICAL DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "FORD DEALERS ASSOCIATION M L LEASE TACTI(0152091)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "FORD DEALERS ASSOCIATION M L TACTICAL(0152091)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "FORD FIESTA TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "FORD FOCUS COUPE CABRIO PKW - VERSIONEN" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "FORD FOCUS TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "FORD OF CANADA M L NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "FORD OF CANADA M L TACTICAL(0084851)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "GA--INFINITI M SERIES CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "GAZPROMBANK INDIRECT ADVERTISING; MAZDA 6 PASSENGER CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "GENESIS / AUTO CUPE IMP HYUNDAI" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "GM OF CANADA M L NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "GQ / AUTO CUPE IMP CITROEN" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HONDA ACCORD COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HONDA ACCORD COUPE TACTICAL HONDA DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HONDA CIVIC COUPE LEASE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "HONDA CIVIC COUPE LEASE TACTICAL(0107443)" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "HONDA CIVIC COUPE TACTICAL HONDA DLRS (0029030)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "HONDA CR Z TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "HONDA CR - Z SPORT HYBRID COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "HONDA DEALERS ASSOCIATION M L LEASE TACT(0029030)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HONDA DEALERS ASSOCIATION M L NAMEPLATE(0029030)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "HONDA DEALERS ASSOCIATION M L TACTICAL(0029030)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HYUNDAI CANADA M L NAMEPLATE(0110190)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HYUNDAI CANADA M L TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HYUNDAI COUPE ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "HYUNDAI DEALERS ASSOCIATION M L TACTICAL(0029040)" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "HYUNDAI ELANTRA COUPE NAMEPLATE(0110190)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "HYUNDAI GENESIS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "HYUNDAI GENESIS COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "HYUNDAI GENESIS COUPE NAMEPLATE DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HYUNDAI GENESIS COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "HYUNDAI GENESIS COUPE TACTICAL(0110190)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "HYUNDAI I30 COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HYUNDAI ROHENS COUPE ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "HYUNDAI VELOSTER COUPE LEASE TACTICAL(0110190)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "HYUNDAI VELOSTER COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "HYUNDAI VELOSTER COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "HYUNDAI VELOSTER COUPE TACTICAL(0110190)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "HYUNDAI VELOSTER COUPE TACTICAL DLRS(0029040)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "HYUNDAI VELOSTER TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HYUNDAI / GENESIS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "INFINITI - G COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "INFINITI - INFINITI M" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "INFINITI - M HYBRID RGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "INFINITI DEALERS ASSOCIATION M L LEASE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "INFINITI G COUPE PKW / RED BULL RACING" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "INFINITI G PASSENGER CAR; INFINITI M PASSENGER CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "INFINITI G37 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "INFINITI G37 COUPE LEASE(0311601)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "INFINITI G37 COUPE LEASE DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "INFINITI G37 COUPE LEASE TACTICAL DLRS(0185910)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "INFINITI M" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "INFINITI M 30 D / CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "INFINITI M 35 HIBRIDO / C." });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "INFINITI M CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "INFINITI M HYB" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "INFINITI M HYBRID PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "INFINITI M PASSENGER CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "INFINITI M PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "INFINITI M PKW - VERSIONEN" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "INFINITI M SEDAN LEASE (0311601)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "INFINITI M SEDAN LEASE DLRS(0185910)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "INFINITI M SEDAN LEASE TACTICAL(0311601)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "INFINITI M SEDAN LEASE TACTICAL DLRS(0185910)" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "INFINITI M SEDAN NAMEPLATE(0311601)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "INFINITI M SERIES CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "INFINITI M SERIES CAR & EMERG - E CONCEPT CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "INFINITI M - SERIES" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "JAGU.XK COUPE'" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "JAGUAR XK COUPE LEASE DLRS(0100790)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "JAGUAR XK COUPE TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "KIA CANADA M L LEASE TACTICAL(0015450)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "KIA CANADA M L TACTICAL(0015450)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "KIA DEALERS ASSOCIATION M L NAMEPLATE(0003440)" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "KIA DEALERS ASSOCIATION M L TACTICAL(0003440)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "KIA FORTE COUPE LEASE TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "KIA FORTE COUPE LEASE TACTICAL DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "KIA FORTE COUPE TACTICAL(0015450)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "KIA FORTE COUPE TACTICAL DLRS(0003440)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "LAMBORGHINI AVENTADOR COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "LAMBORGHINI GALLARDO LP 550 - 2 COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "LAND ROVER EVOQUE COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "LEXUS DEALERS ASSOCIATION M L TACTICAL(0183000)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MAZDA - MX 6" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MAZDA 3 PASSENGER CAR; MAZDA 6 PASSENGER CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MAZDA 3 PASSENGER CAR; MAZDA 6 PASSENGER CAR; MAZDA CX-7 FWD; MAZDA FINANCE CRED" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MAZDA 3 PASSENGER CAR; MAZDA 6 PASSENGER CAR; MAZDA STRAKHOVANIE INSURANCE SERVI" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MAZDA 6" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MAZDA 6 - CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MAZDA 6 1.8 STYLE" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MAZDA 6 1.8 STYLE / CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MAZDA 6 2.2.DIESEL" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MAZDA 6 CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MAZDA 6 DIESEL / CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MAZDA 6 IMPULSE LINE PASSENGER CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MAZDA 6 IRUKA 2.0 DSI" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MAZDA 6 IRUKA / CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MAZDA 6 PASSENGER CAR; MAZDA CX-7 FWD; MAZDA FINANCE CREDIT SERVICES FOR SALE OF" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MAZDA 6 PASSENGER CAR; MAZDA FINANCE CREDIT SERVICES FOR SALE OF TRANSPORT" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MAZDA 6 PASSENGER CAR; MOSCOW INTERNATIONAL AUTOMOBILE SALON INDIRECT ADVERTISIN" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MAZDA 6 PASSENGER CAR; RENAISSANCE INSURANCE INDIRECT ADVERTISING" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MAZDA 6 PASSENGER CAR; RUSFINANS BANK INDIRECT ADVERTISING" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MAZDA 6 PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MAZDA 6 PKW - VERSIONEN" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MAZDA 6 SEDAN LEASE TACTICAL DLRS (0029070)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MAZDA 6 SEDAN TACTICAL(0238751)" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MAZDA 6 SEDAN TACTICAL DLRS(0029070)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MAZDA 6 STYLE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MAZDA 6 STYLE / CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MAZDA 6 TURISMOS 3 MEDIOS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MAZDA 6 ULTRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MAZDA 6 WAGON" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MAZDA 6 WAGON IRUKA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MAZDA DEALERS ASSOCIATION M L LEASE TACT" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MAZDA DEALERS ASSOCIATION M L TACTICAL(0029070)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MAZDA MAZDA 6" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MAZDA MX 5 TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MERC BENZ C CLASS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MERC.CL.C COUPE'" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MERC.CL.E COUPE'" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MERC.CLS COUPE'" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MERCEDES - C 63 AMG COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MERCEDES - C CLASS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MERCEDES - C CLASS COUPE AMG SPORT" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MERCEDES - C CLASS SPORTS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MERCEDES - M CLASS EDITION S" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MERCEDES - M CLASS RGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MERCEDES - M CLASS SPEC ED" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MERCEDES - M CLASS SPORT" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MERCEDES BENZ B CLASS / M CLASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MERCEDES BENZ C CLASS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MERCEDES BENZ C CLASS COUPE LEASE TACT D(0137061)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MERCEDES BENZ C180 COUPE - RETAIL" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MERCEDES BENZ C250 COUPE LEASE TACTICAL(0137061)" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MERCEDES BENZ C250 COUPE LEASE TACTICAL(0640674)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MERCEDES BENZ C350 COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MERCEDES BENZ C63 AMG COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MERCEDES BENZ CANADA M L LEASE TACTICAL(0640674)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MERCEDES BENZ CANADA M L NAMEPLATE(0640674)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MERCEDES BENZ CL CLASS COUPE LEASE TACT(0137061)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MERCEDES BENZ CLASE A TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MERCEDES BENZ CLASE C TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MERCEDES BENZ CLASE E COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MERCEDES BENZ CLASE M CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MERCEDES BENZ CLASE M TURISMOS 9 TODO TERRENO" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MERCEDES BENZ E CLASS COUPE TACTICAL DLR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MERCEDES BENZ E250 AMG COUPE - CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MERCEDES BENZ E350 COUPE LEASE TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MERCEDES BENZ E350 COUPE LEASE TACTICAL(0640674)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MERCEDES BENZ M CLASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MERCEDES BENZ M CLASS 4 DR NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MERCEDES BENZ M CLASS 4WD" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MERCEDES BENZ M CLASS - RETAIL" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MERCEDES BENZ M - CLASS - CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MERCEDES BENZ SLS AMG COUPE NAMEPLATE(0640674)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MERCEDES BENZ SLS AMG COUPE TACTICAL DLR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MERCEDES BENZ SLS AMG TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MERCEDES BENZ / C 63 AMG COUPE 2013" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MERCEDES BENZ / C COUPE 2013" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MERCEDES BENZ / C COUPE 2013 + DIST" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MERCEDES BENZ / CLASE C COUPE AUTO" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MERCEDES BENZ / CLASE M 2012" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MERCEDES C 63 AMG COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MERCEDES C - CLASS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MERCEDES C - COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MERCEDES C - KLASSE COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MERCEDES CLS COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MERCEDES M - CLASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MERCEDES M - KLASSE GEL - WAG" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MERCEDES - BENZ CENTRE AUTOMOBILE DEALERSHIP; MERCEDES - BENZ M - CLASS FWD" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MERCEDES - BENZ CENTRE AUTOMOBILE DEALERSHIP; MERCEDES - BENZ SPRINTER 515 TOURIST M" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MERCEDES - BENZ CENTRE CAR SERVICING CENTRES; MERCEDES - BENZ M - CLASS FWD" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MERCEDES - BENZ M OFF-ROADVEHICLE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MERCEDES - BENZ M SERISI" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MERCEDES - BENZ M - CLASS FWD" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MERCEDES - BENZ M - CLASS FWD; MERCEDES - BENZ PASSENGER CARS" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MERCEDES - BENZ M - CLASS FWD; MERCEDES - BENZ SL - CLASS PASSENGER CAR; MERCEDES - BENZ S" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MERCEDES - BENZ M - CLASS SUV CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MERCEDES - BENZ - M - CLASS(MID - SIZE LUXURY CAR)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MG 3 & 6 CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MG 5 & 6 CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MG 6 CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MG 6 MAGNETTE CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MINI COOPER COUPE LEASE (0020560)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MINI COOPER COUPE LEASE DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MINI COOPER COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MINI COOPER COUPE NAMEPLATE DLRS(0169372)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MINI COOPER COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MINI COOPER COUPE TACTICAL DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MINI COOPER S COUPE - CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MINI COOPER S COUPE OTO" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MINI COOPER S COUPE TACTICAL DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MINI COOPER S COUPE / ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MINI COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MINI COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MINI COUPE / CONC." });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MINI COUPE / ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MINI / COUPE AUTO" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MINI / COUPE + ROADSTER 2012" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MITSUBISHI MOTORS M L LEASE TACTICAL(0745450)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "NEW BEETLE / AUTO CUPE IMP VW" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "NISSAN 370Z COUPE TACTICAL DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "NISSAN ALTIMA COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "NISSAN ALTIMA COUPE TACTICAL DLRS(0029090)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "NISSAN CANADA M L LEASE TACTICAL(0311602)" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "NISSAN CANADA M L TACTICAL(0311602)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "NISSAN DEALERS ASSOC M L LEASE TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "NISSAN DEALERS ASSOCIATION M L TACTICAL(0029090)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "NISSAN GT R COUPE NAMEPLATE(0311602)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "NISSAN INFINITI M" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "NISSAN TIIDA M AUTOM PR / PR" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "NISSAN./ SENTRA ACENTA 6 MT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL ASTRA COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "PEUG.RCZ COUPE'" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "PEUGEOT 308 COUPE CABRIO PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "PEUGEOT 407 COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "PEUGEOT COUPE RCZ" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "PEUGEOT RCZ COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "PEUGEOT RCZ COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "PEUGEOT RCZ COUPE - RETAIL" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "PEUGEOT RCZ TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "PONTIAC BUICK GMC DLRS ASSOC M L LEASE T(0649771)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "PORSCHE 911 CARRERA COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "PORSCHE 911 CARRERA COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "PORSCHE 911 CARRERA COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "RANGE ROVER EVOQUE COUPE JEEP" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "RENA.LAGUNA COUPE + LAGUNA ST.W." });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "RENAULT - MEGANE COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "RENAULT - MEGANE COUPE CABRIOLET" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "RENAULT LAGUNA COUPE DCI" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "RENAULT LAGUNA COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "RENAULT MEGANE COUP¦-CABRIOLET" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RENAULT MEGANE COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "RENAULT MEGANE COUPE EMOT./ C." });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "RENAULT MEGANE COUPE OTO" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "RENAULT WIND ROADSTER COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "RENAULT WIND ROADSTER COUPE PKW SP" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "RENAULT / MEGANE III RS COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "ROLLS ROYCE BESPOKE MIRAGE M" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "ROLLS ROYCE PHANTOM COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "SCION FR S COUPE NAMEPLATE(0829833)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "SCION FR S COUPE TACTICAL DLRS(1240880)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SCION TC COUPE LEASE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "SCION TC COUPE LEASE TACTICAL DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "SCION TC COUPE NAMEPLATE(0829833)" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "SCION TC COUPE TACTICAL DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "SEAT IBIZA COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "SEAT IBIZA COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "SEAT / IBIZA COUPE 2013 + DIST" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "SMART - FORTWO COUPE PULSE 71" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "SMART COUPE LEASE DLRS(0137062)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "SMART COUPE TACTICAL DLRS(0137062)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SMART FORTWO COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "SMART FORTWO COUPE PKW SP" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "SMART FORTWO COUPE PURE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "SUBARU BRZ COUPE NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "SUBARU BRZ COUPE NAMEPLATE DLRS" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "SUBARU CANADA M L NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "SUBARU DEALER ASSOCIATION M L LEASE TACT" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "SUBARU DEALERS ASSOCIATION M L NAMEPLATE(0028980)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "SUBARU DEALERS ASSOCIATION M L TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "SUZUKI - SWIFT 1 6 SPORT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SUZUKI CANADA M L TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "TOYOTA CANADA M L NAMEPLATE(0829831)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "TOYOTA CANADA M L TACTICAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "TOYOTA DEALERS ASSOCIATION M L LEASE TAC(0029200)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "TOYOTA DEALERS ASSOCIATION M L NAMEPLATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "TOYOTA DEALERS ASSOCIATION M L TACTICAL(0029200)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "TOYOTA GT 86 COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "VELOSTER / AUTO CUPE IMP HYUNDAI" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "VELOSTER / AUTO CUPE IMP HYUNDAI(VJ)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "VOLKSWAGEN CC TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "VOLKSWAGEN EOS TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "VOLKSWAGEN SCIROCCO TURISMOS 6 COUPE" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "VOLVO C70 COUPE CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "VW SCIROCCO COUPE PKW" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "VW SCIROCCO COUPE PKW / SPORT1" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "ZHONGHUA COUPE ROADSTER" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "M 6 COUP" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "HUNDA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Hondo" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "AW" });

            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Business & Technology NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Business & Technology Corporate Promotion/ Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Business & Technology General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "WSJ - Ads Under 50 Lines" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Business Propositions" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Employment Recruitment:Clsfd / Excl Agate" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Employment Agencies" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Employment Recruitmnt:Agate / Excl Clsfd" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Railroad(Incl Industrial Dev)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Airline Freight (Incl Industrial Dev)" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Ship, Truck & Other Freight" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Freight: Comb Copy &NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Manufactrg Machinery, Equipment &Tools" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Electronics & Electronic Components" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Manufactrg / Electronics / Engineering: NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Manufactrg Metals &Fabrictd Metal Parts" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Manufactrg Packaging &Paper Products" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Manufactrg Chemicals &Plastics" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Manufactrg Materials &Supplies:Comb & NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Office Furniture &Accessories" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Stationery,Greeting Cards&Misc Paper Gds" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Pens, Pencils & Markers" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Office Furnitr, Stationery&Suppl:Comb & NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Copiers & Duplicating Equipment" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Facsimile Equipment &Accessories" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Office Machines &Equipmentl: NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Real Time &Screen Phone Financial Quote Systems" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Publishing & Media NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Publishing & Media Corporate Promotion/ Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Publishing & Media General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Internet Webcasts" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Internet Broadcasters Corporate Promotion/ Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Advertising, Marketing & Printing Svcs" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Coupon Marketing Organizations" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "TV Networks, Stations &Production Cos" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Cable Networks &Programs & Satellite TV" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Promotionals(MediaWatch Only)" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Television & Cable TV: Comb Copy &NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Radio Stations" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Radio Networks &Syndicated Programmers" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Radio Networks &Syndicated Programmers Corporate Promotion / Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Newspapers, National" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Newspapers, Local" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Magazines" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "TV Magazines" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Print Media: Comb Copy &NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Comic Books" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Books NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Books Corporate Promotion / Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Computers & Software NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Computers & Software Corporate Promotion/ Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Computers & Software General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Web Design, Domain &Hosting Services" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Internet Business &Home Office Svcs NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Offline Internet Support Services NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Internet Sites NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Computer Games &Educational Software" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Computer Software (Excl Games & Educ)" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Printers & Printing Accessories" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Computer Components &Peripherals(Excl Printers)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Computer Accessories" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Computer Components &Accessories, General Promotion/ Multi - Category / Corporate / Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Desktop Computers" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Notebook / Laptop Computers" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Tablet Computers" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "PDA / Handheld Computers" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Workstation Computers" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Servers(Excluding Blade Servers)" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Blade Systems" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Computers NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Computers, General Promotion/ Multi - Category / Corporate / Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Real Estate Agents, Agencies & Brokers" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Real Estate Developers & Developments" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Real Estate: Agate(Newspaper Only)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Real Estate: Comb Copy &NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Homeowners & Personal Property Insurance" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Automobile Insurance" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Business Insurance" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Insurance: Comb Copy &NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Life Insurance" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Medical & Dental Insurance" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Presidential Campaigns" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "National Campaigns (Non - Presidential)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "State & Local Campaigns" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Ballot Issues" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Political & Political Parties: Comb & NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Unions" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Religious, Charitable & Humanitarian" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Public Service Ann(Non - Pd MW Only)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Organization Advertising: NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Foreign & U.S.Government" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Lotteries" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Local Government" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Government: Comb Copy & NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Communications NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Communications General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Cable TV Providers & Systems" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Satellite Providers, Systems & Services" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Telephone Calling Cards" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Telephone Directories" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Communications Networking Systems & Svcs" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Communications Products & Sys: Comb & NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "Long Distance Telecom Providers" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Local Telecom Providers" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "Wireless Telecom Providers" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Internet Telecom Providers" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Internet Service Providers(ISP)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Telecom Providers/ Services:Comb Copy&NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Wired Home Phone Equipment &Systems" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "Wired Business Phone Equipment &Systems" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Wireless Home/ Business Phone Equip &Sys" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "Telephone Equipment: Comb Copy &NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "Financial, General Promotion &Multi - Category" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Financial, Corporate Promotion/ Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Banking(Consumer)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Investment Products &Services(Excluding Retirement)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Retirement Products &Services" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "Loan / Credit Products & Services(Consumer)" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "Business & Commercial Financial Products &Services" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Financial Products &Services NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Credit Cards" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "Travelers Checks" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Credit Cards &Travelers Checks NEC" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "Credit Cards &Travelers Checks, Genl Promo/ Multi - Category / Corporate / Sponsorship" });

            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "36,6 DRUGSTORE; AMUR TIGER (CENTRE); GORZDRAV; RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AEROFLOT; MASTERCARD WORLD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "AEROFLOT; MASTERCARD WORLD; MASTERCARD WORLD BLACK EDITION; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "AFISHA RESTAURANTS; VISA GOLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "AK BARS (BANK)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "AKIT(ASSOCIATION OF INTERNET TRADING COMPANIES); YANDEX.DENGI" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "ALFA - BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "ALFA - BANK; ALFA - BANK ALFA - CASH ULTRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "ALFA - BANK; ALFA - BANK ALFA - MILES" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "ALFA - BANK; ALFA - BANK INTERNET - EKVAYRING LAYT" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "ALFA - BANK; ALFA BANK ALFA - BIZNES ONLINE; ALFA BUSINESS WEEK" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ALFA - BANK; ALFA - BANK ALFA - MIR" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "ALFA - BANK; ALFA - BANK KLUB KLIENTOV" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "ALFA - BANK; ALFA - BANK KLUB KLIENTOV; ALFABANK.RU" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "ALFA - BANK; COSMOPOLITAN; RESERVED; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "ALFA - BANK; ALFA - BANK ALFA - KLIK; COSMOPOLITAN; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "ALFA - BANK; COSMOPOLITAN; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "ALFA - BANK; ALFA - BANK KOPILKA DLYA SDACHI; COSMOPOLITAN; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "ALFA - BANK; ALFA - BANK KOPILKA DLYA SDACHI; GAME LAND (PUBLISHER); MAXIM(MAGAZINE); VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "ALFA - BANK; ALFA - BANK ALFA - CASH ULTRA; LINIYA ZHIZNI" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "ALFA - BANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ALFA - BANK; MASTERCARD WORLD BLACK EDITION" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "ALFA - BANK; ALFA - BANK MAKSIMUM +; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "ALFA - BANK; ALFA - BANK MAKSIMUM +; MASTERCARD WORLD BLACK EDITION" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "ALFA - BANK MAKSIMUM +; MASTERCARD; MASTERCARD WORLD BLACK EDITION" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "ALFA - BANK; MASTERCARD WORLD GOLD PAYPASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "ALFA - BANK; MASTERCARD PAYPASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "ALFA - BANK; MASTERCARD PLATINUM" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "ALFA - BANK; ALFA - BANK ALFA - MOBAYL; MASTERCARD STANDARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "ALFA - BANK; MASTERCARD; RUSSIAN RAILWAYS" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "ALFA - BANK; MAXIM(MAGAZINE); VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ALFA - BANK; OLYMPIC GAMES; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "ALFA - BANK; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "ALFA - BANK; VISA GOLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "AMEDIATEKA.RU; HBO; MASTERCARD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "AMEDIATEKA.RU; HBO; MASTERCARD WORLD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "AMEDIATEKA.RU; IGRA PRESTOLOV; MASTERCARD WORLD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "AMEDIATEKA.RU; MASTERCARD WORLD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "AMUR TIGER(CENTRE); IKH SUDBA V NASHIKH RUKAKH; RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK AMURSKIY TIGR" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "AMUR TIGER(CENTRE); PEREKRESTOK(CHAIN OF SHOPS); RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK AMURSKIY TIGR" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "AMUR TIGER(CENTRE); RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK AMURSKIY TIGR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "APP STORE; GOOGLE PLAY; RAIFFEISENBANK; RAIFFEISENBANK R-CONNECT" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "APP STORE; GOOGLE PLAY; TINKOFF CREDIT SYSTEMS" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "APPLE ITUNES; YANDEX.DENGI" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "AVANGARD BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "AVANGARD BANK; GLOBAL BANKING &FINANCE REVIEW" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "AVTODOR PD; T - PASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BANK RSB 24; CONTACT(PAYMENT SYSTEM)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BEELINE; MASTERCARD WORLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BEELINE; PLATEZHNY TSENTR; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BEELINE; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BINBANK; BINBANK DOKHODNAYA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "BINBANK; BINBANK VOKRUG SVETA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "BINBANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "BINBANK; BINBANK BINBANK-ONLAYN; BINBANK MAKSIMALNY PROTSENT" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "BINBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "BINBANK PREMIUM; BINBANK PREMIUM PREMIUM; VISA SIGNATURE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "BINBANK; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "BINBANK; VISA PLATINUM" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "BINBANK PREMIUM; BINBANK PREMIUM PREMIUM; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "BINBANK; VISA SIGNATURE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BLIZKO; SVYAZ - BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "BPS - SBERBANK; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "  CENTRE OF FINANCIAL TECHNOLOGIES; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "CHRONOPAY" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "CITIBANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "CITIBANK; FINFIN; NAUMIR" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "CITIBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "CONTACT(PAYMENT SYSTEM); RAPIDA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "DISNEYLAND PARIS; MASTERCARD; MASTERCARD BESTSENNYE GORODA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "E100" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ENERGOMASHBANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "ENERGOTRANSBANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "E - OBMEN" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "EUROSET; MOSCOW UNDERGROUND; TROYKA(TRANSPORT CARD)" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "EUROSET; PLATEZHNY TSENTR; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "EUROSET; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "FESTIVAL DE CANNES; MASTERCARD; MASTERCARD BESTSENNYE GORODA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "FESTIVAL DE CANNES; MASTERCARD; RAIFFEISENBANK; RAIFFEISENBANK PREMIUM BANKING" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "FIFA FUTSAL WORLD CUP; KIA; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "FIFA FUTSAL WORLD CUP; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "FINNAIR; VISA PLATINUM; ZENITH BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "FORMULA KINO; MASTERCARD; TOUCH BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "GAZPROM NEFT; GAZPROM NEFT NAM PO PUTI" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "GAZPROM NEFT" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "GAZPROM NEFT; GAZPROMBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "GAZPROMBANK TRAVEL MILES" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "GAZPROMBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "GAZPROMBANK; UNIONPAY" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "GAZPROMBANK; VISA PAYWAVE" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "GOVERNMENT OF MOSCOW REGION; NASHE PODMOSKOVE (PROGRAM); STRELKA EDINAYA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HBO; MASTERCARD WORLD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "KONTINENTAL HOCKEY LEAGUE; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "LUKOIL; MASTERCARD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MAESTRO; SBERBANK OF RUSSIA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MASTERCARD; MASTERCARD WORLD PAYPASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MASTERCARD; MASTERCARD BESTSENNYE GORODA; MASTERCARD GOLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MASTERCARD; MASTERCARD BESTSENNYE GORODA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MASTERCARD; MEGAFON; MEGAFON VSE VKLYUCHENO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD; MEGAFON" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MASTERCARD; MOSCOW INDUSTRIAL BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MASTERCARD; MTS - BANK; MTS" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "  MASTERCARD; N - STORE.RU" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MASTERCARD WORLD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MASTERCARD; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MASTERCARD; MASTERCARD BESTSENNYE GORODA; PARK LIVE; RED HOT CHILI PEPPERS (CONCERT)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MASTERCARD; PARK LIVE; RED HOT CHILLI PEPERS" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MASTERCARD; PETERSBURG FUEL COMPANY; PETERSBURG FUEL COMPANY AVTOPOZITIV; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MASTERCARD; PROMSVYAZBANK; PROMSVYAZBANK TVOY PSB" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD; QIWI KOSHELEK; YANDEX.DENGI; ZAIMOLET.RU" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MASTERCARD; RAIFFEISENBANK; RAIFFEISENBANK PREMIUM BANKING" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MASTERCARD; RFI BANK; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MASTERCARD WORLD; ROCKETBANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MASTERCARD; ROSNEFT" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MASTERCARD; RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK PENSIONNY..." });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MASTERCARD; SAINT - PETERSBURG INDUSTRIAL JOINT-STOCK BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "  MASTERCARD WORLD; SBERBANK OF RUSSIA 1; VISA INFINITE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MASTERCARD; STAR WARS." });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MASTERCARD WORLD; SVYAZNOY; TINKOFF CREDIT SYSTEMS" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD WORLD PLATINUM; TINKOFF CREDIT SYSTEMS" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MASTERCARD PLATINUM; TINKOFF CREDIT SYSTEMS" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MASTERCARD; TOUCH BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MASTERCARD; MASTERCARD BESTSENNYE GORODA; UBER" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MASTERCARD; MASTERCARD BESTSENNYE GORODA; UEFA FOOTBALL CHAMPIONS LEAGUE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MASTERCARD; UEFA FOOTBALL CHAMPIONS LEAGUE" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MASTERCARD; VISA PAYWAVE; VTB" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MASTERCARD; MASTERCARD BESTSENNYE GORODA; VOLKONSKIY" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MASTERCARD; YANDEX.DENGI" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MEGAFON; WESTERN UNION" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MIR(NATIONAL PAYMENT CARD SYSTEM)" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MIR(NATIONAL PAYMENT CARD SYSTEM); MOSCOW INTERNATIONAL FILM FESTIVAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MIR(NATIONAL PAYMENT CARD SYSTEM); NASHE RADIO; NASHESTVIE" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MIR BEZ POSREDNIKOV; MOSCOW STATE UNIVERSITY; QIWI" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MOSCOW CREDIT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "MOSCOW CREDIT BANK; YANDEX.DENGI" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "MOSCOW GOVERNMENT; MOSCOW TRANSPORT; TROYKA(TRANSPORT CARD)" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "MOSCOW TRANSPORT; TROYKA(TRANSPORT CARD)" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "MOSCOW UNDERGROUND; SUNLIGHT(JEWELRY); TROYKA(TRANSPORT CARD)" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "MOSCOW UNDERGROUND; TROYKA(TRANSPORT CARD)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MTS" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "MTS; PLATEZHNY TSENTR; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "MTS; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "MTS - BANK; MTS; MTS SMART" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "MTS - BANK; MTS; MTS SMART; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "  OLYMPIC GAMES; PROMSVYAZBANK; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "  OLYMPIC GAMES; SBERBANK OF RUSSIA; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "  OLYMPIC GAMES; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "  OTKRYTIE PENSIONNAYA; RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "  RUSSIAN DEVELOPMENT BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RUSSIAN DEVELOPMENT BANK; VISA TRAVEL" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "RUSSIAN DEVELOPMENT BANK; VISA GOLD TRAVEL" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "RUSSIAN DEVELOPMENT BANK; VISA PLATINUM" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "PAYONLINE" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "PAYPAL" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "PEREDOVYE PLATEZHNYE RESHENIYA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "PETERSBURG FUEL COMPANY; PETERSBURG FUEL COMPANY AVTOPOZITIV; SBERBANK OF RUSSIA; SBERBANK OF RUSSIA SBERBANK ONL @YN" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "PETROL PLUS SPRINTER; PETROL PLUS TRANZIT CARD; PETROL PLUS VEZDEKHOD" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "PLATEZHNY TSENTR; SVYAZNOY; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "PLATON(TOLL COLLECTION)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "PLUS BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "POCHTA BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "POCHTA BANK; POCHTA BANK SBEREGATELNY SCHET" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "POCHTA BANK; VISA CLASSIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "POCHTA BANK; POCHTA BANK SBEREGATELNY SCHET; VISA CLASSIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "PROMSVYAZBANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "QIWI VISA WALLET" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "QIWI KOSHELEK; TVIDI.RU" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "RAIFFEISENBANK; RAIFFEISENBANK PREMIUM DIRECT; VISA PLATINUM" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "RAMBLER - PUTESHESTVIYA; VISA GOLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RAMBLER - KASSA; VISA GOLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "RENDEZ - VOUS(BOUTIQUE); VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = " ROSBANK; ROSBANK SVERKHKARTA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "ROSBANK; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "ROSBANK; VISA SIGNATURE" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "ROSGOSSTRAKH BANK; ROSGOSSTRAKH BANK PENSIONNAYA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "ROSGOSSTRAKH BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "RUSSIA CITYPASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK AMURSKIY TIGR" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "RUSSIAN AGRICULTURAL BANK; UNIONPAY CLASSIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RUSSIAN AGRICULTURAL BANK; UNIONPAY; UNIONPAY CLASSIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "SAINT - PETERSBURG INDUSTRIAL JOINT-STOCK BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "  SBERBANK OF RUSSIA; SBERBANK OF RUSSIA SBERBANK PERVY" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "  SBERBANK OF RUSSIA" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "SBERBANK OF RUSSIA; SBERBANK OF RUSSIA SBERBANK ONL @YN" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "SBERBANK OF RUSSIA; SBERBANK OF RUSSIA AVTOPLATEZH; SBERBANK OF RUSSIA SBERBANK ONL @YN" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "SBERBANK OF RUSSIA; STRELKA EDINAYA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "SBERBANK OF RUSSIA; TVOE" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "SBERBANK OF RUSSIA; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "SBERBANK OF RUSSIA; VISA PLATINUM" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SBERBANK OF RUSSIA; VISA CLASSIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "SODEXO; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "STRELKA EDINAYA" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "SVYAZ - BANK; SVYAZ - BANK ZIMNIY" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "SVYAZ - BANK; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "SVYAZ - BANK; SVYAZ - BANK DACHNY SEZON; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "    SVYAZNOY; ZOLOTAYA KORONA" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "TINKOFF CREDIT SYSTEMS" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "TINKOFF CREDIT SYSTEMS; TNT - CLUB" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "TINKOFF CREDIT SYSTEMS; VISA PLATINUM" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "TINKOFF CREDIT SYSTEMS; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "TOUCH BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "T - PASS" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "UNIASTRUM BANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "UNIONPAY" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "UNISTRIM" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "URAL BANK OF RECONSTRUCTION AND DEVELOPMENT" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "URALSIB; VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "VISA GOLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "VISA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "VISA PAYWAVE; VTB" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "VISA GOLD; VYBORG - BANK; VYBORG - BANK MAKSIMALNAYA STAVKA" });
            //masterEntities.Add(new WildSearchModel() { Id = 3, Name = "VTB" });
            //masterEntities.Add(new WildSearchModel() { Id = 4, Name = "VTB; VTB AVTOPLATEZH" });
            //masterEntities.Add(new WildSearchModel() { Id = 5, Name = "VTB 24" });
            //masterEntities.Add(new WildSearchModel() { Id = 6, Name = "VTB BANK OF MOSCOW" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "VTB BANK OF MOSCOW; VTB BANK OF MOSCOW START" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "WESTERN UNION" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "XAPO" });
            //masterEntities.Add(new WildSearchModel() { Id = 0, Name = "YANDEX.DENGI" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ZOLOTAYA KORONA" });

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "1" });
            //masterEntities.Add(new WildSearchModel() { Id = 2, Name = "2" });
            //masterEntities.Add(new WildSearchModel() { Id = 7, Name = "3" });
            //masterEntities.Add(new WildSearchModel() { Id = 8, Name = "13" });

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MTS" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "May" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "1-1-2016" });
            //masterEntities.Add(new WildSearchModel() { Id = 9, Name = "2-1-2016" });

            /// Media General Promotion

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Business & Technology General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Publishing & Media General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Computers & Software General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Computer Components &Accessories, General Promotion/ Multi - Category / Corporate / Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Computers, General Promotion/ Multi - Category / Corporate / Sponsorship" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Communications General Promotion" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Financial, General Promotion &Multi - Category" });

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "ALFA - BANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BEELINE; MASTERCARD WORLD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BINBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CITIBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GAZPROMBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD; MEGAFON" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD; N - STORE.RU" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD WORLD; ROCKETBANK" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD; ROSNEFT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GAZPROM NEFT; GAZPROMBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GAZPROMBANK TRAVEL MILES" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GAZPROMBANK; MASTERCARD" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GAZPROMBANK; UNIONPAY" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GAZPROMBANK; VISA PAYWAVE" });

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN CORPO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN 7" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN 310R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN 610R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN 630R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN CAR RANGER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN LECHIR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN 510R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN 560R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK AVENIR " });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK CORP" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK VELI" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK VEHICLE RANG" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK TRUCK RANGE\\" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK GL8*" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK TERRAZA+" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK CAR RANGE." });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK CASCADA56" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK EXCELLEb" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK LACROSSE`" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK LACROSSE CHINA!" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK PARK AVENUE@" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK REGAL#" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK VERANO$" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK WEILANG%" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK YINGLANG^" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK ENCLAVE&" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK ENCORE*" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK ENVISION(" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK RENDEZVOUS)" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC CORPORATE -" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC VEHICLE RANGE_" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC ATS=" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC CAR RANGE+" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC CT6<" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC CTS>" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC ELR/" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC FLEETWOOD?" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC XTS'" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC ESCALADE;" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC SRX" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC SUV RANGE:" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CADILLAC XT5," });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CHEVY." });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CORPORATE]" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET VEHICLE RANGE}" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CHEYENNE{" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET COLORADO[" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CORSA COMBO PBV" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET D-MAX|" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET MONTANA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET N300" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET S10" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SILVERADO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET TRUCK RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET ENJOY" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET ORLANDO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SPIN" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET TAVERA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET AVEO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET BEAT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET BOLT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CAMARO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CAPRICE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CAR RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CAVALIER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CLASSIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET COBALT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CORSICA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CORVETTE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CORVETTE STINGRAY" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CORVETTE Z06" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CRUZE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET IMPALA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET LOVA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET MALIBU" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET ONIX" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET OPTRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET PRISMA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SAIL" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SONIC" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SPARK" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SS" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET VOLT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET BLAZER S/T" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET CAPTIVA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET EQUINOX" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET FRONTERA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET GRAND VITARA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET NIVA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SUBURBAN" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET SUV RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET TAHOE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET TRACKER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET TRAILBLAZER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET TRAVERSE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHEVROLET TRAX" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GM AC DELCO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GENERAL MOTORS CORPORATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GENERAL MOTORS VEHICLE RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GMC CORPORATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GMC CANYON" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GMC SIERRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GMC TRUCK RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GMC ACADIA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GMC TERRAIN" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GMC YUKON" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN CLUBSPORT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN CORPORATE " });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN GEN-F" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN VEHICLE RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN COLORADO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN COMMODORE UTE P/U" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN APOLLO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN ASTRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN BARINA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN BARINA SPARK" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN CAR RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN CASCADA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN COMMODORE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN CRUZE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN INSIGNIA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN CAPTIVA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN SUV RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN TRAILBLAZER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN TRAX" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL CORPORATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL VEHICLE RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL COMBO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL CORSA COMBO PBV" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL MOVANO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL TRUCK RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL MERIVA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL VIVARO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL ZAFIRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL ADAM" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL AMPERA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL ASTRA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL CAR RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL CASCADA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL CORSA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL GT" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL INSIGNIA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL KARL" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL VIVA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL ANTARA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL MOKKA" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL/VAUXHALL MOKKA X" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "WULING VEHICLE RANGE" });


            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI R8+RS CAR RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI R8+RSCAR RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "LAND ROVER DEFENDER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MAZDA 2 + 6 CAR RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "NISSAN LIVINA+TIIDA VEHICLE RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "NISSAN VENUCIA VEHICLE RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "TOYOTA AURIS+AVENSIS CAR RANGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "JAGUAR LAND ROVER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CHANA SUV RANGE SUV & CROSSOVER" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RENAULT SUV RANGE SUV &CROSSOVER" });






            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "January" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "February" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "March" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "April" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "May" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "June" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "July" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "August" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "September" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "October" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "November" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "December" });

            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "1" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "2" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "2" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "4" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "5" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "6" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "7" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "8" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "9" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "10" });

            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CINEMA" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "DESKTOP" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "NTERNET" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "PRINT" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MOBILE" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OUTDOOR" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RADIO" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "TELEVISION" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "DESKTOP DISPLAY" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "DESKTOP VIDEO" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "MAGAZINES" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "NEWSPAPERS" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "PRESS" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Central African Republic" });

            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Brazil" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Iraq" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Iran" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "CUBA" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "India" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Indonesia" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Malawi" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Malaysia" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Maldives" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Mali" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Netherlands" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "New Zealand" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Nicaragua" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Palau" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Poland" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Portugal" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Republic of Korea (South Korea)" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Republic of Moldova" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Romania" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Russian Federation" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Saint Vincent and the Grenadines" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Samoa" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "San Marino" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Saudi Arabia" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Solomon Islands" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Somalia" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "South Africa" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "South Sudan" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Spain" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Sri Lanka" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Swaziland" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Switzerland" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Syrian Arab Republic" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "Thailand" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "United Arab Emirates" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "United Kingdom" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "United Republic of Tanzania" });
            masterEntities.Add(new WildSearchModel() { Id = 1, Name = "United States of America" });

            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN CORPO" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BAOJUN CORPORATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "GENERAL MOTORS CORPORATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HOLDEN CORPORATE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BUICK CORP" });


            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI SERVICE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI 80 PERSONAL CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI A1 PERSONAL CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI A1" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI A1 STYLE + R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI A1+R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI A8" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI A8+R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI 80+R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI FR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI OCCASION+R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI PRESTIGE" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI Q2" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI Q3" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI Q3 + R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI Q5" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI Q5 ADVANCED" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI Q5 + R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI REVENDEUR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI TT RS CP" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI SQ7+R" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI R8 SPYDER CAB" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI R8" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI R8 PERSONAL CAR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI R8+R" });
            

            /// BAOJUN CORPO
            /// BAOJUN 7
            /// BAOJUN 310R
            /// BAOJUN 610R
            /// BAOJUN 630R
            /// BAOJUN CAR RANGER
            /// BAOJUN LECHIR
            /// BAOJUN 510R
            /// BAOJUN 560R
            /// BUICK AVENIR 
            /// BUICK CORP
            /// BUICK VELI
            /// BUICK VEHICLE RANG
            /// BUICK TRUCK RANGE\
            /// BUICK GL8*
            /// BUICK TERRAZA+
            /// BUICK CAR RANGE.
            /// BUICK CASCADA56
            /// BUICK EXCELLEb
            /// BUICK LACROSSE`
            /// BUICK LACROSSE CHINA!
            /// BUICK PARK AVENUE@
            /// BUICK REGAL#
            /// BUICK VERANO$
            /// BUICK WEILANG%
            /// BUICK YINGLANG^
            /// BUICK ENCLAVE&
            /// BUICK ENCORE*
            /// BUICK ENVISION(
            /// BUICK RENDEZVOUS)
            /// CADILLAC CORPORATE -
            /// CADILLAC VEHICLE RANGE_
            /// CADILLAC ATS=
            /// CADILLAC CAR RANGE+
            /// CADILLAC CT6<
            /// CADILLAC CTS>
            /// CADILLAC ELR/
            /// CADILLAC FLEETWOOD?
            /// CADILLAC XTS'
            /// CADILLAC ESCALADE;
            /// CADILLAC SRX"
            /// CADILLAC SUV RANGE:
            /// CADILLAC XT5,
            /// CHEVROLET CHEVY.
            /// CHEVROLET CORPORATE]
            /// CHEVROLET VEHICLE RANGE}
            /// CHEVROLET CHEYENNE{
            /// CHEVROLET COLORADO[
            /// CHEVROLET CORSA COMBO PBV\
            /// CHEVROLET D-MAX|
            /// CHEVROLET MONTANA
            /// CHEVROLET N300
            /// CHEVROLET S10
            /// CHEVROLET SILVERADO
            /// CHEVROLET TRUCK RANGE
            /// CHEVROLET ENJOY
            /// CHEVROLET ORLANDO
            /// CHEVROLET SPIN
            /// CHEVROLET TAVERA
            /// CHEVROLET AVEO
            /// CHEVROLET BEAT
            /// CHEVROLET BOLT
            /// CHEVROLET CAMARO
            /// CHEVROLET CAPRICE
            /// CHEVROLET CAR RANGE
            /// CHEVROLET CAVALIER
            /// CHEVROLET CLASSIC
            /// CHEVROLET COBALT
            /// CHEVROLET CORSICA
            /// CHEVROLET CORVETTE
            /// CHEVROLET CORVETTE STINGRAY
            /// CHEVROLET CORVETTE Z06
            /// CHEVROLET CRUZE
            /// CHEVROLET IMPALA
            /// CHEVROLET LOVA
            /// CHEVROLET MALIBU
            /// CHEVROLET ONIX
            /// CHEVROLET OPTRA
            /// CHEVROLET PRISMA
            /// CHEVROLET SAIL
            /// CHEVROLET SONIC
            /// CHEVROLET SPARK
            /// CHEVROLET SS
            /// CHEVROLET VOLT
            /// CHEVROLET BLAZER S/T
            /// CHEVROLET CAPTIVA
            /// CHEVROLET EQUINOX
            /// CHEVROLET FRONTERA
            /// CHEVROLET GRAND VITARA
            /// CHEVROLET NIVA
            /// CHEVROLET SUBURBAN
            /// CHEVROLET SUV RANGE
            /// CHEVROLET TAHOE
            /// CHEVROLET TRACKER
            /// CHEVROLET TRAILBLAZER
            /// CHEVROLET TRAVERSE
            /// CHEVROLET TRAX
            /// GM AC DELCO
            /// GENERAL MOTORS CORPORATE
            /// GENERAL MOTORS VEHICLE RANGE
            /// GMC CORPORATE
            /// GMC CANYON
            /// GMC SIERRA
            /// GMC TRUCK RANGE
            /// GMC ACADIA
            /// GMC TERRAIN
            /// GMC YUKON
            /// HOLDEN CLUBSPORT
            /// HOLDEN CORPORATE 
            /// HOLDEN GEN-F
            /// HOLDEN VEHICLE RANGE
            /// HOLDEN COLORADO
            /// HOLDEN COMMODORE UTE P/U
            /// HOLDEN APOLLO
            /// HOLDEN ASTRA
            /// HOLDEN BARINA
            /// HOLDEN BARINA SPARK
            /// HOLDEN CAR RANGE
            /// HOLDEN CASCADA
            /// HOLDEN COMMODORE
            /// HOLDEN CRUZE
            /// HOLDEN INSIGNIA
            /// HOLDEN CAPTIVA
            /// HOLDEN SUV RANGE
            /// HOLDEN TRAILBLAZER
            /// HOLDEN TRAX
            /// OPEL/VAUXHALL CORPORATE
            /// OPEL/VAUXHALL VEHICLE RANGE
            /// OPEL/VAUXHALL COMBO
            /// OPEL/VAUXHALL CORSA COMBO PBV
            /// OPEL/VAUXHALL MOVANO
            /// OPEL/VAUXHALL TRUCK RANGE
            /// OPEL/VAUXHALL MERIVA
            /// OPEL/VAUXHALL VIVARO
            /// OPEL/VAUXHALL ZAFIRA
            /// OPEL/VAUXHALL ADAM
            /// OPEL/VAUXHALL AMPERA
            /// OPEL/VAUXHALL ASTRA
            /// OPEL/VAUXHALL CAR RANGE
            /// OPEL/VAUXHALL CASCADA
            /// OPEL/VAUXHALL CORSA
            /// OPEL/VAUXHALL GT
            /// OPEL/VAUXHALL INSIGNIA
            /// OPEL/VAUXHALL KARL
            /// OPEL/VAUXHALL VIVA
            /// OPEL/VAUXHALL ANTARA
            /// OPEL/VAUXHALL MOKKA
            /// OPEL/VAUXHALL MOKKA X
            /// WULING VEHICLE RANGE


            /// Business & Technology General Promotion
            /// Publishing & Media General Promotion
            /// Computers & Software General Promotion
            /// Computer Components &Accessories, General Promotion/ Multi - Category / Corporate / Sponsorship
            /// Computers, General Promotion/ Multi - Category / Corporate / Sponsorship
            /// Communications General Promotion
            /// Financial, General Promotion &Multi - Category

            /// Wage test
            //masterEntities = new List<WildSearchModel>();
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "PEUGEOT BOXER RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "VOLKSWAGEN PASSATRANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "VOLKSWAGEN TIGUANRANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "REKLAMA FIRMYRANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "VOLKSWAGEN GOLFRANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "FORD FOCUS RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "DACIA SANDERO STEPWAY RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "LEXUS NX RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL MOKKA RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HYUNDAI GENESIS RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HONDA ACCORD RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "TOYOTA YARIS RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL CORSA RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "FORD MONDEO RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "DACIA DOKKER VAN RANGE CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW X1 SPORT UTIL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW X3 SPORT UTIL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "BMW X6 SPORT UTIL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "AUDI Q3 SPORT UTIL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL G SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "RENAULT G SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "NISSAN G SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SKODA FABIA SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "SKODA G SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HYUNDAI G SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "FORD TRANSIT COURIER SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "FORD KUGA SMALL CR" });
            //masterEntities.Add(new WildSearchModel() { Id = 1, Name = "HYUNDAI iX 3X SMALL CR" });




















            newEntities = new List<WildSearchModel>();

            newEntities.Add(new WildSearchModel() { Id = 9, Name = "11" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "January" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "States of America" });

            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Jan" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Feb" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Mar" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Apr" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "May" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Jun" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Jul" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Aug" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Sep" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Oct" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Nov" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Dec" });

            newEntities.Add(new WildSearchModel() { Id = 9, Name = "BAOJUN CORP" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "NEWSPAPER" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "DESKTOP" });

            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Republic" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "MAl" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Mal" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "New" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "South Korea" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Russia" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "United Arab Emirate" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "In" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "Ind" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "BRA" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "USA" });

            newEntities.Add(new WildSearchModel() { Id = 9, Name = "AUDI R8+R" });
            newEntities.Add(new WildSearchModel() { Id = 9, Name = "AUDI R8" });












            //newEntities = new List<WildSearchModel>();
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "GILY" });
            //newEntities.Add(new WildSearchModel() { Id = 2, Name = "MARUTI+KUZUKI" });
            //newEntities.Add(new WildSearchModel() { Id = 3, Name = "HYUNDAI+SUZUKI" });
            //newEntities.Add(new WildSearchModel() { Id = 4, Name = "HONDA" });
            //newEntities.Add(new WildSearchModel() { Id = 5, Name = "HONDA PORTUGAL SA" });
            //newEntities.Add(new WildSearchModel() { Id = 6, Name = "M 6 COUPE" });
            //newEntities.Add(new WildSearchModel() { Id = 7, Name = "Media General Promotion" });
            //newEntities.Add(new WildSearchModel() { Id = 8, Name = "A" });
            //newEntities.Add(new WildSearchModel() { Id = 9, Name = "1" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "MASTERCARD" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "Gazprombank Travel" });
            //newEntities.Add(new WildSearchModel() { Id = 8, Name = "CHEVROLET VOLT" });
            //newEntities.Add(new WildSearchModel() { Id = 8, Name = "CHEVROLET CORVETTE STINGRAY" });

            //newEntities = new List<WildSearchModel>();
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL G SMALL CR" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "DACIA DUSTER, SUV SPORT UTIL CR" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "OPEL ANTARA, SUV SPORT UTIL CR" });


            ///// Wage test
            //newEntities = new List<WildSearchModel>();
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "KIA SORENTO, SUV" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "NISSAN GT-R" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "NISSAN QASHQAI, SUV" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "SUZUKI VITARA, SUV" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "VOLKSWAGEN TOUAREG, SUV" });
            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "PEUGEOT, used car" });



            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "M" });
            //newEntities.Add(new WildSearchModel() { Id = 2, Name = "Ma" });
            //newEntities.Add(new WildSearchModel() { Id = 3, Name = "3-1-2016" });


            //newEntities.Add(new WildSearchModel() { Id = 1, Name = "SBERBANK OF RUSSIA; SBERBANK OF RUSSIA SBERBANK PERVY" });
            //newEntities.Add(new WildSearchModel() { Id = 2, Name = "AMUR TIGER(CENTRE); PEREKRESTOK(CHAIN OF SHOPS); RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK AMURSKIY TIGR" });
            //newEntities.Add(new WildSearchModel() { Id = 3, Name = "36,6 DRUGSTORE; AMUR TIGER (CENTRE); GORZDRAV; RUSSIAN AGRICULTURAL BANK; RUSSIAN AGRICULTURAL BANK AMURSKIY TIGR" });
            //newEntities.Add(new WildSearchModel() { Id = 4, Name = "SBERBANK OF RUSSIA; SBERBANK OF RUSSIA SBERBANK ONL @YN" });
            //newEntities.Add(new WildSearchModel() { Id = 5, Name = "PETERSBURG FUEL COMPANY; PETERSBURG FUEL COMPANY AVTOPOZITIV; SBERBANK OF RUSSIA; SBERBANK OF RUSSIA SBERBANK ONL @YN" });
            //newEntities.Add(new WildSearchModel() { Id = 6, Name = "ALFA - BANK; ALFA BANK ALFA - BIZNES ONLINE; ALFA BUSINESS WEEK" });
            //newEntities.Add(new WildSearchModel() { Id = 7, Name = "SBERBANK OF RUSSIA; SBERBANK OF RUSSIA SBERBANK ONL @YN" });
            //newEntities.Add(new WildSearchModel() { Id = 8, Name = "SBERBANK OF RUSSIA; SBERBANK OF RUSSIA AVTOPLATEZH; SBERBANK OF RUSSIA SBERBANK ONL @YN" });
            //newEntities.Add(new WildSearchModel() { Id = 9, Name = "VTB BANK OF MOSCOW; VTB BANK OF MOSCOW START" });
            //newEntities.Add(new WildSearchModel() { Id = 0, Name = "PETROL PLUS SPRINTER; PETROL PLUS TRANZIT CARD; PETROL PLUS VEZDEKHOD" });

        }

        #endregion
    }
}

