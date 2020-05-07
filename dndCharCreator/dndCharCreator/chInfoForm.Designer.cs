/*
 * Created by SharpDevelop.
 * User: Dorian
 * Date: 14.7.2019.
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dndCharCreator
{
	partial class chInfoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelChInfoName;
		private System.Windows.Forms.TextBox textBoxChName;
		private System.Windows.Forms.Label labelChInfoLvl;
		private System.Windows.Forms.NumericUpDown numericUpDownChLvl;
		private System.Windows.Forms.Label labelChInfoRace;
		private System.Windows.Forms.ComboBox comboBoxChRace;
		private System.Windows.Forms.Label labelChInfoClass;
		private System.Windows.Forms.ComboBox comboBoxChClass;
		private System.Windows.Forms.Label labelChInfoAlgn;
		private System.Windows.Forms.ComboBox comboBoxChAlgn;
		private System.Windows.Forms.Label labelChInfoBckg;
		private System.Windows.Forms.ComboBox comboBoxChBkgn;
		private System.Windows.Forms.Button buttonChInfoConf;
		private System.Windows.Forms.Button buttonInfoOptions;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelChInfoName = new System.Windows.Forms.Label();
			this.textBoxChName = new System.Windows.Forms.TextBox();
			this.labelChInfoLvl = new System.Windows.Forms.Label();
			this.numericUpDownChLvl = new System.Windows.Forms.NumericUpDown();
			this.labelChInfoRace = new System.Windows.Forms.Label();
			this.comboBoxChRace = new System.Windows.Forms.ComboBox();
			this.labelChInfoClass = new System.Windows.Forms.Label();
			this.comboBoxChClass = new System.Windows.Forms.ComboBox();
			this.labelChInfoAlgn = new System.Windows.Forms.Label();
			this.comboBoxChAlgn = new System.Windows.Forms.ComboBox();
			this.labelChInfoBckg = new System.Windows.Forms.Label();
			this.comboBoxChBkgn = new System.Windows.Forms.ComboBox();
			this.buttonChInfoConf = new System.Windows.Forms.Button();
			this.buttonInfoOptions = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownChLvl)).BeginInit();
			this.SuspendLayout();
			// 
			// labelChInfoName
			// 
			this.labelChInfoName.Location = new System.Drawing.Point(13, 13);
			this.labelChInfoName.Name = "labelChInfoName";
			this.labelChInfoName.Size = new System.Drawing.Size(200, 23);
			this.labelChInfoName.TabIndex = 0;
			this.labelChInfoName.Text = "Name:";
			// 
			// textBoxChName
			// 
			this.textBoxChName.Location = new System.Drawing.Point(13, 40);
			this.textBoxChName.Name = "textBoxChName";
			this.textBoxChName.Size = new System.Drawing.Size(190, 20);
			this.textBoxChName.TabIndex = 1;
			// 
			// labelChInfoLvl
			// 
			this.labelChInfoLvl.Location = new System.Drawing.Point(13, 81);
			this.labelChInfoLvl.Name = "labelChInfoLvl";
			this.labelChInfoLvl.Size = new System.Drawing.Size(100, 23);
			this.labelChInfoLvl.TabIndex = 2;
			this.labelChInfoLvl.Text = "Level:";
			// 
			// numericUpDownChLvl
			// 
			this.numericUpDownChLvl.Location = new System.Drawing.Point(13, 108);
			this.numericUpDownChLvl.Name = "numericUpDownChLvl";
			this.numericUpDownChLvl.Size = new System.Drawing.Size(40, 20);
			this.numericUpDownChLvl.TabIndex = 3;
			this.numericUpDownChLvl.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// labelChInfoRace
			// 
			this.labelChInfoRace.Location = new System.Drawing.Point(220, 13);
			this.labelChInfoRace.Name = "labelChInfoRace";
			this.labelChInfoRace.Size = new System.Drawing.Size(160, 23);
			this.labelChInfoRace.TabIndex = 4;
			this.labelChInfoRace.Text = "Race:";
			// 
			// comboBoxChRace
			// 
			this.comboBoxChRace.FormattingEnabled = true;
			this.comboBoxChRace.Location = new System.Drawing.Point(220, 40);
			this.comboBoxChRace.Name = "comboBoxChRace";
			this.comboBoxChRace.Size = new System.Drawing.Size(140, 21);
			this.comboBoxChRace.TabIndex = 5;
			// 
			// labelChInfoClass
			// 
			this.labelChInfoClass.Location = new System.Drawing.Point(220, 81);
			this.labelChInfoClass.Name = "labelChInfoClass";
			this.labelChInfoClass.Size = new System.Drawing.Size(160, 23);
			this.labelChInfoClass.TabIndex = 6;
			this.labelChInfoClass.Text = "Class:";
			// 
			// comboBoxChClass
			// 
			this.comboBoxChClass.FormattingEnabled = true;
			this.comboBoxChClass.Location = new System.Drawing.Point(220, 107);
			this.comboBoxChClass.Name = "comboBoxChClass";
			this.comboBoxChClass.Size = new System.Drawing.Size(140, 21);
			this.comboBoxChClass.TabIndex = 7;
			// 
			// labelChInfoAlgn
			// 
			this.labelChInfoAlgn.Location = new System.Drawing.Point(387, 13);
			this.labelChInfoAlgn.Name = "labelChInfoAlgn";
			this.labelChInfoAlgn.Size = new System.Drawing.Size(100, 23);
			this.labelChInfoAlgn.TabIndex = 8;
			this.labelChInfoAlgn.Text = "Alignment:";
			// 
			// comboBoxChAlgn
			// 
			this.comboBoxChAlgn.FormattingEnabled = true;
			this.comboBoxChAlgn.Location = new System.Drawing.Point(387, 40);
			this.comboBoxChAlgn.Name = "comboBoxChAlgn";
			this.comboBoxChAlgn.Size = new System.Drawing.Size(180, 21);
			this.comboBoxChAlgn.TabIndex = 9;
			// 
			// labelChInfoBckg
			// 
			this.labelChInfoBckg.Location = new System.Drawing.Point(387, 81);
			this.labelChInfoBckg.Name = "labelChInfoBckg";
			this.labelChInfoBckg.Size = new System.Drawing.Size(100, 23);
			this.labelChInfoBckg.TabIndex = 10;
			this.labelChInfoBckg.Text = "Background:";
			// 
			// comboBoxChBkgn
			// 
			this.comboBoxChBkgn.FormattingEnabled = true;
			this.comboBoxChBkgn.Location = new System.Drawing.Point(387, 106);
			this.comboBoxChBkgn.Name = "comboBoxChBkgn";
			this.comboBoxChBkgn.Size = new System.Drawing.Size(180, 21);
			this.comboBoxChBkgn.TabIndex = 11;
			// 
			// buttonChInfoConf
			// 
			this.buttonChInfoConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonChInfoConf.Location = new System.Drawing.Point(12, 160);
			this.buttonChInfoConf.Name = "buttonChInfoConf";
			this.buttonChInfoConf.Size = new System.Drawing.Size(75, 23);
			this.buttonChInfoConf.TabIndex = 12;
			this.buttonChInfoConf.Text = "Confirm";
			this.buttonChInfoConf.UseVisualStyleBackColor = true;
			this.buttonChInfoConf.Click += new System.EventHandler(this.ButtonChInfoConfClick);
			// 
			// buttonInfoOptions
			// 
			this.buttonInfoOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonInfoOptions.Location = new System.Drawing.Point(93, 160);
			this.buttonInfoOptions.Name = "buttonInfoOptions";
			this.buttonInfoOptions.Size = new System.Drawing.Size(75, 23);
			this.buttonInfoOptions.TabIndex = 13;
			this.buttonInfoOptions.Text = "Options";
			this.buttonInfoOptions.UseVisualStyleBackColor = true;
			// 
			// chInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 201);
			this.Controls.Add(this.buttonInfoOptions);
			this.Controls.Add(this.buttonChInfoConf);
			this.Controls.Add(this.comboBoxChBkgn);
			this.Controls.Add(this.labelChInfoBckg);
			this.Controls.Add(this.comboBoxChAlgn);
			this.Controls.Add(this.labelChInfoAlgn);
			this.Controls.Add(this.comboBoxChClass);
			this.Controls.Add(this.labelChInfoClass);
			this.Controls.Add(this.comboBoxChRace);
			this.Controls.Add(this.labelChInfoRace);
			this.Controls.Add(this.numericUpDownChLvl);
			this.Controls.Add(this.labelChInfoLvl);
			this.Controls.Add(this.textBoxChName);
			this.Controls.Add(this.labelChInfoName);
			this.Name = "chInfoForm";
			this.Text = "chInfoForm";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownChLvl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
