using System;

namespace TurtleApplication
{
	public class Turtle
	{
		public char dir;
		public int x;
		public int y;
		

		public Turtle()
		{
			dir = 'N';
			x = 1; y = 1;
		}
		public void moveLeft()
		{
			if (dir == 'N')
				dir = 'W';
			else if (dir == 'W')
				dir = 'S';
			else if (dir == 'S')
				dir = 'E';
			else dir = 'N';
			
		}

		public void moveRight()
		{
			if (dir == 'N')
				dir = 'E';
			else if (dir == 'E')
				dir = 'S';
			else if (dir == 'S')
				dir = 'W';
			else dir = 'N';
			
		}

		public void moveForward()
		{
			if (dir == 'N')
				y++;
			else if (dir == 'S')
				y--;
			else if (dir == 'E')
				x++;
			else x--;
		}
	}

	public class Solution
	{
		public static Turtle getFinalPosition(String dir, Turtle turtle)
		{
			if (dir.Length == 0)
			{
				return turtle;
			}

			for (int i = 0; i < dir.Length; i++)
			{
				if (dir[i] == 'F')
					turtle.moveForward();
				else if (dir[i] == 'L')
					turtle.moveLeft();
				else turtle.moveRight();
			}
			return turtle;
		}

		public static void Main(String[] args)
		{
			String dir = "FFFRRFLF";
			Turtle temp = new Turtle();
			getFinalPosition(dir, temp);
			Console.WriteLine(temp.x + " " + temp.y + " " + temp.dir);
		}
	}
}