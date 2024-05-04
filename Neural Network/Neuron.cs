using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network
{
    public class Neuron
    {
        double bias;
        Dendrite[] dendrites;
        public double Output { get; set; }
        public double Input { get; private set; }
        public ActivationFunction Activation { get; set; }

        public Neuron(ActivationFunction activation, Neuron[] previousNeurons)
        {
            dendrites = new Dendrite(previousNeurons);
        }
        public void Randomize(Random random, double min, double max)
        {

        }
        public double Compute()
        {
            return 0d;
        }
    }
}
