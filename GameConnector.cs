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
                memoryMappedFile = MemoryMappedFile.OpenExisting(MapName);
                A0 = memoryMappedFile.CreateViewAccessor(0, 512, MemoryMappedFileAccess.ReadWrite);//Work with first 512 Bytes. We need to be able to write to control the game.
                var mapNameBytes = new byte[100];
                A0.ReadArray(0, mapNameBytes, 0, 100);
                Debug.WriteLine("Connected to " + Encoding.UTF8.GetString(mapNameBytes));//First 100 bytes should have the "ANXRacersGymInterface" string
                A512 = memoryMappedFile.CreateViewAccessor(512, 9000, MemoryMappedFileAccess.Read);//Work with remaining bytes. Note we only want to read this.
                IsConnected = true;
                resetCount = A0.ReadInt32(418);//Reset count is stored at 418 offset. Check the MMAPRep file
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
                mmap.UpdateNumber = A512.ReadInt32(0);//Update Number at the start of Read Operation

                A0.Read<MMLevel>(116, out mmap.Level);

                A0.Read(216, out mmap.ShipPhysics);

                mmap.GameState = (MMGameStates)A0.ReadInt32(400);

                A512.Read(8, out mmap.SpaceshipState);//Reads Spaceships Real time State
                A512.Read(560 - 512, out mmap.CheckpointStatus);//Reads Next Checkpoint's Real time State
                mmap.Sensors = new MMRayInfo[24 * 5];
                A512.ReadArray(600 - 512, mmap.Sensors, 0, 24 * 5);//Reads info about 24/360° raycast sensors. Each provides upto 5 Hits

                if (mmap.UpdateNumber == A512.ReadInt32(0))//Update Number at the end of Read Operation should be same as at the start.
                {
                    Data = mmap;//Ensure we only read a sane copy
                }
            }
            return Data;
        }

        internal void SendInputs(Vector2 inputs)
        {
            if (IsConnected)
            {
                A0.Write(410, ref inputs);//Write Accel, Turn Inputs.
                A0.Write(418, resetCount);//Write reset count. if this is incremented value from previous. the race will reset
            }
        }

        internal void ResetRace()
        {
            resetCount++;
        }
    }
}
