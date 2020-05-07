/*
 * Created by SharpDevelop.
 * User: Dorian
 * Date: 18.7.2019.
 * Time: 15:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dndCharCreator
{
	/// <summary>
	/// Description of statSwitchForm.
	/// </summary>
	public partial class statSwitchForm : Form
	{
		int[] statsToSw = new int[6];
		int tempStat;
		
		public statSwitchForm()
		{
			InitializeComponent();
		}
		
		public void statLoader(int[] stats){
			statsToSw = stats;
			statDisplayer();
		}
		
		void statDisplayer(){
			
			labelStr2.Text = statsToSw[0].ToString();
			labelDex2.Text = statsToSw[1].ToString();
			labelCon2.Text = statsToSw[2].ToString();
			labelInt2.Text = statsToSw[3].ToString();
			labelWis2.Text = statsToSw[4].ToString();
			labelCha2.Text = statsToSw[5].ToString();
		}
		
		//up
		
		void ButtonStrUpClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[5];
			statsToSw[5] = statsToSw[0];
			statsToSw[0] = tempStat;
			statDisplayer();
		}
		
		void ButtonDexUpClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[0];
			statsToSw[0] = statsToSw[1];
			statsToSw[1] = tempStat;
			statDisplayer();
		}
		void ButtonConUpClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[1];
			statsToSw[1] = statsToSw[2];
			statsToSw[2] = tempStat;
			statDisplayer();
		}
		void ButtonIntUpClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[2];
			statsToSw[2] = statsToSw[3];
			statsToSw[3] = tempStat;
			statDisplayer();
		}
		void ButtonWisUpClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[3];
			statsToSw[3] = statsToSw[4];
			statsToSw[4] = tempStat;
			statDisplayer();
		}
		void ButtonChaUpClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[4];
			statsToSw[4] = statsToSw[5];
			statsToSw[5] = tempStat;
			statDisplayer();
		}
		
		//down
		
		void ButtonStrDwClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[1];
			statsToSw[1] = statsToSw[0];
			statsToSw[0] = tempStat;
			statDisplayer();
		}
		void ButtonDexDwClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[2];
			statsToSw[2] = statsToSw[1];
			statsToSw[1] = tempStat;
			statDisplayer();
		}
		void ButtonConDwClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[3];
			statsToSw[3] = statsToSw[2];
			statsToSw[2] = tempStat;
			statDisplayer();
		}
		void ButtonIntDwClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[4];
			statsToSw[4] = statsToSw[3];
			statsToSw[3] = tempStat;
			statDisplayer();
		}
		void ButtonWisDwClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[5];
			statsToSw[5] = statsToSw[4];
			statsToSw[4] = tempStat;
			statDisplayer();
		}
		void ButtonChaDwClick(object sender, EventArgs e)
		{
			tempStat = statsToSw[0];
			statsToSw[0] = statsToSw[5];
			statsToSw[5] = tempStat;
			statDisplayer();
		}
		
		//conf
		
		void ButtonStSwConfClick(object sender, EventArgs e)
		{
			((MainForm)this.Owner).setStats(statsToSw);
			this.Close();
		}
	}
	
	
}
