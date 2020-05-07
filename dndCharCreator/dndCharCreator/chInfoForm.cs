/*
 * Created by SharpDevelop.
 * User: Dorian
 * Date: 14.7.2019.
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dndCharCreator
{
	/// <summary>
	/// Description of chInfoForm.
	/// </summary>
	public partial class chInfoForm : Form
	{
		
 		string[] algns = {"Lawful Good", "Neutral Good", "Chaotic Good",
								"Lawful Neutral", "True Neutral", "Chaotic Neutral",
								"Lawful Evil", "Neutral Evil", "Chaotic Evil"};
			
		string[] chclasses = {"Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk",
								"Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard"};
			
		string[] races = {"Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Halfling",
								"Half-Orc", "Human", "Tiefling"};
			
		string[] bckgnds = {"Acolyte", "Criminal", "Folk Hero", "Noble", "Sage", "Soldier"};
		
		public chInfoForm()
		{
			InitializeComponent();
								
			
			foreach (string algn in algns){
				comboBoxChAlgn.Items.Add(algn);
			}
			
			foreach (string chclass in chclasses){
				comboBoxChClass.Items.Add(chclass);
			}
			
			foreach (string race in races){
				comboBoxChRace.Items.Add(race);
			}
			
			foreach (string bkgn in bckgnds){
				comboBoxChBkgn.Items.Add(bkgn);
			}

			
		}
		void ButtonChInfoConfClick(object sender, EventArgs e)
		{
			int nmUD = (int)numericUpDownChLvl.Value;
			bool iCheck;
			
			if(nmUD == 0){
				nmUD = 1;
			}

			((MainForm)this.Owner).chInfo[0] = textBoxChName.Text;
			((MainForm)this.Owner).chInfo[1] = nmUD.ToString();
			((MainForm)this.Owner).chInfo[2] = comboBoxChRace.Text;
			((MainForm)this.Owner).chInfo[3] = comboBoxChClass.Text;
			((MainForm)this.Owner).chInfo[4] = comboBoxChAlgn.Text;
			((MainForm)this.Owner).chInfo[5] = comboBoxChBkgn.Text;
			
			iCheck = infoChecker(((MainForm)this.Owner).chInfo);
			
			if(iCheck){
				((MainForm)this.Owner).infoDisplayer();
				this.Close();
			}
		}
		
		bool infoChecker(string[] info){
			
			string errorMsg = "Please choose appropriate values for the following:";
			int i = 0;
			bool ch = true;
			
			//race
			
			foreach (string race in races){
				if (info[2] == race){
					break;
				}
				i++;
			}
			
			if(i != races.Length){
				i = 0;
			}
			else{
				errorMsg = errorMsg + "\n\nRace";
				i = 0;
				ch = false;
			}
			
			//class
			
			foreach (string clss in chclasses){
				if (info[3] == clss){
					break;
				}
				i++;
			}
			
			if(i != chclasses.Length){
				i = 0;
			}
			else{
				errorMsg = errorMsg + "\n\nClass";
				i = 0;
				ch = false;
			}
			
			//algn
			
			foreach (string algn in algns){
				if (info[4] == algn){
					break;
				}
				i++;
			}
			
			if(i != algns.Length){
				i = 0;
			}
			else{
				errorMsg = errorMsg + "\n\nAlignment";
				i = 0;
				ch = false;
			}
			
			//bkgn
			
			
			foreach (string bn in bckgnds){
				if (info[5] == bn){
					break;
				}
				i++;
			}
			
			if(i != bckgnds.Length){
				i = 0;
			}
			else{
				errorMsg = errorMsg + "\n\nBackground";
				i = 0;
				ch = false;
			}
			
			//return
			
			if(!ch){
				MessageBox.Show(errorMsg);
			}
			
			return ch;
			
		}
		
	}
}
