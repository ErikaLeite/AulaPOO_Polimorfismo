using System;
namespace AulaPOO_Polimorfismo.classes
{
    public class MegaMan : Player
    {
        private string buster;
        public override string Correr()
        {
            return "correndo em velocidade 1.5x";
        }
    }
}