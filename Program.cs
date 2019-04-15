using System;
using System.Collections.Generic;

namespace animals
{
	public interface IWalking
	{
		void run();
		void walk();
	}

	public interface ISwimming
	{
		int MaximumDepth { get; }
		void swim();
	}
    public interface IFlying
    {
        void fly();
    }
    public interface IDigging
    {
        void dig();
    }
    public interface ISlithering
    {
        void slither();
    }

	public class PaintedDog : IWalking
	{
		public void run()
		{
			Console.WriteLine("Animal is now running");
		}

		public void walk()
		{
			Console.WriteLine("Animal is now walking");
		}
	}
	public class SeaTurtle : IWalking, ISwimming
	{
		public int MaximumDepth { get; } = 100;

		public void run()
		{
			Console.WriteLine("Animal is now running");
		}

		public void walk()
		{
			Console.WriteLine("Animal is now walking");
		}

		public void swim()
		{
			Console.WriteLine("Animal is now swimming");
		}
	}
    public class Parakeet : IFlying
    {
        public void fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }
    public class Earthworm : IDigging
    {
        public void dig()
        {
            Console.WriteLine("Animal is now digging");
        }
    }
    public class Terrapin : ISwimming, IWalking
    {
        public int MaximumDepth { get; } = 10;

		public void run()
		{
			Console.WriteLine("Animal is now running");
		}

		public void walk()
		{
			Console.WriteLine("Animal is now walking");
		}

		public void swim()
		{
			Console.WriteLine("Animal is now swimming");
		}
    }
    public class TimberRattlesnake : ISlithering
    {
        public void slither()
		{
			Console.WriteLine("Animal is now slithering");
		}
    }
    public class Mouse : IWalking
    {
        public void run()
		{
			Console.WriteLine("Animal is now running");
		}

		public void walk()
		{
			Console.WriteLine("Animal is now walking");
		}
    }
    public class Finch : IFlying
    {
        public void fly()
        {
            Console.WriteLine("Animal is now flying");
        }
    }
    public class Ant : IWalking, IDigging
    {
        public void run()
		{
			Console.WriteLine("Animal is now running");
		}

		public void walk()
		{
			Console.WriteLine("Animal is now walking");
		}
        public void dig()
		{
			Console.WriteLine("Animal is now digging");
		}
    }
    public class BettaFish : ISwimming
    {
        public int MaximumDepth { get; } = 2;
        public void swim()
		{
			Console.WriteLine("Animal is now swimming");
		}
    }
    public class CopperheadSnake : ISlithering
    {
        public void slither()
		{
			Console.WriteLine("Animal is now slithering");
		}
    }
    public class Gerbil : IWalking, IDigging
    {
        public void run()
		{
			Console.WriteLine("Animal is now running");
		}

		public void walk()
		{
			Console.WriteLine("Animal is now walking");
		}
        public void dig()
        {
            Console.WriteLine("Animal is now digging");
        }
    }
    public class Birdcage
    {
        public List<IFlying> TempCage { get; set; } = new List<IFlying>();
    }
    public class SafetyRun
    {
        public List<IWalking> TempRun { get; set; } = new List<IWalking>();
    }
    public class SnakeCage
    {
        public List<ISlithering> TempSnakes { get; set; } = new List<ISlithering>();
    }
    public class Pool
    {
        public List<ISwimming> TempPool { get; set; } = new List<ISwimming>();
    }
    public class Mound
    {
        public List<IDigging> TempMound { get; set; } = new List<IDigging>();
    }
	class Program
	{
		static void Main()
		{
			Parakeet Gabby = new Parakeet();
            Earthworm Jim = new Earthworm();
            Terrapin Galapagos = new Terrapin();
            TimberRattlesnake DangerNoodle = new TimberRattlesnake();
            Mouse Jerry = new Mouse();
            Ant Ping = new Ant();
            Finch Atticus = new Finch();
            BettaFish Bitey = new BettaFish();
            CopperheadSnake Danger = new CopperheadSnake();
            Gerbil Tapper = new Gerbil();

            Birdcage cleanCage = new Birdcage();
            Mound cleanMound = new Mound();
            Pool cleanPool = new Pool();
            SnakeCage cleanSnakes = new SnakeCage();
            SafetyRun cleanRun = new SafetyRun();

            cleanCage.TempCage.Add(Gabby);
            cleanCage.TempCage.Add(Atticus);

            cleanMound.TempMound.Add(Tapper);
            cleanMound.TempMound.Add(Ping);
            cleanMound.TempMound.Add(Jim);

            cleanPool.TempPool.Add(Galapagos);
            cleanPool.TempPool.Add(Bitey);

            cleanSnakes.TempSnakes.Add(Danger);
            cleanSnakes.TempSnakes.Add(DangerNoodle);

            cleanRun.TempRun.Add(Jerry);

		}
	}
}
