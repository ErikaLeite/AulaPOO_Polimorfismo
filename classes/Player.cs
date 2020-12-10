namespace AulaPOO_Polimorfismo.classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;
        public virtual string Correr()
        {
            return "correndo em velocidade 1x";
        }
        public virtual string Pular()
        {
            return "pulando normalmente";
        }
        
    }
}