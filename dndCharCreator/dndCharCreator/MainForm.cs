/*
 * Created by SharpDevelop.
 * User: Dorian
 * Date: 10.7.2019.
 * Time: 15:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dndCharCreator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string[] chInfo = new string[6];
		bool statsrolled;
		int[] rStats = new int[6];
		int[] numericMod = new int[6];
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		public void infoDisplayer(){
			
			labelChName2.Text = chInfo[0];
			labelChLvl2.Text = chInfo[1];
			labelChRace2.Text = chInfo[2];
			labelChClass2.Text = chInfo[3];
			labelChAlgn2.Text = chInfo[4];
			labelChBkgd2.Text = chInfo[5];
			
			hpAndDiceDisplayer(chInfo[3], chInfo[1]);
		}
		
		void hpAndDiceDisplayer(string chclss, string chLvl){
			
			int hpCalc = 0, i, chLvLtoNum;
			Random hpR = new Random();
			
			chLvLtoNum = Int32.Parse(chLvl);
			//System.Diagnostics.Debug.WriteLine(chLvLtoNum);
			
			if(chclss.Equals("Barbarian")){
				
				labelChHpDc2.Text = "1d12";
				for(i = 0; i < chLvLtoNum; i++){
					hpCalc = hpCalc + (int) hpR.Next(1, 13);
				}
				labelChHp2.Text = hpCalc.ToString();
			}
			
			else if(chclss.Equals("Fighter") || chclss.Equals("Ranger") || chclss.Equals("Paladin")){
				
				labelChHpDc2.Text = "1d10";
				for(i = 0; i < chLvLtoNum; i++){
					hpCalc = hpCalc + (int) hpR.Next(1, 11);
				}
				labelChHp2.Text = hpCalc.ToString();
			}
			
			else if(chclss.Equals("Cleric") || chclss.Equals("Druid") || chclss.Equals("Monk")
			       || chclss.Equals("Warlock") || chclss.Equals("Rogue") || chclss.Equals("Bard")){
				
				labelChHpDc2.Text = "1d8";
				for(i = 0; i < chLvLtoNum; i++){
					hpCalc = hpCalc + (int) hpR.Next(1, 9);
					//System.Diagnostics.Debug.WriteLine(hpCalc);
				}
				labelChHp2.Text = hpCalc.ToString();
			}
			
			else if(chclss.Equals("Wizard") || chclss.Equals("Sorcerer")){
				
				labelChHpDc2.Text = "1d6";
				for(i = 0; i < chLvLtoNum; i++){
					hpCalc = hpCalc + (int) hpR.Next(1, 7);
				}
				labelChHp2.Text = hpCalc.ToString();
			}

		}
		
		void ButtonStatRollClick(object sender, EventArgs e)
		{
			
			if(!statsrolled){
				
				
				int[] roll = new int[4];
				int[] min = {99, 99, 99, 99, 99, 99};
				int  i, j;
				Random r = new Random();
			
			
				for (i=0; i<6; i++){
					for(j=0; j < 4; j++){
						
						roll[j] = (int) r.Next(1, 7);
						//System.Diagnostics.Debug.WriteLine(roll[j]);
						if(roll[j] < min[i]){
							min[i] = roll[j];
						}
						rStats[i] = rStats[i] + roll[j];
					}
					rStats[i] = rStats[i] - min[i];
				}
			
				modDisplayer();
				
				statsrolled = true;
				buttonStatRoll.Text = "Switch Ability Scores";
			}
			else{
				
				var statSwF = new statSwitchForm();
				statSwF.Owner = this;
				statSwF.Show();
				statSwF.statLoader(rStats);
				
			}
		}
		
		void modDisplayer(){
			
			string[] mods = new string[6];
			int i;
			
			labelChStr2.Text = rStats[0].ToString();
			labelChDex2.Text = rStats[1].ToString();
			labelChCon2.Text = rStats[2].ToString();
			labelChInt2.Text = rStats[3].ToString();
			labelChWis2.Text = rStats[4].ToString();
			labelChCha2.Text = rStats[5].ToString();
			
			for(i=0; i<6; i++){
				
				if(rStats[i] == 1){
					numericMod[i] = -5;
				}
				
				else if(rStats[i] == 2 || rStats[i] == 3){
					numericMod[i] = -4;
				}
				
				else if(rStats[i] == 4 || rStats[i] == 5){
					numericMod[i] = -3;
				}
				
				else if(rStats[i] == 6 || rStats[i] == 7){
					numericMod[i] = -2;
				}
				
				else if(rStats[i] == 8 || rStats[i] == 9){
					numericMod[i] = -1;
				}
				
				else if(rStats[i] == 10 || rStats[i] == 11){
					numericMod[i] = 0;
				}
				
				else if(rStats[i] == 12 || rStats[i] == 13){
					numericMod[i] = 1;
				}
				
				else if(rStats[i] == 14 || rStats[i] == 15){
					numericMod[i] = 2;
				}
				
				else if(rStats[i] == 16 || rStats[i] == 17){
					numericMod[i] = 3;
				}
				
				else if(rStats[i] == 18 || rStats[i] == 19){
					numericMod[i] = 4;
				}
				
				else if(rStats[i] == 20 || rStats[i] == 21){
					numericMod[i] = 5;
				}
				
				else if(rStats[i] == 22 || rStats[i] == 23){
					numericMod[i] = 6;
				}
				
				else if(rStats[i] == 24 || rStats[i] == 25){
					numericMod[i] = 7;
				}
				
				else if(rStats[i] == 26 || rStats[i] == 27){
					numericMod[i] = 8;
				}
				
				else if(rStats[i] == 28 || rStats[i] == 29){
					numericMod[i] = 9;
				}
				
				else if(rStats[i] == 30){
					numericMod[i] = 10;
				}
			}
			
			for (i = 0; i < 6; i++) {
				
				if(numericMod[i] > 0){
					mods[i] = "+" + numericMod[i];
				}
				else{
					mods[i] = "" + numericMod[i];
				}
				
			}
			
			labelChStrMod.Text = mods[0];
			labelChDexMod.Text = mods[1];
			labelChConMod.Text = mods[2];
			labelChIntMod.Text = mods[3];
			labelChWisMod.Text = mods[4];
			labelChChaMod.Text = mods[5];
			
			skillDisplayer(mods);
			
		}
		
		void skillDisplayer(string[] mod){
			
			labelSkillsAcro2.Text = mod[1];
			labelSkillsAnHa2.Text = mod[4];
			labelSkillsArca2.Text = mod[3];
			labelSkillsAthl2.Text = mod[0];
			labelSkillsDecp2.Text = mod[4];
			labelSkillsHist2.Text = mod[3];
			labelSkillsInsg2.Text = mod[4];
			labelSkillsInti2.Text = mod[5];
			labelSkillsInvs2.Text = mod[3];
			labelSkillsMedi2.Text = mod[4];
			labelSkillsNatr2.Text = mod[3];
			labelSkillsPerf2.Text = mod[5];
			labelSkillsPers2.Text = mod[5];
			labelSkillsPrcp2.Text = mod[4];
			labelSkillsRelg2.Text = mod[4];
			labelSkillsSlOH2.Text = mod[1];
			labelSkillsSthl2.Text = mod[1];
			labelSkillsSurv2.Text = mod[4];
			
		}
		
		void ButtonEditChInfoClick(object sender, EventArgs e)
		{
			var chInfF = new chInfoForm();
			chInfF.Owner = this;
			chInfF.Show();
	
		}
		
		public void setStats(int[] stats){
			rStats = stats;
			modDisplayer();
		}
	}
}
