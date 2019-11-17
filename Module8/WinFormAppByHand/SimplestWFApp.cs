using System;
using System.Windows.Forms;

namespace SimpleWFApp
{
	class Program
	{
		static void Main()
		{
			Application.Run(new MainWindow("Regina's Window", 500, 400));
		}
	}
	
	class MainWindow : Form
	{
		// members for a simple menu system
		private MenuStrip mnuMainMenu = new MenuStrip();
		private ToolStripMenuItem mnuFile = new ToolStripMenuItem();
		private ToolStripMenuItem mnuFileExit = new ToolStripMenuItem();
		
		public MainWindow(string title, int height, int width) 
		{
			// set various properties from our parent class
			Text = title;
			Width = width;
			Height = height;
			
			// inherited method to center the form on the screen
			CenterToScreen();
			
			// method to create our menu system
			BuildMenuSystem();
		}
		
		private void BuildMenuSystem()
		{
			// add the file menu item to the main menu
			mnuFile.Text = "&File";
			mnuMainMenu.Items.Add(mnuFile);
			
			// add the exit menu to the file menu
			mnuFileExit.Text = "E&xit";
			mnuFile.DropDownItems.Add(mnuFileExit);
			mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			
			// set the menu for this form
			Controls.Add(this.mnuMainMenu);
			MainMenuStrip = this.mnuMainMenu;
		}
		
		// handler for the file | exit event.
		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}