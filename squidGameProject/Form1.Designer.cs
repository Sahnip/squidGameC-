namespace squidGameProject;
using System.Windows.Forms;

partial class Form1
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

    //private Cases[] tableauCases = new Cases[16];


     Test test = new Test();


        //public VarButton[8,2] tabButton;
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 950);
        this.Text = "Squid Game";

        TableLayoutPanel tabl = new TableLayoutPanel();
        tabl.RowCount = 8;
        tabl.ColumnCount = 2;
        tabl.Size = new System.Drawing.Size(500, 900);

        for(int i = 0; i<16; i=i+2){
            VarButton button, button2;
            Random aleatoire = new Random();
            if(aleatoire.Next(2)==0){
                button = new VarButton(i, true);
                button.Size = new System.Drawing.Size(100,100);
                //int x = button
                //this.tabButton.C = button;
                

                button2 = new VarButton(i+1, false);
                button2.Size = new System.Drawing.Size(100,100);
            }else{
                button = new VarButton(i, false);
                button.Size = new System.Drawing.Size(100,100);

                button2 = new VarButton(i+1, true);
                button2.Size = new System.Drawing.Size(100,100);
            }
          //  button.Click += new EventHandler(this.cliCase);
            //button2.Click += new EventHandler(this.cliCase);
            tabl.Controls.Add(button);
            tabl.Controls.Add(button2);
        }


        this.Controls.Add(tabl);
    }
        

    #endregion
}
