using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDoMin
{
    public partial class FormDoMin : Form
    {
        
        public FormDoMin()
        {
            InitializeComponent();
                     
        }
        public buttons[][]board = new buttons[1000][];
        
        public int flagging;
        public int level;
        public int win = 0;
              
        void DrawBoardGame(int weight, int height) // Vẽ bảng
        {
            
            pnlBoardGame.Controls.Clear();
            timerCountTime.Stop();
            prgCountTime.Value = 0;
            pnlBoardGame.Enabled = true;
            for (int i = 0; i < weight; i++)
            {
                board[i] = new buttons[weight];
                for ( int j = 0; j < height; j++)
                {
                    board[i][j] = new buttons();
                    board[i][j].Name = ("button" + i * level + j + 1);
                    board[i][j].Size = new System.Drawing.Size(30, 30);
                    board[i][j].MouseDown += DoMin_MouseDown;
                    board[i][j].BackColor = System.Drawing.Color.White;                    
                    board[i][j].vitri = i * level + j;
                    board[i][j].Location = new System.Drawing.Point(5 + 30 * j, 6 + 30 * i);
                    pnlBoardGame.Controls.Add(board[i][j]);                 
                }

            }        
        }
     
        private void DoMin_MouseDown(object sender, MouseEventArgs e) // bắt sự kiên click chuột
        {
            
            buttons but = (buttons)(System.Windows.Forms.Button)sender;            
            if (e.Button == MouseButtons.Right && win != 0) 
            {             
                if (but.flag==false && flagging > 0)
                {
                    flagging--;
                    btFlagging.Text = flagging.ToString();
                    but.flag = true;
                    but.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\flag.png");
                    but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (but.flag == true && flagging >= 0)
                {
                    flagging++;
                    btFlagging.Text = flagging.ToString();
                    but.flag = false;
                    but.BackgroundImage = null;
                }
                
            }
            else if (e.Button == MouseButtons.Left)
            {
               
                if (but.flag == false)
                {
                    timerCountTime.Start(); // Khởi tạo chạy thời gian khi click;
                    prgCountTime.Value = 0;
                    if (but.mine == true)
                    {

                        but.BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\main.png");
                        but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        EndGame();
                        
                    }
                    else 
                    {

                        mark( but.vitri / level, but.vitri % level, level);
                        
                    }
                }
            }
           
            FocusButton();
            ConditionOfWin();

        }

        void FocusButton()
        {
            if(level == 10)
            {
                btBeginer.Focus();
            }
            else if (level == 20)
            {
                btIntermediate.Focus();
            }
            else if (level == 30)
            {
                btExpert.Focus();
            }
        }

        public void mark( int b, int c, int weight)
        {

            if (board[b][c].minearound == 0 && board[b][c].flag == false)
            {
                board[b][c].Text = " ";

                board[b][c].BackColor = System.Drawing.Color.LightGray;

                if (b > 0 && board[b - 1][c].Text == "")
                    mark( b - 1, c, weight);

                if (c > 0 && board[b][c - 1].Text == "")
                    mark( b, c - 1, weight);

                if (b < weight - 1 && board[b + 1][c].Text == "")
                    mark( b + 1, c, weight);

                if (c < weight - 1 && board[b][c + 1].Text == "")
                    mark( b, c + 1, weight);
                if (board[b][c].flag == false)
                {
                    board[b][c].Enabled = false;
                    win++;
                }

            }
            else if ((board[b][c].minearound != 0 && board[b][c].flag == false))
            {
                board[b][c].Text = board[b][c].minearound.ToString();
                if (board[b][c].flag == false)
                {
                    board[b][c].Enabled = false;
                    win++;
                }
            }
           
        }

        void EndGame() // Kết thúc game
        {
            pnlBoardGame.Enabled = false;
            if (level == 10)
                ShowMains(Value.Board_Beginer_Weight, Value.Board_Beginer_Height);
            else if (level == 20)
                ShowMains(Value.Board_Intermediate_Weight, Value.Board_Intermediate_Height);
            else if (level == 30)
                ShowMains(Value.Board_Expert_Weight, Value.Board_Expert_Height);
            picReset.Image = Image.FromFile(Application.StartupPath + @"\images\sad.png");
            timerCountTime.Stop();
            
        }


        void ShowMains(int weight, int height) // xuất tất cả vị trí boom khi thua
        {
            for (int i =0; i< weight; i++)
                for (int j =0; j<height; j++)
                {
                    if (board[i][j].mine == true)
                    {
                        board[i][j].BackgroundImage = Image.FromFile(Application.StartupPath + @"\images\main.png");
                        board[i][j].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }

                }
            
        }

        void ConditionOfWin()
        {
            if (level == 10 && win == 90)
            {
                timerCountTime.Stop();
                MessageBox.Show("You win!!!");
                
            }
            else if (level == 20 && win == 350)
            {
                MessageBox.Show("You win!!!");
                timerCountTime.Stop();
            }
            else if (level == 30 && win == 650)
            {
                MessageBox.Show("You win!!!");
                timerCountTime.Stop();
            }
        }

        void CreateMains(int mines, int limitRandom) // Tạo bom ngẫu nhiên, khởi tạo các giá trị
        {
            btFlagging.Text = flagging.ToString();
            Random r=new Random();
            
            for(int i = 0; i < mines; i++)
            {
                int a = r.Next(0,limitRandom);
                if (board[a / level][a % level].mine == false)
                {
                    board[a / level][a % level].mine = true;
                    
                    for (int k = a / level - 1; k <= a / level + 1; k++)
                    {
                        if (k == -1)
                            k++;
                        if (k != level)
                        {
                            for (int m = a % level - 1; m <= a % level + 1; m++)
                            {
                                if (m == -1)
                                    m++;
                                if (m != level)
                                {
                                    if (board[k][m].mine == false)
                                        board[k][m].minearound++;
                                }

                            }
                        }

                    }
                }
                else
                    i--;
              
            }
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            picReset.Image = Image.FromFile(Application.StartupPath + @"\images\happy.png");
            if (level == 10)
            {
                flagging = 10;
                win = 0;
                DrawBoardGame(Value.Board_Beginer_Weight, Value.Board_Beginer_Weight);
                CreateMains(Value.Beginer_Mines, Value.Beginer_Limit_Random);
            }
            else if (level == 20)
            {
                flagging = 50;
                win = 0;
                DrawBoardGame(Value.Board_Intermediate_Weight, Value.Board_Intermediate_Height);
                CreateMains(Value.Intermediate_Mines, Value.Intermediate_Limit_Random);
            }
            else if (level == 30)
            {
                flagging = 250;
                win = 0;
                DrawBoardGame(Value.Board_Expert_Weight, Value.Board_Expert_Height);
                CreateMains(Value.Expert_Mines, Value.Expert_Limit_Random);
            }
            

        }

      
        private void timerCountTime_Tick(object sender, EventArgs e)
        {
            prgCountTime.PerformStep();

            if (prgCountTime.Value >= (prgCountTime.Maximum) )
            {
                EndGame();
            }
        }
        

        private void btBeginer_Click(object sender, EventArgs e)
        {          
            pnlBoardGame.Size = new System.Drawing.Size(313, 315);
            pnlBoardGame.Location = new System.Drawing.Point(326, 86);
            picReset.Location = new System.Drawing.Point(326, 21);
            prgCountTime.Location = new System.Drawing.Point(399, 32);
            btFlagging.Location = new System.Drawing.Point(589, 21);
            btFlagging.Size = new System.Drawing.Size(50, 47);
            this.Size = new System.Drawing.Size(679, 465);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            picReset.Image = Image.FromFile(Application.StartupPath + @"\images\happy.png");

            win = 0;
            level = 10;
            flagging = 10;

            
            DrawBoardGame(Value.Board_Beginer_Weight, Value.Board_Beginer_Weight);
            CreateMains(Value.Beginer_Mines, Value.Beginer_Limit_Random);
            
        }
        private void btIntermediate_Click(object sender, EventArgs e)
        {
           
            pnlBoardGame.Size =  new System.Drawing.Size(616, 616);
            picReset.Location = new System.Drawing.Point(326, 21);
            prgCountTime.Location = new System.Drawing.Point(541, 32);
            btFlagging.Location = new System.Drawing.Point(892, 21);
            btFlagging.Size = new System.Drawing.Size(50, 47);
            this.Size = new System.Drawing.Size(977, 758);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            picReset.Image = Image.FromFile(Application.StartupPath + @"\images\happy.png");

            win = 0;
            level = 20;
            flagging = 50;

            DrawBoardGame(Value.Board_Intermediate_Weight, Value.Board_Intermediate_Height);
            CreateMains(Value.Intermediate_Mines, Value.Intermediate_Limit_Random);
            
        }

        private void btExpert_Click(object sender, EventArgs e)
        {
            
            pnlBoardGame.Size = new System.Drawing.Size(915, 915);
            picReset.Location = new System.Drawing.Point(326, 21);
            btFlagging.Location = new System.Drawing.Point(1170, 21);
            btFlagging.Size = new System.Drawing.Size(71, 47);
            prgCountTime.Location = new System.Drawing.Point(697, 32);
            this.Size = new System.Drawing.Size(1271, 1071);
            this.Location = new System.Drawing.Point(20, 0);
            picReset.Image = Image.FromFile(Application.StartupPath + @"\images\happy.png");

            win = 0;
            level = 30;
            flagging = 250;


            DrawBoardGame(Value.Board_Expert_Weight, Value.Board_Expert_Height);
            CreateMains(Value.Expert_Mines, Value.Expert_Limit_Random);

        }

        private void FormDoMin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Really??", "Thoát game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
