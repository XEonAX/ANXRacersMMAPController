
namespace ANXRacersMMAPController
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pollTimer = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.dgvGame = new System.Windows.Forms.DataGridView();
            this.PropName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShipPhysics = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvShipState = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sliderTurn = new System.Windows.Forms.TrackBar();
            this.sliderThrust = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetRace = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvTrackState = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipPhysics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderThrust)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // pollTimer
            // 
            this.pollTimer.Interval = 10;
            this.pollTimer.Tick += new System.EventHandler(this.pollTimer_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(10, 9);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(82, 22);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // dgvGame
            // 
            this.dgvGame.AllowUserToAddRows = false;
            this.dgvGame.AllowUserToDeleteRows = false;
            this.dgvGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropName,
            this.PropValue});
            this.dgvGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGame.Location = new System.Drawing.Point(3, 18);
            this.dgvGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGame.Name = "dgvGame";
            this.dgvGame.ReadOnly = true;
            this.dgvGame.RowHeadersVisible = false;
            this.dgvGame.RowHeadersWidth = 51;
            this.dgvGame.RowTemplate.Height = 29;
            this.dgvGame.Size = new System.Drawing.Size(267, 178);
            this.dgvGame.TabIndex = 1;
            // 
            // PropName
            // 
            this.PropName.DataPropertyName = "PropName";
            this.PropName.HeaderText = "Name";
            this.PropName.MinimumWidth = 6;
            this.PropName.Name = "PropName";
            this.PropName.ReadOnly = true;
            this.PropName.Width = 125;
            // 
            // PropValue
            // 
            this.PropValue.DataPropertyName = "PropValue";
            this.PropValue.HeaderText = "Value";
            this.PropValue.MinimumWidth = 6;
            this.PropValue.Name = "PropValue";
            this.PropValue.ReadOnly = true;
            this.PropValue.Width = 125;
            // 
            // dgvShipPhysics
            // 
            this.dgvShipPhysics.AllowUserToAddRows = false;
            this.dgvShipPhysics.AllowUserToDeleteRows = false;
            this.dgvShipPhysics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipPhysics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvShipPhysics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShipPhysics.Location = new System.Drawing.Point(3, 19);
            this.dgvShipPhysics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShipPhysics.Name = "dgvShipPhysics";
            this.dgvShipPhysics.ReadOnly = true;
            this.dgvShipPhysics.RowHeadersVisible = false;
            this.dgvShipPhysics.RowHeadersWidth = 51;
            this.dgvShipPhysics.RowTemplate.Height = 29;
            this.dgvShipPhysics.Size = new System.Drawing.Size(263, 332);
            this.dgvShipPhysics.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PropName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PropValue";
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dgvShipState
            // 
            this.dgvShipState.AllowUserToAddRows = false;
            this.dgvShipState.AllowUserToDeleteRows = false;
            this.dgvShipState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShipState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvShipState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShipState.Location = new System.Drawing.Point(3, 19);
            this.dgvShipState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShipState.Name = "dgvShipState";
            this.dgvShipState.ReadOnly = true;
            this.dgvShipState.RowHeadersVisible = false;
            this.dgvShipState.RowHeadersWidth = 51;
            this.dgvShipState.RowTemplate.Height = 29;
            this.dgvShipState.Size = new System.Drawing.Size(267, 157);
            this.dgvShipState.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PropName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PropValue";
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // sliderTurn
            // 
            this.sliderTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderTurn.LargeChange = 10;
            this.sliderTurn.Location = new System.Drawing.Point(3, 18);
            this.sliderTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sliderTurn.Minimum = -10;
            this.sliderTurn.Name = "sliderTurn";
            this.sliderTurn.Size = new System.Drawing.Size(107, 78);
            this.sliderTurn.SmallChange = 10;
            this.sliderTurn.TabIndex = 4;
            this.sliderTurn.TickFrequency = 5;
            // 
            // sliderThrust
            // 
            this.sliderThrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderThrust.LargeChange = 10;
            this.sliderThrust.Location = new System.Drawing.Point(3, 18);
            this.sliderThrust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sliderThrust.Minimum = -10;
            this.sliderThrust.Name = "sliderThrust";
            this.sliderThrust.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderThrust.Size = new System.Drawing.Size(110, 78);
            this.sliderThrust.SmallChange = 10;
            this.sliderThrust.TabIndex = 5;
            this.sliderThrust.TickFrequency = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnResetRace);
            this.groupBox1.Location = new System.Drawing.Point(107, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(272, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sliderThrust);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(153, 40);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(116, 98);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Surge Thrusters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sliderTurn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(113, 98);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turn Thrusters";
            // 
            // btnResetRace
            // 
            this.btnResetRace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetRace.Location = new System.Drawing.Point(3, 18);
            this.btnResetRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetRace.Name = "btnResetRace";
            this.btnResetRace.Size = new System.Drawing.Size(266, 22);
            this.btnResetRace.TabIndex = 6;
            this.btnResetRace.Text = "Reset Race";
            this.btnResetRace.UseVisualStyleBackColor = true;
            this.btnResetRace.Click += new System.EventHandler(this.btnResetRace_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvGame);
            this.groupBox4.Location = new System.Drawing.Point(384, 9);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(273, 198);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game State";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvShipPhysics);
            this.groupBox5.Location = new System.Drawing.Point(663, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 354);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Spaceship Physics";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvShipState);
            this.groupBox6.Location = new System.Drawing.Point(387, 212);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 179);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Spaceship State";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvTrackState);
            this.groupBox7.Location = new System.Drawing.Point(106, 164);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 179);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Track State";
            // 
            // dgvTrackState
            // 
            this.dgvTrackState.AllowUserToAddRows = false;
            this.dgvTrackState.AllowUserToDeleteRows = false;
            this.dgvTrackState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvTrackState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrackState.Location = new System.Drawing.Point(3, 19);
            this.dgvTrackState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrackState.Name = "dgvTrackState";
            this.dgvTrackState.ReadOnly = true;
            this.dgvTrackState.RowHeadersVisible = false;
            this.dgvTrackState.RowHeadersWidth = 51;
            this.dgvTrackState.RowTemplate.Height = 29;
            this.dgvTrackState.Size = new System.Drawing.Size(267, 157);
            this.dgvTrackState.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PropName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PropValue";
            this.dataGridViewTextBoxColumn6.HeaderText = "Value";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dgvSensors
            // 
            this.dgvSensors.AllowUserToAddRows = false;
            this.dgvSensors.AllowUserToDeleteRows = false;
            this.dgvSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Location = new System.Drawing.Point(0, 393);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.ReadOnly = true;
            this.dgvSensors.RowHeadersVisible = false;
            this.dgvSensors.RowTemplate.Height = 25;
            this.dgvSensors.Size = new System.Drawing.Size(1018, 210);
            this.dgvSensors.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 603);
            this.Controls.Add(this.dgvSensors);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ANXRacers Memory Control";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipPhysics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderThrust)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer pollTimer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridView dgvGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropValue;
        private System.Windows.Forms.DataGridView dgvShipPhysics;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvShipState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TrackBar sliderTurn;
        private System.Windows.Forms.TrackBar sliderThrust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetRace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvTrackState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dgvSensors;
    }
}

