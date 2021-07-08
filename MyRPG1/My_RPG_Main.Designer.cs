
namespace MyRPG1
{
    partial class My_RPG_Main
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
            this.btnDebugButton = new System.Windows.Forms.Button();
            this.lblDEBUGPlayerStats = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDebugButton
            // 
            this.btnDebugButton.Location = new System.Drawing.Point(694, 409);
            this.btnDebugButton.Name = "btnDebugButton";
            this.btnDebugButton.Size = new System.Drawing.Size(94, 29);
            this.btnDebugButton.TabIndex = 1;
            this.btnDebugButton.Text = "Debug";
            this.btnDebugButton.UseVisualStyleBackColor = true;
            this.btnDebugButton.Click += new System.EventHandler(this.btnDebugButton_Click);
            // 
            // lblDEBUGPlayerStats
            // 
            this.lblDEBUGPlayerStats.AutoSize = true;
            this.lblDEBUGPlayerStats.Location = new System.Drawing.Point(12, 9);
            this.lblDEBUGPlayerStats.Name = "lblDEBUGPlayerStats";
            this.lblDEBUGPlayerStats.Size = new System.Drawing.Size(85, 20);
            this.lblDEBUGPlayerStats.TabIndex = 5;
            this.lblDEBUGPlayerStats.Text = "Player Stats";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(371, 11);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(94, 29);
            this.btnNorth.TabIndex = 6;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(278, 46);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(94, 29);
            this.btnWest.TabIndex = 7;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(463, 46);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(94, 29);
            this.btnEast.TabIndex = 8;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(371, 82);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(94, 29);
            this.btnSouth.TabIndex = 9;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(378, 46);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(78, 29);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnAttack1
            // 
            this.btnAttack1.Location = new System.Drawing.Point(594, 409);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(94, 29);
            this.btnAttack1.TabIndex = 11;
            this.btnAttack1.Text = "Attack";
            this.btnAttack1.UseVisualStyleBackColor = true;
            this.btnAttack1.Click += new System.EventHandler(this.btnAttack1_Click);
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Location = new System.Drawing.Point(12, 263);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(72, 20);
            this.lblPlayerHP.TabIndex = 12;
            this.lblPlayerHP.Text = "Player HP";
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.Location = new System.Drawing.Point(487, 263);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(76, 20);
            this.lblEnemyHP.TabIndex = 13;
            this.lblEnemyHP.Text = "Enemy HP";
            // 
            // My_RPG_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.lblPlayerHP);
            this.Controls.Add(this.btnAttack1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lblDEBUGPlayerStats);
            this.Controls.Add(this.btnDebugButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "My_RPG_Main";
            this.Text = "MyRPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDebugButton;
        private System.Windows.Forms.Label lblDEBUGPlayerStats;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnAttack1;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblEnemyHP;
    }
}

