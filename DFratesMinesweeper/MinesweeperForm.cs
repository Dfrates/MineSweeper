using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DFratesMinesweeper
{
    //class for minesweeper form
    public partial class MinesweeperForm : Form
    {
        //initializes global variables
        Cell[,] grid;
        int gridSize = 10;
        Random rand = new Random();
        int gridOffset = 48;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int elapsedTime = 0;
        bool gameHasStarted = false;
        bool minesPlaced = false;
        bool firstClick = true;
        
        //minesweeper form
        public MinesweeperForm()
        {
            //loads grid and created events for exiting and about
            InitializeComponent();
            LoadGrid();
            menu_Item_File_Quit.Click += OnQuitClick;
            help_Menu_About.Click += OnAboutClick;
            //creates timer and creates event to handle tick every second
            timer.Interval = 1000;
            timer.Tick += OnTimerTick;
            this.Size = new Size(1000, 1000);
            this.CenterToScreen();

        }

        //Creates grid with cells and creates events for button clicks
        public void LoadGrid()
        {
            
            grid = new Cell[gridSize, gridSize];
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    
                    
                    grid[col, row] = new Cell();
                    
                    grid[col, row].CellColor = Color.Aquamarine;
                    grid[col, row].Row = row;
                    grid[col, row].Col = col;
                    grid[col, row].CellHasBeenClicked += OnCellClick;
                    grid[col, row].Location = new Point(grid[col, row].CellSize * col, gridOffset + grid[col, row].CellSize * row);
                    this.Controls.Add(grid[col, row]);

                }
            }
            
            //places mines after grid is loaded
            if (!minesPlaced)
            {
                PlaceMines();
                minesPlaced = true;
            }

        }

        //method for when a cell is clicked
        public void OnCellClick(object sender, EventArgs e)
        {
            //starts timer when first cell click
            if(!gameHasStarted)
            {
                timer.Start();
                gameHasStarted = true;
            }

            Cell temp = (Cell)sender;
            Color clickColor = temp.CellColor;

            //determines first click and makes sure cell is not a mine
            if (firstClick)
            {
                if(clickColor == Color.Red)
                {
                    temp.CellColor = Color.Aquamarine;
                    clickColor = Color.Aquamarine;
                }
                //checks all directions and performs button click
                CheckRight(temp, clickColor);
                CheckLeft(temp, clickColor);
                CheckUp(temp, clickColor);
                CheckDown(temp, clickColor);
                firstClick = false;
            }
            //shows number for cells with bombs next to them
            ShowNumbers();

            //checks if mine is hit and displays game over message
            if(MineHit(temp.CellColor))
            {
                timer.Stop();

                MessageBox.Show($"game over, you exploded!!! Your score was {elapsedTime}");
                             
            }

        }

        //checks color of clicked color and determines if mine or not
        private bool MineHit(Color clickColor)
        {
            bool hitMine = false;
            if (clickColor == Color.Red)
            {
                hitMine = true;
            }
            return hitMine;
        }

        //creates label for cells with mines next to them and 
        //if a mine them displays how many they are touching
        private void ShowNumbers()
        {
            int mines = 0;
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if(!grid[col,row].MyButton.Visible)
                    {
                        if(MineCheckUp(row, col))
                        {
                            mines++;
                        }
                        if(MineCheckDown(row, col))
                        {
                            mines++;
                        }
                        if(MineCheckLeft(row, col))
                        {
                            mines++;
                        }
                        if (MineCheckRight(row, col))
                        {
                            mines++;
                        }
                        grid[col, row].MyLabel.Text = $"{mines}";
                        if(mines == 0)
                        {
                            grid[col, row].MyLabel.Visible = false;
                        }
                        mines = 0;
                        
                    }
                }
            }
        }

        //checks up from cell for mine 
        private bool MineCheckUp(int row, int col)
        {
            bool isMine = false;
            if(row - 1 >= 0)
            {
                if(grid[col, row - 1].CellColor == Color.Red)
                {
                    isMine = true;
                }
            }
            return isMine;
        }

        //checks down from cell for mine
        private bool MineCheckDown(int row, int col)
        {
            bool isMine = false;
            if (row + 1 <= grid.GetLength(0))
            {
                if (grid[col, row + 1].CellColor == Color.Red)
                {
                    isMine = true;
                }
            }
            return isMine;
        }

        //checks left from cell for mine
        private bool MineCheckLeft(int row, int col)
        {
            bool isMine = false;
            if (col - 1 >= 0)
            {
                if (grid[col - 1, row].CellColor == Color.Red)
                {
                    isMine = true;
                }
            }
            return isMine;
        }

        //checks right from cell for mine
        private bool MineCheckRight(int row, int col)
        {
            bool isMine = false;
            if (col + 1 < grid.GetLength(0))
            {
                if (grid[col + 1, row].CellColor == Color.Red)
                {
                    isMine = true;
                }
            }
            return isMine;
        }

        //places mine on grid in random areas
        private void PlaceMines()
        {
            int mineAmount = 20;
            for (int i = 0; i < mineAmount; i++)
            {
                grid[rand.Next(9), rand.Next(9)].CellColor = Color.Red;
            }
            
        }

        //checks right for same color cell to perform click
        private void CheckRight(Cell temp, Color clickColor)
        {
            if (temp.Col + 1 < grid.GetLength(0))
            {
                if (clickColor.Equals(grid[temp.Col + 1, temp.Row].CellColor))
                {
                    grid[temp.Col + 1, temp.Row].MyButton.PerformClick();
                    
                }
            }
        }

        //checks left same color cell to perform click
        private void CheckLeft(Cell temp, Color clickColor)
        {
            if (temp.Col - 1 > 0)
            {
                if (clickColor.Equals(grid[temp.Col - 1, temp.Row].CellColor))
                {
                    grid[temp.Col - 1, temp.Row].MyButton.PerformClick();
                    
                }
            }
        }

        //checks up for same color cell to perform click
        private void CheckUp(Cell temp, Color clickColor)
        {
            if (temp.Row - 1 > 0)
            {
                if (clickColor.Equals(grid[temp.Col, temp.Row - 1].CellColor))
                {
                    grid[temp.Col, temp.Row- 1].MyButton.PerformClick();
                    
                }
            }
        }
        
        //checks down for same color cell to perform click
        private void CheckDown(Cell temp, Color clickColor)
        {
            if (temp.Row + 1 < grid.GetLength(0))
            {
                if (clickColor.Equals(grid[temp.Col, temp.Row + 1].CellColor))
                {
                    grid[temp.Col, temp.Row + 1].MyButton.PerformClick();
                    
                }
            }
        }

        //creates event for when quit is clicked
        public void OnQuitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //creates event for when about is clicked
        public void OnAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by someone working under an incredible amount of stress!");
        }

        //creates event for tick
        public void OnTimerTick(object sender, EventArgs e)
        {
           
            elapsedTime++;
            statusTimerLbl.Text = $"Timer: {elapsedTime}";
       
        }

    }
}
