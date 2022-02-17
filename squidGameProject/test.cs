namespace squidGameProject // Note: actual namespace depends on the project name.
{
    public class Test
    {

        public Test(){

        }

        public int[] valeur;

        Random aleatoire = new Random();

        public void randomValueGrid(){
            for(int i=0;i<16;i++){
                this.valeur[i] = aleatoire.Next(2);

            }
        }
        

        
    }

}

                


