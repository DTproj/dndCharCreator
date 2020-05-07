/*
 * Created by SharpDevelop.
 * User: Dorian
 * Date: 18.7.2019.
 * Time: 15:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dndCharCreator
{
	partial class statSwitchForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelStr;
		private System.Windows.Forms.Label labelDex;
		private System.Windows.Forms.Label labelCon;
		private System.Windows.Forms.Label labelInt;
		private System.Windows.Forms.Label labelWis;
		private System.Windows.Forms.Label labelCha;
		private System.Windows.Forms.Label labelStr2;
		private System.Windows.Forms.Label labelDex2;
		private System.Windows.Forms.Label labelCon2;
		private System.Windows.Forms.Label labelInt2;
		private System.Windows.Forms.Label labelWis2;
		private System.Windows.Forms.Label labelCha2;
		private System.Windows.Forms.Button buttonStrUp;
		private System.Windows.Forms.Button buttonStrDw;
		private System.Windows.Forms.Button buttonDexUp;
		private System.Windows.Forms.Button buttonConUp;
		private System.Windows.Forms.Button buttonIntUp;
		private System.Windows.Forms.Button buttonWisUp;
		private System.Windows.Forms.Button buttonChaUp;
		private System.Windows.Forms.Button buttonDexDw;
		private System.Windows.Forms.Button buttonConDw;
		private System.Windows.Forms.Button buttonIntDw;
		private System.Windows.Forms.Button buttonWisDw;
		private System.Windows.Forms.Button buttonChaDw;
		private System.Windows.Forms.Button buttonStSwConf;
		
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
			this.labelStr = new System.Windows.Forms.Label();
			this.labelDex = new System.Windows.Forms.Label();
			this.labelCon = new System.Windows.Forms.Label();
			this.labelInt = new System.Windows.Forms.Label();
			this.labelWis = new System.Windows.Forms.Label();
			this.labelCha = new System.Windows.Forms.Label();
			this.labelStr2 = new System.Windows.Forms.Label();
			this.labelDex2 = new System.Windows.Forms.Label();
			this.labelCon2 = new System.Windows.Forms.Label();
			this.labelInt2 = new System.Windows.Forms.Label();
			this.labelWis2 = new System.Windows.Forms.Label();
			this.labelCha2 = new System.Windows.Forms.Label();
			this.buttonStrUp = new System.Windows.Forms.Button();
			this.buttonStrDw = new System.Windows.Forms.Button();
			this.buttonDexUp = new System.Windows.Forms.Button();
			this.buttonConUp = new System.Windows.Forms.Button();
			this.buttonIntUp = new System.Windows.Forms.Button();
			this.buttonWisUp = new System.Windows.Forms.Button();
			this.buttonChaUp = new System.Windows.Forms.Button();
			this.buttonDexDw = new System.Windows.Forms.Button();
			this.buttonConDw = new System.Windows.Forms.Button();
			this.buttonIntDw = new System.Windows.Forms.Button();
			this.buttonWisDw = new System.Windows.Forms.Button();
			this.buttonChaDw = new System.Windows.Forms.Button();
			this.buttonStSwConf = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelStr
			// 
			this.labelStr.Location = new System.Drawing.Point(13, 13);
			this.labelStr.Name = "labelStr";
			this.labelStr.Size = new System.Drawing.Size(70, 40);
			this.labelStr.TabIndex = 0;
			this.labelStr.Text = "Strength:";
			this.labelStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDex
			// 
			this.labelDex.Location = new System.Drawing.Point(13, 67);
			this.labelDex.Name = "labelDex";
			this.labelDex.Size = new System.Drawing.Size(70, 40);
			this.labelDex.TabIndex = 1;
			this.labelDex.Text = "Dexterity:";
			this.labelDex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCon
			// 
			this.labelCon.Location = new System.Drawing.Point(13, 121);
			this.labelCon.Name = "labelCon";
			this.labelCon.Size = new System.Drawing.Size(70, 40);
			this.labelCon.TabIndex = 2;
			this.labelCon.Text = "Constitution:";
			this.labelCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelInt
			// 
			this.labelInt.Location = new System.Drawing.Point(13, 175);
			this.labelInt.Name = "labelInt";
			this.labelInt.Size = new System.Drawing.Size(70, 40);
			this.labelInt.TabIndex = 3;
			this.labelInt.Text = "Intelligence:";
			this.labelInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelWis
			// 
			this.labelWis.Location = new System.Drawing.Point(13, 229);
			this.labelWis.Name = "labelWis";
			this.labelWis.Size = new System.Drawing.Size(70, 40);
			this.labelWis.TabIndex = 4;
			this.labelWis.Text = "Wisdom";
			this.labelWis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCha
			// 
			this.labelCha.Location = new System.Drawing.Point(13, 283);
			this.labelCha.Name = "labelCha";
			this.labelCha.Size = new System.Drawing.Size(70, 40);
			this.labelCha.TabIndex = 5;
			this.labelCha.Text = "Charisma:";
			this.labelCha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelStr2
			// 
			this.labelStr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelStr2.Location = new System.Drawing.Point(90, 13);
			this.labelStr2.Name = "labelStr2";
			this.labelStr2.Size = new System.Drawing.Size(50, 40);
			this.labelStr2.TabIndex = 6;
			this.labelStr2.Text = "10";
			this.labelStr2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDex2
			// 
			this.labelDex2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelDex2.Location = new System.Drawing.Point(90, 67);
			this.labelDex2.Name = "labelDex2";
			this.labelDex2.Size = new System.Drawing.Size(50, 40);
			this.labelDex2.TabIndex = 7;
			this.labelDex2.Text = "10";
			this.labelDex2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCon2
			// 
			this.labelCon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelCon2.Location = new System.Drawing.Point(90, 121);
			this.labelCon2.Name = "labelCon2";
			this.labelCon2.Size = new System.Drawing.Size(50, 40);
			this.labelCon2.TabIndex = 8;
			this.labelCon2.Text = "10";
			this.labelCon2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelInt2
			// 
			this.labelInt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelInt2.Location = new System.Drawing.Point(90, 175);
			this.labelInt2.Name = "labelInt2";
			this.labelInt2.Size = new System.Drawing.Size(50, 40);
			this.labelInt2.TabIndex = 9;
			this.labelInt2.Text = "10";
			this.labelInt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelWis2
			// 
			this.labelWis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelWis2.Location = new System.Drawing.Point(90, 229);
			this.labelWis2.Name = "labelWis2";
			this.labelWis2.Size = new System.Drawing.Size(50, 40);
			this.labelWis2.TabIndex = 10;
			this.labelWis2.Text = "10";
			this.labelWis2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelCha2
			// 
			this.labelCha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelCha2.Location = new System.Drawing.Point(90, 283);
			this.labelCha2.Name = "labelCha2";
			this.labelCha2.Size = new System.Drawing.Size(50, 40);
			this.labelCha2.TabIndex = 11;
			this.labelCha2.Text = "10";
			this.labelCha2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonStrUp
			// 
			this.buttonStrUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonStrUp.Location = new System.Drawing.Point(147, 13);
			this.buttonStrUp.Name = "buttonStrUp";
			this.buttonStrUp.Size = new System.Drawing.Size(50, 40);
			this.buttonStrUp.TabIndex = 12;
			this.buttonStrUp.Text = "↑";
			this.buttonStrUp.UseVisualStyleBackColor = true;
			this.buttonStrUp.Click += new System.EventHandler(this.ButtonStrUpClick);
			// 
			// buttonStrDw
			// 
			this.buttonStrDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonStrDw.Location = new System.Drawing.Point(204, 13);
			this.buttonStrDw.Name = "buttonStrDw";
			this.buttonStrDw.Size = new System.Drawing.Size(50, 40);
			this.buttonStrDw.TabIndex = 13;
			this.buttonStrDw.Text = "↓";
			this.buttonStrDw.UseVisualStyleBackColor = true;
			this.buttonStrDw.Click += new System.EventHandler(this.ButtonStrDwClick);
			// 
			// buttonDexUp
			// 
			this.buttonDexUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonDexUp.Location = new System.Drawing.Point(147, 67);
			this.buttonDexUp.Name = "buttonDexUp";
			this.buttonDexUp.Size = new System.Drawing.Size(50, 40);
			this.buttonDexUp.TabIndex = 14;
			this.buttonDexUp.Text = "↑";
			this.buttonDexUp.UseVisualStyleBackColor = true;
			this.buttonDexUp.Click += new System.EventHandler(this.ButtonDexUpClick);
			// 
			// buttonConUp
			// 
			this.buttonConUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonConUp.Location = new System.Drawing.Point(147, 121);
			this.buttonConUp.Name = "buttonConUp";
			this.buttonConUp.Size = new System.Drawing.Size(50, 40);
			this.buttonConUp.TabIndex = 15;
			this.buttonConUp.Text = "↑";
			this.buttonConUp.UseVisualStyleBackColor = true;
			this.buttonConUp.Click += new System.EventHandler(this.ButtonConUpClick);
			// 
			// buttonIntUp
			// 
			this.buttonIntUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonIntUp.Location = new System.Drawing.Point(147, 175);
			this.buttonIntUp.Name = "buttonIntUp";
			this.buttonIntUp.Size = new System.Drawing.Size(50, 40);
			this.buttonIntUp.TabIndex = 16;
			this.buttonIntUp.Text = "↑";
			this.buttonIntUp.UseVisualStyleBackColor = true;
			this.buttonIntUp.Click += new System.EventHandler(this.ButtonIntUpClick);
			// 
			// buttonWisUp
			// 
			this.buttonWisUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonWisUp.Location = new System.Drawing.Point(147, 229);
			this.buttonWisUp.Name = "buttonWisUp";
			this.buttonWisUp.Size = new System.Drawing.Size(50, 40);
			this.buttonWisUp.TabIndex = 17;
			this.buttonWisUp.Text = "↑";
			this.buttonWisUp.UseVisualStyleBackColor = true;
			this.buttonWisUp.Click += new System.EventHandler(this.ButtonWisUpClick);
			// 
			// buttonChaUp
			// 
			this.buttonChaUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonChaUp.Location = new System.Drawing.Point(147, 283);
			this.buttonChaUp.Name = "buttonChaUp";
			this.buttonChaUp.Size = new System.Drawing.Size(50, 40);
			this.buttonChaUp.TabIndex = 18;
			this.buttonChaUp.Text = "↑";
			this.buttonChaUp.UseVisualStyleBackColor = true;
			this.buttonChaUp.Click += new System.EventHandler(this.ButtonChaUpClick);
			// 
			// buttonDexDw
			// 
			this.buttonDexDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonDexDw.Location = new System.Drawing.Point(204, 67);
			this.buttonDexDw.Name = "buttonDexDw";
			this.buttonDexDw.Size = new System.Drawing.Size(50, 40);
			this.buttonDexDw.TabIndex = 19;
			this.buttonDexDw.Text = "↓";
			this.buttonDexDw.UseVisualStyleBackColor = true;
			this.buttonDexDw.Click += new System.EventHandler(this.ButtonDexDwClick);
			// 
			// buttonConDw
			// 
			this.buttonConDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonConDw.Location = new System.Drawing.Point(204, 121);
			this.buttonConDw.Name = "buttonConDw";
			this.buttonConDw.Size = new System.Drawing.Size(50, 40);
			this.buttonConDw.TabIndex = 20;
			this.buttonConDw.Text = "↓";
			this.buttonConDw.UseVisualStyleBackColor = true;
			this.buttonConDw.Click += new System.EventHandler(this.ButtonConDwClick);
			// 
			// buttonIntDw
			// 
			this.buttonIntDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonIntDw.Location = new System.Drawing.Point(204, 175);
			this.buttonIntDw.Name = "buttonIntDw";
			this.buttonIntDw.Size = new System.Drawing.Size(50, 40);
			this.buttonIntDw.TabIndex = 21;
			this.buttonIntDw.Text = "↓";
			this.buttonIntDw.UseVisualStyleBackColor = true;
			this.buttonIntDw.Click += new System.EventHandler(this.ButtonIntDwClick);
			// 
			// buttonWisDw
			// 
			this.buttonWisDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonWisDw.Location = new System.Drawing.Point(204, 229);
			this.buttonWisDw.Name = "buttonWisDw";
			this.buttonWisDw.Size = new System.Drawing.Size(50, 40);
			this.buttonWisDw.TabIndex = 22;
			this.buttonWisDw.Text = "↓";
			this.buttonWisDw.UseVisualStyleBackColor = true;
			this.buttonWisDw.Click += new System.EventHandler(this.ButtonWisDwClick);
			// 
			// buttonChaDw
			// 
			this.buttonChaDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonChaDw.Location = new System.Drawing.Point(204, 283);
			this.buttonChaDw.Name = "buttonChaDw";
			this.buttonChaDw.Size = new System.Drawing.Size(50, 40);
			this.buttonChaDw.TabIndex = 23;
			this.buttonChaDw.Text = "↓";
			this.buttonChaDw.UseVisualStyleBackColor = true;
			this.buttonChaDw.Click += new System.EventHandler(this.ButtonChaDwClick);
			// 
			// buttonStSwConf
			// 
			this.buttonStSwConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonStSwConf.Location = new System.Drawing.Point(300, 13);
			this.buttonStSwConf.Name = "buttonStSwConf";
			this.buttonStSwConf.Size = new System.Drawing.Size(75, 23);
			this.buttonStSwConf.TabIndex = 24;
			this.buttonStSwConf.Text = "Confirm";
			this.buttonStSwConf.UseVisualStyleBackColor = true;
			this.buttonStSwConf.Click += new System.EventHandler(this.ButtonStSwConfClick);
			// 
			// statSwitchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 341);
			this.Controls.Add(this.buttonStSwConf);
			this.Controls.Add(this.buttonChaDw);
			this.Controls.Add(this.buttonWisDw);
			this.Controls.Add(this.buttonIntDw);
			this.Controls.Add(this.buttonConDw);
			this.Controls.Add(this.buttonDexDw);
			this.Controls.Add(this.buttonChaUp);
			this.Controls.Add(this.buttonWisUp);
			this.Controls.Add(this.buttonIntUp);
			this.Controls.Add(this.buttonConUp);
			this.Controls.Add(this.buttonDexUp);
			this.Controls.Add(this.buttonStrDw);
			this.Controls.Add(this.buttonStrUp);
			this.Controls.Add(this.labelCha2);
			this.Controls.Add(this.labelWis2);
			this.Controls.Add(this.labelInt2);
			this.Controls.Add(this.labelCon2);
			this.Controls.Add(this.labelDex2);
			this.Controls.Add(this.labelStr2);
			this.Controls.Add(this.labelCha);
			this.Controls.Add(this.labelWis);
			this.Controls.Add(this.labelInt);
			this.Controls.Add(this.labelCon);
			this.Controls.Add(this.labelDex);
			this.Controls.Add(this.labelStr);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Name = "statSwitchForm";
			this.Text = "statSwitchForm";
			this.ResumeLayout(false);

		}
	}
}
