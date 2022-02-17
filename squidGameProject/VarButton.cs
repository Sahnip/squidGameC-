
namespace squidGameProject // Note: actual namespace depends on the project name.
{
    class VarButton:Button
    {
        

       // public int[] randomVar;

        public int numCase;
        public bool isGood;

        public VarButton(int n, bool good):base(){
            numCase= n;
            isGood= good;
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

        


    }

}