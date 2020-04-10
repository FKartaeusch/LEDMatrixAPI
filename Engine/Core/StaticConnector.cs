using System;

namespace Engine.Core
{
    public sealed class StaticConnector : IMatrixConnector
    {
        private static StaticConnector instance;

        private StaticConnector()
        {
        }

        public static StaticConnector Instance
        {
            get
            {
                if (instance == null) instance = new StaticConnector();

                return instance;
            }
        }


        public void Connect()
        {
            try
            {
                // connect to led matrix
                // Log success?
            }
            catch
            {
                // Log error
                throw new Exception("Error connecting to the LED matrix");
            }
        }

        public void Disconnect()
        {
            try
            {
                // disconnect
            }
            catch
            {
                throw new Exception("Error while disconnecting the LED matrix");
            }
        }
    }
}