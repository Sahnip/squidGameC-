// See https://aka.ms/new-console-template for more information

namespace squidGameProject // Note: actual namespace depends on the project name.
{
    public class Fonction
    {


        //int nbButton;

        public int[] randomVar;
        
        public char[,] tableau;
        
        public Fonction(){
             this.tableau = new char[,] {{' ',' '},
                                         {' ',' '},
                                         {' ',' '},
                                         {' ',' '},
                                         {' ',' '},
                                         {' ',' '},
                                         {' ',' '},
                                         {' ',' '}};


        }

           
                                 


        public void Displaytableau(){
            for(int i=0;i<tableau.GetLength(0);i++){
                for(int j=0; j<tableau.GetLength(1);j++){
                    Console.Write(this.tableau[i,j]);
                    if(j!=2){
                        Console.Write("|");
                    }
                }
                Console.Write("\n");
            }
        }


    /**
        public int[] RandomCase(){
            Random aleatoire = new Random();
            this.randomVar= new int[2];
            for(int i=0;i<2;i++){
                this.randomVar[i] = aleatoire.Next(2);
            }

            return randomVar;
        }
        **/

        public void getPlayerValue(){
            
        }
        



    }

}

                


