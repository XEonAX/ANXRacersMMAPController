using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
namespace ANXRacersMMAPController
{
    public partial class Form1 : Form
    {
        GameConnector connector = new GameConnector();

        private BindingSource bsGame = new BindingSource();
        private BindingSource bsShipPhysics = new BindingSource();
        private BindingSource bsShipState = new BindingSource();
        private BindingSource bsTrackState = new BindingSource();

        private BindingSource bsSensors = new BindingSource();

        public class KV
        {
            public string PropName { get; set; }
            public object PropValue { get; set; }
        }

        public class Sensor
        {
            public bool Hit { get; set; }
            public bool IsObstacle { get; set; }
            public bool IsProp { get; set; }
            public bool IsTrack { get; set; }
            public int Type { get; set; }
            public float Distance { get; set; }
            public Vector2 Rotation { get; set; }
            public Sensor(MMRayInfo mmrayInfo)
            {
                Hit = mmrayInfo.Hit;
                IsObstacle = mmrayInfo.IsObstacle;
                IsProp = mmrayInfo.IsProp;
                IsTrack = mmrayInfo.IsTrack;
                Type = mmrayInfo.Type;
                Distance = mmrayInfo.Distance;
                Rotation = mmrayInfo.Rotation;

            }
        }
        public Form1()
        {
            InitializeComponent();

            bsGame.Add(new KV { PropName = "GaneState", PropValue = MMGameStates.InMenu });
            bsGame.Add(new KV { PropName = "UpdateNumber", PropValue = 0 });
            bsGame.Add(new KV { PropName = "Checkpoints", PropValue = 0 });
            bsGame.Add(new KV { PropName = "Laps", PropValue = 0 });
            bsGame.Add(new KV { PropName = "Difficulty", PropValue = 0.5 });
            dgvGame.DataSource = bsGame;

            bsShipPhysics.Add(new KV { PropName = "Mass", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "LDrag", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "ADrag", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "SurgeForward", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "SurgeBackward", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "Strafe", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "Torque", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "Radius", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "Friction", PropValue = 0 });
            bsShipPhysics.Add(new KV { PropName = "Bounce", PropValue = 0 });
            dgvShipPhysics.DataSource = bsShipPhysics;

            bsShipState.Add(new KV { PropName = "Position", PropValue = Vector2.Zero });
            bsShipState.Add(new KV { PropName = "ShipRotation", PropValue = Vector2.Zero });
            bsShipState.Add(new KV { PropName = "Rigidbody", PropValue = Vector2.Zero });
            bsShipState.Add(new KV { PropName = "Input", PropValue = Vector2.Zero });

            dgvShipState.DataSource = bsShipState;



            bsTrackState.Add(new KV { PropName = "RelPosition", PropValue = Vector2.Zero });
            bsTrackState.Add(new KV { PropName = "CheckRotation", PropValue = Vector2.Zero });
            bsTrackState.Add(new KV { PropName = "CheckpointIndex", PropValue = 0 });

            dgvTrackState.DataSource = bsTrackState;

            bsSensors.Add(new Sensor(new MMRayInfo()));
            dgvSensors.DataSource = bsSensors;
        }

        private void pollTimer_Tick(object sender, EventArgs e)
        {
            Vector2 Inputs = new Vector2(sliderThrust.Value / 10f, sliderTurn.Value / 10f);
            connector.SendInputs(Inputs);
            var data = connector.ReadData();

            UpdateBS(dgvGame, bsGame, data);
            UpdateBS(dgvShipPhysics, bsShipPhysics, data);
            UpdateBS(dgvShipState, bsShipState, data);
            UpdateBS(dgvTrackState, bsTrackState, data);

            bsSensors.Clear();
            foreach (var sensor in data.Sensors)
            {
                bsSensors.Add(new Sensor(sensor));
            }
        }

        private void UpdateBS(DataGridView dgv, BindingSource bs, MMAPRep data)
        {
            foreach (KV item in bs)
            {
                switch (item.PropName)
                {
                    case "GaneState":
                        item.PropValue = data.GameState;
                        break;
                    case "UpdateNumber":
                        item.PropValue = data.UpdateNumber;
                        break;
                    case "Checkpoints":
                        item.PropValue = data.Level.Checkpoints;
                        break;
                    case "Laps":
                        item.PropValue = data.Level.Laps;
                        break;
                    case "Difficulty":
                        item.PropValue = data.Level.Difficulty;
                        break;



                    case "Mass": item.PropValue = data.ShipPhysics.Mass; break;
                    case "LDrag": item.PropValue = data.ShipPhysics.LDrag; break;
                    case "ADrag": item.PropValue = data.ShipPhysics.ADrag; break;
                    case "SurgeForward": item.PropValue = data.ShipPhysics.SurgeForward; break;
                    case "SurgeBackward": item.PropValue = data.ShipPhysics.SurgeBackward; break;
                    case "Strafe": item.PropValue = data.ShipPhysics.Strafe; break;
                    case "Torque": item.PropValue = data.ShipPhysics.Torque; break;
                    case "Radius": item.PropValue = data.ShipPhysics.Radius; break;
                    case "Friction": item.PropValue = data.ShipPhysics.Friction; break;
                    case "Bounce": item.PropValue = data.ShipPhysics.Bounce; break;

                    case "Position": item.PropValue = data.SpaceshipState.Position; break;
                    case "Rotation": item.PropValue = data.SpaceshipState.Rotation; break;
                    case "Rigidbody": item.PropValue = data.SpaceshipState.Rigidbody; break;
                    case "Input": item.PropValue = data.SpaceshipState.Input; break;

                    case "RelPosition": item.PropValue = data.TrackState.RelPosition; break;
                    case "CheckRotation": item.PropValue = data.TrackState.Rotation; break;
                    case "CheckpointIndex": item.PropValue = data.TrackState.CheckpointIndex; break;
                    


                    default:
                        break;
                }
            }
            bs.ResetBindings(false);
            //dgv.DataSource = null;
            //dgv.DataSource = bs;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            pollTimer.Enabled = connector.Connect();
            btnConnect.Enabled = !pollTimer.Enabled;
        }

        private void btnResetRace_Click(object sender, EventArgs e)
        {
            connector.ResetRace();
        }
    }
}
