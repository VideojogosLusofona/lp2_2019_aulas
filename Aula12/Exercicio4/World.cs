using System.Text;

namespace Exercicio4
{
    public class World
    {
        private int coolness;
        private float[] scores;
        public World(int coolness, float[] scores)
        {
            this.coolness = coolness;
            this.scores = scores;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"{coolness}:");
            foreach (float sc in scores) sb.Append($" {sc:f2}");
            return sb.ToString();
        }
        public void IncScore()
        {
            coolness++;
            for (int i = 0; i < scores.Length; i++) scores[i] += 1;
        }
        public World ShallowCopy()
        {
            return (World)MemberwiseClone();
        }
        public World NewCopy()
        {
            World copy = (World)MemberwiseClone();
            copy.scores = (float[])scores.Clone();
            return copy;
        }
    }
}