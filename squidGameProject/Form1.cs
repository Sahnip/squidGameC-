namespace squidGameProject;

public partial class Form1 : Form
{

    private Fonction fonct;



    public Form1()
    {
        InitializeComponent();
        fonct =  new Fonction();
    }

    
    public void restartGame(){
        /*VarButton button = new VarButton();
        for(int i=0; i<16;i++){
            button.Text="";
        }
        fonct= new Fonction();*/
    }

        
    public void cliCase(object sender, System.EventArgs e){
            VarButton buttonSelect= (VarButton) sender;
            //buttonSelect.isGood;
            
    }
    
}
