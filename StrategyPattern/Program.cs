
using System;
 

namespace StrategyPattern
{
    class Program
    {

            public static void Main(string[] args)
            {
            TransmittedWay transmittedWay;
            Console.WriteLine("---Serial Transmission---");
            transmittedWay = new TransmittedWay(new Serial());
            transmittedWay.TransmittedInterface();
            Console.WriteLine("---Parallel Transmission---");

            transmittedWay = new TransmittedWay(new Parallel());
            transmittedWay.TransmittedInterface();

            }
        }


        public abstract class TransmissionStrategy
        {
            public abstract void AlgorithmInterface();
        }


        public class Serial : TransmissionStrategy
    {
            public override void AlgorithmInterface()
            {
                Console.WriteLine(
                    "Data bits are organized in a specific order, " +
                    "since they can only be sent one after another. ");
            }
        }


        public class Parallel : TransmissionStrategy
    {
            public override void AlgorithmInterface()
            {
                Console.WriteLine(
                    "Multiple data bits are transmitted" +
                    " over multiple channels at the same time. ");
            }
        }


        public class TransmittedWay
        {
        TransmissionStrategy strategy;

            public TransmittedWay(TransmissionStrategy strategy)
            {
                this.strategy = strategy;
            }

            public void TransmittedInterface()
            {
                strategy.AlgorithmInterface();
            }
        }
    }

