
namespace DFratesMinesweeper
{
    partial class MinesweeperForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Item_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Item_File_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Item_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.help_Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusTimerLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Item_File,
            this.menu_Item_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "GameMenu";
            // 
            // menu_Item_File
            // 
            this.menu_Item_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Item_File_Quit});
            this.menu_Item_File.Name = "menu_Item_File";
            this.menu_Item_File.Size = new System.Drawing.Size(54, 29);
            this.menu_Item_File.Text = "File";
            // 
            // menu_Item_File_Quit
            // 
            this.menu_Item_File_Quit.Name = "menu_Item_File_Quit";
            this.menu_Item_File_Quit.Size = new System.Drawing.Size(148, 34);
            this.menu_Item_File_Quit.Text = "Quit";
            // 
            // menu_Item_Help
            // 
            this.menu_Item_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_Menu_About});
            this.menu_Item_Help.Name = "menu_Item_Help";
            this.menu_Item_Help.Size = new System.Drawing.Size(65, 29);
            this.menu_Item_Help.Text = "Help";
            // 
            // help_Menu_About
            // 
            this.help_Menu_About.Name = "help_Menu_About";
            this.help_Menu_About.Size = new System.Drawing.Size(176, 34);
            this.help_Menu_About.Text = "About...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTimerLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusTimerLbl
            // 
            this.statusTimerLbl.Name = "statusTimerLbl";
            this.statusTimerLbl.Size = new System.Drawing.Size(75, 25);
            this.statusTimerLbl.Text = "Timer: 0";
            // 
            // MinesweeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MinesweeperForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Item_File;
        private System.Windows.Forms.ToolStripMenuItem menu_Item_File_Quit;
        private System.Windows.Forms.ToolStripMenuItem menu_Item_Help;
        private System.Windows.Forms.ToolStripMenuItem help_Menu_About;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusTimerLbl;
    }
}

