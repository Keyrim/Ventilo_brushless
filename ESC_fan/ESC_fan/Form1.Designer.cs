namespace ESC_fan
{
    partial class Esc_fan
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.numericUpDown_port_number = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_connexion = new System.Windows.Forms.Button();
            this.numericUpDown_esc_value = new System.Windows.Forms.NumericUpDown();
            this.label_esc_value = new System.Windows.Forms.Label();
            this.button_send_value = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_esc_value)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_port_number
            // 
            this.numericUpDown_port_number.Location = new System.Drawing.Point(107, 51);
            this.numericUpDown_port_number.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_port_number.Name = "numericUpDown_port_number";
            this.numericUpDown_port_number.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_port_number.TabIndex = 0;
            this.numericUpDown_port_number.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_port_number.ValueChanged += new System.EventHandler(this.NumericUpDown_port_number_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arduino port number";
            // 
            // button_connexion
            // 
            this.button_connexion.Location = new System.Drawing.Point(36, 48);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(65, 23);
            this.button_connexion.TabIndex = 2;
            this.button_connexion.Text = "Conexion";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.Button_connexion_Click);
            // 
            // numericUpDown_esc_value
            // 
            this.numericUpDown_esc_value.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_esc_value.Location = new System.Drawing.Point(39, 96);
            this.numericUpDown_esc_value.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDown_esc_value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_esc_value.Name = "numericUpDown_esc_value";
            this.numericUpDown_esc_value.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_esc_value.TabIndex = 3;
            this.numericUpDown_esc_value.Value = new decimal(new int[] {
            1060,
            0,
            0,
            0});
            // 
            // label_esc_value
            // 
            this.label_esc_value.AutoSize = true;
            this.label_esc_value.Location = new System.Drawing.Point(36, 80);
            this.label_esc_value.Name = "label_esc_value";
            this.label_esc_value.Size = new System.Drawing.Size(55, 13);
            this.label_esc_value.TabIndex = 4;
            this.label_esc_value.Text = "Value Esc";
            // 
            // button_send_value
            // 
            this.button_send_value.Location = new System.Drawing.Point(39, 122);
            this.button_send_value.Name = "button_send_value";
            this.button_send_value.Size = new System.Drawing.Size(75, 23);
            this.button_send_value.TabIndex = 5;
            this.button_send_value.Text = "Send Value";
            this.button_send_value.UseVisualStyleBackColor = true;
            this.button_send_value.Click += new System.EventHandler(this.Button_send_value_Click);
            // 
            // Esc_fan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_send_value);
            this.Controls.Add(this.label_esc_value);
            this.Controls.Add(this.numericUpDown_esc_value);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_port_number);
            this.Name = "Esc_fan";
            this.Text = "Esc_fan_keyrim";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_port_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_esc_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.NumericUpDown numericUpDown_port_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.NumericUpDown numericUpDown_esc_value;
        private System.Windows.Forms.Label label_esc_value;
        private System.Windows.Forms.Button button_send_value;
    }
}

