using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
  public partial class Form1 : Form
  {


    string answer;
    string letters;
    int numberOfCharacters = 0;
    



    public Form1()
    {
      InitializeComponent();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    public void btn_Generate_Click(object sender, EventArgs e)
    {
      char[] alphabet = "qwertyuioplkjhgfdsazxcvbnm".ToCharArray();
      if (numberOfCharacters == 0)
      {
        Random random = new Random();
        lbl_Display.Text = alphabet[random.Next(0, 25)].ToString();
        numberOfCharacters++;
      }
      
      string letters = lbl_Display.Text;
    }

    private void btn_Memorize_Click(object sender, EventArgs e)
    {
      answer = letters;
      
      lbl_Display.Visible = false;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void btn_Check_Click(object sender, EventArgs e)
    {
      if (letters == answer)
      {
        lbl_Percent.Text = "20%";
      }
    }
  }
}
