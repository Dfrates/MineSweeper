using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DFratesMinesweeper
{
    //creates cell class
    public partial class Cell : UserControl
    {
        public EventHandler CellHasBeenClicked;
        private int cellSize = 64;
        int row, col;
        Panel myPanel = new Panel();
        Button myButton = new Button();
        Label myLabel = new Label();
        public Cell()
        {
            InitializeComponent();
            this.Size = new Size(cellSize, cellSize);

            //create panel and button
            myButton.Size = new Size(cellSize, cellSize);
            myButton.BackColor = Color.DimGray;
            myPanel.Size = new Size(cellSize, cellSize);
            myPanel.BackColor = Color.LightGray;
            myLabel.AutoSize = true;
            myButton.Click += OnButtonClickHandler;

            //add our panel and button
            this.Controls.Add(myLabel);
            this.Controls.Add(myButton);
            this.Controls.Add(myPanel);
            
        }

        public int CellSize { get => cellSize; }
        public Color CellColor { get => myPanel.BackColor; set => myPanel.BackColor = value; }
        public Button MyButton { get => myButton; }
        public Panel MyPanel { get => myPanel; }

        public Label MyLabel { get => myLabel; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }

        //button becomes invisible when clicked
        public void OnButtonClickHandler(object sender, EventArgs e)
        {
            myButton.Visible = false;
            if(CellHasBeenClicked != null)
            {
                this.CellHasBeenClicked(this, e);
            }
        }

    }
}
