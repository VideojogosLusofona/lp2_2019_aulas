using System;

namespace Exercicio2
{
    public sealed class SingletonFloat
    {

        // Propriedade auto-implementada pública do tipo float
        public float Value { get; set; }

        // Instancia única, privada, so inicializada quando necessário (lazy)
        private static readonly Lazy<SingletonFloat> instance =
          new Lazy<SingletonFloat>(() => new SingletonFloat());

        // Propriedade que devolve única instancia
        public static SingletonFloat Instance => instance.Value;

        // Construtor privado
        private SingletonFloat() { }
    }
}