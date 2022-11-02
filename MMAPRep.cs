using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ANXRacersMMAPController
{

    /// <summary>
    /// 0-100 (Unicode) MemoryMapName = "ANXRacersGymInterface"
    /// 100-200 (Object) Level
    ///     100-116 (Guid) LevelId
    ///     116-120 (int) Number of Checkpoints
    ///     120-124 (int) Laps
    ///     124-128 (float) Difficulty
    ///     128- (Unicode) LevelName
    /// 200-300 (Object) Spaceship Physics
    ///     200-216 (Guid) LevelId
    ///     216-220 (float) Mass         
    ///     220-224 (float) LDrag        
    ///     224-228 (float) ADrag        
    ///     228-232 (float) SurgeForward 
    ///     232-236 (float) SurgeBackward
    ///     236-240 (float) Strafe       
    ///     240-244 (float) Torque       
    ///     244-248 (float) Radius       
    ///     248-252 (float) Friction     
    ///     252-256 (float) Bounce  
    ///     256- (Unicode) ShipName     
    /// 300-400 (Object) Player
    ///     300-316 (Guid) UserId
    ///     316- (Unicode) DisplayName
    /// 400-404 (int) GameState
    /// 404-410 Empty
    /// 410-418 (Vector2) Spaceship Inputs
    ///     410-414 (float) Y Surge +1.0 -1.0
    ///     414-418 (float) Z Turn +1.0 -1.0
    /// 418-422 (int) Reset Input    
    /// 422-426 (int) Giveup Input    
    /// 426-512 Empty
    /// 512-516 (int) UpdateNumber
    /// 520-556 (Object) Spaceship State Live
    ///     520-528 (Vector2) Spaceship Position
    ///         520-524 (float) X Position
    ///         524-528 (float) Y Position
    ///     528-536 (Vector2) Spaceship Rotation
    ///         528-532 (float) Z Rotation
    ///         532-536 (float) W Rotation
    ///     536-544 (Vector3) Spaceship Rigidbody
    ///         536-540 (float) X Velocity
    ///         540-544 (float) Y Velocity
    ///         544-548 (float) Z Angular Velocity
    ///     548-556 (Vector3) Spaceship Inputs
    ///         548-552 (float) Y Surge +1.0 -1.0
    ///         552-556 (float) Z Turn +1.0 -1.0
    /// 556-560 Empty    
    /// 560-580 (Object) Track State Live
    ///     560-568 (Vector2) Rel Position
    ///         560-564 (float) X Position
    ///         564-568 (float) Y Position
    ///     568-576 (Vector2) Rotation
    ///         568-572 (float) Z Rotation
    ///         572-576 (float) W Rotation
    ///     576-580 (int) Checkpoint Index
    /// 600 (Array * 24 * 5) Sensor Info Live
    ///     0 (bool) Hit
    ///     1 (bool) IsObstacle
    ///     2 (bool) IsProp
    ///     3 (bool) IsTrack
    ///     4-8 (int) ObjType
    ///     8-12 (float) Distance
    ///     12-20 (Vector2) Rotation
    ///         12-16 (float) Z Rotation
    ///         16-20 (float) W Rotation
    /// </summary>
    /// 


    public struct MMAPRep
    {
        public int UpdateNumber;
        public byte[] LevelIdBytes;
        public MMLevel Level;
        public byte[] LevelNameBytes;


        public byte[] ShipIdBytes;
        public MMShipPhysics ShipPhysics;
        public byte[] ShipNameBytes;

        public byte[] UserIdBytes;
        public byte[] UserNameBytes;

        public MMGameStates GameState;

        public MMInputs Inputs;

        public MMSpaceshipLiveState SpaceshipState;

        public MMTrackState TrackState;

        public MMRayInfo[] Sensors;
    }


    public struct MMRayInfo
    {
        public bool Hit;
        public bool IsObstacle;
        public bool IsProp;
        public bool IsTrack;
        public int Type;
        public float Distance;
        public Vector2 Rotation;//Euler Z, we store Quaternion Z, W as normalized
    }

    public struct MMSpaceshipLiveState
    {
        public Vector2 Position;
        public Vector2 Rotation;//Euler Z, we store Quaternion Z, W as normalized
        public Vector3 Rigidbody;
        public Vector2 Input;
        //ensure sizeOfSpaceshipState is updated when this struct is modified
    }

    public struct MMLevel
    {
        public int Checkpoints;
        public int Laps;
        public float Difficulty;

    }

    public struct MMTrackState
    {
        public Vector2 RelPosition;
        public Vector2 Rotation;//Euler Z, we store Quaternion Z, W as normalized
        public int CheckpointIndex;
    }
    public struct MMInputs
    {
        public Vector2 Inputs;
        public int ResetCount;
        public int GiveupCount;
    }
    public struct MMShipPhysics
    {
        public float Mass;
        public float LDrag;
        public float ADrag;
        public float SurgeForward;
        public float SurgeBackward;
        public float Strafe;
        public float Torque;
        public float Radius;
        public float Friction;
        public float Bounce;

    }


    public enum MMGameStates
    {
        InMenu,
        InTracklist,
        InShipyard,
        RaceCountdown,
        Racing,
        RaceFinished,
    }

}
