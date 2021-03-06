﻿using System.Threading;

namespace Hydrology.DBManager.DB.SQLServer
{
    static class CDBMutex
    {
        public static Mutex Mutex_TB_Voltage = new Mutex();

        public static Mutex Mutex_TB_CurrentData = new Mutex();

        public static Mutex Mutex_TB_Rain = new Mutex();

        public static Mutex Mutex_TB_Water = new Mutex();

        public static Mutex Mutex_TB_SubCenter = new Mutex();

        public static Mutex Mutex_TB_SerialPort = new Mutex();

        public static Mutex Mutex_TB_StationMap = new Mutex();

        public static Mutex Mutex_TB_Station = new Mutex();

        public static Mutex Mutex_TB_WarningInfo = new Mutex();

        public static Mutex Mutex_TB_User = new Mutex();

        public static Mutex Mutex_TB_WaterFlowMap = new Mutex();

        public static Mutex Mutex_TB_CommunicationRage = new Mutex();

        public static Mutex Mutex_TB_SoilStationInfo = new Mutex();

        public static Mutex Mutex_TB_SoilStationData = new Mutex();

        public static Mutex Mutex_TB_Eva = new Mutex();

        public static Mutex Mutex_TB_HEva = new Mutex();

        public static Mutex Mutex_TB_DEva = new Mutex();

        public static Mutex Mutex_TB_RealEva = new Mutex();

        public static Mutex Mutex_TB_PWD = new Mutex();

        public static Mutex Mutex_TB_FSFX = new Mutex();

        public static Mutex Mutex_TB_OBS = new Mutex();
    }
}
