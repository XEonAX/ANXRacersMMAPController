using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.IO.MemoryMappedFiles;
using System.Diagnostics;
using System.Numerics;

namespace ANXRacersMMAPController
{
    class GameConnector
    {

        public string MapName = "ANXRacersGymInterface";
        private MemoryMappedFile memoryMappedFile;
        private MemoryMappedViewAccessor A0;
        private MemoryMappedViewAccessor A512;
        public bool IsConnected = false;
        private int resetCount;
        private MMAPRep Data = new MMAPRep();

        public bool Connect()
        {
            Data.Sensors = new MMRayInfo[24 * 5];
            try
            {
                memoryMappedFile = MemoryMappedFile.CreateOrOpen(MapName, 10000);
                A0 = memoryMappedFile.CreateViewAccessor(0, 512, MemoryMappedFileAccess.ReadWrite);
                var mapNameBytes = new byte[100];
                A0.ReadArray(0, mapNameBytes, 0, 100);
                Debug.WriteLine("Connected to " + Encoding.UTF8.GetString(mapNameBytes));
                A512 = memoryMappedFile.CreateViewAccessor(512, 9000, MemoryMappedFileAccess.Read);
                IsConnected = true;
                resetCount = A0.ReadInt32(418);
                return IsConnected;
            }
            catch (Exception ex)
            {
                IsConnected = false;
                Debug.Write("Cannot telemeter");
                return IsConnected;
            }
        }

        public MMAPRep ReadData()
        {
            if (IsConnected)
            {
                var mmap = new MMAPRep();
                mmap.UpdateNumber = A512.ReadInt32(0);

                A0.Read<MMLevel>(116, out mmap.Level);

                A0.Read(216, out mmap.ShipPhysics);

                mmap.GameState = (MMGameStates)A0.ReadInt32(400);

                A512.Read(8, out mmap.SpaceshipState);
                A512.Read(560 - 512, out mmap.TrackState);
                mmap.Sensors = new MMRayInfo[24 * 5];
                A512.ReadArray(600 - 512, mmap.Sensors, 0, 24 * 5);

                if (mmap.UpdateNumber == A512.ReadInt32(0))
                {
                    Data = mmap;
                }
            }
            return Data;
        }

        internal void SendInputs(Vector2 inputs)
        {
            if (IsConnected)
            {
                A0.Write(410, ref inputs);
                A0.Write(418, resetCount);
            }
        }

        internal void ResetRace()
        {
            resetCount++;
        }
    }
}
